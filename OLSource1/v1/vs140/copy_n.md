---
title: "copy_n"
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
  - "copy_n"
  - "xutility/std::copy_n"
  - "std.copy_n"
  - "std::copy_n"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "copy_n"
  - "copy_n function"
ms.assetid: 22620efb-2fc0-477f-88ed-837e2f595539
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# copy_n
Copies a specified number of elements.  
  
## Syntax  
  
```  
template<class InputIterator, class Size, class OutputIterator>  
OutputIterator copy_n(InputIterator first, Size count, OutputIterator dest);  
```  
  
#### Parameters  
 `first`  
 An input iterator that indicates where to copy elements from.  
  
 `count`  
 A signed or unsigned integer type specifying the number of elements to copy.  
  
 `dest`  
 An output iterator that indicates where to copy elements to.  
  
## Return Value  
 Returns an output iterator where elements have been copied to. It is the same as the returned value of the third parameter, `dest`.  
  
## Remarks  
 The template function evaluates `*(dest + N) = *(first + N))` once for each `N` in the range `[0,` `count``)`, for strictly increasing values of `N` starting with the lowest value. It then returns `dest` `+ N`. If `dest` and `first` designate regions of storage, `dest` must not be in the range `[``first``,` `Last``)`.  
  
## Requirements  
 **Header:** <algorithm\>  
  
 **Namespace:** std  
  
## See Also  
 [<algorithm\>](../vs140/-algorithm-.md)