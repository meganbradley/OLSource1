---
title: "CComBSTR::AppendBytes"
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
  - "ATL::CComBSTR::AppendBytes"
  - "ATL.CComBSTR.AppendBytes"
  - "CComBSTR::AppendBytes"
  - "CComBSTR.AppendBytes"
  - "AppendBytes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AppendBytes method"
ms.assetid: 6ea412f3-2f9d-415a-a23d-c6d17f625794
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComBSTR::AppendBytes
Appends the specified number of bytes to [m_str](../vs140/ccombstr--m_str.md) without conversion.  
  
## Syntax  
  
```  
  
      HRESULT AppendBytes(  
   const char* lpsz,  
   int nLen  
) throw( );  
```  
  
#### Parameters  
 `lpsz`  
 [in] A pointer to an array of bytes to append.  
  
 `p`  
 [in] The number of bytes to append.  
  
## Return Value  
 `S_OK` on success, or any standard `HRESULT` error value.  
  
## Example  
 [!code[NVC_ATL_Utilities#34](../vs140/codesnippet/CPP/ccombstr--appendbytes_1.cpp)]  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComBSTR Class](../vs140/ccombstr-class.md)   
 [CComBSTR::Append](../vs140/ccombstr--append.md)   
 [CComBSTR::operator +=](../vs140/ccombstr--operator--=.md)   
 [CComBSTR::operator +=](../vs140/ccombstr--operator--=.md)