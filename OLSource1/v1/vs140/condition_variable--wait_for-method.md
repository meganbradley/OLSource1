---
title: "condition_variable::wait_for Method"
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
  - "condition_variable/std::condition_variable::wait_for"
dev_langs: 
  - "C++"
ms.assetid: 6952f1c6-cb33-41ac-8269-f6db38e51d1f
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# condition_variable::wait_for Method
Blocks a thread, and sets a time interval after which the thread unblocks.  
  
## Syntax  
  
```  
template<  
   class Rep,  
   class Period  
>  
cv_status wait_for(  
   unique_lock<mutex>& Lck,  
   const chrono::duration<Rep,  
   Period>& Rel_time  
);  
template<  
   class Rep,  
   class Period,  
   class Predicate  
>  
bool wait_for(  
   unique_lock<mutex>& Lck,  
   const chrono::duration<Rep,  
   Period>& Rel_time,  
   PredicatePred  
);  
```  
  
#### Parameters  
 `Lck`  
 A [unique_lock\<mutex>](unique_lock<mutex>) object.  
  
 `Rel_time`  
 A `chrono::duration` object that specifies the amount of time before the thread wakes up.  
  
 `Pred`  
 Any expression that returns `true` or `false`.  
  
## Return Value  
 The first method returns `cv_status::timeout` if the wait terminates when `Rel_time` has elapsed. Otherwise, the method returns `cv_status::no_timeout`.  
  
 The second method returns the value of `Pred`.  
  
## Remarks  
 The first method blocks until the `condition_variable` object is signaled by a call to [notify_one](../vs140/condition_variable--notify_one-method.md) or [notify_all](../vs140/condition_variable--notify_all-method.md) or until the time interval `Rel_time` has elapsed. It can also wake up spuriously.  
  
 In effect, the second method executes the following code.  
  
```css  
while(!Pred())  
   if(wait_for(Lck, Rel_time) == cv_status::timeout)  
      return Pred();  
return true;  
```  
  
## Requirements  
 **Header:** condition_variable  
  
 **Namespace:** std  
  
## See Also  
 [condition_variable Class](../vs140/condition_variable-class.md)   
 [<condition_variable>](../vs140/-condition_variable-.md)