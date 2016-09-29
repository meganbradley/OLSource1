---
title: "binary_search (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "binary_search (STL/CLR)"
f1_keywords: 
  - "cliext::binary_search"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "binary_search function [STL/CLR]"
ms.assetid: 520869cc-7cd3-4c81-b439-05f042474416
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# binary_search (STL-CLR)
Tests whether there is an element in a sorted range that is equal to a specified value or that is equivalent to it in a sense specified by a binary predicate.  
  
## Syntax  
  
```  
template<class _FwdIt, class _Ty> inline  
    bool binary_search(_FwdIt _First, _FwdIt _Last, const _Ty% _Val);  
template<class _FwdIt, class _Ty, class _Pr> inline  
    bool binary_search(_FwdIt _First, _FwdIt _Last,  
        const _Ty% _Val, _Pr _Pred);  
```  
  
## Remarks  
 This function behaves the same as the STL function `binary_search`. For more information, see [binary_search](../vs140/binary_search.md).  
  
## Requirements  
 **Header:** <cliext/algorithm>  
  
 **Namespace:** cliext  
  
## See Also  
 [algorithm (STL/CLR)](../vs140/algorithm--stl-clr-.md)