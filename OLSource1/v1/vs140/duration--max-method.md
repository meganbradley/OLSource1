---
title: "duration::max Method"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - chrono/std::chrono::duration::max
dev_langs: 
  - C++
ms.assetid: 5b4a1f5b-1597-425a-bf31-b0089082fff6
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# duration::max Method
Static method that returns the upper bound for values of template parameter type `Ref`.  
  
## Syntax  
  
```  
static constexpr duration max();  
```  
  
## Return Value  
 In effect, returns `duration(duration_values<rep>::max())`.  
  
## Requirements  
 **Header:** chrono  
  
 **Namespace:** std::chrono  
  
## See Also  
 [duration Class](../vs140/duration-class.md)   
 [duration_values Structure](../vs140/duration_values-structure.md)   
 [<chrono\>](../vs140/-chrono-.md)