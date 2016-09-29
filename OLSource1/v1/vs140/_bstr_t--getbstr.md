---
title: "_bstr_t::GetBSTR"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "GetBSTR"
  - "_bstr_t::GetBSTR"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetBSTR method"
ms.assetid: 0c62ff16-4433-4183-a03c-d5a0a9b731ef
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _bstr_t::GetBSTR
**Microsoft Specific**  
  
 Points to the beginning of the `BSTR` wrapped by the `_bstr_t`.  
  
## Syntax  
  
```  
  
BSTR& GetBSTR( );  
  
```  
  
## Return Value  
 The beginning of the `BSTR` wrapped by the `_bstr_t`.  
  
## Remarks  
 `GetBSTR` affects all `_bstr_t` objects that share a `BSTR`. More than one `_bstr_t` can share a `BSTR` through the use of the copy constructor and and `operator=`.  
  
## Example  
 See [_bstr_t::Assign](../vs140/_bstr_t--assign.md) for an example using `GetBSTR`.  
  
 **END Microsoft Specific**  
  
## See Also  
 [_bstr_t Class](../vs140/_bstr_t-class.md)