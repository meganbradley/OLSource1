---
title: "GlobalOn and GlobalOff"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 24b0ed68-d19e-473e-9af3-252c11d82bcf
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# GlobalOn and GlobalOff
The VSPerfCmd.exe **GlobalOff** and **GlobalOn** options pause and resume profiling for all processes and threads in a command-line profiling session.  
  
 You can specify **GlobalOn** and **GlobalOff** as the only options in a VSPerfCmd.exe command line, or you can include them in command lines that also contain the **Start**, **Launch**, or **Attach** options.  
  
 **GlobalOn** and **GlobalOff** can also be combined with the **ProcessOn**, **ProcessOff**, **ThreadOn**, and **ThreadOff** options.  
  
 The **GlobalOn** and **GlobalOff** options interact with the **ProcessOn** and **ProcessOff** options that control data collection for a specified process, and with the **ThreadOn** and **ThreadOff** options that control data collection for a specified thread.  
  
 The **GlobalOff** and **GlobalOn** options also affect the Global Start/Stop count that is manipulated by the profiler's API functions.  
  
-   **GlobalOff** immediately sets the Global Start/Stop Count to 0 and therefore pauses profiling.  
  
-   **GlobalOn** immediately sets the Global Start/Stop Count to 1 and therefore resumes profiling.  
  
 For more information, see [Profiling Tools APIs](../vs140/profiling-tools-apis.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 None  
  
## Valid Options  
 **GlobalOn** and **GlobalOff** can be specified on command lines that also contain the following options.  
  
 **Start:** <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Initializes the command-line profiler session and sets the specified profiling method.  
  
 **Launch:** <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Starts the specified application and begins profiling with the sampling method.  
  
 **Attach:** <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Begins profiling the specified process.  
  
 {**ProcessOff**&#124;**ProcessOn**}**:**<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Stops or starts profiling for the specified process.  
  
 {**ThreadOff**&#124;**ThreadOn**}**:**<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Stops or starts profiling for the specified process (instrumentation method only).  
  
## Example  
 In this example, the **GlobalOff** and **GlobalOn** options are used to avoid collecting profiling data for application startup and shutdown.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [VSPerfCmd.exe Reference](../vs140/vsperfcmd.md)   
 [Command-Line Profiling of Stand-Alone Applications](../vs140/command-line-profiling-of-stand-alone-applications.md)   
 [Command-Line Profiling of ASP.NET Web Applications](../vs140/command-line-profiling-of-asp.net-web-applications.md)   
 [Command-Line Profiling of Services](../vs140/command-line-profiling-of-services.md)