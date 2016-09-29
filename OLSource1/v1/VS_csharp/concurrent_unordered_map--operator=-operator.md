---
title: "concurrent_unordered_map::operator= Operator"
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
  - "concurrent_unordered_map/concurrency::concurrent_unordered_map::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator= operator"
ms.assetid: 9f1a017d-886e-4419-9494-55f937779422
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_map::operator= Operator
Assigns the contents of another `concurrent_unordered_map` object to this one. This method is not concurrency-safe.  
  
## Syntax  
  
```  
concurrent_unordered_map& operator=(  
   const concurrent_unordered_map& _Umap  
);  
  
concurrent_unordered_map& operator=(  
   concurrent_unordered_map&& _Umap  
);  
```  
  
#### Parameters  
 `_Umap`  
 The source `concurrent_unordered_map` object.  
  
## Return Value  
 A reference to this `concurrent_unordered_map` object.  
  
## Remarks  
 After erasing any existing elements a concurrent vector, `operator=` either copies or moves the contents of `_Umap` into the concurrent vector.  
  
## Requirements  
 **Header:** concurrent_unordered_map.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_map Class](../VS_csharp/concurrent_unordered_map-class.md)