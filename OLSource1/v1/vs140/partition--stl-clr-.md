---
title: "partition (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "partition (STL/CLR)"
f1_keywords: 
  - "cliext::partition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "partition function [STL/CLR]"
ms.assetid: 3f551eb3-31ec-4b1d-b585-07718d6a1bd7
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# partition (STL-CLR)
Classifies elements in a range into two disjoint sets, with those elements satisfying a unary predicate preceding those that fail to satisfy it.  
  
## Syntax  
  
```  
template<class _BidIt, class _Pr> inline  
    _BidIt partition(_BidIt _First, _BidIt _Last, _Pr _Pred);  
```  
  
## Remarks  
 This function behaves the same as the STL function `partition`. For more information, see [partition](../vs140/partition.md).  
  
## Requirements  
 **Header:** <cliext/algorithm>  
  
 **Namespace:** cliext  
  
## See Also  
 [algorithm (STL/CLR)](../vs140/algorithm--stl-clr-.md)