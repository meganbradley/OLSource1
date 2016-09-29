---
title: "inner_product (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "inner_product (STL/CLR)"
f1_keywords: 
  - "cliext::inner_product"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "inner_product function [STL/CLR]"
ms.assetid: 97d7a507-7494-4216-aedf-0546ed0edb3f
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# inner_product (STL-CLR)
Computes the sum of the element-wise product of two ranges and adds it to a specified initial value or computes the result of a generalized procedure where the sum and product binary operations are replaced by other specified binary operations.  
  
## Syntax  
  
```  
template<class _InIt1, class _InIt2, class _Ty> inline  
    _Ty inner_product(_InIt1 _First1, _InIt1 _Last1, _InIt2 _First2,  
        _Ty _Val);  
template<class _InIt1, class _InIt2, class _Ty, class _Fn21,  
       class _Fn22> inline  
    _Ty inner_product(_InIt1 _First1, _InIt1 _Last1, _InIt2 _First2,  
        _Ty _Val, _Fn21 _Func1, _Fn22 _Func2);  
```  
  
## Remarks  
 This function behaves the same as the STL numeric function `inner_product`. For more information, see [inner_product](../vs140/inner_product.md).  
  
## Requirements  
 **Header:** <cliext/numeric>  
  
 **Namespace:** cliext  
  
## See Also  
 [numeric (STL/CLR)](../vs140/numeric--stl-clr-.md)