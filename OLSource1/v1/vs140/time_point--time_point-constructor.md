---
title: "time_point::time_point Constructor"
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
  - "chrono/std::chrono::time_point::time_point"
dev_langs: 
  - "C++"
ms.assetid: 7dbe4eb0-dcd1-47fa-900c-fd24e5ea8d12
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# time_point::time_point Constructor
Constructs a `time_point` object.  
  
## Syntax  
  
```  
constexpr time_point();  
constexpr explicit time_point(const duration& Dur);  
template<class Duration2>  
    constexpr time_point(const time_point<clock, Duration2>& Tp);  
```  
  
#### Parameters  
 `Dur`  
 A [duration](../vs140/duration-class.md) object.  
  
 `Tp`  
 A `time_point` object.  
  
## Remarks  
 The first constructor constructs an object whose stored `duration` value is equal to [duration::zero](../vs140/duration--zero-method.md).  
  
 The second constructor constructs an object whose stored duration value is equal to `Dur`. Unless `is_convertible<Duration2, duration>`*holds true*, the second constructor does not participate in overload resolution. For more information, see [<type_traits>](../vs140/-type_traits-.md).  
  
 The third constructor initializes its `duration` value by using `Tp.time_since_epoch()`.  
  
## Requirements  
 **Header:** chrono  
  
 **Namespace:** std::chrono  
  
## See Also  
 [time_point Class](../vs140/time_point-class.md)   
 [\<chrono>](../vs140/-chrono-.md)   
 [time_point::time_since_epoch Method](../vs140/time_point--time_since_epoch-method.md)   
 [is_convertible Class](../vs140/is_convertible-class.md)