---
title: "AutoMark"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: c4de965e-0364-4f78-9936-1f509e85df74
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AutoMark
The **AutoMark** option specifies the number of milliseconds between the collection of Windows software performance counter events. Windows performance counters are specified in the **WinCounter** option.  
  
 Only one **AutoMark** option can be specified on the command line. Note that the **WinCounter** sampling interval specified by **AutoMark** is independent of the main sampling interval.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the number of milliseconds between collections of Windows performance counter events.  
  
## Required Options  
 **WinCounter:** <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the Windows performance counter to collect. When you are using the instrumentation method, multiple Windows counters can be specified. When you are using the sampling method, only one software counter can be specified. The **WinCounter** option must be specified in a command line that contains the **Start** option.  
  
## Example  
 In this example, a sampling interval of 1000 milliseconds is set for two Windows performance counters.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [VSPerfCmd.exe Reference](../vs140/vsperfcmd.md)   
 [Command-Line Profiling of Stand-Alone Applications](../vs140/command-line-profiling-of-stand-alone-applications.md)   
 [Command-Line Profiling of ASP.NET Web Applications](../vs140/command-line-profiling-of-asp.net-web-applications.md)   
 [Command-Line Profiling of Services](../vs140/command-line-profiling-of-services.md)