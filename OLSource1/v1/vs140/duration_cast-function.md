---
title: "duration_cast Function"
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
  - chrono/std::chrono::duration_cast
dev_langs: 
  - C++
ms.assetid: a1ae21ae-1af3-4fc4-a7e8-5209efff1bb2
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# duration_cast Function
Casts a `duration` object to a specified type.  
  
## Syntax  
  
```  
template<class To, class Rep, class Period>  
    constexpr To duration_cast(const duration<Rep, Period>& Dur);  
```  
  
## Return Value  
 A `duration` object of type `To` that represents the time interval `Dur`, which is truncated if it has to fit into the target type.  
  
## Remarks  
 If `To` is an instantiation of `duration`, this function does not participate in overload resolution.  
  
## Requirements  
 **Header:** chrono  
  
 **Namespace:** std::chrono  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [<chrono\>](../vs140/-chrono-.md)   
 [duration Class](../vs140/duration-class.md)