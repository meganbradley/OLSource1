---
title: "condition_variable::wait Method"
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
  - "condition_variable/std::condition_variable::wait"
dev_langs: 
  - "C++"
ms.assetid: fb094f8b-1d0e-4018-bc7b-ca49d6a175a4
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# condition_variable::wait Method
Blocks a thread.  
  
## Syntax  
  
```  
void wait(  
   unique_lock<mutex>& Lck  
);  
template<class Predicate>  
void wait(  
   unique_lock<mutex>& Lck,  
   Predicate Pred  
);  
```  
  
#### Parameters  
 `Lck`  
 A [unique_lock\<mutex>](unique_lock<mutex>) object.  
  
 `Pred`  
 Any expression that returns `true` or `false`.  
  
## Remarks  
 The first method blocks until the `condition_variable` object is signaled by a call to [notify_one](../vs140/condition_variable--notify_one-method.md) or [notify_all](../vs140/condition_variable--notify_all-method.md). It can also wake up spuriously.  
  
 In effect, the second method executes the following code.  
  
```cpp  
while(!Pred())  
    wait(Lck);  
```  
  
## Requirements  
 **Header:** condition_variable  
  
 **Namespace:** std  
  
## See Also  
 [condition_variable Class](../vs140/condition_variable-class.md)   
 [<condition_variable>](../vs140/-condition_variable-.md)