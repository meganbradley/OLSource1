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
Removes elements from the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> at specified positions. This method is not concurrency-safe.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The iterator position to erase from.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The key value to erase.  
  
## Return Value  
 The first two member functions return an iterator that designates the first element remaining beyond any elements removed, or [concurrent_unordered_multiset::end Method](../vs140/concurrent_unordered_multiset--end-method.md)() if no such element exists. The third member function returns the number of elements it removes.  
  
## Remarks  
 The first member function removes the element pointed to by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The second member function removes the elements in the range [<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>).  
  
 The third member function removes the elements in the range delimited by [concurrent_unordered_multiset::equal_range Method](../vs140/concurrent_unordered_multiset--equal_range-method.md)(_Keyval).  
  
## Requirements  
 **Header:** concurrent_unordered_set.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_multiset Class](../vs140/concurrent_unordered_multiset-class.md)