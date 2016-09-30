---
title: "duration::duration Constructor"
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
  - "chrono/std::chrono::duration::duration"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "chrono::duration constructor"
ms.assetid: 74edebcd-dd48-4b32-ba43-0fd0d08f40c5
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# duration::duration Constructor
Constructs a `duration` object.  
  
## Syntax  
  
```  
constexpr duration() = default;  
  
template<class Rep2>  
    constexpr explicit duration(const Rep2& R);  
  
template<class Rep2, class Period2>  
    constexpr duration(const duration<Rep2, Period2>& Dur);  
```  
  
#### Parameters  
 `Rep2`  
 An arithmetic type to represent the number of ticks.  
  
 `Period2`  
 A `std::ratio` template specialization to represent the tick period in units of seconds.  
  
 `R`  
 The number of ticks of default period.  
  
 `Dur`  
 The number of ticks of period specified by `Period2`.  
  
## Remarks  
 The default constructor constructs an object that is uninitialized. Value initialization by using empty braces initializes an object that represents a time interval of zero clock ticks.  
  
 The second, one template argument constructor constructs an object that represents a time interval of `R` clock ticks using a default period of `std::ratio<1>`. To avoid round-off of tick counts, it is an error to construct a duration object from a representation type `Rep2` that can be treated as a floating-point type when `duration::rep` cannot be treated as a floating-point type.  
  
 The third, two template argument constructor constructs an object that represents a time interval whose length is the time interval that is specified by `Dur`. To avoid truncation of tick counts, it is an error to construct a duration object from another duration object whose type is *incommensurable* with the target type.  
  
 A duration type `D1` is *incommensurable* with another duration type `D2` if `D2` cannot be treated as a floating-point type and [ratio_divide\<D1::period, D2::period>::type::den](../vs140/-ratio-.md) is not 1.  
  
 Unless `Rep2` is implicitly convertible to `rep` and either `treat_as_floating_point<rep>`*holds true* or `treat_as_floating_point<Rep2>`*holds false*, the second constructor does not participate in overload resolution. For more information, see [<type_traits>](../vs140/-type_traits-.md).  
  
 Unless no overflow is induced in the conversion and `treat_as_floating_point<rep>`*holds true*,  or both `ratio_divide<Period2, period>::den` equals 1 and `treat_as_floating_point<Rep2>`*holds false*, the third constructor does not participate in overload resolution. For more information, see [<type_traits>](../vs140/-type_traits-.md).  
  
## Requirements  
 **Header:** chrono  
  
 **Namespace:** std::chrono  
  
## See Also  
 [duration Class](../vs140/duration-class.md)   
 [\<chrono>](../vs140/-chrono-.md)   
 [treat_as_floating_point Structure](../vs140/treat_as_floating_point-structure.md)