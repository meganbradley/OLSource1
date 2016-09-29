---
title: "equal (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "equal (STL/CLR)"
f1_keywords: 
  - "cliext::equal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "equal function [STL/CLR]"
ms.assetid: 7f271666-2198-4e33-8e03-8b73b376c724
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# equal (STL-CLR)
Compares two ranges element by element either for equality or equivalence in a sense specified by a binary predicate.  
  
## Syntax  
  
```  
template<class _InIt1, class _InIt2> inline  
    bool equal(_InIt1 _First1, _InIt1 _Last1, _InIt2 _First2);  
template<class _InIt1, class _InIt2, class _Pr> inline  
    bool equal(_InIt1 _First1, _InIt1 _Last1, _InIt2 _First2,  
        _Pr _Pred);  
```  
  
## Remarks  
 This function behaves the same as the STL function `equal`. For more information, see [equal](../vs140/equal.md).  
  
## Requirements  
 **Header:** <cliext/algorithm>  
  
 **Namespace:** cliext  
  
## See Also  
 [algorithm (STL/CLR)](../vs140/algorithm--stl-clr-.md)