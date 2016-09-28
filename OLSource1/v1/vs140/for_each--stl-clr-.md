---
title: "for_each (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "for_each (STL/CLR)"
f1_keywords: 
  - "cliext::for_each"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "for_each function [STL/CLR]"
ms.assetid: 4c391ecf-cd35-499e-a3f5-35b965e0da9b
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# for_each (STL-CLR)
Applies a specified function object to each element in a forward order within a range and returns the function object.  
  
## Syntax  
  
```  
template<class _InIt, class _Fn1> inline  
    _Fn1 for_each(_InIt _First, _InIt _Last, _Fn1 _Func);  
```  
  
## Remarks  
 This function behaves the same as the STL function `for_each`. For more information, see [for_each](../vs140/for_each.md).  
  
## Requirements  
 **Header:** <cliext/algorithm>  
  
 **Namespace:** cliext  
  
## See Also  
 [algorithm (STL/CLR)](../vs140/algorithm--stl-clr-.md)