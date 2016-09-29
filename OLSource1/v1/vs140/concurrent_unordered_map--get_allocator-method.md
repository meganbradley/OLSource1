---
title: "concurrent_unordered_map::get_allocator Method"
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
  - "internal_concurrent_hash/concurrency::concurrent_unordered_map::get_allocator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "get_allocator method"
ms.assetid: 83407356-6849-4ada-9b2d-5958c3e55ad0
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_map::get_allocator Method
Returns the stored allocator object for this concurrent container. This method is concurrency safe.  
  
## Syntax  
  
```  
allocator_type get_allocator( ) const;  
```  
  
## Return Value  
 The stored allocator object for this concurrent container.  
  
## Requirements  
 **Header:**  internal_concurrent_hash.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_map Class](../vs140/concurrent_unordered_map-class.md)