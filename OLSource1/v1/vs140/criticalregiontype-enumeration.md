---
title: "CriticalRegionType Enumeration"
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
  - "concrtrm/concurrency::CriticalRegionType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CriticalRegionType enumeration"
ms.assetid: e08c60a8-4a81-4c2d-af3f-320ffa7a1eba
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CriticalRegionType Enumeration
The type of critical region a context is inside.  
  
## Syntax  
  
```  
enum CriticalRegionType;  
```  
  
## Members  
  
### Values  
  
|Name|Description|  
|----------|-----------------|  
|`InsideCriticalRegion`|Indicates that the context is inside a critical region. When inside a critical region, asynchronous suspensions are hidden from the scheduler. Should such a suspension happen, the Resource Manager will wait for the thread to become runnable and simply resume it instead of invoking the scheduler again. Any locks taken inside such a region must be taken with extreme care.|  
|`InsideHyperCriticalRegion`|Indicates that the context is inside a hyper-critical region. When inside a hyper-critical region, both synchronous and asynchronous suspensions are hidden from the scheduler. Should such a suspension or blocking happen, the resource manager will wait for the thread to become runnable and simply resume it instead of invoking the scheduler again. Locks taken inside such a region must never be shared with code running outside such a region. Doing so will cause unpredictable deadlock.|  
|`OutsideCriticalRegion`|Indicates that the context is outside any critical region.|  
  
## Requirements  
 **Header:** concrtrm.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [IUMSThreadProxy Structure](../vs140/iumsthreadproxy-structure.md)