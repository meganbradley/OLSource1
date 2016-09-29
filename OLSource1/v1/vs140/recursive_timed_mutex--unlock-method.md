---
title: "recursive_timed_mutex::unlock Method"
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
  - "mutex/std::recursive_timed_mutex::unlock"
dev_langs: 
  - "C++"
ms.assetid: 6b4ebf63-7b88-4c97-829f-8a14eb9aa297
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# recursive_timed_mutex::unlock Method
Releases ownership of the `mutex`.  
  
## Syntax  
  
```cpp  
void unlock();  
```  
  
## Remarks  
 This method releases ownership of the `mutex` only after it is called as many times as [lock](../vs140/recursive_timed_mutex--lock-method.md), [try_lock](../vs140/recursive_timed_mutex--try_lock-method.md), [try_lock_for](../vs140/recursive_timed_mutex--try_lock_for-method.md), and [try_lock_until](../vs140/recursive_timed_mutex--try_lock_until-method.md) have been called successfully on the `recursive_timed_mutex` object.  
  
 If the calling thread does not own the `mutex`, the behavior is undefined.  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [<mutex\>](../vs140/-mutex-.md)   
 [recursive_timed_mutex Class](../vs140/recursive_timed_mutex-class.md)