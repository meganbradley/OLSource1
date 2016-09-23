---
title: "concurrent_vector::assign Method"
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
  - concurrent_vector/concurrency::concurrent_vector::assign
dev_langs: 
  - C++
helpviewer_keywords: 
  - assign method
ms.assetid: cd9aa3dc-8845-4bd9-a0b8-0fda4a19da6a
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# concurrent_vector::assign Method
Erases the elements of the concurrent vector and assigns to it either `_N` copies of `_Item`, or values specified by the iterator range [`_Begin`, `_End`). This method is not concurrency-safe.  
  
## Syntax  
  
```  
void assign(  
   size_type _N,  
   const_reference _Item  
);  
  
template<  
   class _InputIterator  
>  
void assign(  
   _InputIterator_Begin,  
   _InputIterator_End  
);  
```  
  
#### Parameters  
 `_InputIterator`  
 The type of the specified iterator.  
  
 `_N`  
 The number of items to copy into the concurrent vector.  
  
 `_Item`  
 Reference to a value used to fill the concurrent vector.  
  
 `_Begin`  
 An iterator to the first element of the source range.  
  
 `_End`  
 An iterator to one past the last element of the source range.  
  
## Remarks  
 `assign` is not concurrency-safe. You must ensure that no other threads are invoking methods on the concurrent vector when you call this method.  
  
## Requirements  
 **Header:** concurrent_vector.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_vector Class](../vs140/concurrent_vector-class.md)