---
title: "Scheduler Instances"
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
  - "scheduler instances"
ms.assetid: 4819365f-ef99-49cc-963e-50a2a35a8d6b
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Scheduler Instances
This document describes the role of scheduler instances in the Concurrency Runtime and how to use the [concurrency::Scheduler](../vs140/scheduler-class.md) and [concurrency::CurrentScheduler](../vs140/currentscheduler-class.md) classes to create and manage scheduler instances. Scheduler instances are useful when you want to associate explicit scheduling policies with specific types of workloads. For example, you can create one scheduler instance to run some tasks at an elevated thread priority and use the default scheduler to run other tasks at the normal thread priority.  
  
> [!TIP]
>  The Concurrency Runtime provides a default scheduler, and therefore you are not required to create one in your application. Because the Task Scheduler helps you fine-tune the performance of your applications, we recommend that you start with the [Parallel Patterns Library (PPL)](../vs140/parallel-patterns-library--ppl-.md) or the [Asynchronous Agents Library](../vs140/asynchronous-agents-library.md) if you are new to the Concurrency Runtime.  
  
##  \<a name="top">\</a> Sections  
  
-   [The Scheduler and CurrentScheduler Classes](#classes)  
  
-   [Creating a Scheduler Instance](#creating)  
  
-   [Managing the Lifetime of a Scheduler Instance](#managing)  
  
-   [Methods and Features](#features)  
  
-   [Example](#example)  
  
##  \<a name="classes">\</a> The Scheduler and CurrentScheduler Classes  
 The Task Scheduler enables applications to use one or more *scheduler instances* to schedule work. The [concurrency::Scheduler](../vs140/scheduler-class.md) class represents a scheduler instance and encapsulates the functionality that is related to scheduling tasks.  
  
 A thread that is attached to a scheduler is known as an *execution context*, or just *context*. One scheduler can be active on the current context at any time. The active scheduler is also known as the *current scheduler*. The Concurrency Runtime uses the [concurrency::CurrentScheduler](../vs140/currentscheduler-class.md) class to provide access to the current scheduler. The current scheduler for one context can differ from the current scheduler for another context. The runtime does not provide a process-level representation of the current scheduler.  
  
 Typically, the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> class is used to access the current scheduler. The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class is useful when you need to manage a scheduler that is not the current one.  
  
 The following sections describe how to create and manage a scheduler instance. For a complete example that illustrates these tasks, see [How-to: Manage a Scheduler Instance](../vs140/how-to--manage-a-scheduler-instance.md).  
  
 [[Top](#top)]  
  
##  \<a name="creating">\</a> Creating a Scheduler Instance  
 There are these three ways to create a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object:  
  
-   If no scheduler exists, the runtime creates a default scheduler for you when you use runtime functionality, for example, a parallel algorithm, to perform work. The default scheduler becomes the current scheduler for the context that initiates the parallel work.  
  
-   The [concurrency::CurrentScheduler::Create](../vs140/currentscheduler--create-method.md) method creates a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object that uses a specific policy and associates that scheduler with the current context.  
  
-   The [concurrency::Scheduler::Create](../vs140/scheduler--create-method.md) method creates a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object that uses a specific policy, but does not associate it with the current context.  
  
 Allowing the runtime to create a default scheduler enables all concurrent tasks to share the same scheduler. Typically, the functionality that is provided by the [Parallel Patterns Library](../vs140/parallel-patterns-library--ppl-.md) (PPL) or the [Asynchronous Agents Library](../vs140/asynchronous-agents-library.md) is used to perform parallel work. Therefore, you do not have to work directly with the scheduler to control its policy or lifetime. When you use the PPL or the Agents Library, the runtime creates the default scheduler if it does not exist and makes it the current scheduler for each context. When you create a scheduler and set it as the current scheduler, then the runtime uses that scheduler to schedule tasks. Create additional scheduler instances only when you require a specific scheduling policy. For more information about the policies that are associated with a scheduler, see [Scheduler Policies](../vs140/scheduler-policies.md).  
  
 [[Top](#top)]  
  
##  \<a name="managing">\</a> Managing the Lifetime of a Scheduler Instance  
 The runtime uses a reference-counting mechanism to control the lifetime of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> objects.  
  
 When you use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method or the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method to create a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object, the runtime sets the initial reference count of that scheduler to one. The runtime increments the reference count when you call the [concurrency::Scheduler::Attach](../vs140/scheduler--attach-method.md) method. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method associates the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object together with the current context. This makes it the current scheduler. When you call the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method, the runtime both creates a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object and attaches it to the current context (and sets the reference count to one). You can also use the [concurrency::Scheduler::Reference](../vs140/scheduler--reference-method.md) method to increment the reference count of a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.  
  
 The runtime decrements the reference count when you call the [concurrency::CurrentScheduler::Detach](../vs140/currentscheduler--detach-method.md) method to detach the current scheduler, or call the [concurrency::Scheduler::Release](../vs140/scheduler--release-method.md) method. When the reference count reaches zero, the runtime destroys the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object after all scheduled tasks finish. A running task is allowed to increment the reference count of the current scheduler. Therefore, if the reference count reaches zero and a task increments the reference count, the runtime does not destroy the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object until the reference count again reaches zero and all tasks finish.  
  
 The runtime maintains an internal stack of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> objects for each context. When you call the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> method, the runtime pushes that <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object onto the stack for the current context. This makes it the current scheduler. When you call <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, the runtime pops the current scheduler from the stack for current context and sets the previous one as the current scheduler.  
  
 The runtime provides several ways to manage the lifetime of a scheduler instance. The following table shows the appropriate method that releases or detaches the scheduler from the current context for each method that creates or attaches a scheduler to the current context.  
  
|Create or attach method|Release or detach method|  
|-----------------------------|------------------------------|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
  
 Calling the inappropriate release or detach method produces unspecified behavior in the runtime.  
  
 When you use functionality, for example, the PPL, that causes the runtime to create the default scheduler for you, do not release or detach this scheduler. The runtime manages the lifetime of any scheduler that it creates.  
  
 Because the runtime does not destroy a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object before all tasks have finished, you can use the [concurrency::Scheduler::RegisterShutdownEvent](../vs140/scheduler--registershutdownevent-method.md) method or the [concurrency::CurrentScheduler::RegisterShutdownEvent](../vs140/currentscheduler--registershutdownevent-method.md) method to receive a notification when a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object is destroyed. This is useful when you must wait for every task that is scheduled by a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object to finish.  
  
 [[Top](#top)]  
  
##  \<a name="features">\</a> Methods and Features  
 This section summarizes the important methods of the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> classes.  
  
 Think of the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> class as a helper for creating a scheduler for use on the current context. The <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> class lets you control a scheduler that belongs to another context.  
  
 The following table shows the important methods that are defined by the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> class.  
  
|Method|Description|  
|------------|-----------------|  
|[Create](../vs140/currentscheduler--create-method.md)|Creates a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object that uses the specified policy and associates it with the current context.|  
|[Get](../vs140/currentscheduler--get-method.md)|Retrieves a pointer to the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object that is associated with the current context. This method does not increment the reference count of the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object.|  
|[Detach](../vs140/currentscheduler--detach-method.md)|Detaches the current scheduler from the current context and sets the previous one as the current scheduler.|  
|[RegisterShutdownEvent](../vs140/currentscheduler--registershutdownevent-method.md)|Registers an event that the runtime sets when the current scheduler is destroyed.|  
|[CreateScheduleGroup](../vs140/currentscheduler--createschedulegroup-method.md)|Creates a [concurrency::ScheduleGroup](../vs140/schedulegroup-class.md) object in the current scheduler.|  
|[ScheduleTask](../vs140/currentscheduler--scheduletask-method.md)|Adds a lightweight task to the scheduling queue of the current scheduler.|  
|[GetPolicy](../vs140/currentscheduler--getpolicy-method.md)|Retrieves a copy of the policy that is associated with the current scheduler.|  
  
 The following table shows the important methods that are defined by the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> class.  
  
|Method|Description|  
|------------|-----------------|  
|[Create](../vs140/scheduler--create-method.md)|Creates a <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object that uses the specified policy.|  
|[Attach](../vs140/scheduler--attach-method.md)|Associates the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object together with the current context.|  
|[Reference](../vs140/scheduler--reference-method.md)|Increments the reference counter of the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object.|  
|[Release](../vs140/scheduler--release-method.md)|Decrements the reference counter of the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object.|  
|[RegisterShutdownEvent](../vs140/scheduler--registershutdownevent-method.md)|Registers an event that the runtime sets when the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object is destroyed.|  
|[CreateScheduleGroup](../vs140/scheduler--createschedulegroup-method.md)|Creates a [concurrency::ScheduleGroup](../vs140/schedulegroup-class.md) object in the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object.|  
|[ScheduleTask](../vs140/scheduler--scheduletask-method.md)|Schedules a lightweight task from the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object.|  
|[GetPolicy](../vs140/scheduler--getpolicy-method.md)|Retrieves a copy of the policy that is associated with the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object.|  
|[SetDefaultSchedulerPolicy](../vs140/scheduler--setdefaultschedulerpolicy-method.md)|Sets the policy for the runtime to use when it creates the default scheduler.|  
|[ResetDefaultSchedulerPolicy](../vs140/scheduler--resetdefaultschedulerpolicy-method.md)|Restores the default policy to the one that was active before the call to <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>. If the default scheduler is created after this call, the runtime uses default policy settings to create the scheduler.|  
  
 [[Top](#top)]  
  
##  \<a name="example">\</a> Example  
 For basic examples of how to create and manage a scheduler instance, see [How-to: Manage a Scheduler Instance](../vs140/how-to--manage-a-scheduler-instance.md).  
  
## See Also  
 [Task Scheduler (Concurrency Runtime)](../vs140/task-scheduler--concurrency-runtime-.md)   
 [How-to: Manage a Scheduler Instance](../vs140/how-to--manage-a-scheduler-instance.md)   
 [Scheduler Policies](../vs140/scheduler-policies.md)   
 [Schedule Groups](../vs140/schedule-groups.md)