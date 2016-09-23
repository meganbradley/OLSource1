---
title: "concurrent_unordered_map::max_size Method"
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
  - internal_concurrent_hash/concurrency::concurrent_unordered_map::max_size
dev_langs: 
  - C++
helpviewer_keywords: 
  - max_size method
ms.assetid: 20cc611f-1497-4e77-82e6-10114ceb36a1
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# concurrent_unordered_map::max_size Method
Returns the maximum size of the concurrent container, determined by the allocator. This method is concurrency safe.  
  
## Syntax  
  
```  
size_type max_size() const;  
```  
  
## Return Value  
 The maximum number of elements that can be inserted into this concurrent container.  
  
## Remarks  
 This upper bound value may actually be higher than what the container can actually hold.  
  
## Requirements  
 **Header:** internal_concurrent_hash.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_map Class](../vs140/concurrent_unordered_map-class.md)