---
title: "concurrent_unordered_multiset::size Method"
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
ms.assetid: 00e1920c-0f3b-402b-8778-ab625fa6416f
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_multiset::size Method
Returns the number of elements in this concurrent container. This method is concurrency safe.  
  
## Syntax  
  
```  
size_type size() const;  
```  
  
## Return Value  
 The number of items in the container.  
  
## Remarks  
 In the presence of concurrent inserts, the number of elements in the concurrent container may change immediately after calling this function, before the return value is even read.  
  
## Requirements  
 **Header:** internal_concurrent_hash.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_multiset Class](../vs140/concurrent_unordered_multiset-class.md)