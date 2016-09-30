---
title: "IScheduler Structure"
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
  - "concrtrm/concurrency::IScheduler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IScheduler structure"
ms.assetid: 471de85a-2b1a-4b6d-ab81-2eff2737161e
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IScheduler Structure
An interface to an abstraction of a work scheduler. The Concurrency Runtime's Resource Manager uses this interface to communicate with work schedulers.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IScheduler::AddVirtualProcessors Method](#ischeduler__addvirtualprocessors_method)|Provides a scheduler with a set of virtual processor roots for its use. Each                                         <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> interface represents the right to execute a single thread that can perform work on behalf of the scheduler.|  
|[IScheduler::GetId Method](#ischeduler__getid_method)|Returns a unique identifier for the scheduler.|  
|[IScheduler::GetPolicy Method](#ischeduler__getpolicy_method)|Returns a copy of the scheduler's policy. For more information on scheduler policies, see                                         [SchedulerPolicy](../vs140/schedulerpolicy-class.md).|  
|[IScheduler::NotifyResourcesExternallyBusy Method](#ischeduler__notifyresourcesexternallybusy_method)|Notifies this scheduler that the hardware threads represented by the set of virtual processor roots in the array                                         <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> are now being used by other schedulers.|  
|[IScheduler::NotifyResourcesExternallyIdle Method](#ischeduler__notifyresourcesexternallyidle_method)|Notifies this scheduler that the hardware threads represented by the set of virtual processor roots in the array                                         <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> are not being used by other schedulers.|  
|[IScheduler::RemoveVirtualProcessors Method](#ischeduler__removevirtualprocessors_method)|Initiates the removal of virtual processor roots that were previously allocated to this scheduler.|  
|[IScheduler::Statistics Method](#ischeduler__statistics_method)|Provides information related to task arrival and completion rates, and change in queue length for a scheduler.|  
  
## Remarks  
 If you are implementing a custom scheduler that communicates with the Resource Manager, you should provide an implementation of the                 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> interface. This interface is one end of a two-way channel of communication between a scheduler and the Resource Manager. The other end is represented by the                 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and                 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> interfaces which are implemented by the Resource Manager.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
##  \<a name="ischeduler__addvirtualprocessors_method">\</a>  IScheduler::AddVirtualProcessors Method  
 Provides a scheduler with a set of virtual processor roots for its use. Each                 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> interface represents the right to execute a single thread that can perform work on behalf of the scheduler.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 An array of                                 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> interfaces representing the virtual processor roots being added to the scheduler.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The number of                                 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> interfaces in the array.  
  
### Remarks  
 The Resource Manager invokes the                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> method to grant an initial set of virtual processor roots to a scheduler. It could also invoke the method to add virtual processor roots to the scheduler when it rebalances resources among schedulers.  
  
##  \<a name="ischeduler__getid_method">\</a>  IScheduler::GetId Method  
 Returns a unique identifier for the scheduler.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A unique integer identifier.  
  
### Remarks  
 You should use the                         [GetSchedulerId](concurrency_namespace_Functions) function to obtain a unique identifier for the object that implements the                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> interface, before you use the interface as a parameter to methods supplied by the Resource Manager. You are expected to return the same identifier when the                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> function is invoked.  
  
 An identifier obtained from a different source could result in undefined behavior.  
  
##  \<a name="ischeduler__getpolicy_method">\</a>  IScheduler::GetPolicy Method  
 Returns a copy of the scheduler's policy. For more information on scheduler policies, see                 [SchedulerPolicy](../vs140/schedulerpolicy-class.md).  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 A copy of the scheduler's policy.  
  
##  \<a name="ischeduler__notifyresourcesexternallybusy_method">\</a>  IScheduler::NotifyResourcesExternallyBusy Method  
 Notifies this scheduler that the hardware threads represented by the set of virtual processor roots in the array                 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> are now being used by other schedulers.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 An array of                                 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> interfaces associated with the hardware threads on which other schedulers have become busy.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The number of                                 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> interfaces in the array.  
  
### Remarks  
 It is possible for a particular hardware thread to be assigned to multiple schedulers at the same time. One reason for this could be that there are not enough hardware threads on the system to satisfy the minimum concurrency for all schedulers, without sharing resources. Another possibility is that resources are temporarily assigned to other schedulers when the owning scheduler is not using them, by way of all its virtual processor roots on that hardware thread being deactivated.  
  
 The subscription level of a hardware thread is denoted by the number of subscribed threads and activated virtual processor roots associated with that hardware thread. From a particular scheduler's point of view, the external subscription level of a hardware thread is the portion of the subscription other schedulers contribute to. Notifications that resources are externally busy are sent to a scheduler when the external subscription level for a hardware thread moves from zero into positive territory.  
  
 Notifications via this method are only sent to schedulers that have a policy where the value for the                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> policy key is equal to the value for the                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> policy key. For more information on scheduler policies, see                         [SchedulerPolicy](../vs140/schedulerpolicy-class.md).  
  
 A scheduler that qualifies for notifications gets a set of initial notifications when it is created, informing it whether the resources it was just assigned are externally busy or idle.  
  
##  \<a name="ischeduler__notifyresourcesexternallyidle_method">\</a>  IScheduler::NotifyResourcesExternallyIdle Method  
 Notifies this scheduler that the hardware threads represented by the set of virtual processor roots in the array                 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> are not being used by other schedulers.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 An array of                                 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> interfaces associated with hardware threads on which other schedulers have become idle.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The number of                                 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> interfaces in the array.  
  
### Remarks  
 It is possible for a particular hardware thread to be assigned to multiple schedulers at the same time. One reason for this could be that there are not enough hardware threads on the system to satisfy the minimum concurrency for all schedulers, without sharing resources. Another possibility is that resources are temporarily assigned to other schedulers when the owning scheduler is not using them, by way of all its virtual processor roots on that hardware thread being deactivated.  
  
 The subscription level of a hardware thread is denoted by the number of subscribed threads and activated virtual processor roots associated with that hardware thread. From a particular scheduler's point of view, the external subscription level of a hardware thread is the portion of the subscription other schedulers contribute to. Notifications that resources are externally busy are sent to a scheduler when the external subscription level for a hardware thread falls to zero from a previous positive value.  
  
 Notifications via this method are only sent to schedulers that have a policy where the value for the                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> policy key is equal to the value for the                         <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> policy key. For more information on scheduler policies, see                         [SchedulerPolicy](../vs140/schedulerpolicy-class.md).  
  
 A scheduler that qualifies for notifications gets a set of initial notifications when it is created, informing it whether the resources it was just assigned are externally busy or idle.  
  
##  \<a name="ischeduler__removevirtualprocessors_method">\</a>  IScheduler::RemoveVirtualProcessors Method  
 Initiates the removal of virtual processor roots that were previously allocated to this scheduler.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 An array of                                 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> interfaces representing the virtual processor roots to be removed.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The number of                                 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> interfaces in the array.  
  
### Remarks  
 The Resource Manager invokes the                         <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> method to take back a set of virtual processor roots from a scheduler. The scheduler is expected to invoke the                         [Remove](../vs140/iexecutionresource-structure.md#iexecutionresource__remove_method) method on each interface when it is done with the virtual processor roots. Do not use an                         <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> interface once you have invoked the                         <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> method on it.  
  
 The parameter                         <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> points to an array of interfaces. Among the set of virtual processor roots to be removed, the roots have never been activated can be returned immediately using the                         <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> method. The roots that have been activated and are either executing work, or have been deactivated and are waiting for work to arrive, should be returned asynchronously. The scheduler must make every attempt to remove the virtual processor root as quickly as possible. Delaying removal of the virtual processor roots may result in unintentional oversubscription within the scheduler.  
  
##  \<a name="ischeduler__statistics_method">\</a>  IScheduler::Statistics Method  
 Provides information related to task arrival and completion rates, and change in queue length for a scheduler.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 The number of tasks that have been completed by the scheduler since the last call to this method.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 The number of tasks that have arrived in the scheduler since the last call to this method.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The total number of tasks in all scheduler queues.  
  
### Remarks  
 This method is invoked by the Resource Manager in order to gather statistics for a scheduler. The statistics gathered here will be used to drive dynamic feedback algorithms to determine when it is appropriate to assign more resources to the scheduler and when to take resources away. The values provided by the scheduler can be optimistic and do not necessarily have to reflect the current count accurately.  
  
 You should implement this method if you want the Resource Manager to use feedback about such things as task arrival to determine how to balance resource between your scheduler and other schedulers registered with the Resource Manager. If you choose not to gather statistics, you can set the policy key                         <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> to the value                         <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> in your scheduler's policy, and the Resource Manager will not invoke this method on your scheduler.  
  
 In the absence of statistical information, the Resource Manager will use hardware thread subscription levels to make resource allocation and migration decisions. For more information on subscription levels, see                         [IExecutionResource::CurrentSubscriptionLevel](../vs140/iexecutionresource-structure.md#iexecutionresource__currentsubscriptionlevel_method).  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [PolicyElementKey Enumeration](concurrency_namespace_Enumerations)   
 [SchedulerPolicy Class](../vs140/schedulerpolicy-class.md)   
 [IExecutionContext Structure](../vs140/iexecutioncontext-structure.md)   
 [IThreadProxy Structure](../vs140/ithreadproxy-structure.md)   
 [IVirtualProcessorRoot Structure](../vs140/ivirtualprocessorroot-structure.md)   
 [IResourceManager Structure](../vs140/iresourcemanager-structure.md)