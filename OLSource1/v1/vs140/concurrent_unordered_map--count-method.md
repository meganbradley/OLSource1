---
title: "concurrent_unordered_map::count Method"
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
  - "internal_concurrent_hash/concurrency::concurrent_unordered_map::count"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "count method"
ms.assetid: acb62871-47be-46f8-a9a3-463c2b258591
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_map::count Method
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
 [concurrent_unordered_map Class](../vs140/concurrent_unordered_map-class.md)