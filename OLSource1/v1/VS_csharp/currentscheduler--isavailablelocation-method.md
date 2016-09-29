---
title: "CurrentScheduler::IsAvailableLocation Method"
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
  - "concrt/concurrency::CurrentScheduler::IsAvailableLocation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsAvailableLocation method"
ms.assetid: 2e17725a-98b3-4c34-8bf9-db2885d70bec
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CurrentScheduler::IsAvailableLocation Method
Determines whether a given location is available on the current scheduler.  
  
## Syntax  
  
```  
static bool __cdecl IsAvailableLocation(  
   const location& _Placement  
);  
```  
  
#### Parameters  
 `_Placement`  
 A reference to the location to query the current scheduler about.  
  
## Return Value  
 An indication of whether or not the location specified by the `_Placement` argument is available on the current scheduler.  
  
## Remarks  
 This method will not result in scheduler attachment if the calling context is not already associated with a scheduler.  
  
 Note that the return value is an instantaneous sampling of whether the given location is available. In the presence of multiple schedulers, dynamic resource management can add or take away resources from schedulers at any point. Should this happen, the given location can change availability.  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [CurrentScheduler Class](../VS_csharp/currentscheduler-class.md)