---
title: "IThreadProxy Structure"
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
  - "concrtrm/concurrency::IThreadProxy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IThreadProxy structure"
ms.assetid: feb89241-a555-4e61-ad48-40add54daeca
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IThreadProxy Structure
An abstraction for a thread of execution. Depending on the             <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> policy key of the scheduler you create, the Resource Manager will grant you a thread proxy that is backed by either a regular Win32 thread or a user-mode schedulable (UMS) thread. UMS threads are supported on 64-bit operating systems with version Windows 7 and higher.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IThreadProxy::GetId Method](#ithreadproxy__getid_method)|Returns a unique identifier for the thread proxy.|  
|[IThreadProxy::SwitchOut Method](#ithreadproxy__switchout_method)|Disassociates the context from the underlying virtual processor root.|  
|[IThreadProxy::SwitchTo Method](#ithreadproxy__switchto_method)|Performs a cooperative context switch from the currently executing context to a different one.|  
|[IThreadProxy::YieldToSystem Method](#ithreadproxy__yieldtosystem_method)|Causes the calling thread to yield execution to another thread that is ready to run on the current processor. The operating system selects the next thread to be executed.|  
  
## Remarks  
 Thread proxies are coupled to execution contexts represented by the interface                 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> as a means of dispatching work.  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
##  \<a name="ithreadproxy__getid_method">\</a>  IThreadProxy::GetId Method  
 Returns a unique identifier for the thread proxy.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 A unique integer identifier.  
  
##  \<a name="ithreadproxy__switchout_method">\</a>  IThreadProxy::SwitchOut Method  
 Disassociates the context from the underlying virtual processor root.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Indicates the state of the thread proxy that is executing the switch. The parameter is of type                                 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
### Remarks  
 Use                         <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> if you need to disassociate a context from the virtual processor root it is executing on, for any reason. Depending on the value you pass in to the parameter                         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and whether or not it is executing on a virtual processor root, the call will either return immediately or block the thread proxy associated with the context. It is an error to call                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> with the parameter set to                         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Doing so will result in an                         [invalid_argument](../vs140/invalid_argument-class.md) exception.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is useful when you want to reduce the number of virtual processor roots your scheduler has, either because the Resource Manager has instructed you to do so, or because you requested a temporary oversubscribed virtual processor root, and are done with it. In this case you should invoke the method                         [IVirtualProcessorRoot::Remove Method](assetId:///ad699b4a-1972-4390-97ee-9c083ba7d9e4) on the virtual processor root, before making a call to                         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> with the parameter                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> set to                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. This will block the thread proxy and it will resume execution when a different virtual processor root in the scheduler is available to execute it. The blocking thread proxy can be resumed by calling the function                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to switch to this thread proxy's execution context. You can also resume the thread proxy, by using its associated context to activate a virtual processor root. For more information on how to do this, see                         [IVirtualProcessorRoot::Activate](../vs140/ivirtualprocessorroot-structure.md#ivirtualprocessorroot__activate_method).  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> may also be used when you want reinitialize the virtual processor so it may be activated in the future while either blocking the thread proxy or temporarily detaching it from the virtual processor root it is running on, and the scheduler it is dispatching work for. Use                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> with the parameter                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> set to                         <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> if you wish to block the thread proxy. It can later be resumed using either                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> as noted above. Use                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> with the parameter set to                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> when you want to temporarily detach this thread proxy from the virtual processor root it is running on, and the scheduler the virtual processor is associated with. Calling                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> with the parameter                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> set to                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> while it is executing on a virtual processor root will cause the root to be reinitialized and the current thread proxy to continue executing without the need for one. The thread proxy is considered to have left the scheduler until it calls the                         [IThreadProxy::SwitchOut](#ithreadproxy__switchout_method) method with                         <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> at a later point in time. The second call to                         <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> with the parameter set to                         <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is intended to return the context to a blocked state so that it can be resumed by either                         <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> or                         <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> in the scheduler it detached from. Because it was not executing on a virtual processor root, no reinitialization takes place.  
  
 A reinitialized virtual processor root is no different from a brand new virtual processor root your scheduler has been granted by the Resource Manager. You can use it for execution by activating it with an execution context using                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> must be called on the                         <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> interface that represents the currently executing thread or the results are undefined.  
  
 In the libraries and headers that shipped with Visual Studio 2010, this method did not take a parameter and did not reinitialize the virtual processor root. To preserve old behavior, the default parameter value of                         <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is supplied.  
  
##  \<a name="ithreadproxy__switchto_method">\</a>  IThreadProxy::SwitchTo Method  
 Performs a cooperative context switch from the currently executing context to a different one.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The execution context to cooperatively switch to.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 Indicates the state of the thread proxy that is executing the switch. The parameter is of type                                 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
### Remarks  
 Use this method to switch from one execution context to another, from the                         [IExecutionContext::Dispatch](../vs140/iexecutioncontext-structure.md#iexecutioncontext__dispatch_method) method of the first execution context. The method associates the execution context                         <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> with a thread proxy if it is not already associated with one. The ownership of the current thread proxy is determined by the value you specify for the                         <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> argument.  
  
 Use the value                         <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> when you want to return the currently executing thread proxy to the Resource Manager. Calling                         <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> with the parameter                         <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> set to                         <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> will cause the execution context                         <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> to start executing on the underlying execution resource. Ownership of this thread proxy is transferred to the Resource Manager, and you are expected to return from the execution context's                         <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> method soon after                         <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> returns, in order to complete the transfer. The execution context that the thread proxy was dispatching is disassociated from the thread proxy, and the scheduler is free to reuse it or destroy it as it sees fit.  
  
 Use the value                         <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> when you want this thread proxy to enter a blocked state. Calling                         <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> with the parameter                         <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> set to                         <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> will cause the execution context                         <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> to start executing, and block the current thread proxy until it is resumed. The scheduler retains ownership of the thread proxy when the thread proxy is in the                         <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> state. The blocking thread proxy can be resumed by calling the function                         <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> to switch to this thread proxy's execution context. You can also resume the thread proxy, by using its associated context to activate a virtual processor root. For more information on how to do this, see                         [IVirtualProcessorRoot::Activate](../vs140/ivirtualprocessorroot-structure.md#ivirtualprocessorroot__activate_method).  
  
 Use the value                         <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> when you want to temporarily detach this thread proxy from the virtual processor root it is running on, and the scheduler it is dispatching work for. Calling                         <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> with the parameter                         <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> set to                         <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> will cause the execution context                         <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> to start executing and the current thread proxy also continues executing without the need for a virtual processor root. The thread proxy is considered to have left the scheduler until it calls the                         [IThreadProxy::SwitchOut](#ithreadproxy__switchout_method) method at a later point in time. The                         <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> method could block the thread proxy until a virtual processor root is available to reschedule it.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> must be called on the                         <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> interface that represents the currently executing thread or the results are undefined. The function throws                         <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> if the parameter                         <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> is set to                         <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>.  
  
##  \<a name="ithreadproxy__yieldtosystem_method">\</a>  IThreadProxy::YieldToSystem Method  
 Causes the calling thread to yield execution to another thread that is ready to run on the current processor. The operating system selects the next thread to be executed.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 When called by a thread proxy backed by a regular Windows thread,                         <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> behaves exactly like the Windows function                         <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>. However, when called from user-mode schedulable (UMS) threads, the                         <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> function delegates the task of picking the next thread to run to the user mode scheduler, not the operating system. To achieve the desired effect of switching to a different ready thread in the system, use                         <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> must be called on the                         <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> interface that represents the currently executing thread or the results are undefined.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [IExecutionContext Structure](../vs140/iexecutioncontext-structure.md)   
 [IScheduler Structure](../vs140/ischeduler-structure.md)   
 [IVirtualProcessorRoot Structure](../vs140/ivirtualprocessorroot-structure.md)