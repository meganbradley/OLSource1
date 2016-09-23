---
title: "concurrent_vector::capacity Method"
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
  - concurrent_vector/concurrency::concurrent_vector::capacity
dev_langs: 
  - C++
helpviewer_keywords: 
  - capacity method
ms.assetid: 99ac661c-09b7-43a4-a331-7baf0bdee6a5
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# concurrent_vector::capacity Method
Returns the maximum size to which the concurrent vector can grow without having to allocate more memory. This method is concurrency-safe.  
  
## Syntax  
  
```  
size_type capacity() const;  
```  
  
## Return Value  
 The maximum size to which the concurrent vector can grow without having to allocate more memory.  
  
## Remarks  
 Unlike an STL `vector`, a `concurrent_vector` object does not move existing elements if it allocates more memory.  
  
## Requirements  
 **Header:** concurrent_vector.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_vector Class](../vs140/concurrent_vector-class.md)