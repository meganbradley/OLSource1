---
title: "concurrent_vector::get_allocator Method"
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
  - "concurrent_vector/concurrency::concurrent_vector::get_allocator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_allocator method"
ms.assetid: 40f2c900-6846-4c5c-afb3-7e582b303386
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_vector::get_allocator Method
Returns a copy of the allocator used to construct the concurrent vector. This method is concurrency-safe.  
  
## Syntax  
  
```  
allocator_type get_allocator() const;  
```  
  
## Return Value  
 A copy of the allocator used to construct the `concurrent_vector` object.  
  
## Requirements  
 **Header:** concurrent_vector.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_vector Class](../VS_csharp/concurrent_vector-class.md)