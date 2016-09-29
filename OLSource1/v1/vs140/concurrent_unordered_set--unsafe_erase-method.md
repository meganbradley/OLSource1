---
title: "concurrent_unordered_set::unsafe_erase Method"
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
  - "concurrent_unordered_set/concurrency::concurrent_unordered_set::unsafe_erase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "unsafe_erase method"
ms.assetid: 4197c934-d7bb-420b-a1ab-282fc3f54ddd
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# concurrent_unordered_set::unsafe_erase Method
Removes elements from the `concurrent_unordered_set` at specified positions. This method is not concurrency-safe.  
  
## Syntax  
  
```  
iterator unsafe_erase(  
   const_iterator _Where  
);  
  
size_type unsafe_erase(  
   const key_type& _Keyval  
);  
  
iterator unsafe_erase(  
   const_iterator _First,  
   const_iterator _Last  
);  
```  
  
#### Parameters  
 `_Where`  
 The iterator position to erase from.  
  
 `_Keyval`  
 The key value to erase.  
  
 `_First`  
 `_Last`  
  
## Return Value  
 The first two member functions return an iterator that designates the first element remaining beyond any elements removed, or [concurrent_unordered_set::end Method](../vs140/concurrent_unordered_set--end-method.md)() if no such element exists. The third member function returns the number of elements it removes.  
  
## Remarks  
 The first member function removes the element pointed to by `_Where`. The second member function removes the elements in the range [`_Begin`, `_End`).  
  
 The third member function removes the elements in the range delimited by [concurrent_unordered_set::equal_range Method](../vs140/concurrent_unordered_set--equal_range-method.md)(_Keyval).  
  
## Requirements  
 **Header:** concurrent_unordered_set.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_set Class](../vs140/concurrent_unordered_set-class.md)