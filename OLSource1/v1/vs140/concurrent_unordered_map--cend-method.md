---
title: "concurrent_unordered_map::cend Method"
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
  - "internal_concurrent_hash/concurrency::concurrent_unordered_map::cend"
dev_langs: 
  - "C++"
ms.assetid: 5790b79d-fa9c-400d-b29e-3cb73efcad52
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_map::cend Method
Returns a const iterator pointing to the location succeeding the last element in the concurrent container. This method is concurrency safe.  
  
## Syntax  
  
```  
const_iterator cend( ) const;  
```  
  
## Return Value  
 A const iterator to the location succeeding the last element in the concurrent container.  
  
## Requirements  
 **Header:** internal_concurrent_hash.h  
  
 **Namespace:** concurrency::details  
  
## See Also  
 [concurrent_unordered_map Class](../vs140/concurrent_unordered_map-class.md)