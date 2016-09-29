---
title: "Shutdown"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: a1e37500-4ad1-4670-9737-3d9a20536386
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Shutdown
The **Shutdown** option waits for any currently profiled process to end or detach, and then it turns the profiler off and closes the profiling data file. The **Shutdown** option must be the last command of a profiling run.  
  
 If a time-out parameter is not specified, the **Shutdown** option will wait indefinitely. If a time-out parameter is specified, the option returns after the specified number of seconds without turning the profiler off or closing the data file.  
  
 The **Shutdown** option must be the only option specified on the command line.  
  
## Syntax  
  
```  
VSPerfCmd.exe /Shutdown[:Timeout]  
```  
  
#### Parameters  
 `Timeout`  
 -   (Optional) If specified, the option returns after the specified number of seconds without turning the profiler off or closing the profiling data file.  
  
## See Also  
 [VSPerfCmd.exe Reference](../vs140/vsperfcmd.md)   
 [Command-Line Profiling of Stand-Alone Applications](../vs140/command-line-profiling-of-stand-alone-applications.md)   
 [Command-Line Profiling of ASP.NET Web Applications](../vs140/command-line-profiling-of-asp.net-web-applications.md)   
 [Command-Line Profiling of Services](../vs140/command-line-profiling-of-services.md)