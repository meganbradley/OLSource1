---
title: "task_group Class"
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
  - "ppl/concurrency::task_group"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "task_group class"
ms.assetid: b4af5b28-227d-4488-8194-0a0d039173b7
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# task_group Class
The             <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class represents a collection of parallel work which can be waited on or canceled.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[task_group::task_group Constructor](#task_group__task_group_constructor)|Overloaded. Constructs a new                                         <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.|  
|[task_group::~task_group Destructor](#task_group___dtortask_group_destructor)|Destroys a                                         <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object. You are expected to call the either the                                         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or                                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method on the object prior to the destructor executing, unless the destructor is executing as the result of stack unwinding due to an exception.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[task_group::cancel Method](#task_group__cancel_method)|Makes a best effort attempt to cancel the sub-tree of work rooted at this task group. Every task scheduled on the task group will get canceled transitively if possible.|  
|[task_group::is_canceling Method](#task_group__is_canceling_method)|Informs the caller whether or not the task group is currently in the midst of a cancellation. This does not necessarily indicate that the                                         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> method was called on the                                         <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object (although such certainly qualifies this method to return                                         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>). It may be the case that the                                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object is executing inline and a task group further up in the work tree was canceled. In cases such as these where the runtime can determine ahead of time that cancellation will flow through this                                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object,                                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> will be returned as well.|  
|[task_group::run Method](#task_group__run_method)|Overloaded. Schedules a task on the                                         <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object. If a                                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object is passed as a parameter to                                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, the caller is responsible for managing the lifetime of the                                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object. The version of the method that takes a reference to a function object as a parameter involves heap allocation inside the runtime which may be perform less well than using the version that takes a reference to a                                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object. The version which takes the parameter                                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> causes the task to be biased towards executing at the location specified by that parameter.|  
|[task_group::run_and_wait Method](#task_group__run_and_wait_method)|Overloaded. Schedules a task to be run inline on the calling context with the assistance of the                                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object for full cancellation support. The function then waits until all work on the                                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object has either completed or been canceled. If a                                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object is passed as a parameter to                                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, the caller is responsible for managing the lifetime of the                                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object.|  
|[task_group::wait Method](#task_group__wait_method)|Waits until all work on the                                         <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object has either completed or been canceled.|  
  
## Remarks  
 Unlike the heavily restricted                 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> class, the                 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> class is much more general construct. It does not have any of the restrictions described by                 [structured_task_group](../vs140/structured_task_group-class.md).                 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> objects may safely be used across threads and utilized in free-form ways. The disadvantage of the                 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> construct is that it may not perform as well as the                 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> construct for tasks which perform small amounts of work.  
  
 For more information, see                 [Task Parallelism](../vs140/task-parallelism--concurrency-runtime-.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
##  \<a name="task_group__cancel_method">\</a>  task_group::cancel Method  
 Makes a best effort attempt to cancel the sub-tree of work rooted at this task group. Every task scheduled on the task group will get canceled transitively if possible.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 For more information, see                         [Cancellation in the PPL](../vs140/cancellation-in-the-ppl.md).  
  
##  \<a name="task_group__is_canceling_method">\</a>  task_group::is_canceling Method  
 Informs the caller whether or not the task group is currently in the midst of a cancellation. This does not necessarily indicate that the                 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> method was called on the                 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object (although such certainly qualifies this method to return                 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>). It may be the case that the                 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object is executing inline and a task group further up in the work tree was canceled. In cases such as these where the runtime can determine ahead of time that cancellation will flow through this                 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object,                 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> will be returned as well.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 An indication of whether the                         <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object is in the midst of a cancellation (or is guaranteed to be shortly).  
  
### Remarks  
 For more information, see                         [Cancellation in the PPL](../vs140/cancellation-in-the-ppl.md).  
  
##  \<a name="task_group__run_method">\</a>  task_group::run Method  
 Schedules a task on the                 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object. If a                 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object is passed as a parameter to                 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, the caller is responsible for managing the lifetime of the                 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object. The version of the method that takes a reference to a function object as a parameter involves heap allocation inside the runtime which may be perform less well than using the version that takes a reference to a                 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object. The version which takes the parameter                 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> causes the task to be biased towards executing at the location specified by that parameter.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The type of the function object that will be invoked to execute the body of the task handle.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 A function which will be called to invoke the body of the task. This may be a lambda expression or other object which supports a version of the function call operator with the signature                                 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 A reference to the location where the task represented by the                                 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> parameter should execute.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 A handle to the work being scheduled. Note that the caller has responsibility for the lifetime of this object. The runtime will continue to expect it to live until either the                                 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> or                                 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> method has been called on this                                 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The runtime schedules the provided work function to run at a later time, which can be after the calling function returns. This method uses a                         [task_handle](../vs140/task_handle-class.md) object to hold a copy of the provided work function. Therefore, any state changes that occur in a function object that you pass to this method will not appear in your copy of that function object. In addition, make sure that the lifetime of any objects that you pass by pointer or by reference to the work function remain valid until the work function returns.  
  
 If the                         <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> destructs as the result of stack unwinding from an exception, you do not need to guarantee that a call has been made to either the                         <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> method. In this case, the destructor will appropriately cancel and wait for the task represented by the                         <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> parameter to complete.  
  
 The method throws an                         [invalid_multiple_scheduling](../vs140/invalid_multiple_scheduling-class.md) exception if the task handle given by the                         <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> parameter has already been scheduled onto a task group object via the                         <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> method and there has been no intervening call to either the                         <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> method on that task group.  
  
##  \<a name="task_group__run_and_wait_method">\</a>  task_group::run_and_wait Method  
 Schedules a task to be run inline on the calling context with the assistance of the                 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> object for full cancellation support. The function then waits until all work on the                 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> object has either completed or been canceled. If a                 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> object is passed as a parameter to                 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, the caller is responsible for managing the lifetime of the                 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 The type of the function object that will be invoked to execute the body of the task.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 A handle to the task which will be run inline on the calling context. Note that the caller has responsibility for the lifetime of this object. The runtime will continue to expect it to live until the                                 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> method finishes execution.  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 A function which will be called to invoke the body of the work. This may be a lambda expression or other object which supports a version of the function call operator with the signature                                 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>.  
  
### Return Value  
 An indication of whether the wait was satisfied or the task group was canceled, due to either an explicit cancel operation or an exception being thrown from one of its tasks. For more information, see                         [task_group_status](concurrency_namespace_Enumerations).  
  
### Remarks  
 Note that one or more of the tasks scheduled to this                         <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> object may execute inline on the calling context.  
  
 If one or more of the tasks scheduled to this                         <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> object throws an exception, the runtime will select one such exception of its choosing and propagate it out of the call to the                         <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> method.  
  
 Upon return from the                         <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> method on a                         <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> object, the runtime resets the object to a clean state where it can be reused. This includes the case where the                         <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> object was canceled.  
  
 In the non-exceptional path of execution, you have a mandate to call either this method or the                         <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> method before the destructor of the                         <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> executes.  
  
##  \<a name="task_group__task_group_constructor">\</a>  task_group::task_group Constructor  
 Constructs a new                 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 A cancellation token to associate with this task group. The task group will be canceled when the token is canceled.  
  
### Remarks  
 The constructor that takes a cancellation token creates a                         <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> that will be canceled when the source associated with the token is canceled. Providing an explicit cancellation token also isolates this task group from participating in an implicit cancellation from a parent group with a different token or no token.  
  
##  \<a name="task_group___dtortask_group_destructor">\</a>  task_group::~task_group Destructor  
 Destroys a                 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> object. You are expected to call the either the                 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> or                 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> method on the object prior to the destructor executing, unless the destructor is executing as the result of stack unwinding due to an exception.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 If the destructor runs as the result of normal execution (for example, not stack unwinding due to an exception) and neither the                         <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> nor                         <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> methods have been called, the destructor may throw a                         [missing_wait](../vs140/missing_wait-class.md) exception.  
  
##  \<a name="task_group__wait_method">\</a>  task_group::wait Method  
 Waits until all work on the                 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> object has either completed or been canceled.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 An indication of whether the wait was satisfied or the task group was canceled, due to either an explicit cancel operation or an exception being thrown from one of its tasks. For more information, see                         [task_group_status](concurrency_namespace_Enumerations).  
  
### Remarks  
 Note that one or more of the tasks scheduled to this                         <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> object may execute inline on the calling context.  
  
 If one or more of the tasks scheduled to this                         <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> object throws an exception, the runtime will select one such exception of its choosing and propagate it out of the call to the                         <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> method.  
  
 Calling                         <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> on a                         <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> object resets it to a clean state where it can be reused. This includes the case where the                         <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> object was canceled.  
  
 In the non-exceptional path of execution, you have a mandate to call either this method or the                         <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> method before the destructor of the                         <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> executes.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [structured_task_group Class](../vs140/structured_task_group-class.md)   
 [task_handle Class](../vs140/task_handle-class.md)