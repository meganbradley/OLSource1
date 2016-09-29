---
title: "concurrent_unordered_map::equal_range Method"
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
  - "internal_concurrent_hash/concurrency::concurrent_unordered_map::equal_range"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "equal_range method"
ms.assetid: 7d247c18-1319-44d3-afb7-868f0f1dbbae
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_map::equal_range Method
Finds a range that matches a specified key. This function is concurrency safe.  
  
## Syntax  
  
```  
std::pair<iterator, iterator> equal_range(  
   const key_type& _Keyval);  
std::pair<const_iterator, const_iterator> equal_range(  
   const key_type& _Keyval  
) const;  
```  
  
#### Parameters  
 `_Keyval`  
 The key value to search for.  
  
## Return Value  
 A [pair](assetId:///c5a37023-d939-4eb2-ae24-ce8e0cd4505d) where the first element is an iterator to the beginning and the second element is an iterator to the end of the range.  
  
## Remarks  
 It is possible for concurrent inserts to cause additional keys to be inserted after the begin iterator and before the end iterator.  
  
## Requirements  
 **Header:** internal_concurrent_hash.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_map Class](../vs140/concurrent_unordered_map-class.md)