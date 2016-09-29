---
title: "concurrent_unordered_multimap::count Method"
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
ms.assetid: 5eed79ad-2ebd-4ab8-b7de-aaf29f4ac673
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_multimap::count Method
Counts the number of elements matching a specified key. This function is concurrency safe.  
  
## Syntax  
  
```  
size_type count(  
   const key_type& _Keyval  
) const;  
```  
  
#### Parameters  
 `_Keyval`  
 The key to search for.  
  
## Return Value  
 The number of times number of times the key appears in the container.  
  
## Requirements  
 **Header:** internal_concurrent_hash.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_multimap Class](../vs140/concurrent_unordered_multimap-class.md)