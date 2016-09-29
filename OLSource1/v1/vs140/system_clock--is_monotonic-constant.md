---
title: "system_clock::is_monotonic Constant"
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
  - "chrono/std::chrono::system_clock::is_monotonic"
dev_langs: 
  - "C++"
ms.assetid: 27a9218e-c33e-4d29-a927-d12d276347c9
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# system_clock::is_monotonic Constant
Static value that specifies whether the clock type is monotonic.  
  
## Syntax  
  
```  
static const bool is_monotonic = false;  
```  
  
## Return Value  
 In this implementation, `system_clock::is_monotonic` always returns `false`.  
  
## Remarks  
 A clock is *monotonic* if the value that is returned by a first call to `now()` is always less than or equal to the value that is returned by a subsequent call to `now()`.  
  
## Requirements  
 **Header:** chrono  
  
 **Namespace:** std::chrono  
  
## See Also  
 [system_clock Structure](../vs140/system_clock-structure.md)   
 [\<chrono>](../vs140/-chrono-.md)