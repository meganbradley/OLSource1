---
title: "recursive_timed_mutex::try_lock Method"
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
  - "mutex/std::recursive_timed_mutex::try_lock"
dev_langs: 
  - "C++"
ms.assetid: f9297b2c-d1e7-41f4-970f-b5ab6c164720
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# recursive_timed_mutex::try_lock Method
Attempts to obtain ownership of the `mutex` without blocking.  
  
## Syntax  
  
```cpp  
bool try_lock() _NOEXCEPT;  
```  
  
## Return Value  
 `true` if the method successfully obtained ownership of the `mutex` or if the calling thread already owns the `mutex`; otherwise, `false`.  
  
## Remarks  
 If the calling thread already owns the `mutex`, the function immediately returns `true`, and the previous lock remains in effect.  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [recursive_timed_mutex Class](../vs140/recursive_timed_mutex-class.md)   
 [<mutex\>](../vs140/-mutex-.md)