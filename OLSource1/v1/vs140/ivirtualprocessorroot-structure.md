---
title: "IVirtualProcessorRoot Structure"
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
  - "concrtrm/concurrency::IVirtualProcessorRoot"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IVirtualProcessorRoot structure"
ms.assetid: 5ef371b8-9e4f-4fef-bb0d-49099693dd2b
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IVirtualProcessorRoot Structure
An abstraction for a hardware thread on which a thread proxy can execute.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IVirtualProcessorRoot::Activate Method](#ivirtualprocessorroot__activate_method)|Causes the thread proxy associated with the execution context interface                                         <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to start executing on this virtual processor root.|  
|[IVirtualProcessorRoot::Deactivate Method](#ivirtualprocessorroot__deactivate_method)|Causes the thread proxy currently executing on this virtual processor root to stop dispatching the execution context. The thread proxy will resume executing on a call to the                                         <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method.|  
|[IVirtualProcessorRoot::EnsureAllTasksVisible Method](#ivirtualprocessorroot__ensurealltasksvisible_method)|Causes data stored in the memory hierarchy of individual processors to become visible to all processors on the system. It ensures that a full memory fence has been executed on all processors before the method returns.|  
|[IVirtualProcessorRoot::GetId Method](#ivirtualprocessorroot__getid_method)|Returns a unique identifier for the virtual processor root.|  
  
## Remarks  
 Every virtual processor root has an associated execution resource. The                 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> interface inherits from the                 [IExecutionResource](../vs140/iexecutionresource-structure.md) interface. Multiple virtual processor roots may correspond to the same underlying hardware thread.  
  
 The Resource Manager grants virtual processor roots to schedulers in response to requests for resources. A scheduler can use a virtual processor root to perform work by activating it with an execution context.  
  
## Inheritance Hierarchy  
 [IExecutionResource](../vs140/iexecutionresource-structure.md)  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
##  \<a name="ivirtualprocessorroot__activate_method">\</a>  IVirtualProcessorRoot::Activate Method  
 Causes the thread proxy associated with the execution context interface                 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to start executing on this virtual processor root.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 An interface to the execution context that will be dispatched on this virtual processor root.  
  
### Remarks  
 The Resource Manager will supply a thread proxy if one is not associated with the execution context interface                         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 The                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method can be used to start executing work on a new virtual processor root returned by the Resource Manager, or to resume the thread proxy on a virtual processor root that has deactivated or is about to deactivate. See                         [IVirtualProcessorRoot::Deactivate](#ivirtualprocessorroot__deactivate_method) for more information on deactivation. When you are resuming a deactivated virtual processor root, the parameter                         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> must be the same as the parameter used to deactivate the virtual processor root.  
  
 Once a virtual processor root has been activated for the first time, subsequent pairs of calls to                         <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and                         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> may race with each other. This means it is acceptable for the Resource Manager to receive a call to                         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> before it receives the                         <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> call it was meant for.  
  
 When you activate a virtual processor root, you signal to the Resource Manager that this virtual processor root is currently busy with work. If your scheduler cannot find any work to execute on this root, it is expected to invoke the                         <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> method informing the Resource Manager that the virtual processor root is idle. The Resource Manager uses this data to load balance the system.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is thrown if the argument                         <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> has the value                         <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is thrown if the argument                         <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> does not represent the execution context that was most recently dispatched by this virtual processor root.  
  
 The act of activating a virtual processor root increases the subscription level of the underlying hardware thread by one. For more information on subscription levels, see                         [IExecutionResource::CurrentSubscriptionLevel](../vs140/iexecutionresource-structure.md#iexecutionresource__currentsubscriptionlevel_method).  
  
##  \<a name="ivirtualprocessorroot__deactivate_method">\</a>  IVirtualProcessorRoot::Deactivate Method  
 Causes the thread proxy currently executing on this virtual processor root to stop dispatching the execution context. The thread proxy will resume executing on a call to the                 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> method.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 The context which is currently being dispatched by this root.  
  
### Return Value  
 A boolean value. A value of                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> indicates that the thread proxy returned from the                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> method in response to a call to the                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> method. A value of                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> indicates that the thread proxy returned from the method in response to a notification event in the Resource Manager. On a user-mode schedulable (UMS) thread scheduler, this indicates that items have appeared on the scheduler's completion list, and the scheduler is required to handle them.  
  
### Remarks  
 Use this method to temporarily stop executing a virtual processor root when you cannot find any work in your scheduler. A call to the                         <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> method must originate from within the                         <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> method of the execution context that the virtual processor root was last activated with. In other words, the thread proxy invoking the                         <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> method must be the one that is currently executing on the virtual processor root. Calling the method on a virtual processor root you are not executing on could result in undefined behavior.  
  
 A deactivated virtual processor root may be woken up with a call to the                         <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> method, with the same argument that was passed in to the                         <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> method. The scheduler is responsible for ensuring that calls to the                         <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and                         <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> methods are paired, but they are not required to be received in a specific order. The Resource Manager can handle receiving a call to the                         <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> method before it receives a call to the                         <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> method it was meant for.  
  
 If a virtual processor root awakens and the return value from the                         <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> method is the value                         <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, the scheduler should query the UMS completion list via the                         <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> method, act on that information, and then subsequently call the                         <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> method again. This should be repeated until such time as the                         <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> method returns the value                         <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> is thrown if the argument                         <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> has the value                         <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> is thrown if the virtual processor root has never been activated, or the argument                         <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> does not represent the execution context that was most recently dispatched by this virtual processor root.  
  
 The act of deactivating a virtual processor root decreases the subscription level of the underlying hardware thread by one. For more information on subscription levels, see                         [IExecutionResource::CurrentSubscriptionLevel](../vs140/iexecutionresource-structure.md#iexecutionresource__currentsubscriptionlevel_method).  
  
##  \<a name="ivirtualprocessorroot__ensurealltasksvisible_method">\</a>  IVirtualProcessorRoot::EnsureAllTasksVisible Method  
 Causes data stored in the memory hierarchy of individual processors to become visible to all processors on the system. It ensures that a full memory fence has been executed on all processors before the method returns.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The context which is currently being dispatched by this virtual processor root.  
  
### Remarks  
 You may find this method useful when you want to synchronize deactivation of a virtual processor root with the addition of new work into the scheduler. For performance reasons, you may decide to add work items to your scheduler without executing a memory barrier, which means work items added by a thread executing on one processor are not immediately visible to all other processors. By using this method in conjunction with the                         <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> method you can ensure that your scheduler does not deactivate all its virtual processor roots while work items exist in your scheduler's collections.  
  
 A call to the                         <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> method must originate from within the                         <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> method of the execution context that the virtual processor root was last activated with. In other words, the thread proxy invoking the                         <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> method must be the one that is currently executing on the virtual processor root. Calling the method on a virtual processor root you are not executing on could result in undefined behavior.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> is thrown if the argument                         <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> has the value                         <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> is thrown if the virtual processor root has never been activated, or the argument                         <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> does not represent the execution context that was most recently dispatched by this virtual processor root.  
  
##  \<a name="ivirtualprocessorroot__getid_method">\</a>  IVirtualProcessorRoot::GetId Method  
 Returns a unique identifier for the virtual processor root.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 An integer identifier.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)