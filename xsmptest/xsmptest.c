#include <stdio.h>
#include <string.h>
#include "/usr/include/X11/SM/SMlib.h"

#include <pwd.h>
#include <sys/types.h>
#include <time.h>
#include <stdlib.h>
#include <errno.h>
#include <linux/inotify.h>

void delay(int second)
{

    int milsec = 1000 * second;

    clock_t startTime = clock();

    while (clock() < (startTime + milsec))
        ;
}

typedef struct
{
    SmcConn smcconn;    // The SM connection ID
    IceConn iceconn;    // The ICE connection ID
    char *clientid;     // The client ID for the current smc session
    Bool save_yourself; // If we're in the middle of a save_yourself
    Bool shutdown;      // If we're in shutdown mode
} xsmp_config_T;

static xsmp_config_T xsmp;
static void
xsmp_handle_save_yourself(
    SmcConn smc_conn,
    SmPointer client_data,
    int save_type,
    Bool shutdown,
    int interact_style,
    Bool fast)
{

    printf("XSMP xsmp_handle_save_yourself\n");
    fflush(stdout);

    if (xsmp.save_yourself)
        SmcSaveYourselfDone(smc_conn, True);
    xsmp.save_yourself = True;
    xsmp.shutdown = shutdown;
    SmcSaveYourselfDone(smc_conn, False);
}

static void
xsmp_die(SmcConn smc_conn, SmPointer client_data)
{

    xsmp_close();
    printf("XSMP xsmp_die\n");
    fflush(stdout);
}

static void
xsmp_save_complete(SmcConn smc_conn, SmPointer client_data)
{

    printf("XSMP xsmp_save_complete\n");
    fflush(stdout);
}

static void
xsmp_shutdown_cancelled(SmcConn smc_conn, SmPointer client_data)
{

    printf("XSMP xsmp_shutdown_cancelled\n");
    fflush(stdout);
}

int xsmp_handle_requests(void)
{
    Bool rep;

    if (IceProcessMessages(xsmp.iceconn, NULL, &rep) == IceProcessMessagesIOError)
    {
        // Lost ICE
        printf("XSMP lost ICE connection\n");
        fflush(stdout);
        xsmp_close();
        return -1;
    }
    else
    {
        printf("XSMP IceProcessMessages\n");
        fflush(stdout);
        return 0;
    }
}
static int dummy;
static int xsmp_icefd;

static void
xsmp_close(void)
{
    if (xsmp_icefd != -1)
    {

        printf("XSMP closing connection\n");
        fflush(stdout);
        SmcCloseConnection(xsmp.smcconn, 0, NULL);
        if (xsmp.clientid != NULL)
            free(xsmp.clientid);
        xsmp.clientid = NULL;
        xsmp_icefd = -1;
    }
}

static void
xsmp_ice_connection(
    IceConn iceConn,
    IcePointer clientData,
    Bool opening,
    IcePointer *watchData)
{
    // Intercept creation of ICE connection fd
    if (opening)
    {
        xsmp_icefd = IceConnectionNumber(iceConn);
        IceRemoveConnectionWatch(xsmp_ice_connection, NULL);
    }
}

static void
xsmp_prop_reply_proc(
    SmcConn smc_conn,
    SmPointer client_data,
    int numProps,
    SmProp **props)
{

    for (int i = 0; i < numProps; i++)
    {
        int len = props[i]->vals->length;
        if (len > 0)
        {
            char chr[len];
            char *t = props[i]->vals->value;

            printf(t);
            fflush(stdout);
        }
    }
}

int main()
{
    char errorstring[80];
    SmcCallbacks smcallbacks;

    printf("XSMP opening connection\n");
    fflush(stdout);
    xsmp.save_yourself = xsmp.shutdown = False;

    // Set up SM callbacks - must have all, even if they're not used
    smcallbacks.save_yourself.callback = xsmp_handle_save_yourself;
    smcallbacks.save_yourself.client_data = NULL;
    smcallbacks.die.callback = xsmp_die;
    smcallbacks.die.client_data = NULL;
    smcallbacks.save_complete.callback = xsmp_save_complete;
    smcallbacks.save_complete.client_data = NULL;
    smcallbacks.shutdown_cancelled.callback = xsmp_shutdown_cancelled;
    smcallbacks.shutdown_cancelled.client_data = NULL;

    // Set up a watch on ICE connection creations.  The "dummy" argument is
    // apparently required for FreeBSD (we get a BUS error when using NULL).
    if (IceAddConnectionWatch(xsmp_ice_connection, &dummy) == 0)
    {
        printf("XSMP ICE connection watch failed\n");
        fflush(stdout);
        return;
    }

    // Create an SM connection
    xsmp.smcconn = SmcOpenConnection(
        NULL,
        NULL,
        SmProtoMajor,
        SmProtoMinor,
        SmcSaveYourselfProcMask | SmcDieProcMask | SmcSaveCompleteProcMask | SmcShutdownCancelledProcMask,
        &smcallbacks,
        NULL,
        &xsmp.clientid,
        sizeof(errorstring) - 1,
        errorstring);
    if (xsmp.smcconn == NULL)
    {

        return 0;
    }

    xsmp.iceconn = SmcGetIceConnection(xsmp.smcconn);

    // set the required properties, mostly dummy values
    SmPropValue propvalue[5];
    SmProp props[5];
    propvalue[0].length = sizeof(unsigned char);
    unsigned char value0 = SmRestartNever; // so that this extra SM connection doesn't interfere
    propvalue[0].value = &value0;
    props[0].name = "SmRestartStyleHint";
    props[0].type = "SmCARD8";
    props[0].num_vals = 1;
    props[0].vals = &propvalue[0];
    struct passwd *entry = getpwuid(geteuid());
    propvalue[1].length = entry != NULL ? strlen(entry->pw_name) : 0;
    propvalue[1].value = (SmPointer)(entry != NULL ? entry->pw_name : "\n");
    props[1].name = "SmUserID";
    props[1].type = "SmARRAY8";
    props[1].num_vals = 1;
    props[1].vals = &propvalue[1];
    propvalue[2].length = 0;
    propvalue[2].value = (SmPointer)("\n");
    props[2].name = "SmRestartCommand";
    props[2].type = "SmLISTofARRAY8";
    props[2].num_vals = 1;
    props[2].vals = &propvalue[2];
    propvalue[3].length = strlen("requestshutdownhelper\n");
    propvalue[3].value = (SmPointer) "requestshutdownhelper";
    props[3].name = "SmProgram";
    props[3].type = "SmARRAY8";
    props[3].num_vals = 1;
    props[3].vals = &propvalue[3];
    propvalue[4].length = 0;
    propvalue[4].value = (SmPointer)("\n");
    props[4].name = "SmCloneCommand";
    props[4].type = "SmLISTofARRAY8";
    props[4].num_vals = 1;
    props[4].vals = &propvalue[4];
    SmProp *p[5] = {&props[0], &props[1], &props[2], &props[3], &props[4]};
    SmcSetProperties(xsmp.smcconn, 5, p);

    while (1)
    {
        xsmp_handle_requests();
        SmcGetProperties(xsmp.smcconn, xsmp_prop_reply_proc, (SmPointer)(""));
    }

    // while (1)
    // {
    //     //xsmp_handle_requests();
    //     sleep(100);
    // }

    return 0;
}