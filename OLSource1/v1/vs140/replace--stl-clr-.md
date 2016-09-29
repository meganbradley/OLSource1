---
title: "replace (STL-CLR)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "replace (STL/CLR)"
f1_keywords: 
  - "cliext::replace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "replace function [STL/CLR]"
ms.assetid: 3792abca-8d73-476a-8540-c5f739aa48c2
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# replace (STL-CLR)
Examines each element in a range and replaces it if it matches a specified value.  
  
## Syntax  
  
```  
template<class _FwdIt, class _Ty> inline  
    void replace(_FwdIt _First, _FwdIt _Last,  
        const _Ty% _Oldval, const _Ty% _Newval);  
```  
  
## Remarks  
 This function behaves the same as the STL function `replace`. For more information, see [replace](../vs140/replace.md).  
  
## Requirements  
 **Header:** <cliext/algorithm>  
  
 **Namespace:** cliext  
  
## See Also  
 [algorithm (STL/CLR)](../vs140/algorithm--stl-clr-.md)