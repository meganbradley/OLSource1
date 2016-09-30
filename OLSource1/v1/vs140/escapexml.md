---
title: "EscapeXML"
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
  - "ATL.EscapeXML"
  - "ATLENC/EscapeXML"
  - "EscapeXML"
  - "ATL::EscapeXML"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EscapeXML function"
ms.assetid: bc8793f9-538a-487a-b47d-2ef95e84a15b
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# EscapeXML
Call this function to convert characters that are unsafe for use in XML to their safe equivalents.  
  
## Syntax  
  
```  
  
      inline int EscapeXML(  
   const wchar_t * szIn,  
   int nSrcLen,  
   wchar_t * szEsc,  
   int nDestLen,  
   DWORD dwFlags = ATL_ESC_FLAG_NONE   
) throw( );  
```  
  
#### Parameters  
 `szIn`  
 The string to be converted.  
  
 *nSrclen*  
 The length in characters of the string to be converted.  
  
 *szEsc*  
 Caller-allocated buffer to receive the converted string.  
  
 *nDestLen*  
 The length in characters of the caller-allocated buffer.  
  
 `dwFlags`  
 Flags describing how the conversion is to be performed. See [ATL_ESC Flags](../vs140/atl_esc-flags.md).  
  
## Return Value  
 The length in characters of the converted string.  
  
## Remarks  
 Possible conversions performed by this function are shown in the table:  
  
|Source|Destination|  
|------------|-----------------|  
|\<|&lt;|  
|>|&gt;|  
|&|&amp;|  
|'|&apos;|  
|"|&quot;|  
  
## Requirements  
 **Header:** atlenc.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)