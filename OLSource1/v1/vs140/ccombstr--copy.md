---
title: "CComBSTR::Copy"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CComBSTR.Copy"
  - "ATL::CComBSTR::Copy"
  - "ATL.CComBSTR.Copy"
  - "CComBSTR::Copy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Copy method"
ms.assetid: b53b57c4-b078-40ea-a48c-99521ca5e73b
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComBSTR::Copy
Allocates and returns a copy of `m_str`.  
  
## Syntax  
  
```  
  
BSTR Copy( ) const throw();  
  
```  
  
## Return Value  
 A copy of the [m_str](../vs140/ccombstr--m_str.md) member. If `m_str` is **NULL**, returns **NULL**.  
  
## Example  
 [!code[NVC_ATL_Utilities#38](../vs140/codesnippet/CPP/ccombstr--copy_1.cpp)]  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComBSTR Class](../vs140/ccombstr-class.md)   
 [CComBSTR::CopyTo](../vs140/ccombstr--copyto.md)   
 [CComBSTR::operator =](../vs140/ccombstr--operator-=.md)