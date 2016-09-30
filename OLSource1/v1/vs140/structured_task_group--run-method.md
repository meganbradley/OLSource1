---
title: "structured_task_group::run Method"
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
  - "ppl/concurrency::structured_task_group::run"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "run method"
ms.assetid: c818124d-0316-48ff-98dd-7aa854f99f94
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# structured_task_group::run Method
Schedules a task on the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object. The caller manages the lifetime of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object passed in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter. The version that takes the parameter <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> causes the task to be biased towards executing at the location specified by that parameter.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The type of the function object that will be invoked to execute the body of the task handle.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A handle to the work being scheduled. Note that the caller has responsibility for the lifetime of this object. The runtime will continue to expect it to live until either the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method has been called on this <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A reference to the location where the task represented by the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter should execute.  
  
## Remarks  
 The runtime creates a copy of the work function that you pass to this method. Any state changes that occur in a function object that you pass to this method will not appear in your copy of that function object.  
  
 If the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> destructs as the result of stack unwinding from an exception, you do not need to guarantee that a call has been made to either the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> method. In this case, the destructor will appropriately cancel and wait for the task represented by the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter to complete.  
  
 Throws an [invalid_multiple_scheduling](../vs140/invalid_multiple_scheduling-class.md) exception if the task handle given by the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> parameter has already been scheduled onto a task group object via the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> method and there has been no intervening call to either the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> method on that task group.  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [structured_task_group Class](../vs140/structured_task_group-class.md)   
 [structured_task_group::wait Method](../vs140/structured_task_group--wait-method.md)   
 [structured_task_group::run_and_wait Method](../vs140/structured_task_group--run_and_wait-method.md)   
 [Task Parallelism](../vs140/task-parallelism--concurrency-runtime-.md)   
 [location class](../vs140/location-class.md)