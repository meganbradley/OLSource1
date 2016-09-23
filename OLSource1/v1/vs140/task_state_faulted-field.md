---
title: "TASK_STATE_FAULTED Field"
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
  - TASK_STATE_FAULTED field, Task class [.NET Framework debug engines]
ms.assetid: ced826ae-09a9-4acf-af00-a2343d396bb8
caps.latest.revision: 12
translation.priority.mt: 
  - de-de
  - ja-jp
---
# TASK_STATE_FAULTED Field
The task completed due to an unhandled exception.  
  
 **Namespace:** <xref:System.Threading.Tasks?qualifyHint=True>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
 Because you cannot access this internal member from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).  
  
## Syntax  
  
```  
.field static assembly literal int32 TASK_STATE_FAULTED = int32(0x00400000)  
```  
  
## Remarks  
 If the [m_stateFlags](../vs140/m_stateflags-field.md) field contains this value, the <xref:System.Threading.Tasks.Task.Status?qualifyHint=False> property returns <xref:System.Threading.Tasks.TaskStatus.Faulted?qualifyHint=True>.  
  
## See Also  
 [Task Class (Internals)](../vs140/task-class---internal-members.md)