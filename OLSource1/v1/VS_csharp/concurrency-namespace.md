---
title: "concurrency Namespace"
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
  - "concurrent_priority_queue/concurrency"
  - "agents/concurrency"
  - "concurrent_vector/concurrency"
  - "concrt/concurrency"
  - "internal_split_ordered_list/concurrency"
  - "concurrent_queue/concurrency"
  - "pplcancellation_token/concurrency"
  - "pplinterface/concurrency"
  - "ppltasks/concurrency"
  - "ppl/concurrency"
  - "concurrent_unordered_map/concurrency"
  - "concrtrm/concurrency"
  - "concurrent_unordered_set/concurrency"
  - "pplconcrt/concurrency"
  - "internal_concurrent_hash/concurrency"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Concurrency namespace"
ms.assetid: f1d33ca2-679b-4442-b140-22a9d9df61d1
caps.latest.revision: 36
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrency Namespace
The `Concurrency` namespace provides classes and functions that give you access to the Concurrency Runtime, a concurrent programming framework for C++. For more information, see [Concurrency Runtime](../VS_csharp/concurrency-runtime.md).  
  
## Syntax  
  
```  
namespace concurrency;  
```  
  
## Members  
  
### Namespaces  
  
|Name|Description|  
|----------|-----------------|  
|[concurrency::extensibility Namespace](assetId:///16a86ff2-128e-4edf-89e4-38aac79c81f9)||  
  
### Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|`runtime_object_identity`|Each message instance has an identity that follows it as it is cloned and passed between messaging components. This cannot be the address of the message object.|  
|`task_status`|A type that represents the terminal state of a task. Valid values are `completed` and `canceled`.|  
|`TaskProc`|An elementary abstraction for a task, defined as `void (__cdecl * TaskProc)(void *)`. A `TaskProc` is called to invoke the body of a task.|  
|`TaskProc_t`|An elementary abstraction for a task, defined as `void (__cdecl * TaskProc_t)(void *)`. A `TaskProc` is called to invoke the body of a task.|  
  
### Classes  
  
|Name|Description|  
|----------|-----------------|  
|[affinity_partitioner Class](../VS_csharp/affinity_partitioner-class.md)|The `affinity_partitioner` class is similar to the `static_partitioner` class, but it improves cache affinity by its choice of mapping subranges to worker threads. It can improve performance significantly when a loop is re-executed over the same data set, and the data fits in cache. Note that the same `affinity_partitioner` object must be used with subsequent iterations of a parallel loop that is executed over a particular data set, to benefit from data locality.|  
|[agent Class](../VS_csharp/agent-class.md)|A class intended to be used as a base class for all independent agents. It is used to hide state from other agents and interact using message-passing.|  
|[auto_partitioner Class](../VS_csharp/auto_partitioner-class.md)|The `auto_partitioner` class represents the default method `parallel_for`, `parallel_for_each` and `parallel_transform` use to partition the range they iterates over. This method of partitioning employes range stealing for load balancing as well as per-iterate cancellation.|  
|[bad_target Class](../VS_csharp/bad_target-class.md)|This class describes an exception thrown when a messaging block is given a pointer to a target which is invalid for the operation being performed.|  
|[call Class](../VS_csharp/call-class.md)|A `call` messaging block is a multi-source, ordered `target_block` that invokes a specified function when receiving a message.|  
|[cancellation_token Class](../VS_csharp/cancellation_token-class.md)|The `cancellation_token` class represents the ability to determine whether some operation has been requested to cancel. A given token can be associated with a `task_group`, `structured_task_group`, or `task` to provide implicit cancellation. It can also be polled for cancellation or have a callback registered for if and when the associated `cancellation_token_source` is canceled.|  
|[cancellation_token_registration Class](../VS_csharp/cancellation_token_registration-class.md)|The `cancellation_token_registration` class represents a callback notification from a `cancellation_token`. When the `register` method on a `cancellation_token` is used to receive notification of when cancellation occurs, a `cancellation_token_registration` object is returned as a handle to the callback so that the caller can request a specific callback no longer be made through use of the `deregister` method.|  
|[cancellation_token_source Class](../VS_csharp/cancellation_token_source-class.md)|The `cancellation_token_source` class represents the ability to cancel some cancelable operation.|  
|[choice Class](../VS_csharp/choice-class.md)|A `choice` messaging block is a multi-source, single-target block that represents a control-flow interaction with a set of sources. The choice block will wait for any one of multiple sources to produce a message and will propagate the index of the source that produced the message.|  
|[combinable Class](../VS_csharp/combinable-class.md)|The `combinable<T>` object is intended to provide thread-private copies of data, to perform lock-free thread-local sub-computations during parallel algorithms. At the end of the parallel operation, the thread-private sub-computations can then be merged into a final result. This class can be used instead of a shared variable, and can result in a performance improvement if there would otherwise be a lot of contention on that shared variable.|  
|[concurrent_priority_queue Class](../VS_csharp/concurrent_priority_queue-class.md)|The `concurrent_priority_queue` class is a container that allows multiple threads to concurrently push and pop items. Items are popped in priority order where priority is determined by a functor supplied as a template argument.|  
|[concurrent_queue Class](../VS_csharp/concurrent_queue-class.md)|The `concurrent_queue` class is a sequence container class that allows first-in, first-out access to its elements. It enables a limited set of concurrency-safe operations, such as `push` and `try_pop`.|  
|[concurrent_unordered_map Class](../VS_csharp/concurrent_unordered_map-class.md)|The `concurrent_unordered_map` class is a concurrency-safe container that controls a varying-length sequence of elements of type `std::pair<const _Key_type, _Element_type>`. The sequence is represented in a way that enables concurrency-safe append, element access, iterator access, and iterator traversal operations.|  
|[concurrent_unordered_multimap Class](../VS_csharp/concurrent_unordered_multimap-class.md)|The `concurrent_unordered_multimap` class is an concurrency-safe container that controls a varying-length sequence of elements of type `std::pair<const _Key_type, _Element_type>`. The sequence is represented in a way that enables concurrency-safe append, element access, iterator access and iterator traversal operations.|  
|[concurrent_unordered_multiset Class](../VS_csharp/concurrent_unordered_multiset-class.md)|The `concurrent_unordered_multiset` class is an concurrency-safe container that controls a varying-length sequence of elements of type _Key_type. The sequence is represented in a way that enables concurrency-safe append, element access, iterator access and iterator traversal operations.|  
|[concurrent_unordered_set Class](../VS_csharp/concurrent_unordered_set-class.md)|The `concurrent_unordered_set` class is an concurrency-safe container that controls a varying-length sequence of elements of type _Key_type. The sequence is represented in a way that enables concurrency-safe append, element access, iterator access and iterator traversal operations.|  
|[concurrent_vector Class](../VS_csharp/concurrent_vector-class.md)|The `concurrent_vector` class is a sequence container class that allows random access to any element. It enables concurrency-safe append, element access, iterator access, and iterator traversal operations.|  
|[Context Class](../VS_csharp/context-class.md)|Represents an abstraction for an execution context.|  
|[context_self_unblock Class](../VS_csharp/context_self_unblock-class.md)|This class describes an exception thrown when the `Unblock` method of a `Context` object is called from the same context. This would indicate an attempt by a given context to unblock itself.|  
|[context_unblock_unbalanced Class](../VS_csharp/context_unblock_unbalanced-class.md)|This class describes an exception thrown when calls to the `Block` and `Unblock` methods of a `Context` object are not properly paired.|  
|[critical_section Class](../VS_csharp/critical_section-class.md)|A non-reentrant mutex which is explicitly aware of the Concurrency Runtime.|  
|[CurrentScheduler Class](../VS_csharp/currentscheduler-class.md)|Represents an abstraction for the current scheduler associated with the calling context.|  
|[default_scheduler_exists Class](../VS_csharp/default_scheduler_exists-class.md)|This class describes an exception thrown when the `Scheduler::SetDefaultSchedulerPolicy` method is called when a default scheduler already exists within the process.|  
|[event Class](../VS_csharp/event-class.md)|A manual reset event which is explicitly aware of the Concurrency Runtime.|  
|[improper_lock Class](../VS_csharp/improper_lock-class.md)|This class describes an exception thrown when a lock is acquired improperly.|  
|[improper_scheduler_attach Class](../VS_csharp/improper_scheduler_attach-class.md)|This class describes an exception thrown when the `Attach` method is called on a `Scheduler` object which is already attached to the current context.|  
|[improper_scheduler_detach Class](../VS_csharp/improper_scheduler_detach-class.md)|This class describes an exception thrown when the `CurrentScheduler::Detach` method is called on a context which has not been attached to any scheduler using the `Attach` method of a `Scheduler` object.|  
|[improper_scheduler_reference Class](../VS_csharp/improper_scheduler_reference-class.md)|This class describes an exception thrown when the `Reference` method is called on a `Scheduler` object that is shutting down, from a context that is not part of that scheduler.|  
|[invalid_link_target Class](../VS_csharp/invalid_link_target-class.md)|This class describes an exception thrown when the `link_target` method of a messaging block is called and the messaging block is unable to link to the target. This can be the result of exceeding the number of links the messaging block is allowed or attempting to link a specific target twice to the same source.|  
|[invalid_multiple_scheduling Class](../VS_csharp/invalid_multiple_scheduling-class.md)|This class describes an exception thrown when a `task_handle` object is scheduled multiple times using the `run` method of a `task_group` or `structured_task_group` object without an intervening call to either the `wait` or `run_and_wait` methods.|  
|[invalid_operation Class](../VS_csharp/invalid_operation-class.md)|This class describes an exception thrown when an invalid operation is performed that is not more accurately described by another exception type thrown by the Concurrency Runtime.|  
|[invalid_oversubscribe_operation Class](../VS_csharp/invalid_oversubscribe_operation-class.md)|This class describes an exception thrown when the `Context::Oversubscribe` method is called with the `_BeginOversubscription` parameter set to `false` without a prior call to the `Context::Oversubscribe` method with the `_BeginOversubscription` parameter set to `true`.|  
|[invalid_scheduler_policy_key Class](../VS_csharp/invalid_scheduler_policy_key-class.md)|This class describes an exception thrown when an invalid or unknown key is passed to a `SchedulerPolicy` object constructor, or the `SetPolicyValue` method of a `SchedulerPolicy` object is passed a key that must be changed using other means such as the `SetConcurrencyLimits` method.|  
|[invalid_scheduler_policy_thread_specification Class](../VS_csharp/invalid_scheduler_policy_thread_specification-class.md)|This class describes an exception thrown when an attempt is made to set the concurrency limits of a `SchedulerPolicy` object such that the value of the `MinConcurrency` key is less than the value of the `MaxConcurrency` key.|  
|[invalid_scheduler_policy_value Class](../VS_csharp/invalid_scheduler_policy_value-class.md)|This class describes an exception thrown when a policy key of a `SchedulerPolicy` object is set to an invalid value for that key.|  
|[ISource Class](../VS_csharp/isource-class.md)|The `ISource` class is the interface for all source blocks. Source blocks propagate messages to `ITarget` blocks.|  
|[ITarget Class](../VS_csharp/itarget-class.md)|The `ITarget` class is the interface for all target blocks. Target blocks consume messages offered to them by `ISource` blocks.|  
|[join Class](../VS_csharp/join-class.md)|A `join` messaging block is a single-target, multi-source, ordered `propagator_block` which combines together messages of type `_Type` from each of its sources.|  
|[location Class](../VS_csharp/location-class.md)|An abstraction of a physical location on hardware.|  
|[message Class](../VS_csharp/message-class.md)|The basic message envelope containing the data payload being passed between messaging blocks.|  
|[message_not_found Class](../VS_csharp/message_not_found-class.md)|This class describes an exception thrown when a messaging block is unable to find a requested message.|  
|[message_processor Class](../VS_csharp/message_processor-class.md)|The `message_processor` class is the abstract base class for processing of `message` objects. There is no guarantee on the ordering of the messages.|  
|[missing_wait Class](../VS_csharp/missing_wait-class.md)|This class describes an exception thrown when there are tasks still scheduled to a `task_group` or `structured_task_group` object at the time that object's destructor executes. This exception will never be thrown if the destructor is reached because of a stack unwinding as the result of an exception.|  
|[multi_link_registry Class](../VS_csharp/multi_link_registry-class.md)|The `multi_link_registry` object is a `network_link_registry` that manages multiple source blocks or multiple target blocks.|  
|[multitype_join Class](../VS_csharp/multitype_join-class.md)|A `multitype_join` messaging block is a multi-source, single-target messaging block that combines together messages of different types from each of its sources and offers a tuple of the combined messages to its targets.|  
|[nested_scheduler_missing_detach Class](../VS_csharp/nested_scheduler_missing_detach-class.md)|This class describes an exception thrown when the Concurrency Runtime detects that you neglected to call the `CurrentScheduler::Detach` method on a context that attached to a second scheduler using the `Attach` method of the `Scheduler` object.|  
|[network_link_registry Class](../VS_csharp/network_link_registry-class.md)|The `network_link_registry` abstract base class manages the links between source and target blocks.|  
|[operation_timed_out Class](../VS_csharp/operation_timed_out-class.md)|This class describes an exception thrown when an operation has timed out.|  
|[ordered_message_processor Class](../VS_csharp/ordered_message_processor-class.md)|An `ordered_message_processor` is a `message_processor` that allows message blocks to process messages in the order they were received.|  
|[overwrite_buffer Class](../VS_csharp/overwrite_buffer-class.md)|An `overwrite_buffer` messaging block is a multi-target, multi-source, ordered `propagator_block` capable of storing a single message at a time. New messages overwrite previously held ones.|  
|[progress_reporter Class](../VS_csharp/progress_reporter-class.md)|The progress reporter class allows reporting progress notifications of a specific type. Each progress_reporter object is bound to a particular asynchronous action or operation.|  
|[propagator_block Class](../VS_csharp/propagator_block-class.md)|The `propagator_block` class is an abstract base class for message blocks that are both a source and target. It combines the functionality of both the `source_block` and `target_block` classes.|  
|[reader_writer_lock Class](../VS_csharp/reader_writer_lock-class.md)|A writer-preference queue-based reader-writer lock with local only spinning. The lock grants first in - first out (FIFO) access to writers and starves readers under a continuous load of writers.|  
|[ScheduleGroup Class](../VS_csharp/schedulegroup-class.md)|Represents an abstraction for a schedule group. Schedule groups organize a set of related work that benefits from being scheduled close together either temporally, by executing another task in the same group before moving to another group, or spatially, by executing multiple items within the same group on the same NUMA node or physical socket.|  
|[Scheduler Class](../VS_csharp/scheduler-class.md)|Represents an abstraction for a Concurrency Runtime scheduler.|  
|[scheduler_not_attached Class](../VS_csharp/scheduler_not_attached-class.md)|This class describes an exception thrown when an operation is performed which requires a scheduler to be attached to the current context and one is not.|  
|[scheduler_resource_allocation_error Class](../VS_csharp/scheduler_resource_allocation_error-class.md)|This class describes an exception thrown because of a failure to acquire a critical resource in the Concurrency Runtime.|  
|[scheduler_worker_creation_error Class](../VS_csharp/scheduler_worker_creation_error-class.md)|This class describes an exception thrown because of a failure to create a worker execution context in the Concurrency Runtime.|  
|[SchedulerPolicy Class](../VS_csharp/schedulerpolicy-class.md)|The `SchedulerPolicy` class contains a set of key/value pairs, one for each policy element, that control the behavior of a scheduler instance.|  
|[simple_partitioner Class](../VS_csharp/simple_partitioner-class.md)|The `simple_partitioner` class represents a static partitioning of the range iterated over by `parallel_for`. The partitioner divides the range into chunks such that each chunk has at least the number of iterations specified by the chunk size.|  
|[single_assignment Class](../VS_csharp/single_assignment-class.md)|A `single_assignment` messaging block is a multi-target, multi-source, ordered `propagator_block` capable of storing a single, write-once `message`.|  
|[single_link_registry Class](../VS_csharp/single_link_registry-class.md)|The `single_link_registry` object is a `network_link_registry` that manages only a single source or target block.|  
|[source_block Class](../VS_csharp/source_block-class.md)|The `source_block` class is an abstract base class for source-only blocks. The class provides basic link management functionality as well as common error checks.|  
|[source_link_manager Class](../VS_csharp/source_link_manager-class.md)|The `source_link_manager` object manages messaging block network links to `ISource` blocks.|  
|[static_partitioner Class](../VS_csharp/static_partitioner-class.md)|The `static_partitioner` class represents a static partitioning of the range iterated over by `parallel_for`. The partitioner divides the range into as many chunks as there are workers available to the underyling scheduler.|  
|[structured_task_group Class](../VS_csharp/structured_task_group-class.md)|The `structured_task_group` class represents a highly structured collection of parallel work. You can queue individual parallel tasks to a `structured_task_group` using `task_handle` objects, and wait for them to complete, or cancel the task group before they have finished executing, which will abort any tasks that have not begun execution.|  
|[target_block Class](../VS_csharp/target_block-class.md)|The `target_block` class is an abstract base class that provides basic link management functionality and error checking for target only blocks.|  
|[task Class (Concurrency Runtime)](../VS_csharp/task-class--concurrency-runtime-.md)|The Parallel Patterns Library (PPL) `task` class. A `task` object represents work that can be executed asynchronously, and concurrently with other tasks and parallel work produced by parallel algorithms in the Concurrency Runtime. It produces a result of type `_ResultType` on successful completion. Tasks of type `task<void>` produce no result. A task can be waited upon and canceled independently of other tasks. It can also be composed with other tasks using continuations(`then`), and join(`when_all`) and choice(`when_any`) patterns.|  
|[task_canceled Class](../VS_csharp/task_canceled-class.md)|This class describes an exception thrown by the PPL tasks layer in order to force the current task to cancel. It is also thrown by the `get()` method on [task](assetId:///5389e8a5-5038-40b6-844a-55e9b58ad35f), for a canceled task.|  
|[task_completion_event Class](../VS_csharp/task_completion_event-class.md)|The `task_completion_event` class allows you to delay the execution of a task until a condition is satisfied, or start a task in response to an external event.|  
|[task_continuation_context Class](../VS_csharp/task_continuation_context-class.md)|The `task_continuation_context` class allows you to specify where you would like a continuation to be executed. It is only useful to use this class from a Windows Store app. For non-Windows Store apps, the task continuation's execution context is determined by the runtime, and not configurable.|  
|[task_group Class](../VS_csharp/task_group-class.md)|The `task_group` class represents a collection of parallel work which can be waited on or canceled.|  
|[task_handle Class](../VS_csharp/task_handle-class.md)|The `task_handle` class represents an individual parallel work item. It encapsulates the instructions and the data required to execute a piece of work.|  
|[task_options Class (Concurrency Runtime)](../VS_csharp/task_options-class--concurrency-runtime-.md)|Represents the allowed options for creating a task|  
|[timer Class](../VS_csharp/timer-class.md)|A `timer` messaging block is a single-target `source_block` capable of sending a message to its target after a specified time period has elapsed or at specific intervals.|  
|[transformer Class](../VS_csharp/transformer-class.md)|A `transformer` messaging block is a single-target, multi-source, ordered `propagator_block` which can accept messages of one type and is capable of storing an unbounded number of messages of a different type.|  
|[unbounded_buffer Class](../VS_csharp/unbounded_buffer-class.md)|An `unbounded_buffer` messaging block is a multi-target, multi-source, ordered `propagator_block` capable of storing an unbounded number of messages.|  
|[unsupported_os Class](../VS_csharp/unsupported_os-class.md)|This class describes an exception thrown when an unsupported operating system is used.|  
  
### Structures  
  
|Name|Description|  
|----------|-----------------|  
|[DispatchState Structure](../VS_csharp/dispatchstate-structure.md)|The `DispatchState` structure is used to transfer state to the `IExecutionContext::Dispatch` method. It describes the circumstances under which the `Dispatch` method is invoked on an `IExecutionContext` interface.|  
|[IExecutionContext Structure](../VS_csharp/iexecutioncontext-structure.md)|An interface to an execution context which can run on a given virtual processor and be cooperatively context switched.|  
|[IExecutionResource Structure](../VS_csharp/iexecutionresource-structure.md)|An abstraction for a hardware thread.|  
|[IResourceManager Structure](../VS_csharp/iresourcemanager-structure.md)|An interface to the Concurrency Runtime's Resource Manager. This is the interface by which schedulers communicate with the Resource Manager.|  
|[IScheduler Structure](../VS_csharp/ischeduler-structure.md)|An interface to an abstraction of a work scheduler. The Concurrency Runtime's Resource Manager uses this interface to communicate with work schedulers.|  
|[ISchedulerProxy Structure](../VS_csharp/ischedulerproxy-structure.md)|The interface by which schedulers communicate with the Concurrency Runtime's Resource Manager to negotiate resource allocation.|  
|[IThreadProxy Structure](../VS_csharp/ithreadproxy-structure.md)|An abstraction for a thread of execution. Depending on the `SchedulerType` policy key of the scheduler you create, the Resource Manager will grant you a thread proxy that is backed by either a regular Win32 thread or a user-mode schedulable (UMS) thread. UMS threads are supported on 64-bit operating systems with version Windows 7 and higher.|  
|[ITopologyExecutionResource Structure](../VS_csharp/itopologyexecutionresource-structure.md)|An interface to an execution resource as defined by the Resource Manager.|  
|[ITopologyNode Structure](../VS_csharp/itopologynode-structure.md)|An interface to a topology node as defined by the Resource Manager. A node contains one or more execution resources.|  
|[IUMSCompletionList Structure](../VS_csharp/iumscompletionlist-structure.md)|Represents a UMS completion list. When a UMS thread blocks, the scheduler's designated scheduling context is dispatched in order to make a decision of what to schedule on the underlying virtual processor root while the original thread is blocked. When the original thread unblocks, the operating system queues it to the completion list which is accessible through this interface. The scheduler can query the completion list on the designated scheduling context or any other place it searches for work.|  
|[IUMSScheduler Structure](../VS_csharp/iumsscheduler-structure.md)|An interface to an abstraction of a work scheduler that wants the Concurrency Runtime's Resource Manager to hand it user-mode schedulable (UMS) threads. The Resource Manager uses this interface to communicate with UMS thread schedulers. The `IUMSScheduler` interface inherits from the `IScheduler` interface.|  
|[IUMSThreadProxy Structure](../VS_csharp/iumsthreadproxy-structure.md)|An abstraction for a thread of execution. If you want your scheduler to be granted user-mode schedulable (UMS) threads, set the value for the scheduler policy element `SchedulerKind` to `UmsThreadDefault`, and implement the `IUMSScheduler` interface. UMS threads are only supported on 64-bit operating systems with version Windows 7 and higher.|  
|[IUMSUnblockNotification Structure](../VS_csharp/iumsunblocknotification-structure.md)|Represents a notification from the Resource Manager that a thread proxy which blocked and triggered a return to the scheduler's designated scheduling context has unblocked and is ready to be scheduled. This interface is invalid once the thread proxy's associated execution context, returned from the `GetContext` method, is rescheduled.|  
|[IVirtualProcessorRoot Structure](../VS_csharp/ivirtualprocessorroot-structure.md)|An abstraction for a hardware thread on which a thread proxy can execute.|  
|[scheduler_interface Structure](../VS_csharp/scheduler_interface-structure.md)|Scheduler Interface|  
|[scheduler_ptr Structure (Concurrency Runtime)](../VS_csharp/scheduler_ptr-structure--concurrency-runtime-.md)|Represents a pointer to a scheduler. This class exists to allow the the specification of a shared lifetime by using shared_ptr or just a plain reference by using raw pointer.|  
  
### Enumerations  
  
|Name|Description|  
|----------|-----------------|  
|[agent_status Enumeration](../VS_csharp/agent_status-enumeration.md)|The valid states for an `agent`.|  
|[Agents_EventType Enumeration](../VS_csharp/agents_eventtype-enumeration.md)|The types of events that can be traced using the tracing functionality offered by the Agents Library|  
|[ConcRT_EventType Enumeration](../VS_csharp/concrt_eventtype-enumeration.md)|The types of events that can be traced using the tracing functionality offered by the Concurrency Runtime.|  
|[Concrt_TraceFlags Enumeration](../VS_csharp/concrt_traceflags-enumeration.md)|Trace flags for the event types|  
|[CriticalRegionType Enumeration](../VS_csharp/criticalregiontype-enumeration.md)|The type of critical region a context is inside.|  
|[DynamicProgressFeedbackType Enumeration](../VS_csharp/dynamicprogressfeedbacktype-enumeration.md)|Used by the `DynamicProgressFeedback` policy to describe whether resources for the scheduler will be rebalanced according to statistical information gathered from the scheduler or only based on virtual processors going in and out of the idle state through calls to the `Activate` and `Deactivate` methods on the `IVirtualProcessorRoot` interface. For more information on available scheduler policies, see [PolicyElementKey Enumeration](../VS_csharp/policyelementkey-enumeration.md).|  
|[join_type Enumeration](../VS_csharp/join_type-enumeration.md)|The type of a `join` messaging block.|  
|[message_status Enumeration](../VS_csharp/message_status-enumeration.md)|The valid responses for an offer of a `message` object to a block.|  
|[PolicyElementKey Enumeration](../VS_csharp/policyelementkey-enumeration.md)|Policy keys describing aspects of scheduler behavior. Each policy element is described by a key-value pair. For more information about scheduler policies and their impact on schedulers, see [Task Scheduler (Concurrency Runtime)](../VS_csharp/task-scheduler--concurrency-runtime-.md).|  
|[SchedulerType Enumeration](../VS_csharp/schedulertype-enumeration.md)|Used by the `SchedulerKind` policy to describe the type of threads that the scheduler should utilize for underlying execution contexts. For more information on available scheduler policies, see [PolicyElementKey Enumeration](../VS_csharp/policyelementkey-enumeration.md).|  
|[SchedulingProtocolType Enumeration](../VS_csharp/schedulingprotocoltype-enumeration.md)|Used by the `SchedulingProtocol` policy to describe which scheduling algorithm will be utilized for the scheduler. For more information on available scheduler policies, see [PolicyElementKey Enumeration](../VS_csharp/policyelementkey-enumeration.md).|  
|[SwitchingProxyState Enumeration](../VS_csharp/switchingproxystate-enumeration.md)|Used to denote the state a thread proxy is in, when it is executing a cooperative context switch to a different thread proxy.|  
|[task_group_status Enumeration](../VS_csharp/task_group_status-enumeration.md)|Describes the execution status of a `task_group` or `structured_task_group` object. A value of this type is returned by numerous methods that wait on tasks scheduled to a task group to complete.|  
|[WinRTInitializationType Enumeration](../VS_csharp/winrtinitializationtype-enumeration.md)|Used by the `WinRTInitialization` policy to describe whether and how the Windows Runtime will be initialized on scheduler threads for an application which runs on operating systems with version Windows 8 or higher. For more information on available scheduler policies, see [PolicyElementKey Enumeration](../VS_csharp/policyelementkey-enumeration.md).|  
  
### Functions  
  
|Name|Description|  
|----------|-----------------|  
|[Alloc Function](../VS_csharp/alloc-function.md)|Allocates a block of memory of the size specified from the Concurrency Runtime Caching Suballocator.|  
|[asend Function](../VS_csharp/asend-function.md)|Overloaded. An asynchronous send operation, which schedules a task to propagate the data to the target block.|  
|[cancel_current_task Function](../VS_csharp/cancel_current_task-function.md)|Cancels the currently executing task. This function can be called from within the body of a task to abort the task's execution and cause it to enter the `canceled` state.<br /><br /> It is not a supported scenario to call this function if you are not within the body of a `task`. Doing so will result in undefined behavior such as a crash or a hang in your application.|  
|[create_async Function](../VS_csharp/create_async-function.md)|Creates a Windows Runtime asynchronous construct based on a user supplied lambda or function object. The return type of `create_async` is one of either `IAsyncAction^`, `IAsyncActionWithProgress<TProgress>^`, `IAsyncOperation<TResult>^`, or `IAsyncOperationWithProgress<TResult, TProgress>^` based on the signature of the lambda passed to the method.|  
|[create_task Function](../VS_csharp/create_task-function.md)|Overloaded. Creates a PPL [task](assetId:///5389e8a5-5038-40b6-844a-55e9b58ad35f) object. `create_task` can be used anywhere you would have used a task constructor. It is provided mainly for convenience, because it allows use of the `auto` keyword while creating tasks.|  
|[CreateResourceManager Function](../VS_csharp/createresourcemanager-function.md)|Returns an interface that represents the singleton instance of the Concurrency Runtime's Resource Manager. The Resource Manager is responsible for assigning resources to schedulers that want to cooperate with each other.|  
|[DisableTracing Function](../VS_csharp/disabletracing-function.md)|Disables tracing in the Concurrency Runtime. This function is deprecated because ETW tracing is unregistered by default.|  
|[EnableTracing Function](../VS_csharp/enabletracing-function.md)|Enables tracing in the Concurrency Runtime. This function is deprecated because ETW tracing is now on by default.|  
|[Free Function](../VS_csharp/free-function.md)|Releases a block of memory previously allocated by the `Alloc` method to the Concurrency Runtime Caching Suballocator.|  
|[get_ambient_scheduler Function (Concurrency Runtime)](../VS_csharp/get_ambient_scheduler-function--concurrency-runtime-.md)||  
|[GetExecutionContextId Function](../VS_csharp/getexecutioncontextid-function.md)|Returns a unique identifier that can be assigned to an execution context that implements the `IExecutionContext` interface.|  
|[GetOSVersion Function](../VS_csharp/getosversion-function.md)|Returns the operating system version.|  
|[GetProcessorCount Function](../VS_csharp/getprocessorcount-function.md)|Returns the number of hardware threads on the underlying system.|  
|[GetProcessorNodeCount Function](../VS_csharp/getprocessornodecount-function.md)|Returns the number of NUMA nodes or processor packages on the underlying system.|  
|[GetSchedulerId Function](../VS_csharp/getschedulerid-function.md)|Returns a unique identifier that can be assigned to a scheduler that implements the `IScheduler` interface.|  
|[interruption_point Function](../VS_csharp/interruption_point-function.md)|Creates an interruption point for cancellation. If a cancellation is in progress in the context where this function is called, this will throw an internal exception that aborts the execution of the currently executing parallel work. If cancellation is not in progress, the function does nothing.|  
|[is_current_task_group_canceling Function](../VS_csharp/is_current_task_group_canceling-function.md)|Returns an indication of whether the task group which is currently executing inline on the current context is in the midst of an active cancellation (or will be shortly). Note that if there is no task group currently executing inline on the current context, `false` will be returned.|  
|[make_choice Function](../VS_csharp/make_choice-function.md)|Overloaded. Constructs a `choice` messaging block from an optional `Scheduler` or `ScheduleGroup` and two or more input sources.|  
|[make_greedy_join Function](../VS_csharp/make_greedy_join-function.md)|Overloaded. Constructs a `greedy multitype_join` messaging block from an optional `Scheduler` or `ScheduleGroup` and two or more input sources.|  
|[make_join Function](../VS_csharp/make_join-function.md)|Overloaded. Constructs a `non_greedy multitype_join` messaging block from an optional `Scheduler` or `ScheduleGroup` and two or more input sources.|  
|[make_task Function](../VS_csharp/make_task-function.md)|A factory method for creating a `task_handle` object.|  
|[parallel_buffered_sort Function](../VS_csharp/parallel_buffered_sort-function.md)|Overloaded. Arranges the elements in a specified range into a nondescending order, or according to an ordering criterion specified by a binary predicate, in parallel. This function is semantically similar to `std::sort` in that it is a compare-based, unstable, in-place sort except that it needs `O(n)` additional space, and requires default initialization for the elements being sorted.|  
|[parallel_for Function](../VS_csharp/parallel_for-function.md)|Overloaded. `parallel_for` iterates over a range of indices and executes a user-supplied function at each iteration, in parallel.|  
|[parallel_for_each Function](../VS_csharp/parallel_for_each-function.md)|Overloaded. `parallel_for_each` applies a specified function to each element within a range, in parallel. It is semantically equivalent to the `for_each` function in the `std` namespace, except that iteration over the elements is performed in parallel, and the order of iteration is unspecified. The argument `_Func` must support a function call operator of the form `operator()(T)` where the parameter `T` is the item type of the container being iterated over.|  
|[parallel_invoke Function](../VS_csharp/parallel_invoke-function.md)|Overloaded. Executes the function objects supplied as parameters in parallel, and blocks until they have finished executing. Each function object could be a lambda expression, a pointer to function, or any object that supports the function call operator with the signature `void operator()()`.|  
|[parallel_radixsort Function](../VS_csharp/parallel_radixsort-function.md)|Overloaded. Arranges elements in a specified range into an non descending order using a radix sorting algorithm. This is a stable sort function which requires a projection function that can project elements to be sorted into unsigned integer-like keys. Default initialization is required for the elements being sorted.|  
|[parallel_reduce Function](../VS_csharp/parallel_reduce-function.md)|Overloaded. Computes the sum of all elements in a specified range by computing successive partial sums, or computes the result of successive partial results similarly obtained from using a specified binary operation other than sum, in parallel. `parallel_reduce` is semantically similar to `std::accumulate`, except that it requires the binary operation to be associative, and requires an identity value instead of an initial value.|  
|[parallel_sort Function](../VS_csharp/parallel_sort-function.md)|Overloaded. Arranges the elements in a specified range into a nondescending order, or according to an ordering criterion specified by a binary predicate, in parallel. This function is semantically similar to `std::sort` in that it is a compare-based, unstable, in-place sort.|  
|[parallel_transform Function](../VS_csharp/parallel_transform-function.md)|Overloaded. Applies a specified function object to each element in a source range, or to a pair of elements from two source ranges, and copies the return values of the function object into a destination range, in parallel. This functional is semantically equivalent to `std::transform`.|  
|[receive Function](../VS_csharp/receive-function.md)|Overloaded. A general receive implementation, allowing a context to wait for data from exactly one source and filter the values that are accepted.|  
|[run_with_cancellation_token Function](../VS_csharp/run_with_cancellation_token-function.md)|Executes a function object immediately and synchronously in the context of a given cancellation token.|  
|[send Function](../VS_csharp/send-function.md)|Overloaded. A synchronous send operation, which waits until the target either accepts or declines the message.|  
|[set_ambient_scheduler Function (Concurrency Runtime)](../VS_csharp/set_ambient_scheduler-function--concurrency-runtime-.md)||  
|[set_task_execution_resources Function](../VS_csharp/set_task_execution_resources-function.md)|Overloaded. Restricts the execution resources used by the Concurrency Runtime internal worker threads to the affinity set specified.<br /><br /> It is valid to call this method only before the Resource Manager has been created, or between two Resource Manager lifetimes. It can be invoked multiple times as long as the Resource Manager does not exist at the time of invocation. After an affinity limit has been set, it remains in effect until the next valid call to the `set_task_execution_resources` method.<br /><br /> The affinity mask provided need not be a subset of the process affinity mask. The process affinity will be updated if necessary.|  
|[swap Function](../VS_csharp/swap-function.md)|Exchanges the elements of two `concurrent_vector` objects.|  
|[task_from_exception Function (Concurrency Runtime)](../VS_csharp/task_from_exception-function--concurrency-runtime-.md)||  
|[task_from_result Function (Concurrency Runtime)](../VS_csharp/task_from_result-function--concurrency-runtime-.md)||  
|[Trace_agents_register_name Function](../VS_csharp/trace_agents_register_name-function.md)|Associates the given name to the message block or agent in the ETW trace.|  
|[try_receive Function](../VS_csharp/try_receive-function.md)|Overloaded. A general try-receive implementation, allowing a context to look for data from exactly one source and filter the values that are accepted. If the data is not ready, the method will return false.|  
|[wait Function](../VS_csharp/wait-function.md)|Pauses the current context for a specified amount of time.|  
|[when_all Function](../VS_csharp/when_all-function.md)|Creates a task that will complete successfully when all of the tasks supplied as arguments complete successfully.|  
|[when_any Function](../VS_csharp/when_any-function.md)|Overloaded. Creates a task that will complete successfully when any of the tasks supplied as arguments completes successfully.|  
  
### Operators  
  
|Name|Description|  
|----------|-----------------|  
|[operator!= Operator](../VS_csharp/operator!=-operator.md)|Tests if the `concurrent_vector` object on the left side of the operator is not equal to the `concurrent_vector` object on the right side.|  
|[operator&& Operator](../VS_csharp/operator---operator.md)|Overloaded. Creates a task that will complete succesfully when both of the tasks supplied as arguments complete successfully.|  
|[operator&#124;&#124; Operator](../VS_csharp/operator---operator.md)|Overloaded. Creates a task that will complete successfully when either of the tasks supplied as arguments completes successfully.|  
|[operator< Operator](../VS_csharp/operator--operator.md)|Tests if the `concurrent_vector` object on the left side of the operator is less than the `concurrent_vector` object on the right side.|  
|[operator<= Operator](../VS_csharp/operator-=-operator.md)|Tests if the `concurrent_vector` object on the left side of the operator is less than or equal to the `concurrent_vector` object on the right side.|  
|[operator== Operator](../VS_csharp/operator==-operator.md)|Tests if the `concurrent_vector` object on the left side of the operator is equal to the `concurrent_vector` object on the right side.|  
|[operator> Operator](../VS_csharp/operator--operator.md)|Tests if the `concurrent_vector` object on the left side of the operator is greater than the `concurrent_vector` object on the right side.|  
|[operator>= Operator](../VS_csharp/operator-=-operator.md)|Tests if the `concurrent_vector` object on the left side of the operator is greater than or equal to the `concurrent_vector` object on the right side.|  
  
### Constants  
  
|Name|Description|  
|----------|-----------------|  
|[AgentEventGuid Constant](../VS_csharp/agenteventguid-constant.md)|A category GUID ({B9B5B78C-0713-4898-A21A-C67949DCED07}) describing ETW events fired by the Agents library in the Concurrency Runtime.|  
|[ChoreEventGuid Constant](../VS_csharp/choreeventguid-constant.md)|A category GUID describing ETW events fired by the Concurrency Runtime that are directly related to chores or tasks.|  
|[ConcRT_ProviderGuid Constant](../VS_csharp/concrt_providerguid-constant.md)|The ETW provider GUID for the Concurrency Runtime.|  
|[CONCRT_RM_VERSION_1 Constant](../VS_csharp/concrt_rm_version_1-constant.md)|Indicates support of the Resource Manager interface defined in Visual Studio 2010.|  
|[ConcRTEventGuid Constant](../VS_csharp/concrteventguid-constant.md)|A category GUID describing ETW events fired by the Concurrency Runtime that are not more specifically described by another category.|  
|[ContextEventGuid Constant](../VS_csharp/contexteventguid-constant.md)|A category GUID describing ETW events fired by the Concurrency Runtime that are directly related to contexts.|  
|[COOPERATIVE_TIMEOUT_INFINITE Constant](../VS_csharp/cooperative_timeout_infinite-constant.md)|Value indicating that a wait should never time out.|  
|[COOPERATIVE_WAIT_TIMEOUT Constant](../VS_csharp/cooperative_wait_timeout-constant.md)|Value indicating that a wait timed out.|  
|[INHERIT_THREAD_PRIORITY Constant](../VS_csharp/inherit_thread_priority-constant.md)|Special value for the policy key `ContextPriority` indicating that the thread priority of all contexts in the scheduler should be the same as that of the thread which created the scheduler.|  
|[LockEventGuid Constant](../VS_csharp/lockeventguid-constant.md)|A category GUID describing ETW events fired by the Concurrency Runtime that are directly related to locks.|  
|[MaxExecutionResources Constant](../VS_csharp/maxexecutionresources-constant.md)|Special value for the policy keys `MinConcurrency` and `MaxConcurrency`. Defaults to the number of hardware threads on the machine in the absence of other constraints.|  
|[PPLParallelForeachEventGuid Constant](../VS_csharp/pplparallelforeacheventguid-constant.md)|A category GUID describing ETW events fired by the Concurrency Runtime that are directly related to usage of the `parallel_for_each` function.|  
|[PPLParallelForEventGuid Constant](../VS_csharp/pplparallelforeventguid-constant.md)|A category GUID describing ETW events fired by the Concurrency Runtime that are directly related to usage of the `parallel_for` function.|  
|[PPLParallelInvokeEventGuid Constant](../VS_csharp/pplparallelinvokeeventguid-constant.md)|A category GUID describing ETW events fired by the Concurrency Runtime that are directly related to usage of the `parallel_invoke` function.|  
|[ResourceManagerEventGuid Constant](../VS_csharp/resourcemanagereventguid-constant.md)|A category GUID describing ETW events fired by the Concurrency Runtime that are directly related to the resource manager.|  
|[ScheduleGroupEventGuid Constant](../VS_csharp/schedulegroupeventguid-constant.md)|A category GUID describing ETW events fired by the Concurrency Runtime that are directly related to schedule groups.|  
|[SchedulerEventGuid Constant](../VS_csharp/schedulereventguid-constant.md)|A category GUID describing ETW events fired by the Concurrency Runtime that are directly related to scheduler activity.|  
|[VirtualProcessorEventGuid Constant](../VS_csharp/virtualprocessoreventguid-constant.md)|A category GUID describing ETW events fired by the Concurrency Runtime that are directly related to virtual processors.|  
  
## Requirements  
 **Header:** agents.h, concrt.h, concrtrm.h, concurrent_priority_queue.h, concurrent_queue.h, concurrent_unordered_map.h, concurrent_unordered_set.h, concurrent_vector.h, internal_concurrent_hash.h, internal_split_ordered_list.h, ppl.h, pplcancellation_token.h, pplconcrt.h, pplinterface.h, ppltasks.h  
  
## See Also  
 [Reference (Concurrency Runtime)](../VS_csharp/reference--concurrency-runtime-.md)