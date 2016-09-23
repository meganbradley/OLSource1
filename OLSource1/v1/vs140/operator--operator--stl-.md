---
title: "operator&lt; Operator (STL)"
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
  - chrono/std::chrono::operator<
dev_langs: 
  - C++
ms.assetid: 24210870-acf2-4a18-886b-c62b0916ca5d
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# operator&lt; Operator (STL)
Determines whether one [duration](../vs140/duration-class.md) or [time_point](../vs140/time_point-class.md) object is less than another `duration` or `time_point` object.  
  
## Syntax  
  
```vb  
template<class Rep1, class Period1, class Rep2, class Period2>  
   constexpr bool operator< (  
      const duration<Rep1, Period1>& Left,  
      const duration<Rep2, Period2>& Right);  
  
template<class Clock, class Duration1, class Duration2>  
   constexpr bool operator< (  
      const time_point<Clock, Duration1>& Left,  
      const time_point<Clock, Duration2>& Right);  
```  
  
#### Parameters  
 `Left`  
 The left `duration` or `time_point` object.  
  
 `Right`  
 The right `duration` or `time_point` object.  
  
## Return Value  
 The first function returns `true` if the interval length of `Left` is less than the interval length of `Right`. Otherwise, the function returns `false`.  
  
 The second function returns `true` if `Left` precedes `Right`. Otherwise, the function returns `false`.  
  
## See Also  
 [<chrono\>](../vs140/-chrono-.md)