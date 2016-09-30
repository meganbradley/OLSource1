---
title: "Mark"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 1d72cef3-bb09-4bbb-8864-6ea0ab623ff9
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Mark
The VSPerfCmd.exe **Mark** option inserts the specified information into the profiling data file. Mark can be listed in a separate VSPerfReport report or in the Mark Report view of the profiler UI. **Mark** can be used to specify start and end points in report and view filters.  
  
 The **Mark** option must be the only option specified on the command line.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A user-defined integer that is listed as the Mark ID in profiler views and reports. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> does not have to be unique.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 (Optional) A user-defined string that is listed as the Mark Name in profiler views and reports. If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not specified, the Mark Name field of the mark listing is empty. Enclose strings that contain spaces or forward slashes ("/") in quotation marks.  
  
## Example  
 This example inserts a mark with an ID of 123 and a mark name of "TestMark".  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [VSPerfCmd.exe Reference](../vs140/vsperfcmd.md)   
 [Command-Line Profiling of Stand-Alone Applications](../vs140/command-line-profiling-of-stand-alone-applications.md)   
 [Command-Line Profiling of ASP.NET Web Applications](../vs140/command-line-profiling-of-asp.net-web-applications.md)   
 [Command-Line Profiling of Services](../vs140/command-line-profiling-of-services.md)