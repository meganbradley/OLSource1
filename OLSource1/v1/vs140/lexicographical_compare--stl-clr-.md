---
title: "lexicographical_compare (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "lexicographical_compare (STL/CLR)"
f1_keywords: 
  - "cliext::lexicographical_compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lexicographical_compare function [STL/CLR]"
ms.assetid: 9ec217f3-5523-4f90-a0cc-8fb7dbe4946b
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# lexicographical_compare (STL-CLR)
Compares element by element between two sequences to determine which is lesser of the two.  
  
## Syntax  
  
```  
template<class _InIt1, class _InIt2> inline  
    bool lexicographical_compare(_InIt1 _First1, _InIt1 _Last1,  
        _InIt2 _First2, _InIt2 _Last2);  
template<class _InIt1, class _InIt2, class _Pr> inline  
    bool lexicographical_compare(_InIt1 _First1, _InIt1 _Last1,  
        _InIt2 _First2, _InIt2 _Last2, _Pr _Pred);  
```  
  
## Remarks  
 This function behaves the same as the STL function `lexicographical_compare`. For more information, see [lexicographical_compare](../vs140/lexicographical_compare.md).  
  
## Requirements  
 **Header:** <cliext/algorithm>  
  
 **Namespace:** cliext  
  
## See Also  
 [algorithm (STL/CLR)](../vs140/algorithm--stl-clr-.md)