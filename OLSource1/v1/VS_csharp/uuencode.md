---
title: "UUEncode"
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
  - "UUEncode"
  - "ATL::UUEncode"
  - "ATLENC/UUEncode"
  - "ATL.UUEncode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UUEncode function"
ms.assetid: 26fc4290-23ed-4f40-935a-93f30edab161
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# UUEncode
Call this function to uuencode some data.  
  
## Syntax  
  
```  
  
      inline BOOL UUEncode(  
   const BYTE* pbSrcData,  
   int nSrcLen,  
   LPSTR szDest,  
   int* pnDestLen,  
   LPCTSTR lpszFile = _T("file"),  
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
  
 *lpszFile*  
 The file to be added to the header when ATLSMTP_UUENCODE_HEADER is specified in `dwFlags`.  
  
 `dwFlags`  
 Flags controlling the behavior of this function. See [ATLSMTP_UUENCODE Flags](../VS_csharp/atlsmtp_uuencode-flags.md).  
  
## Return Value  
 Returns **TRUE** on success, **FALSE** on failure.  
  
## Remarks  
 This uuencoding implementation follows the POSIX P1003.2b/D11 specification.  
  
## Requirements  
 **Header:** atlenc.h  
  
## See Also  
 [ATL Concepts](../VS_csharp/active-template-library--atl--concepts.md)   
 [ATL Reference](../VS_csharp/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../VS_csharp/atl-functions-alphabetical-reference.md)   
 [UUDecode](../VS_csharp/uudecode.md)   
 [UUDecodeGetRequiredLength](../VS_csharp/uudecodegetrequiredlength.md)   
 [UUEncodeGetRequiredLength](../VS_csharp/uuencodegetrequiredlength.md)