---
title: "TASK_STATE_WAITING_ON_CHILDREN Field"
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
  - "TASK_STATE_WAITING_ON_CHILDREN field, Task class [.NET Framework debug engines]"
ms.assetid: 6f26b098-84ad-4f6e-ba27-6136581ba630
caps.latest.revision: 14
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# TASK_STATE_WAITING_ON_CHILDREN Field
The task has finished executing its delegate and is implicitly waiting for attached child tasks to complete.  
  
 **Namespace:** <xref:System.Threading.Tasks*?displayProperty=fullName>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
 Because you cannot access this internal member from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).  
  
## Syntax  
  
```  
.field static assembly literal int32 TASK_STATE_WAITING_ON_CHILDREN = int32(0x01000000)  
```  
  
## Remarks  
 If the [m_stateFlags](../vs140/m_stateflags-field.md) field contains this value, the <xref:System.Threading.Tasks.Task.Status*> property returns <xref:System.Threading.Tasks.TaskStatus.WaitingForChildrenToComplete*?displayProperty=fullName>.  
  
## See Also  
 [Task Class (Internals)](../vs140/task-class---internal-members.md)