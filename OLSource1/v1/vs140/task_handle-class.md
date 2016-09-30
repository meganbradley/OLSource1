---
title: "task_handle Class"
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
  - "ppl/concurrency::task_handle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "task_handle class"
ms.assetid: 74a34b15-708b-4231-a509-947874292b13
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# task_handle Class
The             <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class represents an individual parallel work item. It encapsulates the instructions and the data required to execute a piece of work.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The type of the function object that will be invoked to execute the work represented by the                         <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[task_handle::task_handle Constructor](#task_handle__task_handle_constructor)|Constructs a new                                         <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object. The work of the task is performed by invoking the function specified as a parameter to the constructor.|  
|[task_handle::~task_handle Destructor](#task_handle___dtortask_handle_destructor)|Destroys the                                         <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[task_handle::operator() Operator](#task_handle__operator___operator)|The function call operator that the runtime invokes to perform the work of the task handle.|  
  
## Remarks  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> objects can be used in conjunction with a                 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or a more general                 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object, to decompose work into parallel tasks. For more information, see                 [Task Parallelism](../vs140/task-parallelism--concurrency-runtime-.md).  
  
 Note that the creator of a                 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object is responsible for maintaining the lifetime of the created                 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object until it is no longer required by the Concurrency Runtime. Typically, this means that the                 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object must not destruct until either the                 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or                 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> method of the                 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> or                 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to which it is queued has been called.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> objects are typically used in conjunction with C++ lambdas. Because you do not know the true type of the lambda, the                 [make_task](concurrency_namespace_Functions) function is typically used to create a                 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.  
  
 The runtime creates a copy of the work function that you pass to a                 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object. Therefore, any state changes that occur in a function object that you pass to a                 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object will not appear in your copy of that function object.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
##  \<a name="task_handle__operator___operator">\</a>  task_handle::operator() Operator  
 The function call operator that the runtime invokes to perform the work of the task handle.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="task_handle__task_handle_constructor">\</a>  task_handle::task_handle Constructor  
 Constructs a new                 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object. The work of the task is performed by invoking the function specified as a parameter to the constructor.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 The function that will be invoked to execute the work represented by the                                 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object. This may be a lambda functor, a pointer to a function, or any object that supports a version of the function call operator with the signature                                 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
### Remarks  
 The runtime creates a copy of the work function that you pass to the constructor. Therefore, any state changes that occur in a function object that you pass to a                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object will not appear in your copy of that function object.  
  
##  \<a name="task_handle___dtortask_handle_destructor">\</a>  task_handle::~task_handle Destructor  
 Destroys the                 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [task_group Class](../vs140/task_group-class.md)   
 [structured_task_group Class](../vs140/structured_task_group-class.md)   
 [make_task Function](concurrency_namespace_Functions)   
 [task_group::run Method](../vs140/task_group-class.md#task_group__run_method)   
 [task_group::wait Method](../vs140/task_group-class.md#task_group__wait_method)   
 [task_group::run_and_wait Method](../vs140/task_group-class.md#task_group__run_and_wait_method)   
 [structured_task_group::run Method](../vs140/structured_task_group-class.md#structured_task_group__run_method)   
 [structured_task_group::wait Method](../vs140/structured_task_group-class.md#structured_task_group__wait_method)   
 [structured_task_group::run_and_wait Method](../vs140/structured_task_group-class.md#structured_task_group__run_and_wait_method)