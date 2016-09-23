---
title: "concurrent_unordered_multiset::unsafe_cend Method"
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
ms.assetid: 24ba4534-cdd9-4574-8356-07fb09c0c757
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# concurrent_unordered_multiset::unsafe_cend Method
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
 [concurrent_unordered_multiset Class](../vs140/concurrent_unordered_multiset-class.md)