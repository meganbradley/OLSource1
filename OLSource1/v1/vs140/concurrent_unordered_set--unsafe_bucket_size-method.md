---
title: "concurrent_unordered_set::unsafe_bucket_size Method"
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
ms.assetid: d8d40fcb-dbf3-4b6a-83ff-726e1b70b1cf
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# concurrent_unordered_set::unsafe_bucket_size Method
Returns the number of items in a specific bucket of this container.  
  
## Syntax  
  
```  
size_type unsafe_bucket_size(  
   size_type _Bucket  
);  
```  
  
#### Parameters  
 `_Bucket`  
 The bucket to search for.  
  
## Return Value  
 The current number of buckets in this container.  
  
## Requirements  
 **Header:** internal_concurrent_hash.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_set Class](../vs140/concurrent_unordered_set-class.md)