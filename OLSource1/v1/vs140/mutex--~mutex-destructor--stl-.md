---
title: "mutex::~mutex Destructor (STL)"
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
  - mutex/std::mutex::~mutex
dev_langs: 
  - C++
ms.assetid: bb0ab93d-72ba-4b9f-8272-86557e7f31e4
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# mutex::~mutex Destructor (STL)
Releases any resources that are used by the `mutex` object.  
  
## Syntax  
  
```cpp  
~mutex();  
```  
  
## Remarks  
 If the object is locked when the destructor runs, the behavior is undefined.  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [<mutex\>](../vs140/-mutex-.md)   
 [mutex Class (STL)](../vs140/mutex-class--stl-.md)