---
title: "Task Class - Internal Members"
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
  - "debug engines, Task class [.NET Framework]"
  - "Task class [.NET Framework debug engines]"
ms.assetid: 28e47c3b-9323-424a-80ac-6cc3bf19e09b
caps.latest.revision: 18
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Task Class - Internal Members
This topic describes the internal members of the <xref:System.Threading.Tasks.Task*?displayProperty=fullName> class that help you implement a custom debugger. For general information about this class, see the <xref:System.Threading.Tasks.Task*> reference topic.  
  
 **Namespace:** <xref:System.Threading.Tasks*?displayProperty=fullName>  
  
 **Assembly:** mscorlib (in mscorlib.dll)  
  
 Because you cannot access these internal members from the .NET Framework, the following syntax is provided in Common Intermediate Language (CIL).  
  
## Syntax  
  
```  
.class public auto ansi System.Threading.Tasks.Task  
       extends System.Object  
       implements System.Threading.IThreadPoolWorkItem,  
                  System.IAsyncResult,  
                  System.IDisposable,  
                  System.Threading.ICancelableOperation  
```  
  
## Members  
  
### Methods  
  
|Name|Description|  
|----------|-----------------|  
|[SetNotificationForWaitCompletion Method](../VS_csharp/setnotificationforwaitcompletion-method.md)|Sets or clears the TASK_STATE_WAIT_COMPLETION_NOTIFICATION state bit.|  
|[NotifyDebuggerOfWaitCompletion Method](../VS_csharp/notifydebuggerofwaitcompletion-method.md)|Placeholder method used as a breakpoint target by the debugger.|  
  
### Fields  
  
|Name|Description|  
|----------|-----------------|  
|[m_action](../VS_csharp/m_action-field.md)|The delegate that represents the code to execute in the <xref:System.Threading.Tasks.Task*> object.|  
|[m_contingentProperties](../VS_csharp/m_contingentproperties-field.md)|Stores additional properties of the <xref:System.Threading.Tasks.Task*> object.|  
|[m_parent](../VS_csharp/m_parent-field.md)|The backing field for the <xref:System.Threading.Tasks.Task*?displayProperty=fullName> parent property.|  
|[m_stateFlags](../VS_csharp/m_stateflags-field.md)|Stores information about the current state of the <xref:System.Threading.Tasks.Task*> object.|  
|[m_stateObject](../VS_csharp/m_stateobject-field.md)|An object that represents data that will be used by the action.|  
|[m_taskId](../VS_csharp/m_taskid-field.md)|The backing field for the <xref:System.Threading.Tasks.Task.Id*?displayProperty=fullName> property.|  
|[s_taskIdCounter](../VS_csharp/s_taskidcounter-field.md)|The next available identifier for a <xref:System.Threading.Tasks.Task*> object.|  
|[TASK_STATE_CANCELED](../VS_csharp/task_state_canceled-field.md)|Indicates that the task was canceled before it reached the running state, or that the task acknowledged its cancellation and completed without exception.|  
|[TASK_STATE_EXECUTED](../VS_csharp/task_state_executed-field.md)|Indicates that the task is running.|  
|[TASK_STATE_FAULTED](../VS_csharp/task_state_faulted-field.md)|Indicates that the task completed because of an unhandled exception.|  
|[TASK_STATE_RAN_TO_COMPLETION](../VS_csharp/task_state_ran_to_completion-field.md)|Indicates that the task completed execution successfully.|  
|[TASK_STATE_WAITING_ON_CHILDREN](../VS_csharp/task_state_waiting_on_children-field.md)|Indicates that the task has finished executing its delegate and is implicitly waiting for attached child tasks to finish.|  
  
## Remarks  
 The following internal methods are useful to a debugger engine because they mark the entrance to <xref:System.Threading.Tasks.Task*> code execution:  
  
-   `Execute`  
  
-   `ExecuteEntry`  
  
-   `ExecuteWithThreadLocal`  
  
-   `Finish`  
  
-   `InnerInvoke`  
  
-   `InternalWait`  
  
## See Also  
 <xref:System.Threading.Tasks.Task*?displayProperty=fullName>   
 [Debugger Dependencies in Parallel Extensions for the .NET Framework](../VS_csharp/parallel-extension-internals-for-the-.net-framework.md)