---
title: "How to: Instrument a Dynamically Compiled ASP.NET Web Application and Collect Detailed Timing Data with the Profiler by Using the Command Line"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 6c140ae2-ecdd-48c7-bd89-3dc1b88e19b0
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Instrument a Dynamically Compiled ASP.NET Web Application and Collect Detailed Timing Data with the Profiler by Using the Command Line
This topic describes how to use [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Profiling Tools command-line tools to collect detailed timing data for a dynamically compiled [!INCLUDE[vstecasp](../vs140/includes/vstecasp_md.md)] application by using the instrumentation profiling method.  
  
> [!NOTE]
>  Command-line tools of the Profiling Tools are located in the \Team Tools\Performance Tools subdirectory of the [!INCLUDE[vs_current_short](../vs140/includes/vs_current_short_md.md)] installation directory. On 64-bit computers, both 64-bit and 32-bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the Command Prompt window or add it to the command itself. For more information, see [Specifying the Path to Profiling Tools Command Line Tools](../vs140/specifying-the-path-to-profiling-tools-command-line-tools.md).  
  
 To collect performance data from a [!INCLUDE[vstecasp](../vs140/includes/vstecasp_md.md)] Web application, you modify the web.config file of the target application to enable the [VSInstr.exe](../vs140/vsinstr.md) tool to instrument the dynamically compiled application files. You then use the [VSPerfCLREnv.cmd](../vs140/vsperfclrenv.md) tool to set the appropriate environment variables on the Web server to enable profiling, and then restart the computer.  
  
 Start the profiler and then run the target application. While the profiler is attached to the application, you can pause and resume data collection. When you finish profiling, close the application, close the Internet Information Services (IIS) worker process, and then shut down the profiler. When you have completed your profiling work, restore the web.config file and the Web server to their original states.  
  
## Configuring the ASP.NET Web Application and the Web Server  
  
#### To configure the ASP.NET Web application and the Web server  
  
1.  Modify the web.config file of the target application. See [How to: Modify Config.Web Files to Instrument and Profile ASP.NET Web Applications](../vs140/how-to--modify-web.config-files-to-instrument-and-profile-dynamically-compiled-asp.net-web-applications.md).  
  
2.  Open a Command Prompt window.  
  
3.  Initialize the profiling environment variables. Type:  
  
     **VSPerfClrEnv /globaltraceon**  
  
    -   **/globaltraceon** enables profiling by using the instrumentation method.  
  
4.  Restart the computer.  
  
## Running the Profiling Session  
  
#### To profile the Web application  
  
1.  Open a Command Prompt window.  
  
2.  Start the profiler. Type:  
  
     **VSPerfCmd**  [/start](../vs140/start.md) **:trace**  [/output](../vs140/output.md) **:** `OutputFile` [`Options`]  
  
    -   The **/start:trace** option initializes the profiler.  
  
    -   The **/output:**`OutputFile` option is required with **/start**. `OutputFile` specifies the name and location of the profiling data (.vsp) file.  
  
     You can use any of the following options with the **/start:trace** option.  
  
    > [!NOTE]
    >  The **/user** and **/crosssession** options are usually required for ASP.NET applications.  
  
    |Option|Description|  
    |------------|-----------------|  
    |[/user](../vs140/user--vsperfcmd-.md) **:**[`Domain`**\\**]`UserName`|Specifies the domain and user name of the account that owns the ASP.NET worker process. This option is required if the process is running as a user other than the logged-on user. The process owner is listed in the User Name column on the Processes tab of Windows Task Manager.|  
    |[/crosssession](../vs140/crosssession.md)|Enables profiling of processes in other logon sessions. This option is required if the ASP.NET application is running in a different session. The session identifier is listed in the Session ID column on the Processes tab of Windows Task Manager. **/CS** can be specified as an abbreviation for **/crosssession**.|  
    |[/globaloff](../vs140/globalon-and-globaloff.md)|Starts the profiler with data collection paused. Use [/globalon](../vs140/globalon-and-globaloff.md) to resume profiling.|  
    |[/counter](../vs140/counter.md) **:** `Config`|Collects information from the processor performance counter that is specified in `Config`. Counter information is added to the data that is collected at each profiling event.|  
    |[/wincounter](../vs140/wincounter.md) **:** `WinCounterPath`|Specifies a Windows performance counter to be collected during profiling.|  
    |[/automark](../vs140/automark.md) **:** `Interval`|Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. Default is 500 ms.|  
    |[/events](../vs140/events--vsperfcmd-.md) **:** `Config`|Specifies an Event Tracing for Windows (ETW) event to be collected during profiling. ETW events are collected in a separate (.etl) file.|  
  
3.  Start the [!INCLUDE[vstecasp](../vs140/includes/vstecasp_md.md)] Web application in the typical way.  
  
## Controlling Data Collection  
 While the target application is running, you can control data collection by starting and stopping the writing of data to the profiler data file by using **VSPerfCmd.exe** options. Controlling data collection enables you to collect data for a specific part of program execution, such as starting or shutting down the application.  
  
#### To start and stop data collection  
  
-   The following pairs of options start and stop data collection. Specify each option on a separate command line. You can turn data collection on and off multiple times.  
  
    |Option|Description|  
    |------------|-----------------|  
    |[/globalon /globaloff](../vs140/globalon-and-globaloff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|  
    |[/processon](../vs140/processon-and-processoff.md) **:** `PID` [/processoff](../vs140/processon-and-processoff.md) **:** `PID`|Starts (**/processon**) or stops (**/processoff**) data collection for the process specified by the process ID (`PID`).|  
    |[/threadon](../vs140/threadon-and-threadoff.md) **:** `TID` [/threadoff](../vs140/threadon-and-threadoff.md) **:** `TID`|Starts (**/threadon**) or stops (**/threadoff**) data collection for the thread specified by the thread ID (`TID`).|  
  
-   You can also use the **VSPerfCmd.exe**[/mark](../vs140/mark.md) option to insert a profiling mark into the data file. The **/mark** command adds an identifier, a time stamp, and an optional user-defined text string. Marks can be used to filter the data in profiler reports and data views.  
  
## Ending the Profiling Session  
 To end a profiling session, close the target [!INCLUDE[vstecasp](../vs140/includes/vstecasp_md.md)] Web application, reset IIS to stop the profiled process, and then shut down the profiler.  
  
#### To end a profiling session  
  
1.  Close the [!INCLUDE[vstecasp](../vs140/includes/vstecasp_md.md)] Web application.  
  
2.  Close the [!INCLUDE[vstecasp](../vs140/includes/vstecasp_md.md)] worker process by resetting Internet Information Services (IIS). Type:  
  
     **IISReset /stop**  
  
3.  Shut down the profiler. Type:  
  
     **VSPerfCmd**  [/shutdown](../vs140/shutdown.md)  
  
4.  Restart IIS. Type:  
  
     **IISReset /start**  
  
## Restoring the Application and Computer Configuration  
 When you have completed all profiling, replace the web.config file, clear the profiling environment variables, and restart the computer to restore the application and server to the states that they were in before profiling.  
  
#### To restore the application and computer configuration  
  
1.  Replace the web.config file with a copy of the original file.  
  
2.  Clear the profiling environment variables. Type:  
  
     **VSPerfCmd /globaloff**  
  
3.  Restart the computer.  
  
## See Also  
 [Command-Line Profiling of ASP.NET Applications](../vs140/command-line-profiling-of-asp.net-web-applications.md)   
 [Profiler Instrumentation Method Data Views](../vs140/instrumentation-method-data-views.md)