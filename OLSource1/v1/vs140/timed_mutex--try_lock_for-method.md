---
title: "timed_mutex::try_lock_for Method"
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
  - "mutex/std::timed_mutex::try_lock_for"
dev_langs: 
  - "C++"
ms.assetid: e96abad9-db16-4a4b-9228-343fd023fa32
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# timed_mutex::try_lock_for Method
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