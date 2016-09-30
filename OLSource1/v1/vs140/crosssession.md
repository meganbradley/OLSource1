---
title: "CrossSession"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: b9fcb9c3-7903-478c-9b7c-dbd94092fcba
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CrossSession
The VSPerfCmd.exe **CrossSession** option enables the profiler to collect data from any console session. The **CrossSession** option must be used with the **Start** option.  
  
 You can use the abbreviation **CS** in place of **CrossSession**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 None  
  
## Valid Options  
 To enable profiling in another session, the **CrossSession** option must be specified with the **Start** option. **CrossSession** must also be specified in any subsequent **VSPerfCmd Attach** and **Detach** commands.  
  
 **Start:** <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The **Start** option initializes the profiler to the specified profiling method.  
  
 **Attach:** *PID*[**,***PID*]  
 Begins profiling the specified processes.  
  
 **Detach**[**:***PID*[,*PID*]]  
 Stops profiling the specified processes.  
  
## Example  
 In this example, the **CrossSession** option is used to attach to an application that was started in another console session.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [VSPerfCmd.exe Reference](../vs140/vsperfcmd.md)   
 [Command-Line Profiling of Stand-Alone Applications](../vs140/command-line-profiling-of-stand-alone-applications.md)   
 [Command-Line Profiling of ASP.NET Web Applications](../vs140/command-line-profiling-of-asp.net-web-applications.md)   
 [Command-Line Profiling of Services](../vs140/command-line-profiling-of-services.md)