---
title: "IVirtualProcessorRoot::Activate Method"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - concrtrm/concurrency::IVirtualProcessorRoot::Activate
dev_langs: 
  - C++
helpviewer_keywords: 
  - Activate method
ms.assetid: 6fb6f9a6-9110-4c74-b911-b9ee9c7643b7
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IVirtualProcessorRoot::Activate Method
Causes the thread proxy associated with the execution context interface `pContext` to start executing on this virtual processor root.  
  
## Syntax  
  
```  
virtual void Activate(  
   _Inout_ IExecutionContext * pContext  
) =0;  
```  
  
#### Parameters  
 `pContext`  
 An interface to the execution context that will be dispatched on this virtual processor root.  
  
## Remarks  
 The Resource Manager will supply a thread proxy if one is not associated with the execution context interface `pContext`  
  
 The `Activate` method can be used to start executing work on a new virtual processor root returned by the Resource Manager, or to resume the thread proxy on a virtual processor root that has deactivated or is about to deactivate. See [IVirtualProcessorRoot::Deactivate](../vs140/ivirtualprocessorroot--deactivate-method.md) for more information on deactivation. When you are resuming a deactivated virtual processor root, the parameter `pContext` must be the same as the parameter used to deactivate the virtual processor root.  
  
 Once a virtual processor root has been activated for the first time, subsequent pairs of calls to `Deactivate` and `Activate` may race with each other. This means it is acceptable for the Resource Manager to receive a call to `Activate` before it receives the `Deactivate` call it was meant for.  
  
 When you activate a virtual processor root, you signal to the Resource Manager that this virtual processor root is currently busy with work. If your scheduler cannot find any work to execute on this root, it is expected to invoke the `Deactivate` method informing the Resource Manager that the virtual processor root is idle. The Resource Manager uses this data to load balance the system.  
  
 `invalid_argument` is thrown if the argument `pContext` has the value `NULL`.  
  
 `invalid_operation` is thrown if the argument `pContext` does not represent the execution context that was most recently dispatched by this virtual processor root.  
  
 The act of activating a virtual processor root increases the subscription level of the underlying hardware thread by one. For more information on subscription levels, see [IExecutionResource::CurrentSubscriptionLevel](../vs140/iexecutionresource--currentsubscriptionlevel-method.md).  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IVirtualProcessorRoot Structure](../vs140/ivirtualprocessorroot-structure.md)   
 [IVirtualProcessorRoot::Deactivate Method](../vs140/ivirtualprocessorroot--deactivate-method.md)   
 [IExecutionResource::CurrentSubscriptionLevel Method](../vs140/iexecutionresource--currentsubscriptionlevel-method.md)