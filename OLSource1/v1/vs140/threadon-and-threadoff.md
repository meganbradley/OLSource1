---
title: "ThreadOn and ThreadOff"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 5cd5a695-0a14-484a-8952-ed47e13d8e92
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ThreadOn and ThreadOff
The VSPerfCmd.exe **ThreadOff** and **ThreadOn** subcommands are only available in command-line profiling sessions that use the instrumentation method. **ThreadOff** and **ThreadOn** pause and resume profiling for the specified thread. **ThreadOff** stops profiling the thread and **ThreadOn** starts profiling the thread.  
  
 In most cases, you specify **ThreadOn** or **ThreadOff** as the only option in a VSPerfCmd.exe command line, but they can also be combined with the **GlobalOn**, **GlobalOff**, **ProcessOn**, and **ProcessOff** subcommands.  
  
 The **ThreadOn** and **ThreadOff** subcommands interact with the **GlobalOn** and **GlobalOff** subcommands that control data collection for all processes in a command-line profiling session, and the **ProcessOn** and **ProcessOff** subcommands that control data collection for a specified process.  
  
 The **ThreadOff** and **ThreadOn** subcommands also affect the Thread Start/Stop count that is manipulated by profiler API functions.  
  
-   **ThreadOff** immediately sets the Thread Start/Stop Count to 0 and therefore pauses profiling.  
  
-   **ThreadOn** immediately sets the Thread Start/Stop Count to 1 and therefore resumes profiling.  
  
 For more information, see [Profiling Tools APIs](../vs140/profiling-tools-apis.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The integer identifier of the thread to start or stop.  
  
## Valid Options  
 **ThreadOn** and **ThreadOff** can be specified on command lines that also contain the following subcommands.  
  
 **Start:** <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Initializes the command-line profiling session and sets the specified profiling method.  
  
 **GlobalOff**&#124;**GlobalOn**  
 Stops or starts profiling for all processes in a command-line profiling session.  
  
 {**ProcessOff**&#124;**ProcessOn**}**:**<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Stops or starts profiling for the specified process.  
  
## Example  
 In this example, the **ThreadOff** subcommand is used to stop collecting profiling data so that only application startup data is collected.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [VSPerfCmd.exe Reference](../vs140/vsperfcmd.md)   
 [Command-Line Profiling of Stand-Alone Applications](../vs140/command-line-profiling-of-stand-alone-applications.md)   
 [Command-Line Profiling of ASP.NET Web Applications](../vs140/command-line-profiling-of-asp.net-web-applications.md)   
 [Command-Line Profiling of Services](../vs140/command-line-profiling-of-services.md)