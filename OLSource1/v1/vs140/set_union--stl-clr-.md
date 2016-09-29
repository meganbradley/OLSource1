---
title: "set_union (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "set_union (STL/CLR)"
f1_keywords: 
  - "cliext::set_union"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "set_union function [STL/CLR]"
ms.assetid: 8bafbf10-172c-47d9-88af-19b9b0c1c31f
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set_union (STL-CLR)
Unites all of the elements that belong to at least one of two sorted source ranges into a single, sorted destination range, where the ordering criterion may be specified by a binary predicate.  
  
## Syntax  
  
```  
template<class _InIt1, class _InIt2, class _OutIt> inline  
    _OutIt set_union(_InIt1 _First1, _InIt1 _Last1,  
        _InIt2 _First2, _InIt2 _Last2, _OutIt _Dest);  
template<class _InIt1, class _InIt2, class _OutIt, class _Pr> inline  
    _OutIt set_union(_InIt1 _First1, _InIt1 _Last1,  
        _InIt2 _First2, _InIt2 _Last2, _OutIt _Dest, _Pr _Pred);  
```  
  
## Remarks  
 This function behaves the same as the STL function `set_union`. For more information, see [set_union](../vs140/set_union.md).  
  
## Requirements  
 **Header:** <cliext/algorithm>  
  
 **Namespace:** cliext  
  
## See Also  
 [algorithm (STL/CLR)](../vs140/algorithm--stl-clr-.md)