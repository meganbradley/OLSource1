---
title: "concurrent_vector::operator= Operator"
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
  - "concurrent_vector/concurrency::concurrent_vector::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator= operator"
ms.assetid: 8547f316-2473-439f-8fee-39180d7843e5
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_vector::operator= Operator
Assigns the contents of another `concurrent_vector` object to this one. This method is not concurrency-safe.  
  
## Syntax  
  
```  
concurrent_vector& operator=(  
   const concurrent_vector& _Vector  
);  
  
template<  
   class M  
>  
concurrent_vector& operator=(  
   const concurrent_vector<_Ty,  
   M>& _Vector  
);  
  
concurrent_vector& operator=(  
   concurrent_vector && _Vector  
);  
```  
  
#### Parameters  
 `M`  
 The allocator type of the source vector.  
  
 `_Vector`  
 The source `concurrent_vector` object.  
  
## Return Value  
 A reference to this `concurrent_vector` object.  
  
## Requirements  
 **Header:** concurrent_vector.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_vector Class](../vs140/concurrent_vector-class.md)