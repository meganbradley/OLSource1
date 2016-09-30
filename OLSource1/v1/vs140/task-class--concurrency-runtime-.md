---
title: "task Class (Concurrency Runtime)"
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
  - "ppltasks/concurrency::task"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "task class"
ms.assetid: cdc3a8c0-5cbe-45a0-b5d5-e9f81d94df1a
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# task Class (Concurrency Runtime)
The Parallel Patterns Library (PPL)             <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class. A             <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object represents work that can be executed asynchronously, and concurrently with other tasks and parallel work produced by parallel algorithms in the Concurrency Runtime. It produces a result of type             <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> on successful completion. Tasks of type             <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> produce no result. A task can be waited upon and canceled independently of other tasks. It can also be composed with other tasks using continuations(            <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>), and join(            <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>) and choice(            <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>) patterns.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The result type of this task.  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|The type of the result an object of this class produces.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[task::task Constructor](#task__task_constructor)|Overloaded. Constructs a                                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[task::get Method](#task__get_method)|Overloaded. Returns the result this task produced. If the task is not in a terminal state, a call to                                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> will wait for the task to finish. This method does not return a value when called on a task with a                                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> of                                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.|  
|[task::is_apartment_aware Method](#task__is_apartment_aware_method)|Determines whether the task unwraps a Windows Runtime                                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> interface or is descended from such a task.|  
|[task::is_done Method (Concurrency Runtime)](#task__is_done_method__concurrency_runtime_)|Determines if the task is completed.|  
|[task::scheduler Method (Concurrency Runtime)](#task__scheduler_method__concurrency_runtime_)|Returns the scheduler for this task|  
|[task::then Method](#task__then_method)|Overloaded. Adds a continuation task to this task.|  
|[task::wait Method](#task__wait_method)|Waits for this task to reach a terminal state. It is possible for                                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to execute the task inline, if all of the tasks dependencies are satisfied, and it has not already been picked up for execution by a background worker.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[task::operator!= Operator](#task__operator_neq_operator)|Overloaded. Determines whether two                                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> objects represent different internal tasks.|  
|[task::operator= Operator](#task__operator_eq_operator)|Overloaded. Replaces the contents of one                                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object with another.|  
|[task::operator== Operator](#task__operator_eq_eq_operator)|Overloaded. Determines whether two                                         <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> objects represent the same internal task.|  
  
## Remarks  
 For more information, see                 [Task Parallelism (Concurrency Runtime)](../vs140/task-parallelism--concurrency-runtime-.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** ppltasks.h  
  
 **Namespace:** concurrency  
  
##  \<a name="task__get_method">\</a>  task::get Method  
 Returns the result this task produced. If the task is not in a terminal state, a call to                 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> will wait for the task to finish. This method does not return a value when called on a task with a                 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> of                 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 The result of the task.  
  
### Remarks  
 If the task is canceled, a call to                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> will throw a                         [task_canceled](../vs140/task_canceled-class.md) exception. If the task encountered an different exception or an exception was propagated to it from an antecedent task, a call to                         <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> will throw that exception.  
  
> [!IMPORTANT]
>  In a                             [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app, do not call                             [concurrency::task::wait](#task__wait_method) or                             <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> (                            <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> calls                             <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>) in code that runs on the STA. Otherwise, the runtime throws                             [concurrency::invalid_operation](../vs140/invalid_operation-class.md) because these methods block the current thread and can cause the app to become unresponsive. However, you can call the                             <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> method to receive the result of the antecedent task in a task-based continuation because the result is immediately available.  
  
##  \<a name="task__is_apartment_aware_method">\</a>  task::is_apartment_aware Method  
 Determines whether the task unwraps a Windows Runtime                 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> interface or is descended from such a task.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> if the task unwraps an                         <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> interface or is descended from such a task,                         <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="task__is_done_method__concurrency_runtime_">\</a>  task::is_done Method (Concurrency Runtime)  
 Determines if the task is completed.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 True if the task has completed, false otherwise.  
  
### Remarks  
 The function returns true if the task is completed or canceled (with or without user exception).  
  
##  \<a name="task__operator_neq_operator">\</a>  task::operator!= Operator  
 Determines whether two                 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> objects represent different internal tasks.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  
### Return Value  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> if the objects refer to different underlying tasks, and                         <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="task__operator_eq_operator">\</a>  task::operator= Operator  
 Replaces the contents of one                 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object with another.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The source                                 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object.  
  
### Return Value  
  
### Remarks  
 As                         <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> behaves like a smart pointer, after a copy assignment, this                         <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> objects represents the same actual task as                         <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> does.  
  
##  \<a name="task__operator_eq_eq_operator">\</a>  task::operator== Operator  
 Determines whether two                 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> objects represent the same internal task.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
  
### Return Value  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> if the objects refer to the same underlying task, and                         <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="task__scheduler_method__concurrency_runtime_">\</a>  task::scheduler Method (Concurrency Runtime)  
 Returns the scheduler for this task  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the scheduler  
  
##  \<a name="task__task_constructor">\</a>  task::task Constructor  
 Constructs a                 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 The type of the parameter from which the task is to be constructed.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 The parameter from which the task is to be constructed. This could be a lambda, a function object, a                                 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object, or a Windows::Foundation::IAsyncInfo if you are using tasks in your Windows Store app. The lambda or function object should be a type equivalent to                                 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, where X can be a variable of type                                 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>,                                 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, or a Windows::Foundation::IAsyncInfo in Windows Store apps.  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 The task options include cancellation token, scheduler etc  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 The source                                 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The default constructor for a                         <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> is only present in order to allow tasks to be used within containers. A default constructed task cannot be used until you assign a valid task to it. Methods such as                         <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> will throw an                         [invalid_argument](../vs140/invalid_argument-class.md) exception when called on a default constructed task.  
  
 A task that is created from a                         <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> will complete (and have its continuations scheduled) when the task completion event is set.  
  
 The version of the constructor that takes a cancellation token creates a task that can be canceled using the                         <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> the token was obtained from. Tasks created without a cancellation token are not cancelable.  
  
 Tasks created from a                         <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> interface or a lambda that returns an                         <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> interface reach their terminal state when the enclosed Windows Runtime asynchronous operation or action completes. Similarly, tasks created from a lamda that returns a                         <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> reach their terminal state when the inner task reaches its terminal state, and not when the lamda returns.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> behaves like a smart pointer and is safe to pass around by value. It can be accessed by multiple threads without the need for locks.  
  
 The constructor overloads that take a Windows::Foundation::IAsyncInfo interface or a lambda returning such an interface, are only available to Windows Store apps.  
  
 For more information, see                         [Task Parallelism (Concurrency Runtime)](../vs140/task-parallelism--concurrency-runtime-.md).  
  
##  \<a name="task__then_method">\</a>  task::then Method  
 Adds a continuation task to this task.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
 The type of the function object that will be invoked by this task.  
  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 The continuation function to execute when this task completes. This continuation function must take as input a variable of either                                 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> or                                 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, where                                 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> is the type of the result this task produces.  
  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 The task options include cancellation token, scheduler and continuation context. By default the former 3 options are inherited from the antecedent task  
  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 The cancellation token to associate with the continuation task. A continuation task that is created without a cancellation token will inherit the token of its antecedent task.  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 A variable that specifies where the continuation should execute. This variable is only useful when used in a Windows Store style app. For more information, see                                 [task_continuation_context](../vs140/task_continuation_context-class.md)  
  
### Return Value  
 The newly created continuation task. The result type of the returned task is determined by what                         <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> returns.  
  
### Remarks  
 The overloads of                         <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> that take a lambda or functor that returns a Windows::Foundation::IAsyncInfo interface, are only available to Windows Store apps.  
  
 For more information on how to use task continuations to compose asynchronous work, see                         [Task Parallelism (Concurrency Runtime)](../vs140/task-parallelism--concurrency-runtime-.md).  
  
##  \<a name="task__wait_method">\</a>  task::wait Method  
 Waits for this task to reach a terminal state. It is possible for                 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> to execute the task inline, if all of the tasks dependencies are satisfied, and it has not already been picked up for execution by a background worker.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 A                         <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> value which could be either                         <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>. If the task encountered an exception during execution, or an exception was propagated to it from an antecedent task,                         <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> will throw that exception.  
  
### Remarks  
  
> [!IMPORTANT]
>  In a                             [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app, do not call                             <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> in code that runs on the STA. Otherwise, the runtime throws                             [concurrency::invalid_operation](../vs140/invalid_operation-class.md) because this method blocks the current thread and can cause the app to become unresponsive. However, you can call the                             [concurrency::task::get](#task__get_method) method to receive the result of the antecedent task in a task-based continuation.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)