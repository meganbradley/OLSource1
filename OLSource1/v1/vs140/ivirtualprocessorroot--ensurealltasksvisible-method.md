---
title: "IVirtualProcessorRoot::EnsureAllTasksVisible Method"
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
  - "concrtrm/concurrency::IVirtualProcessorRoot::EnsureAllTasksVisible"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnsureAllTasksVisible method"
ms.assetid: cdba9376-e5e4-4602-b891-4fc1a4999840
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IVirtualProcessorRoot::EnsureAllTasksVisible Method
Causes data stored in the memory hierarchy of individual processors to become visible to all processors on the system. It ensures that a full memory fence has been executed on all processors before the method returns.  
  
## Syntax  
  
```  
virtual void EnsureAllTasksVisible(  
   _Inout_ IExecutionContext *pContext  
) =0;  
```  
  
#### Parameters  
 `pContext`  
 The context which is currently being dispatched by this virtual processor root.  
  
## Remarks  
 You may find this method useful when you want to synchronize deactivation of a virtual processor root with the addition of new work into the scheduler. For performance reasons, you may decide to add work items to your scheduler without executing a memory barrier, which means work items added by a thread executing on one processor are not immediately visible to all other processors. By using this method in conjunction with the `Deactivate` method you can ensure that your scheduler does not deactivate all its virtual processor roots while work items exist in your scheduler's collections.  
  
 A call to the `EnsureAllTasksVisibleThe` method must originate from within the `Dispatch` method of the execution context that the virtual processor root was last activated with. In other words, the thread proxy invoking the `EnsureAllTasksVisible` method must be the one that is currently executing on the virtual processor root. Calling the method on a virtual processor root you are not executing on could result in undefined behavior.  
  
 `invalid_argument` is thrown if the argument `pContext` has the value `NULL`.  
  
 `invalid_operation` is thrown if the virtual processor root has never been activated, or the argument `pContext` does not represent the execution context that was most recently dispatched by this virtual processor root.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IVirtualProcessorRoot Structure](../vs140/ivirtualprocessorroot-structure.md)   
 [IVirtualProcessorRoot::Deactivate Method](../vs140/ivirtualprocessorroot--deactivate-method.md)