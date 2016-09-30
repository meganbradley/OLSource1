---
title: "operator- Operator (STL)2"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "operator/ Operator (STL)"
f1_keywords: 
  - "chrono/std::chrono::operator/"
dev_langs: 
  - "C++"
ms.assetid: 587b6663-61d2-4028-8283-92a251820c1f
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator- Operator (STL)2
Division operator for [duration](../vs140/operator--operator--stl-.md) objects.  
  
## Syntax  
  
```  
template<class Rep1, class Period1, class Rep2>  
   constexpr duration<typename common_type<Rep1, Rep2>::type, Period1>  
   operator/(  
      const duration<Rep1, Period1>& Dur,  
      const Rep2& Div);  
  
template<class Rep1, class Period1, class Rep2, class Period2>  
   constexpr typename common_type<Rep1, Rep2>::type  
   operator/(  
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
 The first operator returns a duration object whose interval length is the length of `Dur` divided by the value `Div`.  
  
 The second operator returns the ratio of the interval lengths of `Left` and `Right`.  
  
 Unless `is_convertible<Rep2, common_type<Rep1, Rep2>>`*holds true*, and `Rep2` is not an instantiation of `duration`, the first operator does not participate in overload resolution. For more information, see [\<type_traits>](../vs140/-type_traits-.md).  
  
## Requirements  
 **Header:** chrono  
  
 **Namespace:** std::chrono  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<chrono>](../vs140/-chrono-.md)