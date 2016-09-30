---
title: "Scheduler Policies"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "scheduler policies"
ms.assetid: 58fb68bd-4a57-40a8-807b-6edb6f083cd9
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Scheduler Policies
This document describes the role of scheduler policies in the Concurrency Runtime. A *scheduler policy* controls the strategy that the scheduler uses when it manages tasks. For example, consider an application that requires some tasks to execute at <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and other tasks to execute at <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  You can create two scheduler instances: one that specifies the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> policy to be <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and another that specifies the same policy to be <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 By using scheduler policies, you can divide the available processing resources and assign a fixed set of resources to each scheduler. For example, consider a parallel algorithm that does not scale beyond four processors. You can create a scheduler policy that limits its tasks to use no more than four processors concurrently.  
  
> [!TIP]
>  The Concurrency Runtime provides a default scheduler. Therefore, you don't have to create one in your application. Because the Task Scheduler helps you fine-tune the performance of your applications, we recommend that you start with the [Parallel Patterns Library (PPL)](../vs140/parallel-patterns-library--ppl-.md) or the [Asynchronous Agents Library](../vs140/asynchronous-agents-library.md) if you are new to the Concurrency Runtime.  
  
 When you use the [concurrency::CurrentScheduler::Create](../vs140/currentscheduler--create-method.md), [concurrency::Scheduler::Create](../vs140/scheduler--create-method.md), or [concurrency::Scheduler::SetDefaultSchedulerPolicy](../vs140/scheduler--setdefaultschedulerpolicy-method.md) method to create a scheduler instance, you provide a [concurrency::SchedulerPolicy](../vs140/schedulerpolicy-class.md) object that contains a collection of key-value pairs that specify the behavior of the scheduler. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> constructor takes a variable number of arguments. The first argument is the number of policy elements that you are about to specify. The remaining arguments are key-value pairs for each policy element. The following example creates a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object that specifies three policy elements. The runtime uses default values for the policy keys that are not specified.  
  
 [!code[concrt-scheduler-policy#2](../vs140/codesnippet/CPP/scheduler-policies_1.cpp)]  
  
 The [concurrency::PolicyElementKey](../vs140/policyelementkey-enumeration.md) enumeration defines the policy keys that are associated with the Task Scheduler. The following table describes the policy keys and the default value that the runtime uses for each of them.  
  
|Policy Key|Description|Default Value|  
|----------------|-----------------|-------------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|A [concurrency::SchedulerType](../vs140/schedulertype-enumeration.md) value that specifies the type of threads to use to schedule tasks.|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> (use normal threads). This is the only valid value for this key.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|An <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> value that specifies the maximum number of concurrency resources that the scheduler uses.|[concurrency::MaxExecutionResources](../vs140/maxexecutionresources-constant.md)|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|An <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> value that specifies the minimum number of concurrency resources that the scheduler uses.|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|An <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> value that specifies how many threads to allocate to each processing resource.|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|An <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> value that specifies the maximum number of contexts that can be cached in the local queue of each virtual processor.|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|An <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> value that specifies the size of the stack, in kilobytes, to reserve for each context.|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder> (use the default stack size)|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|An <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> value that specifies the thread priority of each context. This can be any value that you can pass to [SetThreadPriority](http://msdn.microsoft.com/library/windows/desktop/ms686277) or <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|A [concurrency::SchedulingProtocolType](../vs140/schedulingprotocoltype-enumeration.md) value that specifies the scheduling algorithm to use.|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|A [concurrency::DynamicProgressFeedbackType](../vs140/dynamicprogressfeedbacktype-enumeration.md) value that specifies whether to rebalance resources according to statistics-based progress information.\<br />\<br /> **Note** Do not set this policy to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> because it is reserved for use by the runtime.|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|  
  
 Each scheduler uses its own policy when it schedules tasks. The policies that are associated with one scheduler do not affect the behavior of any other scheduler. In addition, you cannot change the scheduler policy after you create the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object.  
  
> [!IMPORTANT]
>  Use only scheduler policies to control the attributes for threads that the runtime creates. Do not change the thread affinity or priority of threads that are created by the runtime because that might cause undefined behavior.  
  
 The runtime creates a default scheduler for you if you do not explicitly create one. If you want to use the default scheduler in your application, but you want to specify a policy for that scheduler to use, call the [concurrency::Scheduler::SetDefaultSchedulerPolicy](../vs140/scheduler--setdefaultschedulerpolicy-method.md) method before you schedule parallel work. If you do not call the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> method, the runtime uses the default policy values from the table.  
  
 Use the [concurrency::CurrentScheduler::GetPolicy](../vs140/currentscheduler--getpolicy-method.md) and the [concurrency::Scheduler::GetPolicy](../vs140/scheduler--getpolicy-method.md) methods to retrieve a copy of the scheduler policy. The policy values that you receive from these methods can differ from the policy values that you specify when you create the scheduler.  
  
## Example  
 To examine examples that use specific scheduler policies to control the behavior of the scheduler, see [How-to: Specify Specific Scheduler Policies](../vs140/how-to--specify-specific-scheduler-policies.md) and [How-to: Create Agents that Use Specific Scheduler Policies](../vs140/how-to--create-agents-that-use-specific-scheduler-policies.md).  
  
## See Also  
 [Task Scheduler (Concurrency Runtime)](../vs140/task-scheduler--concurrency-runtime-.md)   
 [How-to: Specify Specific Scheduler Policies](../vs140/how-to--specify-specific-scheduler-policies.md)   
 [How-to: Create Agents that Use Specific Scheduler Policies](../vs140/how-to--create-agents-that-use-specific-scheduler-policies.md)