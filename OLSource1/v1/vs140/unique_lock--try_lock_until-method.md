---
title: "unique_lock::try_lock_until Method"
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
  - "mutex/std::unique_lock::try_lock_until"
dev_langs: 
  - "C++"
ms.assetid: 410e9db7-7ee1-4fd0-ba7e-91adca8dad6d
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unique_lock::try_lock_until Method
Attempts to obtain ownership of the associated `mutex` without blocking.  
  
## Syntax  
  
```cpp  
template<class Clock, class Duration>  
   bool try_lock_until(const chrono::time_point<Clock, Duration>& Abs_time);  
bool try_lock_until(const xtime *Abs_time);  
```  
  
#### Parameters  
 `Abs_time`  
 A point in time that specifies the threshold after which the method no longer attempts to obtain ownership of the `mutex`.  
  
## Return Value  
 `true` if the method successfully obtains ownership of the `mutex`; otherwise, `false`.  
  
## Remarks  
 If the stored `mutex` pointer is `null`, the method throws a [system_error](../vs140/system_error-class.md) that has an error code of `operation_not_permitted`.  
  
 If the calling thread already owns the `mutex`, the method throws a `system_error` that has an error code of `resource_deadlock_would_occur`.  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [unique_lock Class](../vs140/unique_lock-class.md)   
 [\<mutex>](../vs140/-mutex-.md)   
 [time_point Class](../vs140/time_point-class.md)