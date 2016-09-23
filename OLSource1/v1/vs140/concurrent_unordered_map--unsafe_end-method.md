---
title: "concurrent_unordered_map::unsafe_end Method"
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
  - internal_concurrent_hash/concurrency::concurrent_unordered_map::unsafe_end
dev_langs: 
  - C++
helpviewer_keywords: 
  - unsafe_end method
ms.assetid: b93246a0-9aca-4baf-b004-936126f50648
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# concurrent_unordered_map::unsafe_end Method
Returns an iterator to the last element in this container for a specific bucket.  
  
## Syntax  
  
```  
local_iterator unsafe_end(  
   size_type _Bucket );  
const_local_iterator unsafe_end(  
   size_type _Bucket  
) const;  
```  
  
#### Parameters  
 `_Bucket`  
 The bucket index.  
  
## Return Value  
 An iterator pointing to the end of the bucket.  
  
## Requirements  
 **Header:** internal_concurrent_hash.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_map Class](../vs140/concurrent_unordered_map-class.md)