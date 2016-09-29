---
title: "nth_element (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "nth_element (STL/CLR)"
f1_keywords: 
  - "cliext::nth_element"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "nth_element function [STL/CLR]"
ms.assetid: 19fc1695-62a9-4f85-9920-d153c1c6481f
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# nth_element (STL-CLR)
Partitions a range of elements, correctly locating the `n`th element of the sequence in the range so that all the elements in front of it are less than or equal to it and all the elements that follow it in the sequence are greater than or equal to it.  
  
## Syntax  
  
```  
template<class _RanIt> inline  
    void nth_element(_RanIt _First, _RanIt _Nth, _RanIt _Last);  
template<class _RanIt, class _Pr> inline  
    void nth_element(_RanIt _First, _RanIt _Nth, _RanIt _Last,  
        _Pr _Pred);  
```  
  
## Remarks  
 This function behaves the same as the STL function `nth_element`. For more information, see [nth_element](../vs140/nth_element.md).  
  
## Requirements  
 **Header:** <cliext/algorithm>  
  
 **Namespace:** cliext  
  
## See Also  
 [algorithm (STL/CLR)](../vs140/algorithm--stl-clr-.md)