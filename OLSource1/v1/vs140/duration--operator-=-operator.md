---
title: "duration::operator+= Operator"
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
  - "chrono/std::chrono::duration::operator+="
dev_langs: 
  - "C++"
ms.assetid: 23dcb43a-56a2-443b-9c06-8f1a53f18c8d
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# duration::operator+= Operator
Adds the tick count of a specified `duration` object to the stored tick count.  
  
## Syntax  
  
```  
duration& operator+=(const duration& Dur);  
```  
  
#### Parameters  
 `Dur`  
 A `duration` object.  
  
## Return Value  
 The `duration` object after the addition is performed.  
  
## Requirements  
 **Header:** chrono  
  
 **Namespace:** std::chrono  
  
## See Also  
 [duration Class](../vs140/duration-class.md)   
 [<chrono\>](../vs140/-chrono-.md)