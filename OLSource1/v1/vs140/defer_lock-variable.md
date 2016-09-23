---
title: "defer_lock Variable"
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
  - mutex/std::defer_lock
dev_langs: 
  - C++
ms.assetid: 1df712b8-c290-4e42-936c-caf745b92218
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# defer_lock Variable
Represents an object that can be passed to the constructor for [unique_lock](../vs140/unique_lock-class.md). This indicates that the constructor should not lock the mutex object that's also being passed to it.  
  
## Syntax  
  
```cpp  
const defer_lock_t defer_lock;  
```  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [<mutex\>](../vs140/-mutex-.md)