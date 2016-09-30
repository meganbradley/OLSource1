---
title: "task_group::run_and_wait Method"
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
  - "ppl/concurrency::task_group::run_and_wait"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "run_and_wait method"
ms.assetid: 3da4fdde-ab6f-4938-8483-bffcc5f2e99c
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# task_group::run_and_wait Method
Schedules a task to be run inline on the calling context with the assistance of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object for full cancellation support. The function then waits until all work on the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object has either completed or been canceled. If a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object is passed as a parameter to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the caller is responsible for managing the lifetime of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The type of the function object that will be invoked to execute the body of the task.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A handle to the task which will be run inline on the calling context. Note that the caller has responsibility for the lifetime of this object. The runtime will continue to expect it to live until the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method finishes execution.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A function which will be called to invoke the body of the work. This may be a lambda expression or other object which supports a version of the function call operator with the signature <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Return Value  
 An indication of whether the wait was satisfied or the task group was canceled, due to either an explicit cancel operation or an exception being thrown from one of its tasks. For more information, see [task_group_status](../vs140/task_group_status-enumeration.md).  
  
## Remarks  
 Note that one or more of the tasks scheduled to this <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object may execute inline on the calling context.  
  
 If one or more of the tasks scheduled to this <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object throws an exception, the runtime will select one such exception of its choosing and propagate it out of the call to the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> method.  
  
 Upon return from the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> method on a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object, the runtime resets the object to a clean state where it can be reused. This includes the case where the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object was canceled.  
  
 In the non-exceptional path of execution, you have a mandate to call either this method or the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> method before the destructor of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> executes.  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [task_group Class](../vs140/task_group-class.md)   
 [task_group::run Method](../vs140/task_group--run-method.md)   
 [task_group::wait Method](../vs140/task_group--wait-method.md)   
 [Task Parallelism](../vs140/task-parallelism--concurrency-runtime-.md)