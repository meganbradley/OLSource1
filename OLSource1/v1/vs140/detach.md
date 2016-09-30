---
title: "Detach"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: d9d1b52c-7f28-467d-b1e0-512afc4e46c9
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Detach
The VSPerfCmd.exe **Detach** option disconnects the profiler fromthe specified processes or all processes if none are specifed. Profiling must have been initialized by using the sampling method.  
  
 Profiling that was started with either the **Launch** or the **Attach** options can be disconnected with **Detach**. The profiler can be reattched by using subsequent **Attach** commands.  
  
 **Detach** does not close the profiling data file. Use the **Shutdown** option to end profiling and close the data file.  
  
> [!NOTE]
>  If the **Start** option was specified with the **Crosssession** option, any calls to **VSPerfCmd /Attach** or to **VSPerfCmd /Detach** must also specify **Crosssession**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> - The numeric system identifer of one or more processes.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> - the name of the process. If multiple instances of the named process are running, results are unpredictable.  
  
 Separate multiple processes with commas.  
  
 If no process is specified, the profiler is detached from all profiled process.  
  
## Valid options  
 The following **VSPerfCmd** options can be combined with the **Attach** option on a single command line.  
  
 **Crosssession**  
 Enables profiling applications in sessions other than the logon session. Required if the **Start** option was specified with the **Crosssession** option.  
  
## Example  
 In this example, the **Detach** command suspends profiling and the **Shutdown** command closes the profiler data file.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [VSPerfCmd.exe Reference](../vs140/vsperfcmd.md)   
 [Command-Line Profiling of Stand-Alone Applications](../vs140/command-line-profiling-of-stand-alone-applications.md)   
 [Command-Line Profiling of ASP.NET Web Applications](../vs140/command-line-profiling-of-asp.net-web-applications.md)   
 [Command-Line Profiling of Services](../vs140/command-line-profiling-of-services.md)