---
title: "PolicyElementKey Enumeration"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - concrt/concurrency::PolicyElementKey
dev_langs: 
  - C++
helpviewer_keywords: 
  - PolicyElementKey enumeration
ms.assetid: 6376ca26-54c8-4804-863f-c081e387fe36
caps.latest.revision: 21
translation.priority.ht: 
  - de-de
  - ja-jp
---
# PolicyElementKey Enumeration
Policy keys describing aspects of scheduler behavior. Each policy element is described by a key-value pair. For more information about scheduler policies and their impact on schedulers, see [Task Scheduler (Concurrency Runtime)](../vs140/task-scheduler--concurrency-runtime-.md).  
  
## Syntax  
  
```  
enum PolicyElementKey;  
```  
  
## Members  
  
### Values  
  
|Name|Description|  
|----------|-----------------|  
|`ContextPriority`|The operating system thread priority of each context in the scheduler. If this key is set to the value [INHERIT_THREAD_PRIORITY](../vs140/inherit_thread_priority-constant.md) the contexts in the scheduler will inherit the priority of the thread that created the scheduler.<br /><br /> Valid values : Any of the valid values for the Windows `SetThreadPriority` function and the special value `INHERIT_THREAD_PRIORITY`<br /><br /> Default value : `THREAD_PRIORITY_NORMAL`|  
|`ContextStackSize`|The reserved stack size of each context in the scheduler in kilobytes.<br /><br /> Valid values : Positive integers<br /><br /> Default value : `0`, indicating that the process' default value for stack size be used.|  
|`DynamicProgressFeedback`|Determines whether the resources for the scheduler will be rebalanced according to statistical information gathered from the scheduler or only based on the subscription level of underlying hardware threads. For more information, see [DynamicProgressFeedbackType Enumeration](../vs140/dynamicprogressfeedbacktype-enumeration.md).<br /><br /> Valid values : A member of the `DynamicProgressFeedbackType` enumeration, either `ProgressFeedbackEnabled` or `ProgressFeedbackDisabled`<br /><br /> Default value : `ProgressFeedbackEnabled`|  
|`LocalContextCacheSize`|When the `SchedulingProtocol` policy key is set to the value `EnhanceScheduleGroupLocality`, this specifies the maximum number of runnable contexts allowed to be cached in per virtual processor local queues. Such contexts will typically run in last-in-first-out (LIFO) order on the virtual processor that caused them to become runnable. Note that this policy key has no meaning when the `SchedulingProtocol` key is set to the value `EnhanceForwardProgress`.<br /><br /> Valid values : Non-negative integers<br /><br /> Default value : `8`|  
|`MaxConcurrency`|The maximum concurrency level desired by the scheduler. The resource manager will try to initially allocate this many virtual processors. The special value [MaxExecutionResources](../vs140/maxexecutionresources-constant.md) indicates that the desired concurrency level is same as the number of hardware threads on the machine. If the value specified for `MinConcurrency` is greater than the number of hardware threads on the machine and `MaxConcurrency` is specified as `MaxExecutionResources`, the value for `MaxConcurrency` is raised to match what is set for `MinConcurrency`.<br /><br /> Valid values : Positive integers and the special value `MaxExecutionResources`<br /><br /> Default value : `MaxExecutionResources`|  
|`MaxPolicyElementKey`|The maximum policy element key. Not a valid element key.|  
|`MinConcurrency`|The minimum concurrency level that must be provided to the scheduler by the resource manager. The number of virtual processors assigned to a scheduler will never go below the minimum. The special value [MaxExecutionResources](../vs140/maxexecutionresources-constant.md) indicates that the minimum concurrency level is same as the number of hardware threads on the machine. If the value specified for `MaxConcurrency` is less than the number of hardware threads on the machine and `MinConcurrency` is specified as `MaxExecutionResources`, the value for `MinConcurrency` is lowered to match what is set for `MaxConcurrency`.<br /><br /> Valid values : Non-negative integers and the special value `MaxExecutionResources`. Note that for scheduler policies used for the construction of Concurrency Runtime schedulers, the value `0` is invalid.<br /><br /> Default value : `1`|  
|`SchedulerKind`|The type of threads that the scheduler will utilize for underlying execution contexts. For more information, see [SchedulerType Enumeration](../vs140/schedulertype-enumeration.md).<br /><br /> Valid values : A member of the `SchedulerType` enumeration, for example, `ThreadScheduler`<br /><br /> Default value : `ThreadScheduler`. This translates to Win32 threads on all operating systems.|  
|`SchedulingProtocol`|Describes which scheduling algorithm will be used by the scheduler. For more information, see [SchedulingProtocolType Enumeration](../vs140/schedulingprotocoltype-enumeration.md).<br /><br /> Valid values : A member of the `SchedulingProtocolType` enumeration, either `EnhanceScheduleGroupLocality` or `EnhanceForwardProgress`<br /><br /> Default value : `EnhanceScheduleGroupLocality`|  
|`TargetOversubscriptionFactor`|Tentative number of virtual processors per hardware thread. The target oversubscription factor can be increased by the Resource Manager, if necessary, to satisfy `MaxConcurrency` with the hardware threads on the machine.<br /><br /> Valid values : Positive integers<br /><br /> Default value : `1`|  
|`WinRTInitialization`||  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [SchedulerPolicy Class](../vs140/schedulerpolicy-class.md)   
 [CurrentScheduler Class](../vs140/currentscheduler-class.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [Task Scheduler (Concurrency Runtime)](../vs140/task-scheduler--concurrency-runtime-.md)