---
title: "CComBSTR::Detach"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATL::CComBSTR::Detach
  - CComBSTR.Detach
  - CComBSTR::Detach
  - ATL.CComBSTR.Detach
dev_langs: 
  - C++
helpviewer_keywords: 
  - Detach method
ms.assetid: 9e914c0b-8c30-4030-8b78-61be3d10b0bc
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComBSTR::Detach
Detaches [m_str](../vs140/ccombstr--m_str.md) from the `CComBSTR` object and sets `m_str` to **NULL**.  
  
## Syntax  
  
```  
  
BSTR Detach( ) throw( );  
  
```  
  
## Return Value  
 The `BSTR` associated with the `CComBSTR` object.  
  
## Example  
 [!code[NVC_ATL_Utilities#40](../vs140/codesnippet/CPP/ccombstr--detach_1.cpp)]
  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComBSTR Class](../vs140/ccombstr-class.md)   
 [CComBSTR::Attach](../vs140/ccombstr--attach.md)