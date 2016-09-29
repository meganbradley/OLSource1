---
title: "Scheduler::IsAvailableLocation Method"
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
  - "concrt/concurrency::Scheduler::IsAvailableLocation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsAvailableLocation method"
ms.assetid: 3507a776-b920-4851-a587-e91416d386a5
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Scheduler::IsAvailableLocation Method
Determines whether a given location is available on the scheduler.  
  
## Syntax  
  
```  
virtual bool IsAvailableLocation(  
   const location& _Placement  
) const =0;  
```  
  
#### Parameters  
 `_Placement`  
 A reference to the location to query the scheduler about.  
  
## Return Value  
 An indication of whether or not the location specified by the `_Placement` argument is available on the scheduler.  
  
## Remarks  
 Note that the return value is an instantaneous sampling of whether the given location is available. In the presence of multiple schedulers, dynamic resource management can add or take away resources from schedulers at any point. Should this happen, the given location can change availability.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [Scheduler Class](../vs140/scheduler-class.md)