---
title: "concurrent_unordered_multimap::unsafe_begin Method"
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
ms.assetid: e90878a7-4135-47ae-91e4-73ac75ae3ec6
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# concurrent_unordered_multimap::unsafe_begin Method
Returns an iterator to the first element in this container for a specific bucket.  
  
## Syntax  
  
```  
local_iterator unsafe_begin(  
   size_type _Bucket  
);  
  
const_local_iterator unsafe_begin(  
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
 [concurrent_unordered_multimap Class](../vs140/concurrent_unordered_multimap-class.md)