---
title: "operator modulo (STL)"
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
  - chrono/std::chrono::operator%
dev_langs: 
  - C++
ms.assetid: a1a7ff32-04f4-4470-8884-0a920c596c28
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# operator modulo (STL)
Operator for modulo operations on [duration](../vs140/duration-class.md) objects.  
  
## Syntax  
  
```  
template<class Rep1, class Period1, class Rep2>  
   constexpr duration<Rep1, Period1, Rep2>::type  
   operator%(  
      const duration<Rep1, Period1>& Dur,  
      const Rep2& Div);  
template<class Rep1, class Period1, class Rep2, class Period2>  
   constexpr typename common_type<duration<Rep1, _Period1>,                            duration<Rep2, Period2>>::type  
   operator%(  
      const duration<Rep1, Period1>& Left,  
      const duration<Rep2, Period2>& Right);  
```  
  
#### Parameters  
 `Dur`  
 A `duration` object.  
  
 `Div`  
 An integral value.  
  
 `Left`  
 The left `duration` object.  
  
 `Right`  
 The right `duration` object.  
  
## Return Value  
 The first function returns a `duration` object whose interval length is `Dur` modulo `Div`.  
  
 The second function returns a value that represents `Left` modulo `Right`.  
  
## Requirements  
 **Header:** chrono  
  
 **Namespace:** std::chrono  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)