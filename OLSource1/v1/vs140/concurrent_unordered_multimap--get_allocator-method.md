---
title: "concurrent_unordered_multimap::get_allocator Method"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
ms.assetid: 7d821bf3-9e8e-4feb-8da5-00340675dc13
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# concurrent_unordered_multimap::get_allocator Method
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
 [concurrent_unordered_multimap Class](../vs140/concurrent_unordered_multimap-class.md)