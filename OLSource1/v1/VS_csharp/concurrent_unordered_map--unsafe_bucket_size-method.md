---
title: "concurrent_unordered_map::unsafe_bucket_size Method"
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
  - "internal_concurrent_hash/concurrency::concurrent_unordered_map::unsafe_bucket_size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unsafe_bucket_size method"
ms.assetid: 0fbf135c-bcd3-4045-8ffe-5c52b17dd878
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_map::unsafe_bucket_size Method
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
 [concurrent_unordered_map Class](../VS_csharp/concurrent_unordered_map-class.md)