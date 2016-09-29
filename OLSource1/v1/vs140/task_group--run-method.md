---
title: "task_group::run Method"
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
  - "ppl/concurrency::task_group::run"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "run method"
ms.assetid: 1de8735e-99b0-463d-89f3-dd15bd4a160e
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# task_group::run Method
Schedules a task on the `task_group` object. If a `task_handle` object is passed as a parameter to `run`, the caller is responsible for managing the lifetime of the `task_handle` object. The version of the method that takes a reference to a function object as a parameter involves heap allocation inside the runtime which may be perform less well than using the version that takes a reference to a `task_handle` object. The version which takes the parameter `_Placement` causes the task to be biased towards executing at the location specified by that parameter.  
  
## Syntax  
  
```  
template<  
   typename _Function  
>  
void run(  
   const _Function& _Func  
);  
  
template<  
   typename _Function  
>  
void run(  
   const _Function& _Func,  
   location& _Placement  
);  
  
template<  
   typename _Function  
>  
void run(  
   task_handle<_Function>& _Task_handle  
);  
  
template<  
   typename _Function  
>  
void run(  
   task_handle<_Function>& _Task_handle,  
   location& _Placement  
);  
```  
  
#### Parameters  
 `_Function`  
 The type of the function object that will be invoked to execute the body of the task handle.  
  
 `_Func`  
 A function which will be called to invoke the body of the task. This may be a lambda expression or other object which supports a version of the function call operator with the signature `void operator()()`.  
  
 `_Placement`  
 A reference to the location where the task represented by the `_Func` parameter should execute.  
  
 `_Task_handle`  
 A handle to the work being scheduled. Note that the caller has responsibility for the lifetime of this object. The runtime will continue to expect it to live until either the `wait` or `run_and_wait` method has been called on this `task_group` object.  
  
## Remarks  
 The runtime schedules the provided work function to run at a later time, which can be after the calling function returns. This method uses a [task_handle](../vs140/task_handle-class.md) object to hold a copy of the provided work function. Therefore, any state changes that occur in a function object that you pass to this method will not appear in your copy of that function object. In addition, make sure that the lifetime of any objects that you pass by pointer or by reference to the work function remain valid until the work function returns.  
  
 If the `task_group` destructs as the result of stack unwinding from an exception, you do not need to guarantee that a call has been made to either the `wait` or `run_and_wait` method. In this case, the destructor will appropriately cancel and wait for the task represented by the `_Task_handle` parameter to complete.  
  
 The method throws an [invalid_multiple_scheduling](../vs140/invalid_multiple_scheduling-class.md) exception if the task handle given by the `_Task_handle` parameter has already been scheduled onto a task group object via the `run` method and there has been no intervening call to either the `wait` or `run_and_wait` method on that task group.  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [task_group Class](../vs140/task_group-class.md)   
 [task_group::wait Method](../vs140/task_group--wait-method.md)   
 [task_group::run_and_wait Method](../vs140/task_group--run_and_wait-method.md)   
 [Task Parallelism](../vs140/task-parallelism--concurrency-runtime-.md)   
 [location class](../vs140/location-class.md)