---
title: "time_point::max Method"
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
  - "chrono/std::chrono::time_point::max"
dev_langs: 
  - "C++"
ms.assetid: 9effc0c3-531c-4151-b81b-2c204f919756
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# time_point::max Method
Static method that returns the upper bound for values of type `time_point::ref`.  
  
## Syntax  
  
```  
static constexpr time_point max();  
```  
  
## Return Value  
 In effect, returns `time_point(duration::max())`.  
  
## Requirements  
 **Header:** chrono  
  
 **Namespace:** std::chrono  
  
## See Also  
 [time_point Class](../vs140/time_point-class.md)   
 [duration::max](../vs140/duration--max-method.md)   
 [<chrono\>](../vs140/-chrono-.md)