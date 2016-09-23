---
title: "timed_mutex::try_lock_until Method"
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
  - mutex/std::timed_mutex::try_lock_until
dev_langs: 
  - C++
ms.assetid: 7839cd58-4971-4898-a126-1d952866610d
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# timed_mutex::try_lock_until Method
Attempts to obtain ownership of the `mutex` without blocking.  
  
## Syntax  
  
```cpp  
template<class Clock, class Duration>  
   bool try_lock_for(const chrono::time_point<Clock, Duration>& Abs_time);  
bool try_lock_until(const xtime *Abs_time);  
```  
  
#### Parameters  
 `Abs_time`  
 A point in time that specifies the threshold after which the method no longer attempts to obtain ownership of the `mutex`.  
  
## Return Value  
 `true` if the method successfully obtains ownership of the `mutex`; otherwise, `false`.  
  
## Remarks  
 If the calling thread already owns the `mutex`, the behavior is undefined.  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [<mutex\>](../vs140/-mutex-.md)   
 [timed_mutex Class](../vs140/timed_mutex-class.md)   
 [time_point Class](../vs140/time_point-class.md)