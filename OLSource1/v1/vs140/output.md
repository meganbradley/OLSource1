---
title: "Output"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 5e286e61-4548-42cf-a635-e608c5edbe2b
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Output
The **Output** option specifies the name of the profiling data file for the performance session. **Output** must be used with the **Start** option.  
  
## Syntax  
  
```  
VSPerfCmd.exe /Start:Method /Output:FileName [Options]  
```  
  
#### Parameters  
 `FileName`  
 The name of the data file. Full and partial paths are accepted. If a path is not specified, the file is created in the current directory.  
  
## Required Options  
 The **Output** option must be used with the **Start** option.  
  
 **Start:** `Method`  
 Specifies the output file name.  
  
## Example  
 In the following example, the profiling data file is created in the current directory.  
  
```  
VSPerfCmd.exe /Start:Sample /Output:TestApp.exe.vsp  
```  
  
## See Also  
 [VSPerfCmd.exe Reference](../vs140/vsperfcmd.md)   
 [Command-Line Profiling of Stand-Alone Applications](../vs140/command-line-profiling-of-stand-alone-applications.md)   
 [Command-Line Profiling of ASP.NET Applications](../vs140/command-line-profiling-of-asp.net-web-applications.md)   
 [Command-Line Profiling of Services](../vs140/command-line-profiling-of-services.md)