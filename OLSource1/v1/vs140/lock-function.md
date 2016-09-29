---
title: "lock Function"
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
  - "mutex/std::lock"
dev_langs: 
  - "C++"
ms.assetid: 3fc3b0e5-3c61-4928-a9ca-f9fc57e13d30
caps.latest.revision: 9
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# lock Function
Attempts to lock all arguments without deadlock.  
  
## Syntax  
  
```cpp  
template<class L1, class L2, class... L3>  
   void lock(L1&, L2&, L3&...);  
```  
  
## Remarks  
 The arguments to the template function must be *mutex types*, except that calls to `try_lock` might throw exceptions.  
  
 The function locks all of its arguments without deadlock by calls to `lock`, `try_lock`, and `unlock`. If a call to `lock` or `try_lock` throws an exception, the function calls `unlock` on any of the mutex objects that were successfully locked before rethrowing the exception.  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [<mutex\>](../vs140/-mutex-.md)   
 [mutex Class (STL)](../vs140/mutex-class--stl-.md)   
 [recursive_mutex Class (STL)](../vs140/recursive_mutex-class.md)   
 [recursive_timed_mutex Class (STL)](../vs140/recursive_timed_mutex-class.md)   
 [timed_mutex Class (STL)](../vs140/timed_mutex-class.md)