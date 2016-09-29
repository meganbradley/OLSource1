---
title: "set_intersection (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "set_intersection (STL/CLR)"
f1_keywords: 
  - "cliext::set_intersection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "set_intersection function [STL/CLR]"
ms.assetid: 8a799b20-55a5-4fba-a9c1-a48597cbdae6
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set_intersection (STL-CLR)
Unites all of the elements that belong to both sorted source ranges into a single, sorted destination range, where the ordering criterion may be specified by a binary predicate.  
  
## Syntax  
  
```  
template<class _InIt1, class _InIt2, class _OutIt> inline  
    _OutIt set_intersection(_InIt1 _First1, _InIt1 _Last1,  
        _InIt2 _First2, _InIt2 _Last2, _OutIt _Dest);  
template<class _InIt1, class _InIt2, class _OutIt, class _Pr> inline  
    _OutIt set_intersection(_InIt1 _First1, _InIt1 _Last1,  
        _InIt2 _First2, _InIt2 _Last2, _OutIt _Dest, _Pr _Pred);  
```  
  
## Remarks  
 This function behaves the same as the STL function `set_intersection`. For more information, see [set_intersection](../vs140/set_intersection.md).  
  
## Requirements  
 **Header:** <cliext/algorithm>  
  
 **Namespace:** cliext  
  
## See Also  
 [algorithm (STL/CLR)](../vs140/algorithm--stl-clr-.md)