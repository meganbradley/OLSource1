---
title: "random_shuffle (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "random_shuffle (STL/CLR)"
f1_keywords: 
  - "cliext::random_shuffle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "random_shuffle function [STL/CLR]"
ms.assetid: 0f9d93e2-f50f-40e6-bbe4-2ca3231a895e
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# random_shuffle (STL-CLR)
Rearranges a sequence of `N` elements in a range into one of `N`! possible arrangements selected at random.  
  
## Syntax  
  
```  
template<class _RanIt> inline  
    void random_shuffle(_RanIt _First, _RanIt _Last);  
template<class _RanIt, class _Fn1> inline  
    void random_shuffle(_RanIt _First, _RanIt _Last, _Fn1% _Func);  
```  
  
## Remarks  
 This function behaves the same as the STL function `random_shuffle`. For more information, see [random_shuffle](../vs140/random_shuffle.md).  
  
## Requirements  
 **Header:** <cliext/algorithm>  
  
 **Namespace:** cliext  
  
## See Also  
 [algorithm (STL/CLR)](../vs140/algorithm--stl-clr-.md)