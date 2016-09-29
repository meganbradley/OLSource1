---
title: "replace_if (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "replace_if (STL/CLR)"
f1_keywords: 
  - "cliext::replace_if"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "replace_if function [STL/CLR]"
ms.assetid: 485ed698-551f-4808-8562-9e32b151786d
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# replace_if (STL-CLR)
Examines each element in a range and replaces it if it satisfies a specified predicate.  
  
## Syntax  
  
```  
template<class _FwdIt, class _Pr, class _Ty> inline  
    void replace_if(_FwdIt _First, _FwdIt _Last, _Pr _Pred,  
        const _Ty% _Val);  
```  
  
## Remarks  
 This function behaves the same as the STL function `replace_if`. For more information, see [replace_if](../Topic/replace_if.md).  
  
## Requirements  
 **Header:** <cliext/algorithm>  
  
 **Namespace:** cliext  
  
## See Also  
 [algorithm (STL/CLR)](../VS_csharp/algorithm--stl-clr-.md)