---
title: "duration::operator-- Operator"
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
  - "chrono/std::chrono::duration::operator--"
dev_langs: 
  - "C++"
ms.assetid: 5b6bbc73-9ed0-43dc-a467-008335186bf6
caps.latest.revision: 10
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# duration::operator-- Operator
Decrements the stored tick count.  
  
## Syntax  
  
```  
duration& operator--();  
duration operator--(int);  
```  
  
## Return Value  
 The first method returns `*this`.  
  
 The second method returns a copy of `*this` that is made before the decrement.  
  
## Requirements  
 **Header:** chrono  
  
 **Namespace:** std::chrono  
  
## See Also  
 [duration Class](../vs140/duration-class.md)   
 [\<chrono>](../vs140/-chrono-.md)