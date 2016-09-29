---
title: "mutex::unlock Method (STL)"
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
  - "mutex/std::mutex::unlock"
dev_langs: 
  - "C++"
ms.assetid: 4284bd39-c64d-4587-b58a-f58781d85461
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# mutex::unlock Method (STL)
Releases ownership of the `mutex`.  
  
## Syntax  
  
```cpp  
void unlock();  
```  
  
## Remarks  
 If the calling thread does not own the `mutex`, the behavior is undefined.  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<mutex>](../vs140/-mutex-.md)   
 [mutex Class (STL)](../vs140/mutex-class--stl-.md)