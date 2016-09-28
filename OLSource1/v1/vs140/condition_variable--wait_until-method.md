---
title: "condition_variable::wait_until Method"
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
  - "condition_variable/std::condition_variable::wait_until"
dev_langs: 
  - "C++"
ms.assetid: d7d6f6a3-3fbe-40f4-854c-36e0b9a42864
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# condition_variable::wait_until Method
Blocks a thread, and sets a maximum point in time at which the thread unblocks.  
  
## Syntax  
  
```  
template<  
   class Clock,  
   class Duration  
>  
cv_status wait_until(  
   unique_lock<mutex>& Lck,  
   const chrono::time_point<Clock,  
   Duration>& Abs_time  
);  
template<  
   class Clock,  
   class Duration,  
   class Predicate  
>  
bool wait_until(  
   unique_lock<mutex>& Lck,  
   const chrono::time_point<Clock,  
   Duration>& Abs_time,  
   Predicate Pred  
);  
cv_status wait_until(  
   unique_lock<mutex>& Lck,  
   const xtime *Abs_time  
);  
template<class Predicate>  
bool wait_until(  
   unique_lock<mutex>& Lck,  
   const xtime *Abs_time,  
   Predicate Pred  
);  
```  
  
#### Parameters  
 `Lck`  
 A [unique_lock<mutex\>](unique_lock<mutex>) object.  
  
 `Abs_time`  
 A [chrono::time_point](../vs140/time_point-class.md) object.  
  
 `Pred`  
 Any expression that returns `true` or `false`.  
  
## Return Value  
 Methods that return a `cv_status` type return `cv_status::timeout` if the wait terminates when `Abs_time` elapses. Otherwise, the methods return `cv_status::no_timeout`.  
  
 Methods that return a `bool` return the value of `Pred`.  
  
## Remarks  
 The first method blocks until the `condition_variable` object is signaled by a call to [notify_one](../vs140/condition_variable--notify_one-method.md) or [notify_all](../vs140/condition_variable--notify_all-method.md) or until `Abs_time`. It can also wake up spuriously.  
  
 In effect, the second method executes the following code  
  
```cpp  
while(!Pred())  
   if(wait_until(Lck, Abs_time) == cv_status::timeout)  
      return Pred();  
return true;  
```  
  
 The third and fourth methods use a pointer to an object of type `xtime` to replace the `chrono::time_point` object. The `xtime` object specifies the maximum amount of time to wait for a signal.  
  
## Requirements  
 **Header:** condition_variable  
  
 **Namespace:** std  
  
## See Also  
 [condition_variable Class](../vs140/condition_variable-class.md)   
 [<condition_variable>](../vs140/-condition_variable-.md)