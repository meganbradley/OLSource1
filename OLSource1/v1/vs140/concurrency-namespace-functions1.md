---
title: "concurrency namespace functions1"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "concurrency namespace functions"
ms.assetid: 86c683a4-3d47-429d-b385-bfdf307cc49e
caps.latest.revision: 7
---
# concurrency namespace functions1
||||  
|-|-|-|  
|[Alloc Function](#alloc_function)|[CreateResourceManager Function](#createresourcemanager_function)|[DisableTracing Function](#disabletracing_function)|  
|[EnableTracing Function](#enabletracing_function)|[Free Function](#free_function)|[GetExecutionContextId Function](#getexecutioncontextid_function)|  
|[GetOSVersion Function](#getosversion_function)|[GetProcessorCount Function](#getprocessorcount_function)|[GetProcessorNodeCount Function](#getprocessornodecount_function)|  
|[GetSchedulerId Function](#getschedulerid_function)|[Trace_agents_register_name Function](#trace_agents_register_name_function)|[asend Function](#asend_function)|  
|[cancel_current_task Function](#cancel_current_task_function)|[clear Function](#clear_function)|[create_async Function](#create_async_function)|  
|[create_task Function](#create_task_function)|[get_ambient_scheduler Function (Concurrency Runtime)](#get_ambient_scheduler_function__concurrency_runtime_)|[internal_assign_iterators Function](#internal_assign_iterators_function)|  
|[interruption_point Function](#interruption_point_function)|[is_current_task_group_canceling Function](#is_current_task_group_canceling_function)|[make_choice Function](#make_choice_function)|  
|[make_greedy_join Function](#make_greedy_join_function)|[make_join Function](#make_join_function)|[make_task Function](#make_task_function)|  
|[parallel_buffered_sort Function](#parallel_buffered_sort_function)|[parallel_for Function](#parallel_for_function)|[parallel_for_each Function](#parallel_for_each_function)|  
|[parallel_invoke Function](#parallel_invoke_function)|[parallel_radixsort Function](#parallel_radixsort_function)|[parallel_reduce Function](#parallel_reduce_function)|  
|[parallel_sort Function](#parallel_sort_function)|[parallel_transform Function](#parallel_transform_function)|[receive Function](#receive_function)|  
|[run_with_cancellation_token Function](#run_with_cancellation_token_function)|[send Function](#send_function)|[set_ambient_scheduler Function (Concurrency Runtime)](#set_ambient_scheduler_function__concurrency_runtime_)|  
|[set_task_execution_resources Function](#set_task_execution_resources_function)|[swap Function](#swap_function)|[task_from_exception Function (Concurrency Runtime)](#task_from_exception_function__concurrency_runtime_)|  
|[task_from_result Function (Concurrency Runtime)](#task_from_result_function__concurrency_runtime_)|[try_receive Function](#try_receive_function)|[wait Function](#wait_function)|  
|[when_all Function](#when_all_function)|[when_any Function](#when_any_function)|  
  
##  \<a name="alloc_function">\</a>  Alloc Function  
 Allocates a block of memory of the size specified from the Concurrency Runtime Caching Suballocator.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The number of bytes of memory to allocate.  
  
### Return Value  
 A pointer to newly allocated memory.  
  
### Remarks  
 For more information about which scenarios in your application could benefit from using the Caching Suballocator, see                         [Task Scheduler (Concurrency Runtime)](../vs140/task-scheduler--concurrency-runtime-.md).  
  
##  \<a name="asend_function">\</a>  asend Function  
 An asynchronous send operation, which schedules a task to propagate the data to the target block.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 The type of the data to be sent.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 A pointer or reference to the target to which data is sent.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 A reference to the data to be sent.  
  
### Return Value  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> if the message was accepted before the method returned,                         <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 For more information, see                         [Message Passing Functions](../vs140/message-passing-functions.md).  
  
##  \<a name="cancel_current_task_function">\</a>  cancel_current_task Function  
 Cancels the currently executing task. This function can be called from within the body of a task to abort the task's execution and cause it to enter the                 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> state.  
  
 It is not a supported scenario to call this function if you are not within the body of a                 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>. Doing so will result in undefined behavior such as a crash or a hang in your application.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="clear_function">\</a>  clear Function  
 Clears the concurrent queue, destroying any currently enqueued elements. This method is not concurrency-safe.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
  
##  \<a name="create_async_function">\</a>  create_async Function  
 Creates a Windows Runtime asynchronous construct based on a user supplied lambda or function object. The return type of                 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is one of either                 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>,                 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>,                 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, or                 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> based on the signature of the lambda passed to the method.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 The lambda or function object from which to create a Windows Runtime asynchronous construct.  
  
### Return Value  
 An asynchronous construct represented by an IAsyncAction^, IAsyncActionWithProgress\<TProgress>^, IAsyncOperation\<TResult>^, or an IAsyncOperationWithProgress\<TResult, TProgress>^. The interface returned depends on the signature of the lambda passed into the function.  
  
### Remarks  
 The return type of the lambda determines whether the construct is an action or an operation.  
  
 Lambdas that return void cause the creation of actions. Lambdas that return a result of type                         <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> cause the creation of operations of TResult.  
  
 The lambda may also return a                         <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> which encapsulates the aysnchronous work within itself or is the continuation of a chain of tasks that represent the asynchronous work. In this case, the lambda itself is executed inline, since the tasks are the ones that execute asynchronously, and the return type of the lambda is unwrapped to produce the asynchronous construct returned by                         <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>. This implies that a lambda that returns a task\<void> will cause the creation of actions, and a lambda that returns a task\<TResult> will cause the creation of operations of TResult.  
  
 The lambda may take either zero, one or two arguments. The valid arguments are                         <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> and                         <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, in that order if both are used. A lambda without arguments causes the creation of an asynchronous construct without the capability for progress reporting. A lambda that takes a progress_reporter\<TProgress> will cause                         <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> to return an asynchronous construct which reports progress of type TProgress each time the                         <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> method of the progress_reporter object is called. A lambda that takes a cancellation_token may use that token to check for cancellation, or pass it to tasks that it creates so that cancellation of the asynchronous construct causes cancellation of those tasks.  
  
 If the body of the lambda or function object returns a result (and not a task\<TResult>), the lamdba will be executed asynchronously within the process MTA in the context of a task the Runtime implicitly creates for it. The                         <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> method will cause cancellation of the implicit task.  
  
 If the body of the lambda returns a task, the lamba executes inline, and by declaring the lambda to take an argument of type                         <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> you can trigger cancellation of any tasks you create within the lambda by passing that token in when you create them. You may also use the                         <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> method on the token to cause the Runtime to invoke a callback when you call                         <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> on the async operation or action produced..  
  
 This function is only available to Windows Store apps.  
  
##  \<a name="createresourcemanager_function">\</a>  CreateResourceManager Function  
 Returns an interface that represents the singleton instance of the Concurrency Runtime's Resource Manager. The Resource Manager is responsible for assigning resources to schedulers that want to cooperate with each other.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 An                         <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> interface.  
  
### Remarks  
 Multiple subsequent calls to this method will return the same instance of the Resource Manager. Each call to the method increments a reference count on the Resource Manager, and must be matched with a call to the                         [IResourceManager::Release](assetId:///5d1356ec-fbd3-4284-a361-1e9e20bbb522) method when your scheduler is done communicating with the Resource Manager.  
  
 [unsupported_os](../vs140/unsupported_os-class.md) is thrown if the operating system is not supported by the Concurrency Runtime.  
  
##  \<a name="create_task_function">\</a>  create_task Function  
 Creates a PPL                 [task](assetId:///5389e8a5-5038-40b6-844a-55e9b58ad35f) object.                 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> can be used anywhere you would have used a task constructor. It is provided mainly for convenience, because it allows use of the                 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> keyword while creating tasks.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 The type of the parameter from which the task is to be constructed.  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 The parameter from which the task is to be constructed. This could be a lambda or function object, a                                 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> object, a different                                 <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> object, or a Windows::Foundation::IAsyncInfo interface if you are using tasks in your Windows Store app.  
  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
  
### Return Value  
 A new task of type                         <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, that is inferred from                         <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.  
  
### Remarks  
 The first overload behaves like a task constructor that takes a single parameter.  
  
 The second overload associates the cancellation token provided with the newly created task. If you use this overload you are not allowed to pass in a different                         <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> object as the first parameter.  
  
 The type of the returned task is inferred from the first parameter to the function. If                         <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> is a                         <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>, a                         <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>, or a functor that returns either type                         <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>, the type of the created task is                         <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>.  
  
 In a Windows Store app, if                         <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> is of type Windows::Foundation::IAsyncOperation\<T>^ or Windows::Foundation::IAsyncOperationWithProgress\<T,P>^, or a functor that returns either of those types, the created task will be of type                         <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>. If                         <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> is of type Windows::Foundation::IAsyncAction^ or Windows::Foundation::IAsyncActionWithProgress\<P>^, or a functor that returns either of those types, the created task will have type                         <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>.  
  
##  \<a name="disabletracing_function">\</a>  DisableTracing Function  
 Disables tracing in the Concurrency Runtime. This function is deprecated because ETW tracing is unregistered by default.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 If tracing was correctly disabled,                         <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> is returned. If tracing was not previously initiated,                         <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> is returned  
  
##  \<a name="enabletracing_function">\</a>  EnableTracing Function  
 Enables tracing in the Concurrency Runtime. This function is deprecated because ETW tracing is now on by default.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 If tracing was correctly initiated,                         <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> is returned; otherwise,                         <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> is returned.  
  
##  \<a name="free_function">\</a>  Free Function  
 Releases a block of memory previously allocated by the                 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> method to the Concurrency Runtime Caching Suballocator.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 A pointer to memory previously allocated by the                                 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> method which is to be freed. If the parameter                                 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> is set to the value                                 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>, this method will ignore it and return immediately.  
  
### Remarks  
 For more information about which scenarios in your application could benefit from using the Caching Suballocator, see                         [Task Scheduler (Concurrency Runtime)](../vs140/task-scheduler--concurrency-runtime-.md).  
  
##  \<a name="get_ambient_scheduler_function__concurrency_runtime_">\</a>  get_ambient_scheduler Function (Concurrency Runtime)  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
  
##  \<a name="getexecutioncontextid_function">\</a>  GetExecutionContextId Function  
 Returns a unique identifier that can be assigned to an execution context that implements the                 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> interface.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 A unique identifier for an execution context.  
  
### Remarks  
 Use this method to obtain an identifier for your execution context before you pass an                         <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> interface as a parameter to any of the methods offered by the Resource Manager.  
  
##  \<a name="getosversion_function">\</a>  GetOSVersion Function  
 Returns the operating system version.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 An enumerated value representing the operating system.  
  
### Remarks  
 [unsupported_os](../vs140/unsupported_os-class.md) is thrown if the operating system is not supported by the Concurrency Runtime.  
  
##  \<a name="getprocessorcount_function">\</a>  GetProcessorCount Function  
 Returns the number of hardware threads on the underlying system.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 The number of hardware threads.  
  
### Remarks  
 [unsupported_os](../vs140/unsupported_os-class.md) is thrown if the operating system is not supported by the Concurrency Runtime.  
  
##  \<a name="getprocessornodecount_function">\</a>  GetProcessorNodeCount Function  
 Returns the number of NUMA nodes or processor packages on the underlying system.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 The number of NUMA nodes or processor packages.  
  
### Remarks  
 If the system contains more NUMA nodes than processor packages, the number of NUMA nodes is returned, otherwise, the number of processor packages is returned.  
  
 [unsupported_os](../vs140/unsupported_os-class.md) is thrown if the operating system is not supported by the Concurrency Runtime.  
  
##  \<a name="getschedulerid_function">\</a>  GetSchedulerId Function  
 Returns a unique identifier that can be assigned to a scheduler that implements the                 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> interface.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 A unique identifier for a scheduler.  
  
### Remarks  
 Use this method to obtain an identifier for your scheduler before you pass an                         <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> interface as a parameter to any of the methods offered by the Resource Manager.  
  
##  \<a name="internal_assign_iterators_function">\</a>  internal_assign_iterators Function  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
  
##  \<a name="interruption_point_function">\</a>  interruption_point Function  
 Creates an interruption point for cancellation. If a cancellation is in progress in the context where this function is called, this will throw an internal exception that aborts the execution of the currently executing parallel work. If cancellation is not in progress, the function does nothing.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Remarks  
 You should not catch the internal cancellation exception thrown by the                         <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> function. The exception will be caught and handled by the runtime, and catching it may cause your program to behave abnormally.  
  
##  \<a name="is_current_task_group_canceling_function">\</a>  is_current_task_group_canceling Function  
 Returns an indication of whether the task group which is currently executing inline on the current context is in the midst of an active cancellation (or will be shortly). Note that if there is no task group currently executing inline on the current context,                 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> will be returned.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> if the task group which is currently executing is canceling,                         <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 For more information, see                         [Cancellation in the PPL](../vs140/cancellation-in-the-ppl.md).  
  
##  \<a name="make_choice_function">\</a>  make_choice Function  
 Constructs a                 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> messaging block from an optional                 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> or                 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> and two or more input sources.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 The message block type of the first source.  
  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 The message block type of the second source.  
  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> object within which the propagation task for the                                 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> messaging block is scheduled.  
  
 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
 The first source.  
  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 The second source.  
  
 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
 Additional sources.  
  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> object within which the propagation task for the                                 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> messaging block is scheduled. The                                 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> object used is implied by the schedule group.  
  
### Return Value  
 A                         <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> message block with two or more input sources.  
  
##  \<a name="make_greedy_join_function">\</a>  make_greedy_join Function  
 Constructs a                 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> messaging block from an optional                 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> or                 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> and two or more input sources.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
 The message block type of the first source.  
  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 The message block type of the second source.  
  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> object within which the propagation task for the                                 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> messaging block is scheduled.  
  
 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 The first source.  
  
 <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
 The second source.  
  
 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>  
 Additional sources.  
  
 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> object within which the propagation task for the                                 <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> messaging block is scheduled. The                                 <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> object used is implied by the schedule group.  
  
### Return Value  
 A                         <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> message block with two or more input sources.  
  
##  \<a name="make_join_function">\</a>  make_join Function  
 Constructs a                 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> messaging block from an optional                 <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> or                 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> and two or more input sources.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 The message block type of the first source.  
  
 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 The message block type of the second source.  
  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> object within which the propagation task for the                                 <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> messaging block is scheduled.  
  
 <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
 The first source.  
  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 The second source.  
  
 <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>  
 Additional sources.  
  
 <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> object within which the propagation task for the                                 <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> messaging block is scheduled. The                                 <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> object used is implied by the schedule group.  
  
### Return Value  
 A                         <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> message block with two or more input sources.  
  
##  \<a name="make_task_function">\</a>  make_task Function  
 A factory method for creating a                 <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>  
 The type of the function object that will be invoked to execute the work represented by the                                 <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>  
 The function that will be invoked to execute the work represented by the                                 <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> object. This may be a lambda functor, a pointer to a function, or any object that supports a version of the function call operator with the signature                                 <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>.  
  
### Return Value  
 A                         <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> object.  
  
### Remarks  
 This function is useful when you need to create a                         <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> object with a lambda expression, because it allows you to create the object without knowing the true type of the lambda functor.  
  
##  \<a name="parallel_buffered_sort_function">\</a>  parallel_buffered_sort Function  
 Arranges the elements in a specified range into a nondescending order, or according to an ordering criterion specified by a binary predicate, in parallel. This function is semantically similar to                 <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> in that it is a compare-based, unstable, in-place sort except that it needs                 <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> additional space, and requires default initialization for the elements being sorted.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>  
 The iterator type of the input range.  
  
 <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
 The type of an STL compatible memory allocator.  
  
 <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
 The type of the binary comparator.  
  
 <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position of the first element in the range to be sorted.  
  
 <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position one past the final element in the range to be sorted.  
  
 <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
 An instance of an STL compatible memory allocator.  
  
 <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>  
 A user-defined predicate function object that defines the comparison criterion to be satisfied by successive elements in the ordering. A binary predicate takes two arguments and returns                                 <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> when satisfied and                                 <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> when not satisfied. This comparator function must impose a strict weak ordering on pairs of elements from the sequence.  
  
 <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
 The mimimum size of a chunk that will be split into two for parallel execution.  
  
### Remarks  
 All overloads require                         <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> additional space, where                         <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> is the number of elements to be sorted, and                         <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> is the element type. In most cases parallel_buffered_sort will show an improvement in performance over                         [parallel_sort](concurrency_namespace_Functions), and you should use it over parallel_sort if you have the memory available.  
  
 If you do not supply a binary comparator                         <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> is used as the default, which requires the element type to provide the operator                         <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>.  
  
 If you do not supply an allocator type or instance, the STL memory allocator                         <CodeContentPlaceHolder>190\</CodeContentPlaceHolder> is used to allocate the buffer.  
  
 The algorithm divides the input range into two chunks and successively divides each chunk into two sub-chunks for execution in parallel. The optional argument                         <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> can be used to indicate to the algorithm that it should handles chunks of size <                         <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> serially.  
  
##  \<a name="parallel_for_function">\</a>  parallel_for Function  
 <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> iterates over a range of indices and executes a user-supplied function at each iteration, in parallel.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  
 The type of the index being used for the iteration.  
  
 <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>  
 The type of the function that will be executed at each iteration.  
  
 <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>  
 The type of the partitioner that is used to partition the supplied range.  
  
 <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
 The first index to be included in the iteration.  
  
 <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>  
 The index one past the last index to be included in the iteration.  
  
 <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>  
 The value by which to step when iterating from                                 <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> to                                 <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>. The step must be positive.                                 [invalid_argument](../vs140/invalid_argument-class.md) is thrown if the step is less than 1.  
  
 <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>  
 The function to be executed at each iteration. This may be a lambda expression, a function pointer, or any object that supports a version of the function call operator with the signature                                 <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>  
 A reference to the partitioner object. The argument can be one of                                 <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>[auto_partitioner](../vs140/auto_partitioner-class.md)<CodeContentPlaceHolder>206\</CodeContentPlaceHolder>,                                 <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>[static_partitioner](../vs140/static_partitioner-class.md)<CodeContentPlaceHolder>208\</CodeContentPlaceHolder>,                                 <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>[simple_partitioner](../vs140/simple_partitioner-class.md)<CodeContentPlaceHolder>210\</CodeContentPlaceHolder> or                                 [affinity_partitioner](../vs140/affinity_partitioner-class.md)<CodeContentPlaceHolder>211\</CodeContentPlaceHolder> If an                                 [affinity_partitioner](../vs140/affinity_partitioner-class.md) object is used, the reference must be a non-const l-value reference, so that the algorithm can store state for future loops to re-use.  
  
### Remarks  
 For more information, see                         [Parallel Algorithms](../vs140/parallel-algorithms.md).  
  
##  \<a name="parallel_for_each_function">\</a>  parallel_for_each Function  
 <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> applies a specified function to each element within a range, in parallel. It is semantically equivalent to the                 <CodeContentPlaceHolder>213\</CodeContentPlaceHolder> function in the                 <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> namespace, except that iteration over the elements is performed in parallel, and the order of iteration is unspecified. The argument                 <CodeContentPlaceHolder>215\</CodeContentPlaceHolder> must support a function call operator of the form                 <CodeContentPlaceHolder>216\</CodeContentPlaceHolder> where the parameter                 <CodeContentPlaceHolder>217\</CodeContentPlaceHolder> is the item type of the container being iterated over.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>  
 The type of the iterator being used to iterate over the container.  
  
 <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>  
 The type of the function that will be applied to each element within the range.  
  
 <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>  
 An iterator addressing the position of the first element to be included in parallel iteration.  
  
 <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>  
 An iterator addressing the position one past the final element to be included in parallel iteration.  
  
 <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>  
 A user-defined function object that is applied to each element in the range.  
  
 <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>  
 A reference to the partitioner object. The argument can be one of                                 <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>[auto_partitioner](../vs140/auto_partitioner-class.md)<CodeContentPlaceHolder>226\</CodeContentPlaceHolder>,                                 <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>[static_partitioner](../vs140/static_partitioner-class.md)<CodeContentPlaceHolder>228\</CodeContentPlaceHolder>,                                 <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>[simple_partitioner](../vs140/simple_partitioner-class.md)<CodeContentPlaceHolder>230\</CodeContentPlaceHolder> or                                 [affinity_partitioner](../vs140/affinity_partitioner-class.md)<CodeContentPlaceHolder>231\</CodeContentPlaceHolder> If an                                 [affinity_partitioner](../vs140/affinity_partitioner-class.md) object is used, the reference must be a non-const l-value reference, so that the algorithm can store state for future loops to re-use.  
  
### Remarks  
 [auto_partitioner](../vs140/auto_partitioner-class.md) will be used for the overload without an explicit partitioner.  
  
 For iterators that do not support random access, only                         [auto_partitioner](../vs140/auto_partitioner-class.md) is supported.  
  
 For more information, see                         [Parallel Algorithms](../vs140/parallel-algorithms.md).  
  
##  \<a name="parallel_invoke_function">\</a>  parallel_invoke Function  
 Executes the function objects supplied as parameters in parallel, and blocks until they have finished executing. Each function object could be a lambda expression, a pointer to function, or any object that supports the function call operator with the signature                 <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>  
 The type of the first function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>  
 The type of the second function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>235\</CodeContentPlaceHolder>  
 The type of the third function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>  
 The type of the fourth function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>  
 The type of the fifth function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>  
 The type of the sixth function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>239\</CodeContentPlaceHolder>  
 The type of the seventh function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>  
 The type of the eighth function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>  
 The type of the ninth function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>  
 The type of the tenth function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>  
 The first function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>244\</CodeContentPlaceHolder>  
 The second function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>245\</CodeContentPlaceHolder>  
 The third function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>246\</CodeContentPlaceHolder>  
 The fourth function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>  
 The fifth function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>  
 The sixth function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>249\</CodeContentPlaceHolder>  
 The seventh function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>250\</CodeContentPlaceHolder>  
 The eighth function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>  
 The ninth function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>252\</CodeContentPlaceHolder>  
 The tenth function object to be executed in parallel.  
  
### Remarks  
 Note that one or more of the function objects supplied as parameters may execute inline on the calling context.  
  
 If one or more of the function objects passed as parameters to this function throws an exception, the runtime will select one such exception of its choosing and propagate it out of the call to                         <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>.  
  
 For more information, see                         [Parallel Algorithms](../vs140/parallel-algorithms.md).  
  
##  \<a name="parallel_radixsort_function">\</a>  parallel_radixsort Function  
 Arranges elements in a specified range into an non descending order using a radix sorting algorithm. This is a stable sort function which requires a projection function that can project elements to be sorted into unsigned integer-like keys. Default initialization is required for the elements being sorted.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>254\</CodeContentPlaceHolder>  
 The iterator type of the input range.  
  
 <CodeContentPlaceHolder>255\</CodeContentPlaceHolder>  
 The type of an STL compatible memory allocator.  
  
 <CodeContentPlaceHolder>256\</CodeContentPlaceHolder>  
 The type of the projection function.  
  
 <CodeContentPlaceHolder>257\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position of the first element in the range to be sorted.  
  
 <CodeContentPlaceHolder>258\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position one past the final element in the range to be sorted.  
  
 <CodeContentPlaceHolder>259\</CodeContentPlaceHolder>  
 An instance of an STL compatible memory allocator.  
  
 <CodeContentPlaceHolder>260\</CodeContentPlaceHolder>  
 A user-defined projection function object that converts an element into an integral value.  
  
 <CodeContentPlaceHolder>261\</CodeContentPlaceHolder>  
 The mimimum size of a chunk that will be split into two for parallel execution.  
  
### Remarks  
 All overloads require                         <CodeContentPlaceHolder>262\</CodeContentPlaceHolder> additional space, where                         <CodeContentPlaceHolder>263\</CodeContentPlaceHolder> is the number of elements to be sorted, and                         <CodeContentPlaceHolder>264\</CodeContentPlaceHolder> is the element type. An unary projection functor with the signature <CodeContentPlaceHolder>265\</CodeContentPlaceHolder> is required to return a key when given an element, where                         <CodeContentPlaceHolder>266\</CodeContentPlaceHolder> is the element type and                         <CodeContentPlaceHolder>267\</CodeContentPlaceHolder> is an unsigned integer-like type.  
  
 If you do not supply a projection function, a default projection function which simply returns the element is used for integral types. The function will fail to compile if the element is not an integral type in the absence of a projection function.  
  
 If you do not supply an allocator type or instance, the STL memory allocator                         <CodeContentPlaceHolder>268\</CodeContentPlaceHolder> is used to allocate the buffer.  
  
 The algorithm divides the input range into two chunks and successively divides each chunk into two sub-chunks for execution in parallel. The optional argument                         <CodeContentPlaceHolder>269\</CodeContentPlaceHolder> can be used to indicate to the algorithm that it should handles chunks of size <                         <CodeContentPlaceHolder>270\</CodeContentPlaceHolder> serially.  
  
##  \<a name="parallel_reduce_function">\</a>  parallel_reduce Function  
 Computes the sum of all elements in a specified range by computing successive partial sums, or computes the result of successive partial results similarly obtained from using a specified binary operation other than sum, in parallel.                 <CodeContentPlaceHolder>271\</CodeContentPlaceHolder> is semantically similar to                 <CodeContentPlaceHolder>272\</CodeContentPlaceHolder>, except that it requires the binary operation to be associative, and requires an identity value instead of an initial value.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>273\</CodeContentPlaceHolder>  
 The iterator type of input range.  
  
 <CodeContentPlaceHolder>274\</CodeContentPlaceHolder>  
 The type of the symmetric reduction function. This must be a function type with signature                                 <CodeContentPlaceHolder>275\</CodeContentPlaceHolder>, where _Reduce_type is the same as the identity type and the result type of the reduction. For the third overload, this should be consistent with the output type of                                 <CodeContentPlaceHolder>276\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>277\</CodeContentPlaceHolder>  
 The type that the input will reduce to, which can be different from the input element type. The return value and identity value will has this type.  
  
 <CodeContentPlaceHolder>278\</CodeContentPlaceHolder>  
 The type of the range reduction function. This must be a function type with signature                                 <CodeContentPlaceHolder>279\</CodeContentPlaceHolder>, _Reduce_type is the same as the identity type and the result type of the reduction.  
  
 <CodeContentPlaceHolder>280\</CodeContentPlaceHolder>  
 An input iterator addressing the first element in the range to be reduced.  
  
 <CodeContentPlaceHolder>281\</CodeContentPlaceHolder>  
 An input iterator addressing the element that is one position beyond the final element in the range to be reduced.  
  
 <CodeContentPlaceHolder>282\</CodeContentPlaceHolder>  
 The identity value                                 <CodeContentPlaceHolder>283\</CodeContentPlaceHolder> is of the same type as the result type of the reduction and also the                                 <CodeContentPlaceHolder>284\</CodeContentPlaceHolder> of the iterator for the first and second overloads. For the third overload, the identity value must have the same type as the result type of the reduction, but can be different from the                                 <CodeContentPlaceHolder>285\</CodeContentPlaceHolder> of the iterator. It must have an appropriate value such that the range reduction operator                                 <CodeContentPlaceHolder>286\</CodeContentPlaceHolder>, when applied to a range of a single element of type                                 <CodeContentPlaceHolder>287\</CodeContentPlaceHolder> and the identity value, behaves like a type cast of the value from type                                 <CodeContentPlaceHolder>288\</CodeContentPlaceHolder> to the identity type.  
  
 <CodeContentPlaceHolder>289\</CodeContentPlaceHolder>  
 The symmetric function that will be used in the second of the reduction. Refer to Remarks for more information.  
  
 <CodeContentPlaceHolder>290\</CodeContentPlaceHolder>  
 The function that will be used in the first phase of the reduction. Refer to Remarks for more information.  
  
### Return Value  
 The result of the reduction.  
  
### Remarks  
 To perform a parallel reduction, the function divides the range into chunks based on the number of workers available to the underlying scheduler. The reduction takes place in two phases, the first phase performs a reduction within each chunk, and the second phase performs a reduction between the partial results from each chunk.  
  
 The first overload requires that the iterator's                         <CodeContentPlaceHolder>291\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>292\</CodeContentPlaceHolder>, be the same as the identity value type as well as the reduction result type. The element type T must provide the operator                         <CodeContentPlaceHolder>293\</CodeContentPlaceHolder> to reduce elements in each chunk. The same operator is used in the second phase as well.  
  
 The second overload also requires that the iterator's                         <CodeContentPlaceHolder>294\</CodeContentPlaceHolder> be the same as the identity value type as well as the reduction result type. The supplied binary operator                         <CodeContentPlaceHolder>295\</CodeContentPlaceHolder> is used in both reduction phases, with the identity value as the initial value for the first phase.  
  
 For the third overload, the identity value type must be the same as the reduction result type, but the iterator's                         <CodeContentPlaceHolder>296\</CodeContentPlaceHolder> may be different from both. The range reduction function                         <CodeContentPlaceHolder>297\</CodeContentPlaceHolder> is used in the first phase with the identity value as the initial value, and the binary function                         <CodeContentPlaceHolder>298\</CodeContentPlaceHolder> is applied to sub results in the second phase.  
  
##  \<a name="parallel_sort_function">\</a>  parallel_sort Function  
 Arranges the elements in a specified range into a nondescending order, or according to an ordering criterion specified by a binary predicate, in parallel. This function is semantically similar to                 <CodeContentPlaceHolder>299\</CodeContentPlaceHolder> in that it is a compare-based, unstable, in-place sort.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>300\</CodeContentPlaceHolder>  
 The iterator type of the input range.  
  
 <CodeContentPlaceHolder>301\</CodeContentPlaceHolder>  
 The type of the binary comparison functor.  
  
 <CodeContentPlaceHolder>302\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position of the first element in the range to be sorted.  
  
 <CodeContentPlaceHolder>303\</CodeContentPlaceHolder>  
 A random-access iterator addressing the position one past the final element in the range to be sorted.  
  
 <CodeContentPlaceHolder>304\</CodeContentPlaceHolder>  
 A user-defined predicate function object that defines the comparison criterion to be satisfied by successive elements in the ordering. A binary predicate takes two arguments and returns                                 <CodeContentPlaceHolder>305\</CodeContentPlaceHolder> when satisfied and                                 <CodeContentPlaceHolder>306\</CodeContentPlaceHolder> when not satisfied. This comparator function must impose a strict weak ordering on pairs of elements from the sequence.  
  
 <CodeContentPlaceHolder>307\</CodeContentPlaceHolder>  
 The mimimum size of a chunk that will be split into two for parallel execution.  
  
### Remarks  
 The first overload uses the the binary comparator                         <CodeContentPlaceHolder>308\</CodeContentPlaceHolder>.  
  
 The second overloaded uses the supplied binary comparator that should have the signature                         <CodeContentPlaceHolder>309\</CodeContentPlaceHolder> where                         <CodeContentPlaceHolder>310\</CodeContentPlaceHolder> is the type of the elements in the input range.  
  
 The algorithm divides the input range into two chunks and successively divides each chunk into two sub-chunks for execution in parallel. The optional argument                         <CodeContentPlaceHolder>311\</CodeContentPlaceHolder> can be used to indicate to the algorithm that it should handles chunks of size <                         <CodeContentPlaceHolder>312\</CodeContentPlaceHolder> serially.  
  
##  \<a name="parallel_transform_function">\</a>  parallel_transform Function  
 Applies a specified function object to each element in a source range, or to a pair of elements from two source ranges, and copies the return values of the function object into a destination range, in parallel. This functional is semantically equivalent to                 <CodeContentPlaceHolder>313\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>314\</CodeContentPlaceHolder>  
 The type of the first or only input iterator.  
  
 <CodeContentPlaceHolder>315\</CodeContentPlaceHolder>  
 The type of the output iterator.  
  
 <CodeContentPlaceHolder>316\</CodeContentPlaceHolder>  
 The type of the unary functor to be executed on each element in the input range.  
  
 <CodeContentPlaceHolder>317\</CodeContentPlaceHolder>  
 The type of second input iterator.  
  
 <CodeContentPlaceHolder>318\</CodeContentPlaceHolder>  
 The type of the binary functor executed pairwise on elements from the two source ranges.  
  
 <CodeContentPlaceHolder>319\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>320\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the first or only source range to be operated on.  
  
 <CodeContentPlaceHolder>321\</CodeContentPlaceHolder>  
 An input iterator addressing the position one past the final element in the first or only source range to be operated on.  
  
 <CodeContentPlaceHolder>322\</CodeContentPlaceHolder>  
 An output iterator addressing the position of the first element in the destination range.  
  
 <CodeContentPlaceHolder>323\</CodeContentPlaceHolder>  
 A user-defined unary function object that is applied to each element in the source range.  
  
 <CodeContentPlaceHolder>324\</CodeContentPlaceHolder>  
 A reference to the partitioner object. The argument can be one of                                 <CodeContentPlaceHolder>325\</CodeContentPlaceHolder>[auto_partitioner](../vs140/auto_partitioner-class.md)<CodeContentPlaceHolder>326\</CodeContentPlaceHolder>,                                 <CodeContentPlaceHolder>327\</CodeContentPlaceHolder>[static_partitioner](../vs140/static_partitioner-class.md)<CodeContentPlaceHolder>328\</CodeContentPlaceHolder>,                                 <CodeContentPlaceHolder>329\</CodeContentPlaceHolder>[simple_partitioner](../vs140/simple_partitioner-class.md)<CodeContentPlaceHolder>330\</CodeContentPlaceHolder> or                                 [affinity_partitioner](../vs140/affinity_partitioner-class.md)<CodeContentPlaceHolder>331\</CodeContentPlaceHolder> If an                                 [affinity_partitioner](../vs140/affinity_partitioner-class.md) object is used, the reference must be a non-const l-value reference, so that the algorithm can store state for future loops to re-use.  
  
 <CodeContentPlaceHolder>332\</CodeContentPlaceHolder>  
 An input iterator addressing the position of the first element in the second source range to be operated on.  
  
 <CodeContentPlaceHolder>333\</CodeContentPlaceHolder>  
 A user-defined binary function object that is applied pairwise, in a forward order, to the two source ranges.  
  
### Return Value  
 An output iterator addressing the position one past the final element in the destination range that is receiving the output elements transformed by the function object.  
  
### Remarks  
 [auto_partitioner](../vs140/auto_partitioner-class.md) will be used for the overloads without an explicit partitioner argument.  
  
 For iterators that do not support random access, only                         [auto_partitioner](../vs140/auto_partitioner-class.md) is supported.  
  
 The overloads that take the argument                         <CodeContentPlaceHolder>334\</CodeContentPlaceHolder> transform the input range into the output range by applying the unary functor to each element in the input range.                         <CodeContentPlaceHolder>335\</CodeContentPlaceHolder> must support the function call operator with signature                         <CodeContentPlaceHolder>336\</CodeContentPlaceHolder> where                         <CodeContentPlaceHolder>337\</CodeContentPlaceHolder> is the value type of the range being iterated over.  
  
 The overloads that take the argument                         <CodeContentPlaceHolder>338\</CodeContentPlaceHolder> transform two input ranges into the output range by applying the binary functor to one element from the first input range and one element from the second input range.                         <CodeContentPlaceHolder>339\</CodeContentPlaceHolder> must support the function call operator with signature                         <CodeContentPlaceHolder>340\</CodeContentPlaceHolder> where                         <CodeContentPlaceHolder>341\</CodeContentPlaceHolder>,                         <CodeContentPlaceHolder>342\</CodeContentPlaceHolder> are value types of the two input iterators.  
  
 For more information, see                         [Parallel Algorithms](../vs140/parallel-algorithms.md).  
  
##  \<a name="receive_function">\</a>  receive Function  
 A general receive implementation, allowing a context to wait for data from exactly one source and filter the values that are accepted.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>343\</CodeContentPlaceHolder>  
 The payload type.  
  
 <CodeContentPlaceHolder>344\</CodeContentPlaceHolder>  
 A pointer or reference to the source from which data is expected.  
  
 <CodeContentPlaceHolder>345\</CodeContentPlaceHolder>  
 The maximum time for which the method should for the data, in milliseconds.  
  
 <CodeContentPlaceHolder>346\</CodeContentPlaceHolder>  
 A filter function which determines whether messages should be accepted.  
  
### Return Value  
 A value from the source, of the payload type.  
  
### Remarks  
 If the parameter                         <CodeContentPlaceHolder>347\</CodeContentPlaceHolder> has a value other than the constant                         <CodeContentPlaceHolder>348\</CodeContentPlaceHolder>, the exception                         [operation_timed_out](../vs140/operation_timed_out-class.md) is thrown if the specified amount of time expires before a message is received. If you want a zero length timeout, you should use the                         [try_receive](concurrency_namespace_Functions) function, as opposed to calling                         <CodeContentPlaceHolder>349\</CodeContentPlaceHolder> with a timeout of                         <CodeContentPlaceHolder>350\</CodeContentPlaceHolder> (zero), as it is more efficient and does not throw exceptions on timeouts.  
  
 For more information, see                         [Message Passing Functions](../vs140/message-passing-functions.md).  
  
##  \<a name="run_with_cancellation_token_function">\</a>  run_with_cancellation_token Function  
 Executes a function object immediately and synchronously in the context of a given cancellation token.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>351\</CodeContentPlaceHolder>  
 The type of the function object that will be invoked.  
  
 <CodeContentPlaceHolder>352\</CodeContentPlaceHolder>  
 The function object which will be executed. This object must support the function call operator with a signature of void(void).  
  
 <CodeContentPlaceHolder>353\</CodeContentPlaceHolder>  
 The cancellation token which will control implicit cancellation of the function object. Use                                 <CodeContentPlaceHolder>354\</CodeContentPlaceHolder> if you want the function execute without any possibility of implicit cancellation from a parent task group being canceled.  
  
### Remarks  
 Any interruption points in the function object will be triggered when the                         <CodeContentPlaceHolder>355\</CodeContentPlaceHolder> is canceled. The explicit token                         <CodeContentPlaceHolder>356\</CodeContentPlaceHolder> will isolate this                         <CodeContentPlaceHolder>357\</CodeContentPlaceHolder> from parent cancellation if the parent has a different token or no token.  
  
##  \<a name="send_function">\</a>  send Function  
 A synchronous send operation, which waits until the target either accepts or declines the message.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>358\</CodeContentPlaceHolder>  
 The payload type.  
  
 <CodeContentPlaceHolder>359\</CodeContentPlaceHolder>  
 A pointer or reference to the target to which data is sent.  
  
 <CodeContentPlaceHolder>360\</CodeContentPlaceHolder>  
 A reference to the data to be sent.  
  
### Return Value  
 <CodeContentPlaceHolder>361\</CodeContentPlaceHolder> if the message was accepted,                         <CodeContentPlaceHolder>362\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 For more information, see                         [Message Passing Functions](../vs140/message-passing-functions.md).  
  
##  \<a name="set_ambient_scheduler_function__concurrency_runtime_">\</a>  set_ambient_scheduler Function (Concurrency Runtime)  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>363\</CodeContentPlaceHolder>  
  
##  \<a name="set_task_execution_resources_function">\</a>  set_task_execution_resources Function  
 Restricts the execution resources used by the Concurrency Runtime internal worker threads to the affinity set specified.  
  
 It is valid to call this method only before the Resource Manager has been created, or between two Resource Manager lifetimes. It can be invoked multiple times as long as the Resource Manager does not exist at the time of invocation. After an affinity limit has been set, it remains in effect until the next valid call to the                 <CodeContentPlaceHolder>364\</CodeContentPlaceHolder> method.  
  
 The affinity mask provided need not be a subset of the process affinity mask. The process affinity will be updated if necessary.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>365\</CodeContentPlaceHolder>  
 The affinity mask that the Concurrency Runtime worker threads are to be restricted to. Use this method on a system with greater than 64 hardware threads only if you want to limit the Concurrency Runtime to a subset of the current processor group. In general, you should use the version of the method that accepts an array of group affinities as a parameter, to restrict affinity on machines with greater than 64 hardware threads.  
  
 <CodeContentPlaceHolder>366\</CodeContentPlaceHolder>  
 The number of                                 <CodeContentPlaceHolder>367\</CodeContentPlaceHolder> entries in the array specified by the parameter                                 <CodeContentPlaceHolder>368\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>369\</CodeContentPlaceHolder>  
 An array of                                 <CodeContentPlaceHolder>370\</CodeContentPlaceHolder> entries.  
  
### Remarks  
 The method will throw an                         [invalid_operation](../vs140/invalid_operation-class.md) exception if a Resource Manager is present at the time it is invoked, and an                         [invalid_argument](../vs140/invalid_argument-class.md) exception if the affinity specified results in an empty set of resources.  
  
 The version of the method that takes an array of group affinities as a parameter should only be used on operating systems with version Windows 7 or higher. Otherwise, an                         [invalid_operation](../vs140/invalid_operation-class.md) exception is thrown.  
  
 Programatically modifying the process affinity after this method has been invoked will not cause the Resource Manager to re-evaluate the affinity it is restricted to. Therefore, all changes to process affinity should be made before calling this method.  
  
##  \<a name="swap_function">\</a>  swap Function  
 Exchanges the elements of two                 <CodeContentPlaceHolder>371\</CodeContentPlaceHolder> objects.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>372\</CodeContentPlaceHolder>  
 The data type of the elements stored in the concurrent vectors.  
  
 <CodeContentPlaceHolder>373\</CodeContentPlaceHolder>  
 The allocator type of the concurrent vectors.  
  
 <CodeContentPlaceHolder>374\</CodeContentPlaceHolder>  
 The concurrent vector whose elements are to be exchanged with those of the concurrent vector                                 <CodeContentPlaceHolder>375\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>376\</CodeContentPlaceHolder>  
 The concurrent vector providing the elements to be swapped, or the vector whose elements are to be exchanged with those of the concurrent vector                                 <CodeContentPlaceHolder>377\</CodeContentPlaceHolder>.  
  
### Remarks  
 The template function is an algorithm specialized on the container class                         <CodeContentPlaceHolder>378\</CodeContentPlaceHolder> to execute the member function                         <CodeContentPlaceHolder>379\</CodeContentPlaceHolder>. [concurrent_vector::swap](../vs140/concurrent_vector-class.md#concurrent_vector__swap_method)(                        <CodeContentPlaceHolder>380\</CodeContentPlaceHolder>). These are instances of the partial ordering of function templates by the compiler. When template functions are overloaded in such a way that the match of the template with the function call is not unique, then the compiler will select the most specialized version of the template function. The general version of the template function,                         <CodeContentPlaceHolder>381\</CodeContentPlaceHolder>, in the algorithm class works by assignment and is a slow operation. The specialized version in each container is much faster as it can work with the internal representation of the container class.  
  
 This method is not concurrency-safe. You must ensure that no other threads are performing operations on either of the concurrent vectors when you call this method.  
  
##  \<a name="task_from_exception_function__concurrency_runtime_">\</a>  task_from_exception Function (Concurrency Runtime)  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>382\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>383\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>384\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>385\</CodeContentPlaceHolder>  
  
### Return Value  
  
##  \<a name="task_from_result_function__concurrency_runtime_">\</a>  task_from_result Function (Concurrency Runtime)  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>386\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>387\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>388\</CodeContentPlaceHolder>  
  
### Return Value  
  
##  \<a name="trace_agents_register_name_function">\</a>  Trace_agents_register_name Function  
 Associates the given name to the message block or agent in the ETW trace.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>389\</CodeContentPlaceHolder>  
 The type of the object. This is typically a message block or an agent.  
  
 <CodeContentPlaceHolder>390\</CodeContentPlaceHolder>  
 A pointer to the message block or agent that is being named in the trace.  
  
 <CodeContentPlaceHolder>391\</CodeContentPlaceHolder>  
 The name for the given object.  
  
##  \<a name="try_receive_function">\</a>  try_receive Function  
 A general try-receive implementation, allowing a context to look for data from exactly one source and filter the values that are accepted. If the data is not ready, the method will return false.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>392\</CodeContentPlaceHolder>  
 The payload type  
  
 <CodeContentPlaceHolder>393\</CodeContentPlaceHolder>  
 A pointer or reference to the source from which data is expected.  
  
 <CodeContentPlaceHolder>394\</CodeContentPlaceHolder>  
 A reference to a location where the result will be placed.  
  
 <CodeContentPlaceHolder>395\</CodeContentPlaceHolder>  
 A filter function which determines whether messages should be accepted.  
  
### Return Value  
 A                         <CodeContentPlaceHolder>396\</CodeContentPlaceHolder> value indicating whether or not a payload was placed in                         <CodeContentPlaceHolder>397\</CodeContentPlaceHolder>.  
  
### Remarks  
 For more information, see                         [Message Passing Functions](../vs140/message-passing-functions.md).  
  
##  \<a name="wait_function">\</a>  wait Function  
 Pauses the current context for a specified amount of time.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>398\</CodeContentPlaceHolder>  
 The number of milliseconds the current context should be paused for. If the                                 <CodeContentPlaceHolder>399\</CodeContentPlaceHolder> parameter is set to the value                                 <CodeContentPlaceHolder>400\</CodeContentPlaceHolder>, the current context should yield execution to other runnable contexts before continuing.  
  
### Remarks  
 If this method is called on a Concurrency Runtime scheduler context, the scheduler will find a different context to run on the underlying resource. Because the scheduler is cooperative in nature, this context cannot resume exactly after the number of milliseconds specified. If the scheduler is busy executing other tasks that do not cooperatively yield to the scheduler, the wait period could be indefinite.  
  
##  \<a name="when_all_function">\</a>  when_all Function  
 Creates a task that will complete successfully when all of the tasks supplied as arguments complete successfully.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>401\</CodeContentPlaceHolder>  
 The type of the input iterator.  
  
 <CodeContentPlaceHolder>402\</CodeContentPlaceHolder>  
 The position of the first element in the range of elements to be combined into the resulting task.  
  
 <CodeContentPlaceHolder>403\</CodeContentPlaceHolder>  
 The position of the first element beyond the range of elements to be combined into the resulting task.  
  
 <CodeContentPlaceHolder>404\</CodeContentPlaceHolder>  
  
### Return Value  
 A task that completes sucessfully when all of the input tasks have completed successfully. If the input tasks are of type                         <CodeContentPlaceHolder>405\</CodeContentPlaceHolder>, the output of this function will be a                         <CodeContentPlaceHolder>406\</CodeContentPlaceHolder>. If the input tasks are of type                         <CodeContentPlaceHolder>407\</CodeContentPlaceHolder> the output task will also be a                         <CodeContentPlaceHolder>408\</CodeContentPlaceHolder>.  
  
### Remarks  
 <CodeContentPlaceHolder>409\</CodeContentPlaceHolder> is a non-blocking function that produces a                         <CodeContentPlaceHolder>410\</CodeContentPlaceHolder> as its result. Unlike                         [task::wait](../vs140/task-class--concurrency-runtime-.md#task__wait_method), it is safe to call this function in a                         [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app on the ASTA (Application STA) thread.  
  
 If one of the tasks is canceled or throws an exception, the returned task will complete early, in the canceled state, and the exception, if one is encoutered, will be thrown if you call                         [task::get](../vs140/task-class--concurrency-runtime-.md#task__get_method) or                         <CodeContentPlaceHolder>411\</CodeContentPlaceHolder> on that task.  
  
 For more information, see                         [Task Parallelism (Concurrency Runtime)](../vs140/task-parallelism--concurrency-runtime-.md).  
  
##  \<a name="when_any_function">\</a>  when_any Function  
 Creates a task that will complete successfully when any of the tasks supplied as arguments completes successfully.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>412\</CodeContentPlaceHolder>  
 The type of the input iterator.  
  
 <CodeContentPlaceHolder>413\</CodeContentPlaceHolder>  
 The position of the first element in the range of elements to be combined into the resulting task.  
  
 <CodeContentPlaceHolder>414\</CodeContentPlaceHolder>  
 The position of the first element beyond the range of elements to be combined into the resulting task.  
  
 <CodeContentPlaceHolder>415\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>416\</CodeContentPlaceHolder>  
 The cancellation token which controls cancellation of the returned task. If you do not provide a cancellation token, the resulting task will receive the cancellation token of the task that causes it to complete.  
  
### Return Value  
 A task that completes successfully when any one of the input tasks has completed successfully. If the input tasks are of type                         <CodeContentPlaceHolder>417\</CodeContentPlaceHolder>, the output of this function will be a                         <CodeContentPlaceHolder>418\</CodeContentPlaceHolder>, where the first element of the pair is the result of the completing task, and the second element is the index of the task that finished. If the input tasks are of type                         <CodeContentPlaceHolder>419\</CodeContentPlaceHolder> the output is a                         <CodeContentPlaceHolder>420\</CodeContentPlaceHolder>, where the result is the index of the completing task.  
  
### Remarks  
 <CodeContentPlaceHolder>421\</CodeContentPlaceHolder> is a non-blocking function that produces a                         <CodeContentPlaceHolder>422\</CodeContentPlaceHolder> as its result. Unlike                         [task::wait](../vs140/task-class--concurrency-runtime-.md#task__wait_method), it is safe to call this function in a                         [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app on the ASTA (Application STA) thread.  
  
 For more information, see                         [Task Parallelism (Concurrency Runtime)](../vs140/task-parallelism--concurrency-runtime-.md).  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)