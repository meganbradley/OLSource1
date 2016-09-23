---
title: "concurrent_unordered_multimap::operator= Operator"
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
  - concurrent_unordered_map/concurrency::concurrent_unordered_multimap::operator=
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator= operator
ms.assetid: 756998f4-61dc-4bb7-96f6-9ed96aad3628
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# concurrent_unordered_multimap::operator= Operator
Assigns the contents of another `concurrent_unordered_multimap` object to this one. This method is not concurrency-safe.  
  
## Syntax  
  
```  
concurrent_unordered_multimap& operator=(  
   const concurrent_unordered_multimap& _Umap  
);  
  
concurrent_unordered_multimap& operator=(  
   concurrent_unordered_multimap&& _Umap  
);  
```  
  
#### Parameters  
 `_Umap`  
 The source `concurrent_unordered_multimap` object.  
  
## Return Value  
 A reference to this `concurrent_unordered_multimap` object.  
  
## Remarks  
 After erasing any existing elements in a concurrent unordered multimap, `operator=` either copies or moves the contents of `_Umap` into the concurrent unordered multimap.  
  
## Requirements  
 **Header:** concurrent_unordered_map.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_multimap Class](../vs140/concurrent_unordered_multimap-class.md)