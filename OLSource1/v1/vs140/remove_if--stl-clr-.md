---
title: "remove_if (STL-CLR)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
H1: remove_if (STL/CLR)
f1_keywords: 
  - cliext::remove_if
dev_langs: 
  - C++
helpviewer_keywords: 
  - remove_if function [STL/CLR]
ms.assetid: de501d3f-965b-4a99-b833-f6fa303fbcdc
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# remove_if (STL-CLR)
Eliminates elements that satisfy a predicate from a given range without disturbing the order of the remaining elements and returning the end of a new range free of the specified value.  
  
## Syntax  
  
```  
template<class _FwdIt, class _Pr> inline  
    _FwdIt remove_if(_FwdIt _First, _FwdIt _Last, _Pr _Pred);  
```  
  
## Remarks  
 This function behaves the same as the STL function `remove_if`. For more information, see [remove_if](../vs140/remove_if.md).  
  
## Requirements  
 **Header:** <cliext/algorithm>  
  
 **Namespace:** cliext  
  
## See Also  
 [algorithm (STL/CLR)](../vs140/algorithm--stl-clr-.md)