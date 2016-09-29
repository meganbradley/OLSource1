---
title: "m_stateFlags Field"
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
  - "m_stateFlags field, Task class [.NET Framework debug engines]"
ms.assetid: 82b20efc-08f2-4cd2-91f6-4e01e3da906b
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# m_stateFlags Field
Stores information about the current state of the <xref:System.Threading.Tasks.Task*> object.  
  
 **Namespace:** <xref:System.Threading.Tasks*?displayProperty=fullName>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
 Because you cannot access this internal member from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).  
  
## Syntax  
  
```  
.field assembly int32 modreq(System.Runtime.CompilerServices.IsVolatile) m_stateFlags  
```  
  
## Remarks  
 You typically use the <xref:System.Threading.Tasks.Task.Status*?displayProperty=fullName> property to access this value.  
  
 This member can be any combination of the following values:  
  
-   [TASK_STATE_EXECUTED](../vs140/task_state_executed-field.md)  
  
-   [TASK_STATE_FAULTED](../vs140/task_state_faulted-field.md)  
  
-   [TASK_STATE_CANCELED](../vs140/task_state_canceled-field.md)  
  
-   [TASK_STATE_WAITING_ON_CHILDREN](../vs140/task_state_waiting_on_children-field.md)  
  
-   [TASK_STATE_RAN_TO_COMPLETION](../vs140/task_state_ran_to_completion-field.md)  
  
## See Also  
 [Task Class (Internals)](../vs140/task-class---internal-members.md)