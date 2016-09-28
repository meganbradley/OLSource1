---
title: "IScheduler::RemoveVirtualProcessors Method"
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
  - "concrtrm/concurrency::IScheduler::RemoveVirtualProcessors"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveVirtualProcessors method"
ms.assetid: 4046ec0e-48c4-444f-aee5-8f208af74b95
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IScheduler::RemoveVirtualProcessors Method
Initiates the removal of virtual processor roots that were previously allocated to this scheduler.  
  
## Syntax  
  
```  
virtual void RemoveVirtualProcessors(  
   _In_reads_(count) IVirtualProcessorRoot ** ppVirtualProcessorRoots,  
   unsigned int count  
) =0;  
```  
  
#### Parameters  
 `ppVirtualProcessorRoots`  
 An array of `IVirtualProcessorRoot` interfaces representing the virtual processor roots to be removed.  
  
 `count`  
 The number of `IVirtualProcessorRoot` interfaces in the array.  
  
## Remarks  
 The Resource Manager invokes the `RemoveVirtualProcessors` method to take back a set of virtual processor roots from a scheduler. The scheduler is expected to invoke the [Remove](../vs140/iexecutionresource--remove-method.md) method on each interface when it is done with the virtual processor roots. Do not use an `IVirtualProcessorRoot` interface once you have invoked the `Remove` method on it.  
  
 The parameter `ppVirtualProcessorRoots` points to an array of interfaces. Among the set of virtual processor roots to be removed, the roots have never been activated can be returned immediately using the `Remove` method. The roots that have been activated and are either executing work, or have been deactivated and are waiting for work to arrive, should be returned asynchronously. The scheduler must make every attempt to remove the virtual processor root as quickly as possible. Delaying removal of the virtual processor roots may result in unintentional oversubscription within the scheduler.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IScheduler Structure](../vs140/ischeduler-structure.md)   
 [IVirtualProcessorRoot Structure](../vs140/ivirtualprocessorroot-structure.md)   
 [IScheduler::RemoveVirtualProcessors Method](../vs140/ischeduler--removevirtualprocessors-method.md)