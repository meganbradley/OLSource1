---
title: "IScheduler::AddVirtualProcessors Method"
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
  - "concrtrm/concurrency::IScheduler::AddVirtualProcessors"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddVirtualProcessors method"
ms.assetid: 6225fe81-f56b-4312-9d96-35b71b3f8fd3
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IScheduler::AddVirtualProcessors Method
Provides a scheduler with a set of virtual processor roots for its use. Each <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface represents the right to execute a single thread that can perform work on behalf of the scheduler.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An array of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> interfaces representing the virtual processor roots being added to the scheduler.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The number of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> interfaces in the array.  
  
## Remarks  
 The Resource Manager invokes the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method to grant an initial set of virtual processor roots to a scheduler. It could also invoke the method to add virtual processor roots to the scheduler when it rebalances resources among schedulers.  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [IScheduler Structure](../vs140/ischeduler-structure.md)   
 [IVirtualProcessorRoot Structure](../vs140/ivirtualprocessorroot-structure.md)   
 [IScheduler::RemoveVirtualProcessors Method](../vs140/ischeduler--removevirtualprocessors-method.md)