---
title: "How to: Instrument a Native Service and Collect Detailed Timing Data by Using the Profiler Command Line"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: dfe58b39-63f8-4a87-ab3a-2b5b14faa8d0
caps.latest.revision: 26
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Instrument a Native Service and Collect Detailed Timing Data by Using the Profiler Command Line
This topic describes how to use [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Profiling Tools command-line tools to instrument a native (C/C++) service and collect detailed timing data.  
  
> [!NOTE]
>  You cannot profile a service with the instrumentation method if the service cannot be restarted after the computer starts, such a service that start only when the operating system starts.  
>   
>  Command-line tools of the Profiling Tools are located in the \Team Tools\Performance Tools subdirectory of the [!INCLUDE[vs_current_short](../vs140/includes/vs_current_short_md.md)] installation directory. On 64 bit computers, both 64 bit and 32 bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the command prompt window or add it to to the command itself. For more information, see [Specifying the Path to Profiling Tools Command Line Tools](../vs140/specifying-the-path-to-profiling-tools-command-line-tools.md).  
  
 To collect detailed timing data from a native service by using the instrumentation method, you use the [VSInstr.exe](../vs140/vsinstr.md) tool to generate an instrumented version of the component. You then replace the non-instrumented version of the service with the instrumented version, making sure that the service is configured to start manually. You then start the profiler.  
  
 When the service is started, timing data is automatically collected to a data file. You can pause and resume data collection during the profiling session.  
  
 To end a profiling session, you turn off the service and then explicitly shut down the profiler.  
  
## Starting the Application with the Profiler  
  
#### To start profiling a native service  
  
1.  Open a command prompt window.  
  
2.  Use the **VSInstr** tool to generate an instrumented version of the service binary.  
  
3.  Replace the original binary with the instrumented version. In Windows Service Control Manager, make sure that the service Startup Type is set to Manual.  
  
4.  Start the profiler. Type:  
  
     **VSPerfCmd** [/start](../vs140/start.md) **:trace**  [/output](../vs140/output.md) **:** `OutputFile` [`Options`]  
  
    -   The **/start:trace** option initializes the profiler.  
  
    -   The **/output:**`OutputFile` option is required with **/start**. `OutputFile` specifies the name and location of the profiling data (.vsp) file.  
  
     You can use any of the following options with the **/start:trace** option.  
  
    > [!NOTE]
    >  The **/user** and **/crosssession** options are usually required for ASP.NET applications.  
  
    |Option|Description|  
    |------------|-----------------|  
    |[/user](../vs140/user--vsperfcmd-.md) **:**[`Domain`**\\**]`UserName`|Specifies the domain and user name of the account that owns the ASP.NET worker process. This option is required if the process is running as a user other than the logged on user. The process owner is listed in the User Name column on the Processes tab of Windows Task Manager.|  
    |[/crosssession](../vs140/crosssession.md)|Enables profiling of processes in other logon sessions. This option is required if the ASP.NET application is running in a different session. The session id is listed in the Session ID column on the the Processes tab of Windows Task Manager. **/CS** can be specified as an abbreviation for **/crosssession**.|  
    |[/waitstart](../vs140/waitstart.md)[**:**`Interval`]|Specifies the number of seconds to wait for the profiler to initialize before it returns an error. If `Interval` is not specified, the profiler waits indefinitely. By default, **/start** returns immediately.|  
    |[/globaloff](../vs140/globalon-and-globaloff.md)|To start the profiler with data collection paused, add the **/globaloff** option to the **/start** command line. Use **/globalon** to resume profiling.|  
    |[/counter](../vs140/counter.md) **:** `Config`|Collects information from the processor performance counter specified in Config. Counter information is added to the data collected at each profiling event.|  
    |[/wincounter](../vs140/wincounter.md) **:** `WinCounterPath`|Specifies a Windows performance counter to be collected during profiling.|  
    |[/automark](../vs140/automark.md) **:** `Interval`|Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. Default is 500 ms.|  
    |[/events](../vs140/events--vsperfcmd-.md) **:** `Config`|Specifies an Event Tracing for Windows (ETW) event to be collected during profiling. ETW events are collected in a separate (.etl) file.|  
  
5.  Start the service from Service Control Manager.  
  
## Controlling Data Collection  
 When the service is running, you can use **VSPerfCmd.exe** options to start and stop the writing of data to the profiler data file. Controlling data collection enables you to collect data for a specific part of program execution, such as starting or shutting down the service.  
  
#### To start and stop data collection  
  
-   The following pairs of **VSPerfCmd** options start and stop data collection. Specify each option on a separate command line. You can turn data collection on and off multiple times.  
  
    |Option|Description|  
    |------------|-----------------|  
    |[/globalon /globaloff](../vs140/globalon-and-globaloff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|  
    |[/processon](../vs140/processon-and-processoff.md) **:** `PID` [/processoff](../vs140/processon-and-processoff.md) **:** `PID`|Starts (**/processon**) or stops (**/processoff**) data collection for the process specified by the process ID (`PID`).|  
    |[/threadon](../vs140/threadon-and-threadoff.md) **:** `TID` [/threadoff](../vs140/threadon-and-threadoff.md) **:** `TID`|Starts (**/threadon**) or stops (**/threadoff**) data collection for the thread specified by the thread ID (`TID`).|  
  
## Ending the Profiling Session  
 To end a profiling session, stop the service that is running the instrumented component, and then call the **VSPerfCmd**[/shutdown](../vs140/shutdown.md) option to turn the profiler off and close the profiling data file.  
  
#### To end a profiling session  
  
1.  Stop the service from Service Control Manager.  
  
2.  Shut down the profiler. Type:  
  
     **VSPerfCmd /shutdown**  
  
3.  Replace the instrumented module with the original. If necessary, reconfigure the Startup Type of the service.  
  
## See Also  
 [Command-Line Profiling of Services](../vs140/command-line-profiling-of-services.md)   
 [Profiler Instrumentation Method Data Views](../vs140/instrumentation-method-data-views.md)