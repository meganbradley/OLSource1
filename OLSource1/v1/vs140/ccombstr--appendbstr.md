---
title: "CComBSTR::AppendBSTR"
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
  - "ATL.CComBSTR.AppendBSTR"
  - "ATL::CComBSTR::AppendBSTR"
  - "CComBSTR.AppendBSTR"
  - "CComBSTR::AppendBSTR"
  - "AppendBSTR"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AppendBSTR method"
ms.assetid: f8edd475-921b-4652-8b78-f8475c49b233
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComBSTR::AppendBSTR
Appends the specified `BSTR` to [m_str](../vs140/ccombstr--m_str.md).  
  
## Syntax  
  
```  
  
      HRESULT AppendBSTR(  
   BSTR p   
) throw( );  
```  
  
#### Parameters  
 `p`  
 [in] A `BSTR` to append.  
  
## Return Value  
 `S_OK` on success, or any standard `HRESULT` error value.  
  
## Remarks  
 Do not pass an ordinary wide-character string to this method. The compiler cannot catch the error and run time errors will occur.  
  
## Example  
 [!code[NVC_ATL_Utilities#33](../vs140/codesnippet/CPP/ccombstr--appendbstr_1.cpp)]  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComBSTR Class](../vs140/ccombstr-class.md)   
 [CComBSTR::Append](../vs140/ccombstr--append.md)   
 [CComBSTR::operator +=](../vs140/ccombstr--operator--=.md)   
 [ATL and MFC String Conversion Macros](../vs140/atl-and-mfc-string-conversion-macros.md)