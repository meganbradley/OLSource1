---
title: "concurrent_unordered_set::rehash Method"
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
ms.assetid: 37ecb07b-a573-407c-9e9f-d9c5e7aef0ad
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_set::rehash Method
Rebuilds the hash table.  
  
## Syntax  
  
```  
void rehash(  
   size_type _Buckets  
);  
```  
  
#### Parameters  
 `_Buckets`  
 The desired number of buckets.  
  
## Remarks  
 The member function alters the number of buckets to be at least `_Buckets` and rebuilds the hash table as needed. The number of buckets must be a power of 2. If not a power of 2, it will be rounded up to the next largest power of 2.  
  
 It throws an [out_of_range](../vs140/out_of_range-class.md) exception if the number of buckets is invalid (either 0 or greater than the maximum number of buckets).  
  
## Requirements  
 **Header:** internal_concurrent_hash.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_set Class](../vs140/concurrent_unordered_set-class.md)