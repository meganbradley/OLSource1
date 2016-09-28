---
title: "unique_lock::unique_lock Constructor"
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
  - "mutex/std::unique_lock::unique_lock"
dev_langs: 
  - "C++"
ms.assetid: 7bca5258-64a8-4133-af66-c0f9e2118b9b
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unique_lock::unique_lock Constructor
Constructs a `unique_lock` object.  
  
## Syntax  
  
```cpp  
unique_lock() noexcept;  
unique_lock(unique_lock&& Other) noexcept;  
explicit unique_lock(mutex_type& Mtx);  
unique_lock(mutex_type& Mtx, adopt_lock_t Adopt);  
unique_lock(mutex_type& Mtx, defer_lock_t Defer) noexcept;  
unique_lock(mutex_type& Mtx, try_to_lock_t Try);  
template<class Rep, class Period>  
   unique_lock(mutex_type& Mtx,  
      const chrono::duration<Rep, Period> Rel_time);  
template<class Clock, class Duration>  
   unique_lock(mutex_type& Mtx,  
      const chrono::time_point<Clock, Duration> Abs_time);  
unique_lock(mutex_type& Mtx,  
   const xtime *Abs_time) noexcept;  
```  
  
#### Parameters  
 `Mtx`  
 A mutex type object.  
  
 `Rel_time`  
 A [chrono::duration](../vs140/duration-class.md) object that specifies the maximum amount of time that the method attempts to obtain ownership of the `mutex`.  
  
 `Abs_time`  
 A point in time that specifies the threshold after which the method no longer attempts to obtain ownership of the `mutex`.  
  
 `Other`  
 A `unique_lock` object.  
  
## Remarks  
 The first constructor constructs an object that has an associated mutex pointer value of 0.  
  
 The second constructor moves the associated mutex status from `Other`. After the move, `Other` is no longer associated with a mutex.  
  
 The remaining constructors store &`Mtx` as the stored `mutex` pointer. Ownership of the `mutex` is determined by the second argument, if it exists.  
  
|||  
|-|-|  
|`No argument`|Ownership is obtained by calling the `lock` method on the associated `mutex` object.|  
|`Adopt`|Ownership is assumed. `Mtx` must be locked when the constructor is called.|  
|`Defer`|The calling thread is assumed not to own the `mutex` object. `Mtx` must not be locked when the constructor is called.|  
|`Try`|Ownership is determined by calling `try_lock` on the associated `mutex` object. The constructor throws nothing.|  
|`Rel_time`|Ownership is determined by calling `try_lock_for(Rel_time)`.|  
|`Abs_time`|Ownership is determined by calling `try_lock_until(Abs_time)`.|  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [unique_lock Class](../vs140/unique_lock-class.md)   
 [<mutex\>](../vs140/-mutex-.md)