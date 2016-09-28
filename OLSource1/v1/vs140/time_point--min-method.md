---
title: "time_point::min Method"
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
  - "chrono/std::chrono::time_point::min"
dev_langs: 
  - "C++"
ms.assetid: 47b224c7-6add-45a3-bdd9-3372ae45555c
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# time_point::min Method
Static method that returns the lower bound for values of type `time_point::ref`.  
  
## Syntax  
  
```  
static constexpr time_point min();  
```  
  
## Return Value  
 In effect, returns `time_point(duration::min())`.  
  
## Requirements  
 **Header:** chrono  
  
 **Namespace:** std::chrono  
  
## See Also  
 [time_point Class](../vs140/time_point-class.md)   
 [duration::min](../vs140/duration--min-method.md)   
 [<chrono\>](../vs140/-chrono-.md)