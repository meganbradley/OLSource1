---
title: "adopt_lock Variable"
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
  - "mutex/std::adopt_lock"
dev_langs: 
  - "C++"
ms.assetid: 38b417aa-ee6c-46c0-8268-059affe6d215
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# adopt_lock Variable
Represents an object that can be passed to constructors for [lock_guard](../vs140/lock_guard-class.md) and [unique_lock](../vs140/unique_lock-class.md) to indicate that the mutex object that is also being passed to the constructor is locked.  
  
## Syntax  
  
```cpp  
const adopt_lock_t adopt_lock;  
```  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [<mutex\>](../vs140/-mutex-.md)