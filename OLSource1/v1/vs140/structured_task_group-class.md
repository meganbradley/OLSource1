---
title: "structured_task_group Class"
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
  - "ppl/concurrency::structured_task_group"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "structured_task_group class"
ms.assetid: 742afa8c-c7b6-482c-b0ba-04c809927b22
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# structured_task_group Class
The             <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class represents a highly structured collection of parallel work. You can queue individual parallel tasks to a             <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> using             <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> objects, and wait for them to complete, or cancel the task group before they have finished executing, which will abort any tasks that have not begun execution.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[structured_task_group::structured_task_group Constructor](#structured_task_group__structured_task_group_constructor)|Overloaded. Constructs a new                                         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.|  
|[structured_task_group::~structured_task_group Destructor](#structured_task_group___dtorstructured_task_group_destructor)|Destroys a                                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object. You are expected to call either the                                         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or                                         <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> method on the object prior to the destructor executing, unless the destructor is executing as a result of stack unwinding due to an exception.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[structured_task_group::cancel Method](#structured_task_group__cancel_method)|Makes a best effort attempt to cancel the sub-tree of work rooted at this task group. Every task scheduled on the task group will get canceled transitively if possible.|  
|[structured_task_group::is_canceling Method](#structured_task_group__is_canceling_method)|Informs the caller whether or not the task group is currently in the midst of a cancellation. This does not necessarily indicate that the                                         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> method was called on the                                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object (although such certainly qualifies this method to return                                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>). It may be the case that the                                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object is executing inline and a task group further up in the work tree was canceled. In cases such as these where the runtime can determine ahead of time that cancellation will flow through this                                         <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object,                                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> will be returned as well.|  
|[structured_task_group::run Method](#structured_task_group__run_method)|Overloaded. Schedules a task on the                                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object. The caller manages the lifetime of the                                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object passed in the                                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> parameter. The version that takes the parameter                                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> causes the task to be biased towards executing at the location specified by that parameter.|  
|[structured_task_group::run_and_wait Method](#structured_task_group__run_and_wait_method)|Overloaded. Schedules a task to be run inline on the calling context with the assistance of the                                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object for full cancellation support. If a                                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object is passed as a parameter to                                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, the caller is responsible for managing the lifetime of the                                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object. The function then waits until all work on the                                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object has either completed or been canceled.|  
|[structured_task_group::wait Method](#structured_task_group__wait_method)|Waits until all work on the                                         <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> has completed or is canceled.|  
  
## Remarks  
 There are a number of severe restrictions placed on usage of a                 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object in order to gain performance:  
  
-   A single                         <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object cannot be used by multiple threads. All operations on a                         <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object must be performed by the thread that created the object. The two exceptions to this rule are the member functions                         <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> and                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. The object may not be in the capture list of a lambda expression and be used within a task, unless the task is using one of the cancellation operations.  
  
-   All tasks scheduled to a                         <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object are scheduled through the use of                         <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> objects which you must explicitly manage the lifetime of.  
  
-   Multiple groups may only be used in absolutely nested order. If two                         <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> objects are declared, the second one being declared (the inner one) must destruct before any method except                         <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> is called on the first one (the outer one). This condition holds true in both the case of simply declaring multiple                         <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> objects within the same or functionally nested scopes as well as the case of a task that was queued to the                         <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> via the                         <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> methods.  
  
-   Unlike the general                         <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> class, all states in the                         <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> class are final. After you have queued tasks to the group and waited for them to complete, you may not use the same group again.  
  
 For more information, see                 [Task Parallelism](../vs140/task-parallelism--concurrency-runtime-.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
##  \<a name="structured_task_group__cancel_method">\</a>  structured_task_group::cancel Method  
 Makes a best effort attempt to cancel the sub-tree of work rooted at this task group. Every task scheduled on the task group will get canceled transitively if possible.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 For more information, see                         [Cancellation in the PPL](../vs140/cancellation-in-the-ppl.md).  
  
##  \<a name="structured_task_group__is_canceling_method">\</a>  structured_task_group::is_canceling Method  
 Informs the caller whether or not the task group is currently in the midst of a cancellation. This does not necessarily indicate that the                 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> method was called on the                 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object (although such certainly qualifies this method to return                 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>). It may be the case that the                 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object is executing inline and a task group further up in the work tree was canceled. In cases such as these where the runtime can determine ahead of time that cancellation will flow through this                 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object,                 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> will be returned as well.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 An indication of whether the                         <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object is in the midst of a cancellation (or is guaranteed to be shortly).  
  
### Remarks  
 For more information, see                         [Cancellation in the PPL](../vs140/cancellation-in-the-ppl.md).  
  
##  \<a name="structured_task_group__run_method">\</a>  structured_task_group::run Method  
 Schedules a task on the                 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object. The caller manages the lifetime of the                 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object passed in the                 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> parameter. The version that takes the parameter                 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> causes the task to be biased towards executing at the location specified by that parameter.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 The type of the function object that will be invoked to execute the body of the task handle.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 A handle to the work being scheduled. Note that the caller has responsibility for the lifetime of this object. The runtime will continue to expect it to live until either the                                 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> or                                 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> method has been called on this                                 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 A reference to the location where the task represented by the                                 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> parameter should execute.  
  
### Remarks  
 The runtime creates a copy of the work function that you pass to this method. Any state changes that occur in a function object that you pass to this method will not appear in your copy of that function object.  
  
 If the                         <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> destructs as the result of stack unwinding from an exception, you do not need to guarantee that a call has been made to either the                         <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> method. In this case, the destructor will appropriately cancel and wait for the task represented by the                         <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> parameter to complete.  
  
 Throws an                         [invalid_multiple_scheduling](../vs140/invalid_multiple_scheduling-class.md) exception if the task handle given by the                         <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> parameter has already been scheduled onto a task group object via the                         <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> method and there has been no intervening call to either the                         <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> method on that task group.  
  
##  \<a name="structured_task_group__run_and_wait_method">\</a>  structured_task_group::run_and_wait Method  
 Schedules a task to be run inline on the calling context with the assistance of the                 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> object for full cancellation support. If a                 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> object is passed as a parameter to                 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>, the caller is responsible for managing the lifetime of the                 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> object. The function then waits until all work on the                 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> object has either completed or been canceled.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 The type of the function object that will be invoked to execute the task.  
  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 A handle to the task which will be run inline on the calling context. Note that the caller has responsibility for the lifetime of this object. The runtime will continue to expect it to live until the                                 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> method finishes execution.  
  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 A function which will be called to invoke the body of the work. This may be a lambda or other object which supports a version of the function call operator with the signature                                 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.  
  
### Return Value  
 An indication of whether the wait was satisfied or the task group was canceled, due to either an explicit cancel operation or an exception being thrown from one of its tasks. For more information, see                         [task_group_status](concurrency_namespace_Enumerations)  
  
### Remarks  
 Note that one or more of the tasks scheduled to this                         <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> object may execute inline on the calling context.  
  
 If one or more of the tasks scheduled to this                         <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> object throws an exception, the runtime will select one such exception of its choosing and propagate it out of the call to the                         <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> method.  
  
 After this function returns, the                         <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object is considered in a final state and should not be used. Note that utilization after the                         <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> method returns will result in undefined behavior.  
  
 In the non-exceptional path of execution, you have a mandate to call either this method or the                         <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> method before the destructor of the                         <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> executes.  
  
##  \<a name="structured_task_group__structured_task_group_constructor">\</a>  structured_task_group::structured_task_group Constructor  
 Constructs a new                 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 A cancellation token to associate with this structured task group. The structured task group will be canceled when the token is canceled.  
  
### Remarks  
 The constructor that takes a cancellation token creates a                         <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> that will be canceled when the source associated with the token is canceled. Providing an explicit cancellation token also isolates this structured task group from participating in an implicit cancellation from a parent group with a different token or no token.  
  
##  \<a name="structured_task_group___dtorstructured_task_group_destructor">\</a>  structured_task_group::~structured_task_group Destructor  
 Destroys a                 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> object. You are expected to call either the                 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> or                 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> method on the object prior to the destructor executing, unless the destructor is executing as a result of stack unwinding due to an exception.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 If the destructor runs as the result of normal execution (for example, not stack unwinding due to an exception) and neither the                         <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> nor                         <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> methods have been called, the destructor may throw a                         [missing_wait](../vs140/missing_wait-class.md) exception.  
  
##  \<a name="structured_task_group__wait_method">\</a>  structured_task_group::wait Method  
 Waits until all work on the                 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> has completed or is canceled.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 An indication of whether the wait was satisfied or the task group was canceled, due to either an explicit cancel operation or an exception being thrown from one of its tasks. For more information, see                         [task_group_status](concurrency_namespace_Enumerations)  
  
### Remarks  
 Note that one or more of the tasks scheduled to this                         <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> object may execute inline on the calling context.  
  
 If one or more of the tasks scheduled to this                         <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> object throws an exception, the runtime will select one such exception of its choosing and propagate it out of the call to the                         <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> method.  
  
 After this function returns, the                         <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> object is considered in a final state and should not be used. Note that utilization after the                         <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> method returns will result in undefined behavior.  
  
 In the non-exceptional path of execution, you have a mandate to call either this method or the                         <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> method before the destructor of the                         <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> executes.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [task_group Class](../vs140/task_group-class.md)   
 [task_handle Class](../vs140/task_handle-class.md)