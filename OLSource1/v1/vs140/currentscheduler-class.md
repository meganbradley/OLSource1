---
title: "CurrentScheduler Class"
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
  - "concrt/concurrency::CurrentScheduler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CurrentScheduler class"
ms.assetid: 31c20e0e-4cdf-49b4-8220-d726130aad2b
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CurrentScheduler Class
Represents an abstraction for the current scheduler associated with the calling context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CurrentScheduler::Create Method](#currentscheduler__create_method)|Creates a new scheduler whose behavior is described by the                                         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter and attaches it to the calling context. The newly created scheduler will become the current scheduler for the calling context.|  
|[CurrentScheduler::CreateScheduleGroup Method](#currentscheduler__createschedulegroup_method)|Overloaded. Creates a new schedule group within the scheduler associated with the calling context. The version that takes the parameter                                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> causes tasks within the newly created schedule group to be biased towards executing at the location specified by that parameter.|  
|[CurrentScheduler::Detach Method](#currentscheduler__detach_method)|Detaches the current scheduler from the calling context and restores the previously attached scheduler as the current scheduler, if one exists. After this method returns, the calling context is then managed by the scheduler that was previously attached to the context using either the                                         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or                                         <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> method.|  
|[CurrentScheduler::Get Method](#currentscheduler__get_method)|Returns a pointer to the scheduler associated with the calling context, also referred to as the current scheduler.|  
|[CurrentScheduler::GetNumberOfVirtualProcessors Method](#currentscheduler__getnumberofvirtualprocessors_method)|Returns the current number of virtual processors for the scheduler associated with the calling context.|  
|[CurrentScheduler::GetPolicy Method](#currentscheduler__getpolicy_method)|Returns a copy of the policy that the current scheduler was created with.|  
|[CurrentScheduler::Id Method](#currentscheduler__id_method)|Returns a unique identifier for the current scheduler.|  
|[CurrentScheduler::IsAvailableLocation Method](#currentscheduler__isavailablelocation_method)|Determines whether a given location is available on the current scheduler.|  
|[CurrentScheduler::RegisterShutdownEvent Method](#currentscheduler__registershutdownevent_method)|Causes the Windows event handle passed in the                                         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter to be signaled when the scheduler associated with the current context shuts down and destroys itself. At the time the event is signaled, all work that had been scheduled to the scheduler is complete. Multiple shutdown events can be registered through this method.|  
|[CurrentScheduler::ScheduleTask Method](#currentscheduler__scheduletask_method)|Overloaded. Schedules a light-weight task within the scheduler associated with the calling context. The light-weight task will be placed in a schedule group determined by the runtime. The version that takes the parameter                                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> causes the task to be biased towards executing at the specified location.|  
  
## Remarks  
 If there is no scheduler (see                 [Scheduler](../vs140/scheduler-class.md)) associated with the calling context, many methods within the                 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> class will result in attachment of the process' default scheduler. This may also imply that the process' default scheduler is created during such a call.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
##  \<a name="currentscheduler__create_method">\</a>  CurrentScheduler::Create Method  
 Creates a new scheduler whose behavior is described by the                 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> parameter and attaches it to the calling context. The newly created scheduler will become the current scheduler for the calling context.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The scheduler policy that describes the behavior of the newly created scheduler.  
  
### Remarks  
 The attachment of the scheduler to the calling context implicitly places a reference count on the scheduler.  
  
 After a scheduler is created with the                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> method, you must call the                         [CurrentScheduler::Detach](#currentscheduler__detach_method) method at some point in the future in order to allow the scheduler to shut down.  
  
 If this method is called from a context that is already attached to a different scheduler, the existing scheduler is remembered as the previous scheduler, and the newly created scheduler becomes the current scheduler. When you call the                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> method at a later point, the previous scheduler is restored as the current scheduler.  
  
 This method can throw a variety of exceptions, including                         [scheduler_resource_allocation_error](../vs140/scheduler_resource_allocation_error-class.md) and                         [invalid_scheduler_policy_value](../vs140/invalid_scheduler_policy_value-class.md).  
  
##  \<a name="currentscheduler__createschedulegroup_method">\</a>  CurrentScheduler::CreateScheduleGroup Method  
 Creates a new schedule group within the scheduler associated with the calling context. The version that takes the parameter                 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> causes tasks within the newly created schedule group to be biased towards executing at the location specified by that parameter.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 A reference to a location where the tasks within the schedule group will be biased towards executing at.  
  
### Return Value  
 A pointer to the newly created schedule group. This                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object has an initial reference count placed on it.  
  
### Remarks  
 This method will result in the process' default scheduler being created and/or attached to the calling context if there is no scheduler currently associated with the calling context.  
  
 You must invoke the                         [Release](../vs140/schedulegroup-class.md#schedulegroup__release_method) method on a schedule group when you are done scheduling work to it. The scheduler will destroy the schedule group when all work queued to it has completed.  
  
 Note that if you explicitly created this scheduler, you must release all references to schedule groups within it, before you release your reference on the scheduler, by detaching the current context from it.  
  
##  \<a name="currentscheduler__detach_method">\</a>  CurrentScheduler::Detach Method  
 Detaches the current scheduler from the calling context and restores the previously attached scheduler as the current scheduler, if one exists. After this method returns, the calling context is then managed by the scheduler that was previously attached to the context using either the                 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> or                 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> method.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> method implicitly removes a reference count from the scheduler.  
  
 If there is no scheduler attached to the calling context, calling this method will result in a                         [scheduler_not_attached](../vs140/scheduler_not_attached-class.md) exception being thrown.  
  
 Calling this method from a context that is internal to and managed by a scheduler, or a context that was attached using a method other than the                         [Scheduler::Attach](../vs140/scheduler-class.md#scheduler__attach_method) or                         [CurrentScheduler::Create](#currentscheduler__create_method) methods, will result in an                         [improper_scheduler_detach](../vs140/improper_scheduler_detach-class.md) exception being thrown.  
  
##  \<a name="currentscheduler__get_method">\</a>  CurrentScheduler::Get Method  
 Returns a pointer to the scheduler associated with the calling context, also referred to as the current scheduler.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the scheduler associated with the calling context (the current scheduler).  
  
### Remarks  
 This method will result in the process' default scheduler being created and/or attached to the calling context if there is no scheduler currently associated with the calling context. No additional reference is placed on the                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object returned by this method.  
  
##  \<a name="currentscheduler__getnumberofvirtualprocessors_method">\</a>  CurrentScheduler::GetNumberOfVirtualProcessors Method  
 Returns the current number of virtual processors for the scheduler associated with the calling context.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 If a scheduler is associated with the calling context, the current number of virtual processors for that scheduler; otherwise, the value                         <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method will not result in scheduler attachment if the calling context is not already associated with a scheduler.  
  
 The return value from this method is an instantaneous sampling of the number of virtual processors for the scheduler associated with the calling context. This value can be stale the moment it is returned.  
  
##  \<a name="currentscheduler__getpolicy_method">\</a>  CurrentScheduler::GetPolicy Method  
 Returns a copy of the policy that the current scheduler was created with.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A copy of the policy that that the current scheduler was created with.  
  
### Remarks  
 This method will result in the process' default scheduler being created and/or attached to the calling context if there is no scheduler currently associated with the calling context.  
  
##  \<a name="currentscheduler__id_method">\</a>  CurrentScheduler::Id Method  
 Returns a unique identifier for the current scheduler.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 If a scheduler is associated with the calling context, a unique identifier for that scheduler; otherwise, the value                         <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method will not result in scheduler attachment if the calling context is not already associated with a scheduler.  
  
##  \<a name="currentscheduler__isavailablelocation_method">\</a>  CurrentScheduler::IsAvailableLocation Method  
 Determines whether a given location is available on the current scheduler.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 A reference to the location to query the current scheduler about.  
  
### Return Value  
 An indication of whether or not the location specified by the                         <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> argument is available on the current scheduler.  
  
### Remarks  
 This method will not result in scheduler attachment if the calling context is not already associated with a scheduler.  
  
 Note that the return value is an instantaneous sampling of whether the given location is available. In the presence of multiple schedulers, dynamic resource management can add or take away resources from schedulers at any point. Should this happen, the given location can change availability.  
  
##  \<a name="currentscheduler__registershutdownevent_method">\</a>  CurrentScheduler::RegisterShutdownEvent Method  
 Causes the Windows event handle passed in the                 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> parameter to be signaled when the scheduler associated with the current context shuts down and destroys itself. At the time the event is signaled, all work that had been scheduled to the scheduler is complete. Multiple shutdown events can be registered through this method.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 A handle to a Windows event object which will be signaled by the runtime when the scheduler associated with the current context shuts down and destroys itself.  
  
### Remarks  
 If there is no scheduler attached to the calling context, calling this method will result in a                         [scheduler_not_attached](../vs140/scheduler_not_attached-class.md) exception being thrown.  
  
##  \<a name="currentscheduler__scheduletask_method">\</a>  CurrentScheduler::ScheduleTask Method  
 Schedules a light-weight task within the scheduler associated with the calling context. The light-weight task will be placed in a schedule group determined by the runtime. The version that takes the parameter                 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> causes the task to be biased towards executing at the specified location.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 A pointer to the function to execute to perform the body of the light-weight task.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 A void pointer to the data that will be passed as a parameter to the body of the task.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 A reference to a location where the light-weight task will be biased towards executing at.  
  
### Remarks  
 This method will result in the process' default scheduler being created and/or attached to the calling context if there is no scheduler currently associated with the calling context.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [PolicyElementKey Enumeration](concurrency_namespace_Enumerations)   
 [Task Scheduler (Concurrency Runtime)](../vs140/task-scheduler--concurrency-runtime-.md)