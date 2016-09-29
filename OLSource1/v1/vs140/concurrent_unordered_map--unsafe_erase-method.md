---
title: "concurrent_unordered_map::unsafe_erase Method"
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
  - "concurrent_unordered_map/concurrency::concurrent_unordered_map::unsafe_erase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unsafe_erase method"
ms.assetid: 1882a0b2-735b-4ed4-a87c-198c263b7552
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_map::unsafe_erase Method
Removes elements from the `concurrent_unordered_map` at specified positions. This method is not concurrency-safe.  
  
## Syntax  
  
```  
iterator unsafe_erase(  
   const_iterator _Where  
);  
  
iterator unsafe_erase(  
   const_iterator _Begin,  
   const_iterator _End  
);  
  
size_type unsafe_erase(  
   const key_type& _Keyval  
);  
```  
  
#### Parameters  
 `_Where`  
 The iterator position to erase from.  
  
 `_Begin`  
 The position of the first element in the range of elements to be erased.  
  
 `_End`  
 The position of the first element beyond the range of elements to be erased.  
  
 `_Keyval`  
 The key value to erase.  
  
## Return Value  
 The first two member functions return an iterator that designates the first element remaining beyond any elements removed, or `concurrent_unordered_map::end`() if no such element exists. The third member function returns the number of elements it removes.  
  
## Remarks  
 The first member function removes the element of the controlled sequence pointed to by `_Where`. The second member function removes the elements in the range [`_Begin`, `_End`).  
  
 The third member function removes the elements in the range delimited by `concurrent_unordered_map::equal_range`(_Keyval).  
  
## Requirements  
 **Header:** concurrent_unordered_map.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_map Class](../vs140/concurrent_unordered_map-class.md)