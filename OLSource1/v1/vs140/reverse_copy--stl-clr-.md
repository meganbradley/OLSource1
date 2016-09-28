---
title: "reverse_copy (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "reverse_copy (STL/CLR)"
f1_keywords: 
  - "cliext::reverse_copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reverse_copy function [STL/CLR]"
ms.assetid: 694e577a-0fa8-44f7-adde-6dd9f45adefd
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# reverse_copy (STL-CLR)
Reverses the order of the elements within a source range while copying them into a destination range.  
  
## Syntax  
  
```  
template<class _BidIt, class _OutIt> inline  
    _OutIt reverse_copy(_BidIt _First, _BidIt _Last, _OutIt _Dest);  
```  
  
## Remarks  
 This function behaves the same as the STL function `reverse_copy`. For more information, see [reverse_copy](../vs140/reverse_copy.md).  
  
## Requirements  
 **Header:** <cliext/algorithm>  
  
 **Namespace:** cliext  
  
## See Also  
 [algorithm (STL/CLR)](../vs140/algorithm--stl-clr-.md)