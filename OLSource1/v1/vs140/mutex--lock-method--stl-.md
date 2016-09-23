---
title: "mutex::lock Method (STL)"
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
  - mutex/std::mutex::lock
dev_langs: 
  - C++
ms.assetid: 5de09860-296e-44c0-81f6-77ca27ca1ae8
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# mutex::lock Method (STL)
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
 [mutex Class (STL)](../vs140/mutex-class--stl-.md)