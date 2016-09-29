---
title: "CComBSTR::Append"
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
  - "CComBSTR.Append"
  - "CComBSTR::Append"
  - "ATL::CComBSTR::Append"
  - "ATL.CComBSTR.Append"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Append method"
ms.assetid: f32de0ac-9d95-4776-a97b-94f5f0d8750b
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComBSTR::Append
Appends either `lpsz` or the `BSTR` member of `bstrSrc` to [m_str](../vs140/ccombstr--m_str.md).  
  
## Syntax  
  
```  
  
      HRESULT Append(  
   const CComBSTR& bstrSrc   
) throw( );  
HRESULT Append(  
   wchar_t ch  
) throw( );  
HRESULT Append(  
   char ch  
) throw( );  
HRESULT Append(  
   LPCOLESTR lpsz   
) throw( );  
HRESULT Append(  
   LPCSTR lpsz   
) throw( );  
HRESULT Append(  
   LPCOLESTR lpsz,  
   int nLen   
) throw( );  
```  
  
#### Parameters  
 `bstrSrc`  
 [in] A `CComBSTR` object to append.  
  
 *ch*  
 [in] A character to append.  
  
 `lpsz`  
 [in] A zero-terminated character string to append. You can pass a Unicode string via the **LPCOLESTR** overload or an ANSI string via the `LPCSTR` version.  
  
 `nLen`  
 [in] The number of characters from `lpsz` to append.  
  
## Return Value  
 `S_OK` on success, or any standard `HRESULT` error value.  
  
## Remarks  
 An ANSI string will be converted to Unicode before being appended.  
  
## Example  
 [!code[NVC_ATL_Utilities#32](../vs140/codesnippet/CPP/ccombstr--append_1.cpp)]  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComBSTR Class](../vs140/ccombstr-class.md)   
 [CComBSTR::AppendBSTR](../vs140/ccombstr--appendbstr.md)   
 [CComBSTR::operator +=](../vs140/ccombstr--operator--=.md)