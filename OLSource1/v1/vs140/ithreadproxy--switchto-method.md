---
title: "IThreadProxy::SwitchTo Method"
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
  - "concrtrm/concurrency::IThreadProxy::SwitchTo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SwitchTo method"
ms.assetid: 680a5f5e-db85-4bf2-9739-9c9a0b662984
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IThreadProxy::SwitchTo Method
Performs a cooperative context switch from the currently executing context to a different one.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The execution context to cooperatively switch to.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Indicates the state of the thread proxy that is executing the switch. The parameter is of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 Use this method to switch from one execution context to another, from the [IExecutionContext::Dispatch](../vs140/iexecutioncontext--dispatch-method.md) method of the first execution context. The method associates the execution context <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> with a thread proxy if it is not already associated with one. The ownership of the current thread proxy is determined by the value you specify for the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> argument.  
  
 Use the value <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> when you want to return the currently executing thread proxy to the Resource Manager. Calling <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> with the parameter <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> will cause the execution context <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to start executing on the underlying execution resource. Ownership of this thread proxy is transferred to the Resource Manager, and you are expected to return from the execution context's <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method soon after <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> returns, in order to complete the transfer. The execution context that the thread proxy was dispatching is disassociated from the thread proxy, and the scheduler is free to reuse it or destroy it as it sees fit.  
  
 Use the value <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> when you want this thread proxy to enter a blocked state. Calling <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> with the parameter <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> will cause the execution context <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to start executing, and block the current thread proxy until it is resumed. The scheduler retains ownership of the thread proxy when the thread proxy is in the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> state. The blocking thread proxy can be resumed by calling the function <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to switch to this thread proxy's execution context. You can also resume the thread proxy, by using its associated context to activate a virtual processor root. For more information on how to do this, see [IVirtualProcessorRoot::Activate](../vs140/ivirtualprocessorroot--activate-method.md).  
  
 Use the value <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> when you want to temporarily detach this thread proxy from the virtual processor root it is running on, and the scheduler it is dispatching work for. Calling <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> with the parameter <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> will cause the execution context <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to start executing and the current thread proxy also continues executing without the need for a virtual processor root. The thread proxy is considered to have left the scheduler until it calls the [IThreadProxy::SwitchOut](../vs140/ithreadproxy--switchout-method.md) method at a later point in time. The <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> method could block the thread proxy until a virtual processor root is available to reschedule it.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> must be called on the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> interface that represents the currently executing thread or the results are undefined. The function throws <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> if the parameter <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IThreadProxy Structure](../vs140/ithreadproxy-structure.md)   
 [SwitchingProxyState Enumeration](../vs140/switchingproxystate-enumeration.md)