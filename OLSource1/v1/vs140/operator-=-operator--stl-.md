---
title: "operator&gt;= Operator (STL)"
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
  - "chrono/std::chrono::operator>="
dev_langs: 
  - "C++"
ms.assetid: 8d188768-5173-4eb5-bfe2-9b1fcc498523
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&gt;= Operator (STL)
Determines whether one [duration](../vs140/duration-class.md) or [time_point](../vs140/time_point-class.md) object is greater than or equal to another `duration` or `time_point` object.  
  
## Syntax  
  
```  
template<class Rep1, class Period1, class Rep2, class Period2>  
   constexpr bool operator>=(  
      const duration<Rep1, Period1>& Left,  
      const duration<Rep2, Period2>& Right);  
  
template<class Clock, class Duration1, class Duration2>  
   constexpr bool operator>=(  
      const time_point<Clock, Duration1>& Left,  
      const time_point<Clock, Duration2>& Right);  
```  
  
#### Parameters  
 `Left`  
 The left `duration` or `time_point` object.  
  
 `Right`  
 The right `duration` or `time_point` object.  
  
## Return Value  
 Each function returns `!(Left < Right)`.  
  
## Requirements  
 **Header:** chrono  
  
 **Namespace:** std::chrono  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [<chrono\>](../vs140/-chrono-.md)