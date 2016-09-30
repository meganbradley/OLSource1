---
title: "TASK_STATE_CANCELED Field"
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
  - "TASK_STATE_CANCELED field, Task class [.NET Framework debug engines]"
ms.assetid: f4f5a96a-8230-493d-9696-8d2716bda261
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# TASK_STATE_CANCELED Field
The task was canceled before it reached the running state, or it acknowledged its cancellation and completed without exception.  
  
 **Namespace:** \<xref:System.Threading.Tasks*?displayProperty=fullName>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
 Because you cannot access this internal member from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If the [m_stateFlags](../vs140/m_stateflags-field.md) field contains this value, the \<xref:System.Threading.Tasks.Task.Status*> property returns \<xref:System.Threading.Tasks.TaskStatus.Canceled*?displayProperty=fullName>.  
  
## See Also  
 [Task Class (Internals)](../vs140/task-class---internal-members.md)