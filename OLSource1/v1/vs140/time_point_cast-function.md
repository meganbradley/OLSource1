---
title: "time_point_cast Function"
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
  - "chrono/std::chrono::time_point_cast"
dev_langs: 
  - "C++"
ms.assetid: 54d4f4dd-30c2-4254-b82a-f4a6d2d514c3
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# time_point_cast Function
Casts a [time_point](../vs140/time_point-class.md) object to a specified type.  
  
## Syntax  
  
```  
template<class To, class Clock, class Duration>  
    time_point<Clock, To> time_point_cast(  
        const time_point<Clock, Duration>& Tp  
    );  
```  
  
## Return Value  
 A `time_point` object that has a duration of type `To`.  
  
## Remarks  
 Unless `To` is an instantiation of [duration](../vs140/duration-class.md), this function does not participate in overload resolution.  
  
## Requirements  
 **Header:** chrono  
  
 **Namespace:** std::chrono  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<chrono>](../vs140/-chrono-.md)