---
title: "concurrent_unordered_set::load_factor Method"
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
ms.assetid: 26ddcb1c-dfca-4522-9d04-fac2326c9e25
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_set::load_factor Method
Computes and returns the current load factor of the container. The load factor is the number of elements in the container divided by the number of buckets.  
  
## Syntax  
  
```  
float load_factor() const;  
```  
  
## Return Value  
 The load factor for the container.  
  
## Requirements  
 **Header:** internal_concurrent_hash.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_set Class](../vs140/concurrent_unordered_set-class.md)