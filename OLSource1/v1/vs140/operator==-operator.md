---
title: "operator== Operator"
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
  - "concurrent_vector/concurrency::operator=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator== operator"
ms.assetid: 16c7a9ba-2aa4-4ad2-91e0-6c61d4a72ae4
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator== Operator
Tests if the `concurrent_vector` object on the left side of the operator is equal to the `concurrent_vector` object on the right side.  
  
## Syntax  
  
```  
template<  
   typename _Ty,  
   class A1,  
   class A2  
>  
inline bool operator==(  
   const concurrent_vector<_Ty,  
   A1> &_A,  
   const concurrent_vector<_Ty,  
   A2> &_B  
);  
```  
  
#### Parameters  
 `_Ty`  
 The data type of the elements stored in the concurrent vectors.  
  
 `A1`  
 The allocator type of the first `concurrent_vector` object.  
  
 `A2`  
 The allocator type of the second `concurrent_vector` object.  
  
 `_A`  
 An object of type `concurrent_vector`.  
  
 `_B`  
 An object of type `concurrent_vector`.  
  
## Return Value  
 `true` if the concurrent vector on the left side of the operator is equal to the concurrent vector on the right side of the operator; otherwise `false`.  
  
## Remarks  
 Two concurrent vectors are equal if they have the same number of elements and their respective elements have the same values. Otherwise, they are unequal.  
  
 This method is not concurrency-safe with respect to other methods that could modify either of the concurrent vectors `_A` or `_B`.  
  
## Requirements  
 **Header:** concurrent_vector.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)   
 [concurrent_vector Class](../vs140/concurrent_vector-class.md)   
 [Parallel Containers and Objects](../vs140/parallel-containers-and-objects.md)