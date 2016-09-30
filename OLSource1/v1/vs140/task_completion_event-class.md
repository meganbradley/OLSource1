---
title: "task_completion_event Class"
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
  - "ppltasks/concurrency::task_completion_event"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "task_completion_event class"
ms.assetid: fb19ed98-f245-48dc-9ba5-487ba879b28a
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# task_completion_event Class
The             <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class allows you to delay the execution of a task until a condition is satisfied, or start a task in response to an external event.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The result type of this                         <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[task_completion_event::task_completion_event Constructor](#task_completion_event__task_completion_event_constructor)|Constructs a                                         <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[task_completion_event::set Method](#task_completion_event__set_method)|Overloaded. Sets the task completion event.|  
|[task_completion_event::set_exception Method](#task_completion_event__set_exception_method)|Overloaded. Propagates an exception to all tasks associated with this event.|  
  
## Remarks  
 Use a task created from a task completion event when your scenario requires you to create a task that will complete, and thereby have its continuations scheduled for execution, at some point in the future. The                 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> must have the same type as the task you create, and calling the set method on the task completion event with a value of that type will cause the associated task to complete, and provide that value as a result to its continuations.  
  
 If the task completion event is never signaled, any tasks created from it will be canceled when it is destructed.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> behaves like a smart pointer, and should be passed by value.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
##  \<a name="task_completion_event__set_method">\</a>  task_completion_event::set Method  
 Sets the task completion event.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The result to set this event with.  
  
### Return Value  
 The method returns                         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> if it was successful in setting the event. It returns                         <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> if the event is already set.  
  
### Remarks  
 In the presence of multiple or concurrent calls to                         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, only the first call will succeed and its result (if any) will be stored in the task completion event. The remaining sets are ignored and the method will return false. When you set a task completion event, all the tasks created from that event will immediately complete, and its continuations, if any, will be scheduled. Task completion objects that have a                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> other than                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> will pass the value                          to their continuations.  
  
##  \<a name="task_completion_event__set_exception_method">\</a>  task_completion_event::set_exception Method  
 Propagates an exception to all tasks associated with this event.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
### Return Value  
  
##  \<a name="task_completion_event__task_completion_event_constructor">\</a>  task_completion_event::task_completion_event Constructor  
 Constructs a                 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [task Class](assetId:///5389e8a5-5038-40b6-844a-55e9b58ad35f)