---
title: "AtlHexDecode"
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
  - "AtlHexDecode"
  - "ATLENC/AtlHexDecode"
  - "ATL::AtlHexDecode"
  - "ATL.AtlHexDecode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlHexDecode function"
ms.assetid: 305ccc56-7f96-4795-b297-b04e58c98187
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlHexDecode
Decodes a string of data that has been encoded as hexadecimal text such as by a previous call to [AtlHexEncode](../VS_csharp/atlhexencode.md).  
  
## Syntax  
  
```  
  
      inline BOOL AtlHexDecode(  
   LPCSTR pSrcData,  
   int nSrcLen,  
   LPBYTE pbDest,  
   int* pnDestLen   
) throw( );  
```  
  
#### Parameters  
 `pSrcData`  
 The string containing the data to be decoded.  
  
 `nSrcLen`  
 The length in characters of `pSrcData`.  
  
 `pbDest`  
 Caller-allocated buffer to receive the decoded data.  
  
 `pnDestLen`  
 Pointer to a variable that contains the length in bytes of `pbDest`. If the function succeeds, the variable receives the number of bytes written to the buffer. If the function fails, the variable receives the required length in bytes of the buffer.  
  
## Return Value  
 Returns **TRUE** on success, **FALSE** on failure.  
  
## Requirements  
 **Header:** atlenc.h  
  
## See Also  
 [ATL Concepts](../VS_csharp/active-template-library--atl--concepts.md)   
 [ATL Reference](../VS_csharp/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../VS_csharp/atl-functions-alphabetical-reference.md)   
 [AtlHexDecodeGetRequiredLength](../VS_csharp/atlhexdecodegetrequiredlength.md)   
 [AtlHexEncode](../VS_csharp/atlhexencode.md)   
 [AtlHexEncodeGetRequiredLength](../VS_csharp/atlhexencodegetrequiredlength.md)