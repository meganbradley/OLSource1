---
title: "User (VSPerfCmd)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: ee1a478e-374d-4f30-ae28-d260b9d4723a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# User (VSPerfCmd)
The **User** option specifies the domain and user name of the account that owns the profiled process. This option is required only if the process is running as a user other than the logged on user. The process owner is listed in the User Name column on the Processes tab of Windows Task Manager.  
  
 The **User** option can only be specified on a command line that also contains the **Start** option option.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The name of the user's domain.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The name of the user.  
  
## Required Options  
 The **User** option can only be used with the **Start** option.  
  
 **Start:** <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Initializes the profiler to the specified profiling method.  
  
## Example  
 The following example demonstrates the use of the **User** option.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [VSPerfCmd.exe Reference](../vs140/vsperfcmd.md)   
 [Command-Line Profiling of Stand-Alone Applications](../vs140/command-line-profiling-of-stand-alone-applications.md)   
 [Command-Line Profiling of ASP.NET Web Applications](../vs140/command-line-profiling-of-asp.net-web-applications.md)   
 [Command-Line Profiling of Services](../vs140/command-line-profiling-of-services.md)