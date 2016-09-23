---
title: "concurrent_unordered_map::unsafe_cend Method"
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
  - internal_concurrent_hash/concurrency::concurrent_unordered_map::unsafe_cend
dev_langs: 
  - C++
helpviewer_keywords: 
  - imsafe_cend method
ms.assetid: 9faa4bdf-7fc6-4575-beb3-d94873308bfb
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# concurrent_unordered_map::unsafe_cend Method
Returns an iterator to the location succeeding the last element in a specific bucket.  
  
## Syntax  
  
```  
const_local_iterator unsafe_cend(  
   size_type _Bucket  
) const;  
```  
  
#### Parameters  
 `_Bucket`  
 The bucket index.  
  
## Return Value  
 An iterator pointing to the beginning of the bucket.  
  
## Requirements  
 **Header:** internal_concurrent_hash.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_map Class](../vs140/concurrent_unordered_map-class.md)