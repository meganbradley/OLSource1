---
title: "How to: Launch a Stand-Alone Application with the Profiler and Collect Application Statistics by Using the Command Line"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 52dcee2b-f178-4a76-bddc-e36c50bfcb78
caps.latest.revision: 41
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Launch a Stand-Alone Application with the Profiler and Collect Application Statistics by Using the Command Line
This topic describes how to use [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Profiling Tools command-line tools to start a stand-alone (client) application and collect performance statistics by using the sampling method.  
  
> [!NOTE]
>  Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. Windows Store apps also require new collection techniques. See [Profiling Windows 8 and Windows Server 2012 applications](../vs140/performance-tools-on-windows-8-and-windows-server-2012-applications.md).  
>   
>  Adding tier interaction data to a profiling run requires specific procedures with the command line profiling tools. See [Adding Tier Interaction Data to Profiling Data From the Command Line](../vs140/adding-tier-interaction-data-from-the-command-line.md)  
  
 To use the profiler command-line tools, you must add the path to the PATH environment variable of the Command Prompt window or add it to the command itself. You can run the profiling tools on a machine where Visual Studio is installed from a Visual Studio command window.  
  
1.  If you are running the profiling tools on a machine where Visual Studio is installed a Visual Studio command window sets the correct paths. On the **Tools** menu, choose **VS command prompt**  
  
> [!NOTE]
>  Command-line tools of the Profiling Tools are located in the \Team Tools\Performance Tools subdirectory of the Visual Studio installation directory. On 64-bit computers, both 64-bit and 32-bit versions of the tools are available. To use the profiler command-line tools, you must add the path to the PATH environment variable of the Command Prompt window or add it to the command itself. For more information, see [Specifying the Path to Profiling Tools Command Line Tools](../vs140/specifying-the-path-to-profiling-tools-command-line-tools.md).  
  
## Starting the Application with the Profiler  
 To start a target application by using the profiler, you use the VSPerfCmd **/start** and **/launch** options to initialize the profiler and start the application. You can specify **/start** and **/launch** and their respective options on a single command line.  
  
 You can also add the **/globaloff** option to pause data collection at the start of the target application. You then use **/globalon** to start to collect data.  
  
#### To start an application by using the Profiler  
  
1.  Open a Command Prompt window.  
  
2.  Start the profiler. Type:  
  
     **VSPerfCmd /start:sample /output:** <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> [<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>]  
  
    -   The [/start](../vs140/start.md)**:sample** option initializes the profiler.  
  
    -   The [/output](../vs140/output.md)**:**<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> option is required with **/start**. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> specifies the name and location of the profiling data (.vsp) file.  
  
     You can use any of the following options with the **/start:sample** option.  
  
    |Option|Description|  
    |------------|-----------------|  
    |[/wincounter](../vs140/wincounter.md) **:** <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Specifies a Windows performance counter to be collected during profiling.|  
    |[/automark](../vs140/automark.md) **:** <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. Default is 500 ms.|  
    |[/events](../vs140/events--vsperfcmd-.md) **:** <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Specifies an Event Tracing for Windows (ETW) event to be collected during profiling. ETW events are collected in a separate (.etl) file.|  
  
3.  Start the target application. Type:**VSPerfCmd /launch:**<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> [<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>] [<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>]  
  
     You can use one or more of the following options with the **/launch** option.  
  
    |Option|Description|  
    |------------|-----------------|  
    |[/args](../vs140/args.md) **:** <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Specifies a string that contains the command-line arguments to be passed to the target application.|  
    |[/console](../vs140/console.md)|Starts the target command-line application in a separate window.|  
  
     By default, performance data is sampled every 10,000,000 non-halted processor clock cycles. This is approximately one time every 10 seconds on a 1GHz processor. You can specify one of the following options to change the clock cycle interval or to specify a different sampling event.  
  
    |Sample event|Description|  
    |------------------|-----------------|  
    |[/timer](../vs140/timer.md) **:** <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Changes the sampling interval to the number of non-halted clock cycles that are specified by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.|  
    |[/pf](../vs140/pf.md)[**:**<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>]|Changes the sampling event to page faults. If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is specified, sets the number of page faults between samples. Default is 10.|  
    |[/sys](../vs140/sys--vsperfcmd-.md)[**:**<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>]|Changes the sampling event to system calls from the process to the operating system kernel (syscalls). If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is specified, sets the number of calls between samples. Default is 10.|  
    |[/counter](../vs140/counter.md) **:** <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Changes the sampling event and interval to the processor performance counter and interval that are specified in <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.|  
  
## Controlling Data Collection  
 When the target application is running, you can control data collection by starting and stopping the writing of data to the profiler data file by using **VSPerfCmd.exe** options. Controlling data collection enables you to collect data for a specific part of program execution, such as starting or shutting down the application.  
  
#### To start and stop data collection  
  
-   The following pairs of options start and stop data collection. Specify each option on a separate command line. You can turn data collection on and off multiple times.  
  
    |Option|Description|  
    |------------|-----------------|  
    |[/globalon /globaloff](../vs140/globalon-and-globaloff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|  
    |[/processon](../vs140/processon-and-processoff.md) **:** <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  [/processoff](../vs140/processon-and-processoff.md) **:** <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Starts (**/processon**) or stops (**/processoff**) data collection for the process specified by the process ID (<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>).|  
    |[/attach](../vs140/attach.md) **:**{<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>} [/detach](../vs140/detach.md)[**:**{<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>}]|**/attach** starts to collect data for the process specified by the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> or process name (ProcName). **/detach** stops data collection for the specified process or for all processes if a specific process is not specified.|  
  
## Ending the Profiling Session  
 To end a profiling session, the profiler must not be attached to any profiled process and the profiler must be explicitly shut down. You can detach the profiler from an application that was profiled by using the sampling method by closing the application or by calling the **VSPerfCmd /detach** option. You then call the **VSPerfCmd /shutdown** option to turn the profiler off and close the profiling data file. The **VSPerfClrEnv /off** command clears the profiling environment variables.  
  
#### To end a profiling session  
  
1.  Perform one of the following steps to detach the profiler from the target application:  
  
    -   Close the target application.  
  
         -or-  
  
    -   Type **VSPerfCmd /detach**  
  
2.  Shut down the profiler. Type:  
  
     **VSPerfCmd**  [/shutdown](../vs140/shutdown.md)  
  
## See Also  
 [Command-Line Profiling of Stand-Alone Applications](../vs140/command-line-profiling-of-stand-alone-applications.md)   
 [Profiler Sampling Method Data Views](../vs140/profiler-sampling-method-data-views.md)