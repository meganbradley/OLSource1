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
Removes elements from the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> at specified positions. This method is not concurrency-safe.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The iterator position to erase from.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The position of the first element in the range of elements to be erased.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The position of the first element beyond the range of elements to be erased.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The key value to erase.  
  
## Return Value  
 The first two member functions return an iterator that designates the first element remaining beyond any elements removed, or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>() if no such element exists. The third member function returns the number of elements it removes.  
  
## Remarks  
 The first member function removes the element of the controlled sequence pointed to by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. The second member function removes the elements in the range [<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>).  
  
 The third member function removes the elements in the range delimited by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>(_Keyval).  
  
## Requirements  
 **Header:** concurrent_unordered_map.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrent_unordered_map Class](../vs140/concurrent_unordered_map-class.md)