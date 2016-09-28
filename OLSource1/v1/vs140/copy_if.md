---
title: "copy_if"
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
  - "algorithm/std::copy_if"
  - "copy_if"
  - "std.copy_if"
  - "std::copy_if"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "copy_if function"
  - "copy_if"
ms.assetid: 56694c4a-6e99-414e-9748-6992a81c78a6
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# copy_if
In a range of elements, copies the elements that are `true` for the specified condition.  
  
## Syntax  
  
```  
template<class InputIterator, class OutputIterator, class BinaryPredicate>  
   OutputIterator copy_if(  
      InputIterator _First,   
      InputIterator _Last,  
      OutputIterator _Dest,  
      Predicate _Pred  
    );  
```  
  
#### Parameters  
 `_First`  
 An input iterator that indicates the start of a range to check for the condition.  
  
 `_Last`  
 An input iterator that indicates the end of the range.  
  
 `_Dest`  
 The output iterator that indicates the destination for the copied elements.  
  
 `_Pred`  
 The condition against which every element in the range is tested. This condition is provided by a user-defined predicate function object. A predicate takes one argument and returns `true` or `false`.  
  
## Return Value  
 An output iterator that equals `_Dest` incremented once for each element that fulfills the condition. In other words, the return value minus `_Dest` equals the number of copied elements.  
  
## Remarks  
 The template function evaluates  
  
 `if (` `_Pred` `(*` `_First`  `+ N))`  
  
 `*` `_Dest` `++ = *(` `_First`  `+ N))`  
  
 once for each `N` in the range `[0,` `_Last` `-` `_First``)`, for strictly increasing values of `N` starting with the lowest value. If `_Dest` and `_First` designate regions of storage, `_Dest` must not be in the range `[``_First``,` `_Last``)`.  
  
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [Standard Template Library](../vs140/standard-template-library.md)