---
title: "&lt;alg&gt; move"
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
  - "std::move"
  - "algorithm/std::move"
  - "move"
  - "std.move"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "move function"
ms.assetid: 3e2ba411-48a8-42ce-b9b8-faa020f00645
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;alg&gt; move
Move elements associated with a specified range.  
  
## Syntax  
  
```  
template<class InputIterator, class OutputIterator>  
    OutputIterator move(  
        InputIterator _First,   
        InputIterator _Last,  
        OutputIterator _Dest  
  );  
```  
  
#### Parameters  
 `_First`  
 An input iterator that indicates where to start the range of elements to move.  
  
 `_Last`  
 An input iterator that indicates the end of a range of elements to move.  
  
 `_Dest`  
 The output iterator that is to contain the moved elements.  
  
## Property Value/Return Value  
 Returns an output iterator to the first element that was not moved.  
  
## Remarks  
 The template function evaluates `*(``_Dest` `+ N) =` [move](assetId:///bfa07080-5187-4aa7-87b5-d2d2a3fc65ab)`(*(``_First` `+ N)))` once for each `N` in the range `[0,` `_Last` `-` `_First``)`, for strictly increasing values of `N` starting with the lowest value. It then returns `_Dest` `+ N`. If `_Dest`and `_First` designate regions of storage, `_Dest` must not be in the range `[``_First``,` `_Last``)`.  
  
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [<algorithm\>](../vs140/-algorithm-.md)   
 [Standard Template Library](../vs140/standard-template-library.md)