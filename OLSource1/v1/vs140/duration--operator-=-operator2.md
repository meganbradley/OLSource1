---
title: "duration::operator-= Operator2"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "duration::operator-= Operator"
f1_keywords: 
  - "chrono/std::chrono::duration::operator-="
dev_langs: 
  - "C++"
ms.assetid: 4aa49dde-e403-492c-8f95-a08f60e6ad9c
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# duration::operator-= Operator2
Subtracts the tick count of a specified `duration` object from the stored tick count.  
  
## Syntax  
  
```  
duration& operator-=(const duration& Dur);  
```  
  
#### Parameters  
 `Dur`  
 A `duration` object.  
  
## Return Value  
 The `duration` object after the subtraction is performed.  
  
## Requirements  
 **Header:** chrono  
  
 **Namespace:** std::chrono  
  
## See Also  
 [duration Class](../vs140/duration-class.md)   
 [<chrono\>](../vs140/-chrono-.md)