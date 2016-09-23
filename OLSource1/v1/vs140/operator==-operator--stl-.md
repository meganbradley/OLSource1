---
title: "operator== Operator (STL)"
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
  - chrono/std::chrono::operator==
dev_langs: 
  - C++
ms.assetid: 4da8f645-2b39-4a42-bcc4-44eef3553520
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# operator== Operator (STL)
Determines whether two `duration` objects represent time intervals that have the same length, or whether two `time_point` objects represent the same point in time.  
  
## Syntax  
  
```  
template<class Rep1, class Period1, class Rep2, class Period2>  
   constexpr bool operator==(  
      const duration<Rep1, Period1>& Left,  
      const duration<Rep2, Period2>& Right);  
  
template<class Clock, class Duration1, class Duration2>  
   constexpr bool operator==(  
      const time_point<Clock, Duration1>& Left,  
      const time_point<Clock, Duration2>& Right);  
```  
  
#### Parameters  
 `Left`  
 The left `duration` or `time_point` object.  
  
 `Right`  
 The right `duration` or `time_point` object.  
  
## Return Value  
 The first function returns `true` if `Left` and `Right` represent time intervals that have the same length. Otherwise, the function returns `false`.  
  
 The second function returns `true` if `Left` and `Right` represent the same point in time. Otherwise, the function returns `false`.  
  
## Requirements  
 **Header:** chrono  
  
 **Namespace:** std::chrono  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [<chrono\>](../vs140/-chrono-.md)