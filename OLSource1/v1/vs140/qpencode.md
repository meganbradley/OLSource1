---
title: "QPEncode"
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
  - "ATL::QPEncode"
  - "QPEncode"
  - "ATLENC/QPEncode"
  - "ATL.QPEncode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QPEncode function"
ms.assetid: f6ea53d6-3677-48bd-8717-74a3900fa3c5
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QPEncode
Call this function to encode some data in quoted-printable format.  
  
## Syntax  
  
```  
  
      inline BOOL QPEncode(  
   BYTE* pbSrcData,  
   int nSrcLen,  
   LPSTR szDest,  
   int* pnDestLen,  
   DWORD dwFlags = 0   
) throw( );  
```  
  
#### Parameters  
 `pbSrcData`  
 The buffer containing the data to be encoded.  
  
 `nSrcLen`  
 The length in bytes of the data to be encoded.  
  
 `szDest`  
 Caller-allocated buffer to receive the encoded data.  
  
 `pnDestLen`  
 Pointer to a variable that contains the length in characters of `szDest`. If the function succeeds, the variable receives the number of characters written to the buffer. If the function fails, the variable receives the required length in characters of the buffer.  
  
 `dwFlags`  
 Flags describing how the conversion is to be performed. See [ATLSMTP_QPENCODE Flags](../vs140/atlsmtp_qpencode-flags.md).  
  
## Return Value  
 Returns **TRUE** on success, **FALSE** on failure.  
  
## Remarks  
 The quoted-printable encoding scheme is described in RFC 2045 ([http://www.ietf.org/rfc/rfc2045.txt](http://www.ietf.org/rfc/rfc2045.txt)).  
  
## Requirements  
 **Header:** atlenc.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)   
 [QPDecode](../vs140/qpdecode.md)   
 [QPDecodeGetRequiredLength](../vs140/qpdecodegetrequiredlength.md)   
 [QPEncodeGetRequiredLength](../vs140/qpencodegetrequiredlength.md)