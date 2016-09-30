---
title: "VSPerfCmd"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "performance tools, VSPerfCmd tool"
  - "command-line tools, VSPerfCmd tool"
  - "command line, tools"
  - "profiling tools,VSPerfCmd"
  - "VSPerfCmd tool"
ms.assetid: 778bc105-7643-46c4-a338-f3620e31125a
caps.latest.revision: 53
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# VSPerfCmd
The **VSPerfCmd.exe** tool is used to start and stop performance data collection. It uses the following syntax:  
  
```  
VSPerfCmd [/U] [/options]  
```  
  
 The following tables describe **VSPerfCmd.exe** tool options.  
  
|Option|Description|  
|------------|-----------------|  
|**U**|Redirected console output is written as Unicode. Must be the first option specified.|  
|[Start](../vs140/start.md) **:** `mode`|Starts the profiling service in the specified mode.|  
|[Output](../vs140/output.md) **:** `filename`|Specifies the output file name. Use only with **Start**.|  
|[CrossSession&#124;CS](../vs140/crosssession.md)|Enables profiling across Windows sessions. Use only with **Start**, **Attach**, **or Launch**.|  
|[User](../vs140/user--vsperfcmd-.md) **:**[`domain\`]`username`|Enables the specified account access to the profiler service. Use only with **Start**.|  
|[WaitStart](../vs140/waitstart.md)[**:**`n`]|Waits for the data collection logger to initialize. If `n` is specified, **VSPerfCmd** will wait at most `n` seconds. If `n` is not specified, **VSPerfCmd** will wait indefinitely. This eases use of **VSPerfCmd** as part of a batch process.|  
|[Counter](../vs140/counter.md) **:** `cfg`|When the sample profiling method is used, specifies a CPU counter and the number of events to use as the sampling interval. You can sample only one counter value.\<br />\<br /> When the instrumentation profiling method is used, specifies a CPU counter to be collected at each instrumentation point. Use only with **Start:**`Trace`, **Attach**,or **Launch**.|  
|[QueryCounters](../vs140/querycounters.md)|Displays a list of valid CPU counters for the current machine.|  
|[WinCounter](../vs140/wincounter.md) **:** *path*|Specifies a Windows performance counter event to include with profile mark data. Use only with **Start**.|  
|[AutoMark](../vs140/automark.md) **:** *n*|Specifies the time interval (in milliseconds) between Windows performance counter data collection events. Use with **WinCounter**.|  
|[Events](../vs140/events--vsperfcmd-.md) **:** `option`|Controls collection of specified Event Tracing for Windows (ETW) events. ETW data is collected to an .itl file that is not the profiling data (.vsp) file.|  
|[Status](../vs140/status.md)|Displays the state of the profiler, information about processes that are currently being profiled, and accounts that have authority to control the profiler.|  
|[Shutdown](../vs140/shutdown.md)[**:**`n`]|Closes the profiling data file and turns the profiler off.|  
|[GlobalOn](../vs140/globalon-and-globaloff.md)|Resumes data collection after a call to **VSPerfCmdGlobalOff**.|  
|[GlobalOff](../vs140/globalon-and-globaloff.md)|Stops all data collection, but does not end the profiling session.|  
|[ProcessOn](../vs140/processon-and-processoff.md) **:** `pid`|Resumes data collection for the specified process after profiling was paused by a call to **VSPerfCmdProcessOff**.|  
|[ProcessOff](../vs140/processon-and-processoff.md) **:** `pid`|Stops data collection for the specified process.|  
|[ThreadOn](../vs140/threadon-and-threadoff.md) **:** *tid*|Resumes profiling for the specified process after profiling was paused by a call to **VSPerfCmdThreadOff**. Use **ThreadOn** only when profiling with the instrumentation method.|  
|[ThreadOff](../vs140/threadon-and-threadoff.md) **:** *tid*|Pauses profiling for the specified thread. Use **ThreadOff** only when profiling with the instrumentation method.|  
|[Mark](../vs140/mark.md) **:** *MarkNum*[**,***MarkText***]**|Inserts a mark into the profiling data file, with optional text.|  
  
## Sampling Method Options  
 The following options are only available when you are using the sampling profiling method.  
  
|Option|Description|  
|------------|-----------------|  
|[Launch](../vs140/launch.md) **:** *Executable*|Starts the specified application and begins profiling.|  
|[Args](../vs140/args.md) **:** *Arguments*|Specifies command line arguments to pass to the launched application.|  
|[Console](../vs140/console.md)|Starts the specified command in a new command prompt window.|  
|[Attach](../vs140/attach.md) **:** *PID*[**,***PID*]|Begins profiling the specified processes. Processes can be identified by the process id or by the process name.|  
|[Detach](../vs140/detach.md)[**:***PID*[,*PID*]]|Stops profiling the specified processes. Processes can be identified by the process id or by the process name. If no process is specified, profiling is halted for all processes.|  
|[GC](../vs140/gc--vsperfcmd-.md)[**:**{**Allocation**`&#124;`**Lifetime**}]|Collects .NET memory allocation and object lifetime data. Use only with the **VSPerfCmdLaunch** option.|  
  
### Sampling Interval Options  
 The following options specify the type and duration of sampling intervals. The default is **Timer**. You can also specify a CPU counter as the interval by using the **Counter** option. These options can only be specified with **Launch** or with the first **Attach** of a profiling session.  
  
|Option|Description|  
|------------|-----------------|  
|[PF](../vs140/pf.md)[**:***n*]|Samples on every n-th page fault (default=10).|  
|[Sys](../vs140/sys--vsperfcmd-.md)[**:***n*]|Samples on every n-th system call (default=10).|  
|[Timer](../vs140/timer.md)[**:***n*]|Samples on every n-th processor cycle (default=10000000).|  
  
## Service Component and Kernel Mode Device Options  
 The following Admin options support profiling service components or kernel mode device drivers. The Admin options set profiling permissions and control the profiled service or device driver.  
  
 Admin options must be executed at a command prompt that is running with administrative credentials.  
  
|Option|Description|  
|------------|-----------------|  
|**Admin:Security** <**ALLOW&#124;DENY**> *Right*[ *Right*] <*User*&#124;*Group*>|Allows or denies the specified user or group access to profiling services.\<br />\<br /> `Right` can be:\<br />\<br /> CrossSession - gives the user access to the service to do cross session profiling.\<br />\<br /> SampleProfiling - gives the user access to the driver to enable sampling profiling. Also used to access kernel transition information during trace profiling.\<br />\<br /> FullAccess - gives the user both CrossSession and SampleProfiling access.|  
|**Admin:Security, List**|Lists the current state of profiling services and lists user permissions.|  
|**Admin:** <*Service*&#124;*Driver*><**START**&#124;**STOP**&#124;**INSTALL**&#124;**UNINSTALL**>|Starts, stops, installs, or uninstalls the profiling service component (service) or kernel mode device driver (driver).|  
|**Admin:** <*Service*&#124;*Driver*>**AutoStart**<**ON**&#124;**OFF**>|Enables or disables automatically starting the profiling service (service) or kernel mode device driver (driver) after a restart.|  
  
## VSPerfCmd /Driver  
 The **VSPerfCmd /Driver** option is now obsolete. Use the **VsPerfCmdAdmin** options for this functionality.  
  
## See Also  
 [VSInstr](../vs140/vsinstr.md)   
 [VSPerfMon](../vs140/vsperfmon.md)   
 [VSPerfReport](../vs140/vsperfreport.md)