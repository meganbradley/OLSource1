---
title: "timed_mutex::lock Method"
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
  - "mutex/std::timed_mutex::lock"
dev_langs: 
  - "C++"
ms.assetid: 58e74b6d-670f-4c69-9d51-20a4afd9c171
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# timed_mutex::lock Method
Blocks the calling thread until the thread obtains ownership of the `mutex`.  
  
## Syntax  
  
```cpp  
void lock();  
```  
  
## Remarks  
 If the calling thread already owns the `mutex`, the behavior is undefined.  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [<mutex\>](../vs140/-mutex-.md)   
 [timed_mutex Class](../vs140/timed_mutex-class.md)