---
title: "How to: Attach the Profiler to a .NET Service to Collect Memory Data by Using the Command Line"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: aeac39af-ad99-479f-aa36-4104356ca512
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Attach the Profiler to a .NET Service to Collect Memory Data by Using the Command Line
This topic describes how to use [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Profiling Tools command-line tools to attach the profiler to a [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] service and collect memory data. You can collect data about the number and size of memory allocations, and you can also collect data about the lifetime of memory objects.  
  
> [!NOTE]
>  Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. Windows Store apps also require new collection techniques. See [Profiling Windows 8 and Windows Server 2012 applications](../vs140/performance-tools-on-windows-8-and-windows-server-2012-applications.md).  
  
> [!NOTE]
>  Command-line tools of the Profiling Tools are located in the \Team Tools\Performance Tools subdirectory of the [!INCLUDE[vs_current_short](../vs140/includes/vs_current_short_md.md)] installation directory. On 64 bit computers, both 64 bit and 32 bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the command prompt window or add it to to the command itself. For more information, see [Specifying the Path to Profiling Tools Command Line Tools](../vs140/specifying-the-path-to-profiling-tools-command-line-tools.md).  
  
 To collect memory data from a [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] service, you use the [VSPerfCLREnv.cmd](../vs140/vsperfclrenv.md) tool to initialize the appropriate environment variables on the computer that hosts the service. The computer must be restarted to configure it for profiling.  
  
 You then use the [VSPerfCmd](../vs140/vsperfcmd.md) tool to attach the profiler to the service process. While the profiler is attached to the service, you can pause and resume data collection.  
  
 To end a profiling session, the profiler must be detached from the service and the profiler must be explicitly shut down. In most cases, we recommend clearing the profiling environment variables at the end of a session.  
  
## Attaching the Profiler  
  
#### To attach the Profiler to a .NET Framework service  
  
1.  If necessary, install the service.  
  
2.  Open a command prompt window.  
  
3.  Initialize the profiling environment variables. Type:  
  
     **VSPerfClrEnv** {**/globalsamplegc /globalsamplegclife**}[**/samplelineoff**]  
  
    -   The options **/globalsamplegclife** and **/globalsamplegclife** specify the type of memory data to collect. Specify one and only one of the following options.  
  
     **/globalsamplegc**  
     Enables the collection of memory allocation data.  
  
     **/globalsamplegclife**  
     Enables the collection of both memory allocation data and object lifetime data.  
  
    -   The **/samplelineoff** option disables the collection of source code line number data.  
  
4.  Restart the computer to set the new environment configuration.  
  
5.  If necessary, start the service.  
  
6.  Open a command prompt window. If necessary, add the profiler path to the PATH environment variable.  
  
7.  Start the profiler. Type:  
  
     **VSPerfCmd**  [/start](../vs140/start.md) **:sample**  [/output](../vs140/output.md) **:** <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> [<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>]  
  
    -   The **/start:sample** option initializes the profiler.  
  
    -   The **/output:**<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> option is required with **/start**. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> specifies the name and location of the profiling data (.vsp) file.  
  
     You can use one or more of the following options with the **/start:sample** option.  
  
    > [!NOTE]
    >  The **/user** and **/crosssession** options are usually required for services.  
  
    |Option|Description|  
    |------------|-----------------|  
    |[/user](../vs140/user--vsperfcmd-.md) **:**[<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>**\\**]<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Specifies the domain and user name of the account that owns the process. This option is required if the process is running as a user other than the logged on user. The process owner is listed in the User Name column on the Processes tab of Windows Task Manager.|  
    |[/crosssession](../vs140/crosssession.md)|Enables profiling of processes in other logon sessions. This option is required if the ASP.NET application is running in a different session. The session id is listed in the Session ID column on the the Processes tab of Windows Task Manager. **/CS** can be specified as an abbreviation for **/crosssession**.|  
    |[/user](../vs140/user--vsperfcmd-.md) **:**[<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>**\\**]<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Specifies the optional domain and user name of the logon account under which the service runs. The logon account is listed in the Log On As column of the service in the Windows Service Control Manager.|  
    |[/crosssession&#124;cs](../vs140/crosssession.md)|Enables profiling of processes in other logon sessions.|  
    |[/wincounter](../vs140/wincounter.md) **:** <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Specifies a Windows performance counter to be collected during profiling.|  
    |[/automark](../vs140/automark.md) **:** <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. Default is 500 ms.|  
    |[/events](../vs140/events--vsperfcmd-.md) **:** <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Specifies an Event Tracing for Windows (ETW) event to be collected during profiling. ETW events are collected in a separate (.etl) file.|  
  
8.  Attach the profiler to the service. Type:  
  
     **VSPerfCmd**  [/attach](../vs140/attach.md) **:**{<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>} [[/targetclr](../vs140/targetclr.md)**:**<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>]  
  
    -   Specify either the process ID or the process name of the service. You can view the process IDs and names of all running processes in Windows Task Manager.  
  
    -   **targetclr:** <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> specifies the version of the common language runtime (CLR) to profile when more than one version of the runtime is loaded in an application. Optional.  
  
## Controlling Data Collection  
 While the service is running, you can use **VSPerfCmd.exe** options to stop and start the writing of data to the profiler data file. Controlling data collection enables you to collect data for a specific part of the program execution, such as starting or shutting down the application.  
  
#### To start and stop data collection  
  
-   The following pairs of **VSPerfCmd** options start and stop data collection. Specify each option on a separate command line. You can turn data collection on and off multiple times.  
  
    |Option|Description|  
    |------------|-----------------|  
    |[/globalon /globaloff](../vs140/globalon-and-globaloff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|  
    |[/processon](../vs140/processon-and-processoff.md) **:** <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> [/processoff](../vs140/processon-and-processoff.md) **:** <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Starts (**/processon**) or stops (**/processoff**) data collection for the process specified by the process ID (<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>).|  
    |**/attach:**{<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>} [/detach](../vs140/detach.md)[:{<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>}]|**/attach** starts to collect data for the process specified by the process ID or process name. **/detach** stops data collection for the specified process, or for all processes if a specific process is not specified.|  
  
## Ending the Profiling Session  
 To end a profiling session, the profiler must not be collecting data. You can stop the collection of data from an application profiled with the sampling method by stopping the service or by calling the **VSPerfCmd /detach** option. You then call the **VSPerfCmd** [/shutdown](../vs140/shutdown.md) option to turn the profiler off and close the profiling data file. The **VSPerfClrEnv /globaloff** command clears the profiling environment variables, but the system configuration is not reset until the computer is restarted.  
  
#### To end a profiling session  
  
1.  Do one of the following to detach the profiler from the target application:  
  
    -   Stop the service.  
  
         -or-  
  
    -   Type **VSPerfCmd /detach**  
  
2.  Shut down the profiler. Type:  
  
     **VSPerfCmd /shutdown**  
  
3.  (Optional) Clear the profiling environment variables. Type:  
  
     **VSPerfClrEnv /globaloff**  
  
4.  Restart the computer.  
  
## See Also  
 [Command-Line Profiling of Services](../vs140/command-line-profiling-of-services.md)   
 [Profiler .NET Memory Data Views](../vs140/.net-memory-data-views.md)