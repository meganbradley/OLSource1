---
title: "IThreadProxy::SwitchOut Method"
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
  - "concrtrm/concurrency::IThreadProxy::SwitchOut"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SwitchOut method"
ms.assetid: 4ea16cd0-3a1d-45db-b793-1edb08d2e170
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IThreadProxy::SwitchOut Method
Disassociates the context from the underlying virtual processor root.  
  
## Syntax  
  
```  
virtual void SwitchOut(  
   SwitchingProxyState switchState = Blocking  
) =0;  
```  
  
#### Parameters  
 `switchState`  
 Indicates the state of the thread proxy that is executing the switch. The parameter is of type `SwitchingProxyState`.  
  
## Remarks  
 Use `SwitchOut` if you need to disassociate a context from the virtual processor root it is executing on, for any reason. Depending on the value you pass in to the parameter `switchState`, and whether or not it is executing on a virtual processor root, the call will either return immediately or block the thread proxy associated with the context. It is an error to call `SwitchOut` with the parameter set to `Idle`. Doing so will result in an [invalid_argument](../vs140/invalid_argument-class.md) exception.  
  
 `SwitchOut` is useful when you want to reduce the number of virtual processor roots your scheduler has, either because the Resource Manager has instructed you to do so, or because you requested a temporary oversubscribed virtual processor root, and are done with it. In this case you should invoke the method [IVirtualProcessorRoot::Remove Method](assetId:///ad699b4a-1972-4390-97ee-9c083ba7d9e4) on the virtual processor root, before making a call to `SwitchOut` with the parameter `switchState` set to `Blocking`. This will block the thread proxy and it will resume execution when a different virtual processor root in the scheduler is available to execute it. The blocking thread proxy can be resumed by calling the function `SwitchTo` to switch to this thread proxy's execution context. You can also resume the thread proxy, by using its associated context to activate a virtual processor root. For more information on how to do this, see [IVirtualProcessorRoot::Activate](../vs140/ivirtualprocessorroot--activate-method.md).  
  
 `SwitchOut` may also be used when you want reinitialize the virtual processor so it may be activated in the future while either blocking the thread proxy or temporarily detaching it from the virtual processor root it is running on, and the scheduler it is dispatching work for. Use `SwitchOut` with the parameter `switchState` set to `Blocking` if you wish to block the thread proxy. It can later be resumed using either `SwitchTo` or `IVirtualProcessorRoot::Activate` as noted above. Use `SwitchOut` with the parameter set to `Nesting` when you want to temporarily detach this thread proxy from the virtual processor root it is running on, and the scheduler the virtual processor is associated with. Calling `SwitchOut` with the parameter `switchState` set to `Nesting` while it is executing on a virtual processor root will cause the root to be reinitialized and the current thread proxy to continue executing without the need for one. The thread proxy is considered to have left the scheduler until it calls the [IThreadProxy::SwitchOut](../vs140/ithreadproxy--switchout-method.md) method with `Blocking` at a later point in time. The second call to `SwitchOut` with the parameter set to `Blocking` is intended to return the context to a blocked state so that it can be resumed by either `SwitchTo` or `IVirtualProcessorRoot::Activate` in the scheduler it detached from. Because it was not executing on a virtual processor root, no reinitialization takes place.  
  
 A reinitialized virtual processor root is no different from a brand new virtual processor root your scheduler has been granted by the Resource Manager. You can use it for execution by activating it with an execution context using `IVirtualProcessorRoot::Activate`.  
  
 `SwitchOut` must be called on the `IThreadProxy` interface that represents the currently executing thread or the results are undefined.  
  
 In the libraries and headers that shipped with Visual Studio 2010, this method did not take a parameter and did not reinitialize the virtual processor root. To preserve old behavior, the default parameter value of `Blocking` is supplied.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IThreadProxy Structure](../vs140/ithreadproxy-structure.md)