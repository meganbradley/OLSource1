---
title: "recursive_timed_mutex::try_lock_for Method"
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
  - mutex/std::recursive_timed_mutex::try_lock_for
dev_langs: 
  - C++
ms.assetid: 4e46684d-7c55-4146-b1d5-ffef7c6af911
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# recursive_timed_mutex::try_lock_for Method
Attempts to obtain ownership of the `mutex` without blocking.  
  
## Syntax  
  
```cpp  
template<class Rep, class Period>  
   bool try_lock_for(const chrono::duration<Rep, Period>& Rel_time);  
```  
  
#### Parameters  
 `Rel_time`  
 A [chrono::duration](../vs140/duration-class.md) object that specifies the maximum amount of time that the method attempts to obtain ownership of the `mutex`.  
  
## Return Value  
 `true` if the method successfully obtains ownership of the `mutex` or if the calling thread already owns the `mutex`; otherwise, `false`.  
  
## Remarks  
 If the calling thread already owns the `mutex`, the method immediately returns `true`, and the previous lock remains in effect.  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [<mutex\>](../vs140/-mutex-.md)   
 [recursive_timed_mutex Class](../vs140/recursive_timed_mutex-class.md)