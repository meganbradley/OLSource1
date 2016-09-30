---
title: "Context Class"
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
  - "concrt/concurrency::Context"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Context class"
ms.assetid: c0d553f3-961d-4ecd-9a29-4fa4351673b8
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Context Class
Represents an abstraction for an execution context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Protected Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[Context::~Context Destructor](#context___dtorcontext_destructor)||  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[Context::Block Method](#context__block_method)|Blocks the current context.|  
|[Context::CurrentContext Method](#context__currentcontext_method)|Returns a pointer to the current context.|  
|[Context::GetId Method](#context__getid_method)|Returns an identifier for the context that is unique within the scheduler to which the context belongs.|  
|[Context::GetScheduleGroupId Method](#context__getschedulegroupid_method)|Returns an identifier for the schedule group that the context is currently working on.|  
|[Context::GetVirtualProcessorId Method](#context__getvirtualprocessorid_method)|Returns an identifier for the virtual processor that the context is currently executing on.|  
|[Context::Id Method](#context__id_method)|Returns an identifier for the current context that is unique within the scheduler to which the current context belongs.|  
|[Context::IsCurrentTaskCollectionCanceling Method](#context__iscurrenttaskcollectioncanceling_method)|Returns an indication of whether the task collection which is currently executing inline on the current context is in the midst of an active cancellation (or will be shortly).|  
|[Context::IsSynchronouslyBlocked Method](#context__issynchronouslyblocked_method)|Determines whether or not the context is synchronously blocked. A context is considered to be synchronously blocked if it explicitly performed an action which led to blocking.|  
|[Context::Oversubscribe Method](#context__oversubscribe_method)|Injects an additional virtual processor into a scheduler for the duration of a block of code when invoked on a context executing on one of the virtual processors in that scheduler.|  
|[Context::ScheduleGroupId Method](#context__schedulegroupid_method)|Returns an identifier for the schedule group that the current context is working on.|  
|[Context::Unblock Method](#context__unblock_method)|Unblocks the context and causes it to become runnable.|  
|[Context::VirtualProcessorId Method](#context__virtualprocessorid_method)|Returns an identifier for the virtual processor that the current context is executing on.|  
|[Context::Yield Method](#context__yield_method)|Yields execution so that another context can execute. If no other context is available to yield to, the scheduler can yield to another operating system thread.|  
  
## Remarks  
 The Concurrency Runtime scheduler (see                 [Scheduler](../vs140/scheduler-class.md)) uses execution contexts to execute the work queued to it by your application. A Win32 thread is an example of an execution context on a Windows operating system.  
  
 At any time, the concurrency level of a scheduler is equal to the number of virtual processors granted to it by the Resource Manager. A virtual processor is an abstraction for a processing resource and maps to a hardware thread on the underlying system. Only a single scheduler context can execute on a virtual processor at a given time.  
  
 The scheduler is cooperative in nature and an executing context can yield its virtual processor to a different context at any time if it wishes to enter a wait state. When its wait it satisfied, it cannot resume until an available virtual processor from the scheduler begins executing it.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
##  \<a name="context__block_method">\</a>  Context::Block Method  
 Blocks the current context.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 This method will result in the process' default scheduler being created and/or attached to the calling context if there is no scheduler currently associated with the calling context.  
  
 If the calling context is running on a virtual processor, the virtual processor will find another runnable context to execute or can potentially create a new one.  
  
 After the                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> method has been called or will be called, you must pair it with a call to the                         [Unblock](#context__unblock_method) method from another execution context in order for it to run again. Be aware that there is a critical period between the point where your code publishes its context for another thread to be able to call the                         <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> method and the point where the actual method call to                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is made. During this period, you must not call any method which can in turn block and unblock for its own reasons (for example, acquiring a lock). Calls to the                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> method do not track the reason for the blocking and unblocking. Only one object should have ownership of a                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>-                        <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> pair.  
  
 This method can throw a variety of exceptions, including                         [scheduler_resource_allocation_error](../vs140/scheduler_resource_allocation_error-class.md).  
  
##  \<a name="context___dtorcontext_destructor">\</a>  Context::~Context Destructor  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="context__currentcontext_method">\</a>  Context::CurrentContext Method  
 Returns a pointer to the current context.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the current context.  
  
### Remarks  
 This method will result in the process' default scheduler being created and/or attached to the calling context if there is no scheduler currently associated with the calling context.  
  
##  \<a name="context__getid_method">\</a>  Context::GetId Method  
 Returns an identifier for the context that is unique within the scheduler to which the context belongs.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 An identifier for the context that is unique within the scheduler to which the context belongs.  
  
##  \<a name="context__getschedulegroupid_method">\</a>  Context::GetScheduleGroupId Method  
 Returns an identifier for the schedule group that the context is currently working on.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 An identifier for the schedule group the context is currently working on.  
  
### Remarks  
 The return value from this method is an instantaneous sampling of the schedule group that the context is executing on. If this method is called on a context other than the current context, the value can be stale the moment it is returned and cannot be relied upon. Typically, this method is used for debugging or tracing purposes only.  
  
##  \<a name="context__getvirtualprocessorid_method">\</a>  Context::GetVirtualProcessorId Method  
 Returns an identifier for the virtual processor that the context is currently executing on.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 If the context is currently executing on a virtual processor, an identifier for the virtual processor that the context is currently executing on; otherwise, the value                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
### Remarks  
 The return value from this method is an instantaneous sampling of the virtual processor that the context is executing on. This value can be stale the moment it is returned and cannot be relied upon. Typically, this method is used for debugging or tracing purposes only.  
  
##  \<a name="context__id_method">\</a>  Context::Id Method  
 Returns an identifier for the current context that is unique within the scheduler to which the current context belongs.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 If the current context is attached to a scheduler, an identifier for the current context that is unique within the scheduler to which the current context belongs; otherwise, the value                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
##  \<a name="context__iscurrenttaskcollectioncanceling_method">\</a>  Context::IsCurrentTaskCollectionCanceling Method  
 Returns an indication of whether the task collection which is currently executing inline on the current context is in the midst of an active cancellation (or will be shortly).  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 If a scheduler is attached to the calling context and a task group is executing a task inline on that context, an indication of whether that task group is in the midst of an active cancellation (or will be shortly); otherwise, the value                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
##  \<a name="context__issynchronouslyblocked_method">\</a>  Context::IsSynchronouslyBlocked Method  
 Determines whether or not the context is synchronously blocked. A context is considered to be synchronously blocked if it explicitly performed an action which led to blocking.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 Whether the context is synchronously blocked.  
  
### Remarks  
 A context is considered to be synchronously blocked if it explicitly performed an action which led to blocking. On the thread scheduler, this would indicate a direct call to the                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> method or a synchronization object which was built using the                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> method.  
  
 The return value from this method is an instantaneous sample of whether the context is synchronously blocked. This value may be stale the moment it is returned and can only be used under very specific circumstances.  
  
##  \<a name="context__operator_delete_operator">\</a>  Context::operator delete Operator  
 A                 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object is destroyed internally by the runtime. It can not be explicitly deleted.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 A pointer to the object to be deleted.  
  
##  \<a name="context__oversubscribe_method">\</a>  Context::Oversubscribe Method  
 Injects an additional virtual processor into a scheduler for the duration of a block of code when invoked on a context executing on one of the virtual processors in that scheduler.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 If                                 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, an indication that an extra virtual processor should be added for the duration of the oversubscription. If                                 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, an indication that the oversubscription should end and the previously added virtual processor should be removed.  
  
##  \<a name="context__schedulegroupid_method">\</a>  Context::ScheduleGroupId Method  
 Returns an identifier for the schedule group that the current context is working on.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 If the current context is attached to a scheduler and working on a schedule group, an identifier for the scheduler group that the current context is working on; otherwise, the value                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
##  \<a name="context__unblock_method">\</a>  Context::Unblock Method  
 Unblocks the context and causes it to become runnable.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 It is perfectly legal for a call to the                         <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> method to come before a corresponding call to the                         [Block](#context__block_method) method. As long as calls to the                         <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> and                         <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> methods are properly paired, the runtime properly handles the natural race of either ordering. An                         <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> call coming before a                         <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> call simply negates the effect of the                         <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> call.  
  
 There are several exceptions which can be thrown from this method. If a context attempts to call the                         <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> method on itself, a                         [context_self_unblock](../vs140/context_self_unblock-class.md) exception will be thrown. If calls to                         <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> and                         <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> are not properly paired (for example, two calls to                         <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> are made for a context which is currently running), a                         [context_unblock_unbalanced](../vs140/context_unblock_unbalanced-class.md) exception will be thrown.  
  
 Be aware that there is a critical period between the point where your code publishes its context for another thread to be able to call the                         <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> method and the point where the actual method call to                         <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is made. During this period, you must not call any method which can in turn block and unblock for its own reasons (for example, acquiring a lock). Calls to the                         <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> and                         <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> method do not track the reason for the blocking and unblocking. Only one object should have ownership of a                         <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> and                         <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> pair.  
  
##  \<a name="context__virtualprocessorid_method">\</a>  Context::VirtualProcessorId Method  
 Returns an identifier for the virtual processor that the current context is executing on.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 If the current context is attached to a scheduler, an identifier for the virtual processor that the current context is executing on; otherwise, the value                         <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.  
  
### Remarks  
 The return value from this method is an instantaneous sampling of the virtual processor that the current context is executing on. This value can be stale the moment it is returned and cannot be relied upon. Typically, this method is used for debugging or tracing purposes only.  
  
##  \<a name="context__yield_method">\</a>  Context::Yield Method  
 Yields execution so that another context can execute. If no other context is available to yield to, the scheduler can yield to another operating system thread.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Remarks  
 This method will result in the process' default scheduler being created and/or attached to the calling context if there is no scheduler currently associated with the calling context.  
  
##  \<a name="context__yieldexecution_method">\</a>  Context::YieldExecution Method  
 Yields execution so that another context can execute. If no other context is available to yield to, the scheduler can yield to another operating system thread.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Remarks  
 This method will result in the process' default scheduler being created and/or attached to the calling context if there is no scheduler currently associated with the calling context.  
  
 This function is new in                         [!INCLUDE[vs_dev14](../vs140/includes/vs_dev14_md.md)] and is identical to the                         [Yield](#context__yield_method) function but does not conflict with the Yield macro in Windows.h.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [Scheduler Class](../vs140/scheduler-class.md)   
 [Task Scheduler (Concurrency Runtime)](../vs140/task-scheduler--concurrency-runtime-.md)