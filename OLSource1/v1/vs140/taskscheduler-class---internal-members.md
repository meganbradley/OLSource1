---
title: "TaskScheduler Class - Internal Members"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - TaskScheduler class [.NET Framework debug engines]
  - debug engines, TaskScheduler class [.NET Framework]
ms.assetid: 87f1c969-0217-4464-8907-7609c1bf61d3
caps.latest.revision: 14
translation.priority.mt: 
  - de-de
  - ja-jp
---
# TaskScheduler Class - Internal Members
This topic describes the internal members of the <xref:System.Threading.Tasks.TaskScheduler?qualifyHint=True> class that help you implement a custom debugger. For general information about this class, see the <xref:System.Threading.Tasks.TaskScheduler?qualifyHint=False> reference topic.  
  
 **Namespace:** <xref:System.Threading.Tasks?qualifyHint=True>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
 Because you cannot access these internal members from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).  
  
## Syntax  
  
```  
.class public abstract auto ansi beforefieldinit System.Threading.Tasks.TaskScheduler  
       extends System.Object  
```  
  
## Members  
  
### Methods  
  
|Name|Description|  
|----------|-----------------|  
|[GetScheduledTasksForDebugger](../vs140/getscheduledtasksfordebugger-method.md)|Retrieves an array of all scheduled tasks.|  
|[GetTaskSchedulersForDebugger](../vs140/gettaskschedulersfordebugger-method.md)|Retrieves an array of all <xref:System.Threading.Tasks.TaskScheduler?qualifyHint=False> objects that are currently active.|  
  
## Remarks  
  
## See Also  
 <xref:System.Threading.Tasks.TaskScheduler?qualifyHint=True>   
 [Debugger Dependencies in Parallel Extensions for the .NET Framework](../vs140/parallel-extension-internals-for-the-.net-framework.md)