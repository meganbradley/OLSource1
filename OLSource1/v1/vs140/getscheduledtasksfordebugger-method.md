---
title: "GetScheduledTasksForDebugger Method"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "GetScheduledTasksForDebugger method, TaskScheduler class [.NET Framework debug engines]"
ms.assetid: 7c9b4cde-6e4a-4cef-929f-7d02b1da5762
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# GetScheduledTasksForDebugger Method
Retrieves an array of all scheduled tasks.  
  
 **Namespace:** \<xref:System.Threading.Tasks*?displayProperty=fullName>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
 Because you cannot access this internal member from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 An array of all scheduled tasks. Each task is executing or has finished executing.  
  
## Remarks  
 This method is not thread safe and should not be used concurrently with other instances of \<xref:System.Threading.Tasks.TaskScheduler*> It should be called from a debugger only when the debugger has suspended all other threads.  
  
## See Also  
 [TaskScheduler Class](../vs140/taskscheduler-class---internal-members.md)