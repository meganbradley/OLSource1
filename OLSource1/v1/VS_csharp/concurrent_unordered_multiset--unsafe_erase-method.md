---
title: "concurrent_unordered_multiset::unsafe_erase Method"
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
  - "concurrent_unordered_set/concurrency::concurrent_unordered_multiset::unsafe_erase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unsafe_erase method"
ms.assetid: 8a025d80-d04d-41c3-b7b0-27bfe7bd3184
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_multiset::unsafe_erase Method
Removes elements from the `concurrent_unordered_multiset` at specified positions. This method is not concurrency-safe.  
  
## Syntax  
  
```  
iterator unsafe_erase(  
   const_iterator _Where  
);  
  
iterator unsafe_erase(  
   const_iterator _First,  
   const_iterator _Last  
);  
  
size_type unsafe_erase(  
   const key_type& _Keyval  
);  
```  
  
#### Parameters  
 `_Where`  
 The iterator position to erase from.  
  
 `_First`  
 `_Last`  
 `_Keyval`  
 The key value to erase.  
  
## Return Value  
 The first two member functions return an iterator that designates the first element remaining beyond any elements removed, or [concurrent_unordered_multiset::end Method](../VS_csharp/concurrent_unordered_multiset--end-method.md)() if no such element exists. The third member function returns the number of elements it removes.  
  
## Remarks  
 The first member function removes the element pointed to by `_Where`. The second member function removes the elements in the range [`_Begin`, `_End`).  
  
 The third member function removes the elements in the range delimited by [concurrent_unordered_multiset::equal_range Method](../VS_csharp/concurrent_unordered_multiset--equal_range-method.md)(_Keyval).  
  
## Requirements  
 **Header:** concurrent_unordered_set.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_multiset Class](../VS_csharp/concurrent_unordered_multiset-class.md)