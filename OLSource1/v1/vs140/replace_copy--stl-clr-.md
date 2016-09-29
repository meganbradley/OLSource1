---
title: "replace_copy (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "replace_copy (STL/CLR)"
f1_keywords: 
  - "cliext::replace_copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "replace_copy function [STL/CLR]"
ms.assetid: b531b49b-b16d-4b04-8f80-74f43dd496a4
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# replace_copy (STL-CLR)
Examines each element in a source range and replaces it if it matches a specified value while copying the result into a new destination range.  
  
## Syntax  
  
```  
template<class _InIt, class _OutIt, class _Ty> inline  
    _OutIt replace_copy(_InIt _First, _InIt _Last, _OutIt _Dest,  
        const _Ty% _Oldval, const _Ty% _Newval);  
```  
  
## Remarks  
 This function behaves the same as the STL function `replace_copy`. For more information, see [replace_copy](../vs140/replace_copy.md).  
  
## Requirements  
 **Header:** <cliext/algorithm>  
  
 **Namespace:** cliext  
  
## See Also  
 [algorithm (STL/CLR)](../vs140/algorithm--stl-clr-.md)