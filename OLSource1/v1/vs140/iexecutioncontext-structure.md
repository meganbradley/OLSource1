---
title: "IExecutionContext Structure"
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
  - "concrtrm/concurrency::IExecutionContext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IExecutionContext structure"
ms.assetid: f3108089-ecda-4b07-86db-3efae60c31e0
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IExecutionContext Structure
An interface to an execution context which can run on a given virtual processor and be cooperatively context switched.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IExecutionContext::Dispatch Method](#iexecutioncontext__dispatch_method)|The method that is called when a thread proxy starts executing a particular execution context. This should be the main worker routine for your scheduler.|  
|[IExecutionContext::GetId Method](#iexecutioncontext__getid_method)|Returns a unique identifier for the execution context.|  
|[IExecutionContext::GetProxy Method](#iexecutioncontext__getproxy_method)|Returns an interface to the thread proxy that is executing this context.|  
|[IExecutionContext::GetScheduler Method](#iexecutioncontext__getscheduler_method)|Returns an interface to the scheduler this execution context belongs to.|  
|[IExecutionContext::SetProxy Method](#iexecutioncontext__setproxy_method)|Associates a thread proxy with this execution context. The associated thread proxy invokes this method right before it starts executing the context's                                         <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method.|  
  
## Remarks  
 If you are implementing a custom scheduler that interfaces with the Concurrency Runtime's Resource Manager, you will need to implement the                 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> interface. The threads created by the Resource Manager perform work on behalf of your scheduler by executing the                 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
##  \<a name="iexecutioncontext__dispatch_method">\</a>  IExecutionContext::Dispatch Method  
 The method that is called when a thread proxy starts executing a particular execution context. This should be the main worker routine for your scheduler.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A pointer to the state under which this execution context is being dispatched. For more information on dispatch state, see                                 [DispatchState](../vs140/dispatchstate-structure.md).  
  
##  \<a name="iexecutioncontext__getid_method">\</a>  IExecutionContext::GetId Method  
 Returns a unique identifier for the execution context.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A unique integer identifier.  
  
### Remarks  
 You should use the method                         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to obtain a unique identifier for the object that implements the                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> interface, before you use the interface as a parameter to methods supplied by the Resource Manager. You are expected to return the same identifier when the                         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> function is invoked.  
  
 An identifier obtained from a different source could result in undefined behavior.  
  
##  \<a name="iexecutioncontext__getproxy_method">\</a>  IExecutionContext::GetProxy Method  
 Returns an interface to the thread proxy that is executing this context.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 An                         <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> interface. If the execution context's thread proxy has not been initialized with a call to                         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, the function must return                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
### Remarks  
 The Resource Manager will invoke the                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> method on an execution context, with an                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> interface as a parameter, prior to entering the                         <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> method on the on the context. You are expected to store this argument and return it on calls to                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
##  \<a name="iexecutioncontext__getscheduler_method">\</a>  IExecutionContext::GetScheduler Method  
 Returns an interface to the scheduler this execution context belongs to.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 An                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> interface.  
  
### Remarks  
 You are required to initialize the execution context with a valid                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> interface before you use it as a parameter to methods supplied by the Resource Manager.  
  
##  \<a name="iexecutioncontext__setproxy_method">\</a>  IExecutionContext::SetProxy Method  
 Associates a thread proxy with this execution context. The associated thread proxy invokes this method right before it starts executing the context's                 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> method.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 An interface to the thread proxy that is about to enter the                                 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> method on this execution context.  
  
### Remarks  
 You are expected to save the parameter                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> and return it on a call to the                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> method. The Resource Manager guarantees that the thread proxy associated with the execution context will not change while the thread proxy is executing the                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> method.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [IScheduler Structure](../vs140/ischeduler-structure.md)   
 [IThreadProxy Structure](../vs140/ithreadproxy-structure.md)