---
title: "QueryCounters"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 8059d4b2-af61-4a47-a6c2-8da5c0741c74
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QueryCounters
The **QueryCounters** option lists the CPU (hardware) performance counters that are available on the computer.  
  
 **QueryCounters** must be the only option on the command line.  
  
## Syntax  
  
```  
VSPerfCmd.exe /QueryCounters  
```  
  
#### Parameters  
 None  
  
## Remarks  
 When you are using the instrumentation method, the profiler can collect the values of one or more CPU performance counters at each data collection event. When you are using the sampling profiling method, you can specify one counter event and the number of event occurrences to be used as the sampling interval.  
  
 Different processors expose different CPU performance counters. The profiler defines a set of generic counters that can be used on almost all processors. The **QueryCounters** option lists both the names of the generic counters and the names of the counters that are specific to the processor.  
  
## See Also  
 [VSPerfCmd.exe Reference](../vs140/vsperfcmd.md)   
 [Command-Line Profiling of Stand-Alone Applications](../vs140/command-line-profiling-of-stand-alone-applications.md)   
 [Command-Line Profiling of ASP.NET Web Applications](../vs140/command-line-profiling-of-asp.net-web-applications.md)   
 [Command-Line Profiling of Services](../vs140/command-line-profiling-of-services.md)