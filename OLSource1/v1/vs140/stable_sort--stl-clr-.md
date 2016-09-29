---
title: "stable_sort (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "stable_sort (STL/CLR)"
f1_keywords: 
  - "cliext::stable_sort"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "stable_sort function [STL/CLR]"
ms.assetid: c28fc2df-c68b-4923-ac16-9f8edd926fbb
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# stable_sort (STL-CLR)
Arranges the elements in a specified range into a nondescending order or according to an ordering criterion specified by a binary predicate and preserves the relative ordering of equivalent elements.  
  
## Syntax  
  
```  
template<class _BidIt> inline  
    void stable_sort(_BidIt _First, _BidIt _Last);  
template<class _BidIt, class _Pr> inline  
    void stable_sort(_BidIt _First, _BidIt _Last, _Pr _Pred);  
```  
  
## Remarks  
 This function behaves the same as the STL function `stable_sort`. For more information, see [stable_sort](../vs140/stable_sort.md).  
  
## Requirements  
 **Header:** <cliext/algorithm>  
  
 **Namespace:** cliext  
  
## See Also  
 [algorithm (STL/CLR)](../vs140/algorithm--stl-clr-.md)