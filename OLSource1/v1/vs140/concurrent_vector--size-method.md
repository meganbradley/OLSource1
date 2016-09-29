---
title: "concurrent_vector::size Method"
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
  - "concurrent_vector/concurrency::concurrent_vector::size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size method"
ms.assetid: 3231e1e5-546d-449a-b7b4-fadaa0bb817d
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_vector::size Method
Returns the number of elements in the concurrent vector. This method is concurrency-safe.  
  
## Syntax  
  
```  
size_type size() const;  
```  
  
## Return Value  
 The number of elements in this `concurrent_vector` object.  
  
## Remarks  
 The returned size is guaranteed to include all elements appended by calls to the function `push_back`, or grow operations that have completed prior to invoking this method. However, it may also include elements that are allocated but still under construction by concurrent calls to any of the growth methods.  
  
## Requirements  
 **Header:** concurrent_vector.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_vector Class](../vs140/concurrent_vector-class.md)