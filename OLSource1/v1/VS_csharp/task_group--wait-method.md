---
title: "task_group::wait Method"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ppl/concurrency::task_group::wait"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "wait method"
ms.assetid: 19ee5bbc-8654-40a7-9f22-d5329cec6e96
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# task_group::wait Method
Waits until all work on the `task_group` object has either completed or been canceled.  
  
## Syntax  
  
```  
task_group_status wait();  
```  
  
## Return Value  
 An indication of whether the wait was satisfied or the task group was canceled, due to either an explicit cancel operation or an exception being thrown from one of its tasks. For more information, see [task_group_status](../VS_csharp/task_group_status-enumeration.md).  
  
## Remarks  
 Note that one or more of the tasks scheduled to this `task_group` object may execute inline on the calling context.  
  
 If one or more of the tasks scheduled to this `task_group` object throws an exception, the runtime will select one such exception of its choosing and propagate it out of the call to the `wait` method.  
  
 Calling `wait` on a `task_group` object resets it to a clean state where it can be reused. This includes the case where the `task_group` object was canceled.  
  
 In the non-exceptional path of execution, you have a mandate to call either this method or the `run_and_wait` method before the destructor of the `task_group` executes.  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [task_group Class](../VS_csharp/task_group-class.md)