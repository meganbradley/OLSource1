---
title: "concurrent_unordered_multiset::get_allocator Method"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 4a79227c-23e7-46f9-9da0-405980233455
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_multiset::get_allocator Method
Returns the stored allocator object for this concurrent container. This method is concurrency safe.  
  
## Syntax  
  
```  
allocator_type get_allocator() const;  
```  
  
## Return Value  
 The stored allocator object for this concurrent container.  
  
## Requirements  
 **Header:** internal_concurrent_hash.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_multiset Class](../VS_csharp/concurrent_unordered_multiset-class.md)