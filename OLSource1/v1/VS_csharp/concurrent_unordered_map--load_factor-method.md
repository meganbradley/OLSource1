---
title: "concurrent_unordered_map::load_factor Method"
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
  - "internal_concurrent_hash/concurrency::concurrent_unordered_map::load_factor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "load_factor method"
ms.assetid: d834bc77-43eb-49c6-b4f3-7e9c64591a83
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_map::load_factor Method
Computes and returns the current load factor of the container. The load factor is the number of elements in the container divided by the number of buckets.  
  
## Syntax  
  
```  
float load_factor( ) const;  
```  
  
## Return Value  
 The load factor for the container.  
  
## Requirements  
 **Header:** internal_concurrent_hash.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_map Class](../VS_csharp/concurrent_unordered_map-class.md)