---
title: "duration::operator mod= Operator"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 5e7c8e78-a52d-4e86-b57d-5a6c0620999c
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# duration::operator mod= Operator
Reduces the stored tick count modulo Div or Div.count().  
  
## Syntax  
  
```vb  
duration& operator%=(const rep& Div);duration& operator%=(const duration& Div);  
```  
  
#### Parameters  
 `Div`  
 The divisor, which is either a duration object or a value that represents tick counts.  
  
## Return Value  
 Returns *this.  
  
## Remarks  
 The first member function reduces the stored tick count modulo Div and returns *this. The second member function reduces the stored tick count modulo Div.count() and returns \*this.  
  
## Requirements  
 **Header:** <chrono\> **Namespace:** std::chrono  
  
## See Also  
 [<chrono\>](../vs140/-chrono-.md)   
 [duration Class](../vs140/duration-class.md)