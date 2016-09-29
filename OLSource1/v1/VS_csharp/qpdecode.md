---
title: "QPDecode"
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
  - "ATL.QPDecode"
  - "QPDecode"
  - "ATL::QPDecode"
  - "ATLENC/QPDecode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QPDecode function"
ms.assetid: c5caf731-9bc4-4740-8899-720f84ed014c
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QPDecode
Decodes a string of data that has been encoded in quoted-printable format such as by a previous call to [QPEncode](../VS_csharp/qpencode.md).  
  
## Syntax  
  
```  
inline BOOL QPDecode(  
   BYTE* pbSrcData,  
   int nSrcLen,  
   LPSTR szDest,  
   int* pnDestLen,  
   DWORD dwFlags = 0   
) throw( );  
```  
  
#### Parameters  
 [in] `pbSrcData`  
 The buffer containing the data to be decoded.  
  
 [in] `nSrcLen`  
 The length in bytes of `pbSrcData`.  
  
 [out] `szDest`  
 Caller-allocated buffer to receive the decoded data.  
  
 [out] `pnDestLen`  
 Pointer to a variable that contains the length in bytes of `szDest`. If the function succeeds, the variable receives the number of bytes written to the buffer. If the function fails, the variable receives the required length in bytes of the buffer.  
  
 [in] `dwFlags`  
 Flags describing how the conversion is to be performed. See [ATLSMTP_QPENCODE Flags](../VS_csharp/atlsmtp_qpencode-flags.md).  
  
## Return Value  
 Returns `TRUE` on success, `FALSE` on failure.  
  
## Remarks  
 The quoted-printable encoding scheme is described in RFC 2045 ([http://www.ietf.org/rfc/rfc2045.txt](http://www.ietf.org/rfc/rfc2045.txt)).  
  
## Requirements  
 **Header:** atlenc.h  
  
## See Also  
 [ATL Concepts](../VS_csharp/active-template-library--atl--concepts.md)   
 [ATL Reference](../VS_csharp/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../VS_csharp/atl-functions-alphabetical-reference.md)   
 [QPDecodeGetRequiredLength](../VS_csharp/qpdecodegetrequiredlength.md)   
 [QPEncode](../VS_csharp/qpencode.md)   
 [QPEncodeGetRequiredLength](../VS_csharp/qpencodegetrequiredlength.md)