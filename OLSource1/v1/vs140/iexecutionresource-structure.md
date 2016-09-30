---
title: "IExecutionResource Structure"
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
  - "concrtrm/concurrency::IExecutionResource"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IExecutionResource structure"
ms.assetid: 6b27042b-b98c-4f7f-b831-566950af84cd
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IExecutionResource Structure
An abstraction for a hardware thread.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IExecutionResource::CurrentSubscriptionLevel Method](#iexecutionresource__currentsubscriptionlevel_method)|Returns the number of activated virtual processor roots and subscribed external threads currently associated with the underlying hardware thread this execution resource represents.|  
|[IExecutionResource::GetExecutionResourceId Method](#iexecutionresource__getexecutionresourceid_method)|Returns a unique identifier for the hardware thread that this execution resource represents.|  
|[IExecutionResource::GetNodeId Method](#iexecutionresource__getnodeid_method)|Returns a unique identifier for the processor node that this execution resource belongs to.|  
|[IExecutionResource::Remove Method](#iexecutionresource__remove_method)|Returns this execution resource to the Resource Manager.|  
  
## Remarks  
 Execution resources can be standalone or associated with virtual processor roots. A standalone execution resource is created when a thread in your application creates a thread subscription. The methods                 [ISchedulerProxy::SubscribeThread](../vs140/ischedulerproxy-structure.md#ischedulerproxy__subscribecurrentthread_method) and                 [ISchedulerProxy::RequestInitialVirtualProcessors](../vs140/ischedulerproxy-structure.md#ischedulerproxy__requestinitialvirtualprocessors_method) create thread subscriptions, and return an                 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> interface representing the subscription. Creating a thread subscription is a way to inform the Resource Manager that a given thread will participate in the work queued to a scheduler, along with the virtual processor roots Resource Manager assigns to the scheduler. The Resource Manager uses the information to avoid oversubscribing hardware threads where it can.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
##  \<a name="iexecutionresource__currentsubscriptionlevel_method">\</a>  IExecutionResource::CurrentSubscriptionLevel Method  
 Returns the number of activated virtual processor roots and subscribed external threads currently associated with the underlying hardware thread this execution resource represents.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 The current subscription level.  
  
### Remarks  
 The subscription level tells you how many running threads are associated with the hardware thread. This only includes threads the Resource Manager is aware of in the form of subscribed threads, and virtual processor roots that are actively executing thread proxies.  
  
 Calling the method                         [ISchedulerProxy::SubscribeCurrentThread](../vs140/ischedulerproxy-structure.md#ischedulerproxy__subscribecurrentthread_method), or the method                         [ISchedulerProxy::RequestInitialVirtualProcessors](../vs140/ischedulerproxy-structure.md#ischedulerproxy__requestinitialvirtualprocessors_method) with the parameter                         <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> set to the value                         <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> increments the subscription level of a hardware thread by one. They also return an                         <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> interface representing the subscription. A corresponding call to the                         [IExecutionResource::Remove](#iexecutionresource__remove_method) decrements the hardware thread's subscription level by one.  
  
 The act of activating a virtual processor root using the method                         [IVirtualProcessorRoot::Activate](../vs140/ivirtualprocessorroot-structure.md#ivirtualprocessorroot__activate_method) increments the subscription level of a hardware thread by one. The methods                         [IVirtualProcessorRoot::Deactivate](../vs140/ivirtualprocessorroot-structure.md#ivirtualprocessorroot__deactivate_method), or                         [IExecutionResource::Remove](#iexecutionresource__remove_method) decrement the subscription level by one when invoked on an activated virtual processor root.  
  
 The Resource Manager uses subscription level information as one of the ways in which to determine when to move resources between schedulers.  
  
##  \<a name="iexecutionresource__getexecutionresourceid_method">\</a>  IExecutionResource::GetExecutionResourceId Method  
 Returns a unique identifier for the hardware thread that this execution resource represents.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A unique identifier for the hardware thread underlying this execution resource.  
  
### Remarks  
 Each hardware thread is assigned a unique identifier by the Concurrency Runtime. If multiple execution resources are associated hardware thread, they will all have the same execution resource identifier.  
  
##  \<a name="iexecutionresource__getnodeid_method">\</a>  IExecutionResource::GetNodeId Method  
 Returns a unique identifier for the processor node that this execution resource belongs to.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 A unique identifier for a processor node.  
  
### Remarks  
 The Concurrency Runtime represents hardware threads on the system in groups of processor nodes. Nodes are usually derived from the hardware topology of the system. For example, all processors on a specific socket or a specific NUMA node may belong to the same processor node. The Resource Manager assigns unique identifiers to these nodes starting with                         <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> up to and including                         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, where                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> represents the total number of processor nodes on the system.  
  
 The count of nodes can be obtained from the function                         [GetProcessorNodeCount](concurrency_namespace_Functions).  
  
##  \<a name="iexecutionresource__remove_method">\</a>  IExecutionResource::Remove Method  
 Returns this execution resource to the Resource Manager.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 An interface to the scheduler making the request to remove this execution resource.  
  
### Remarks  
 Use this method to return standalone execution resources as well as execution resources associated with virtual processor roots to the Resource Manager.  
  
 If this is a standalone execution resource you received from either of the methods                         [ISchedulerProxy::SubscribeCurrentThread](../vs140/ischedulerproxy-structure.md#ischedulerproxy__subscribecurrentthread_method) or                         [ISchedulerProxy::RequestInitialVirtualProcessors](../vs140/ischedulerproxy-structure.md#ischedulerproxy__requestinitialvirtualprocessors_method), calling the method                         <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> will end the thread subscription that the resource was created to represent. You are required to end all thread subscriptions before shutting down a scheduler proxy, and must call                         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> from the thread that created the subscription.  
  
 Virtual processor roots, too, can be returned to the Resource Manager by invoking the                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> method, because the interface                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> inherits from the                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> interface. You may need to return a virtual processor root either in response to a call to the                         [IScheduler::RemoveVirtualProcessors](../vs140/ischeduler-structure.md#ischeduler__removevirtualprocessors_method) method, or when you are done with an oversubscribed virtual processor root you obtained from the                         [ISchedulerProxy::CreateOversubscriber](../vs140/ischedulerproxy-structure.md#ischedulerproxy__createoversubscriber_method) method. For virtual processor roots, there are no restrictions on which thread can invoke the                         <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> method.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is thrown if the parameter                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is set to                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is thrown if the parameter                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is different from the scheduler that this execution resource was created for, or, with a standalone execution resource, if the current thread is different from the thread that created the thread subscription.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [IVirtualProcessorRoot Structure](../vs140/ivirtualprocessorroot-structure.md)   
 [ISchedulerProxy::SubscribeCurrentThread Method](../vs140/ischedulerproxy-structure.md#ischedulerproxy__subscribecurrentthread_method)   
 [ISchedulerProxy::RequestInitialVirtualProcessors Method](../vs140/ischedulerproxy-structure.md#ischedulerproxy__requestinitialvirtualprocessors_method)