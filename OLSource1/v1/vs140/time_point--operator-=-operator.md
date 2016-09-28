---
title: "time_point::operator+= Operator"
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
  - "chrono/std::chrono::time_point::operator+="
dev_langs: 
  - "C++"
ms.assetid: 7ae814c0-0b78-4db9-8613-c2aa8ed4aae6
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# time_point::operator+= Operator
Adds a specified value to the stored [duration](../vs140/duration-class.md) value.  
  
## Syntax  
  
```  
time_point& operator+=(  
   const duration& Dur  
);  
```  
  
#### Parameters  
 `Dur`  
 A `duration` object.  
  
## Return Value  
 The `time_point` object after the addition is performed.  
  
## Requirements  
 **Header:** chrono  
  
 **Namespace:** std::chrono  
  
## See Also  
 [time_point Class](../vs140/time_point-class.md)   
 [<chrono\>](../vs140/-chrono-.md)