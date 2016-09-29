---
title: "move_backward"
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
  - "xutility/std::move_backward"
  - "std.move_backward"
  - "move_backward"
  - "std::move_backward"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "move_backward"
  - "move_backward function"
ms.assetid: 82872773-11ce-45b9-aa73-c47d237511f5
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# move_backward
Moves the elements of one iterator to another. The move starts with the last element in a specified range, and ends with the first element in that range.  
  
## Syntax  
  
```  
  
  template<class BidirectionalIterator1, class BidirectionalIterator2>  
BidirectionalIterator2 move_backward(  
    BidirectionalIterator1 _First,   
    BidirectionalIterator1 _Last,  
    BidirectionalIterator2 _DestEnd  
);  
```  
  
#### Parameters  
 `_First`  
 An iterator that indicates the start of a range to move elements from.  
  
 `_Last`  
 An iterator that indicates the end of a range to move elements from. This element is not moved.  
  
 `_DestEnd`  
 A bidirectional iterator addressing the position of one past the final element in the destination range.  
  
## Property Value/Return Value  
 Returns an iterator that refers to the first element that is not moved.  
  
## Remarks  
 The template function evaluates `*(``_DestEnd` `- N - 1) =` `move``(*(``_Last` `- N - 1)))` once for each `N` in the range `[0,` `_Last` `-` `_First``)`, for strictly increasing values of `N` starting with the lowest value. It then returns `_DestEnd` `- (``_Last` `-` `_First``)`. If `_DestEnd` and `_First` designate regions of storage, `_DestEnd` must not be in the range `[``_First``,` `_Last``)`.  
  
 `move` and `move_backward` are functionally equivalent to using `copy` and `copy_backward` with a move iterator.  
  
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [<algorithm\>](../vs140/-algorithm-.md)   
 [copy_backward](../vs140/copy_backward.md)   
 [Standard Template Library](../vs140/standard-template-library.md)