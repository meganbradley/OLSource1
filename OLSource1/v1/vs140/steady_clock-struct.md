---
title: "steady_clock struct"
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
  - "chrono/std::chrono::steady_clock"
dev_langs: 
  - "C++"
ms.assetid: 970d12ec-fc80-4391-a2f7-b57b2aec668d
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# steady_clock struct
Represents a `steady` clock.  
  
## Syntax  
  
```  
struct steady_clock;  
```  
  
## Remarks  
 On Windows, steady_clock wraps the QueryPerformanceCounter function.  
  
 A clock is *monotonic* if the value that is returned by a first call to `now()` is always less than or equal to the value that is returned by a subsequent call to `now()`.  
  
 A clock is *steady* if it is *monotonic* and if the time between clock ticks is constant.  
  
 High_resolution_clock is a typdef for steady_clock.  
  
## Public functions  
  
|Function|Description|  
|--------------|-----------------|  
|now|Returns the current time as a time_point value.|  
  
## Public Constants  
  
|Name|Description|  
|----------|-----------------|  
|`system_clock::is_steady`|Holds `true`. A `steady_clock` is *steady*.|  
  
## Requirements  
 **Header:** chrono  
  
 **Namespace:** std::chrono  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<chrono>](../vs140/-chrono-.md)   
 [system_clock Structure](../vs140/system_clock-structure.md)