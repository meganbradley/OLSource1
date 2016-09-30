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
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IScheduler::RemoveVirtualProcessors Method
Initiates the removal of virtual processor roots that were previously allocated to this scheduler.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An array of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> interfaces representing the virtual processor roots to be removed.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The number of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> interfaces in the array.  
  
## Remarks  
 The Resource Manager invokes the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method to take back a set of virtual processor roots from a scheduler. The scheduler is expected to invoke the [Remove](../vs140/iexecutionresource--remove-method.md) method on each interface when it is done with the virtual processor roots. Do not use an <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> interface once you have invoked the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method on it.  
  
 The parameter <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> points to an array of interfaces. Among the set of virtual processor roots to be removed, the roots have never been activated can be returned immediately using the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method. The roots that have been activated and are either executing work, or have been deactivated and are waiting for work to arrive, should be returned asynchronously. The scheduler must make every attempt to remove the virtual processor root as quickly as possible. Delaying removal of the virtual processor roots may result in unintentional oversubscription within the scheduler.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IScheduler Structure](../vs140/ischeduler-structure.md)   
 [IVirtualProcessorRoot Structure](../vs140/ivirtualprocessorroot-structure.md)   
 [IScheduler::RemoveVirtualProcessors Method](../vs140/ischeduler--removevirtualprocessors-method.md)