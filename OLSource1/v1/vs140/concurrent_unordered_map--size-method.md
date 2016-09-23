---
title: "concurrent_unordered_map::size Method"
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
  - internal_concurrent_hash/concurrency::concurrent_unordered_map::size
dev_langs: 
  - C++
ms.assetid: 5f8fd063-4e3c-4bea-b136-52edb5a6f10c
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# concurrent_unordered_map::size Method
Returns the number of elements in this concurrent container. This method is concurrency safe.  
  
## Syntax  
  
```  
size_type size( ) const;  
```  
  
## Return Value  
 The number of items in the container.  
  
## Remarks  
 In the presence of concurrent inserts, the number of elements in the concurrent container may change immediately after calling this function, before the return value is even read.  
  
## Requirements  
 **Header:** internal_concurrent_hash.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_map Class](../vs140/concurrent_unordered_map-class.md)