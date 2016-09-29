---
title: "AtlHexEncode"
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
  - "ATL::AtlHexEncode"
  - "ATL.AtlHexEncode"
  - "AtlHexEncode"
  - "ATLENC/AtlHexEncode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlHexEncode function"
ms.assetid: 256f1d5c-ca40-488e-bcfb-503cf6ac0ea8
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlHexEncode
Call this function to encode some data as a string of hexadecimal text.  
  
## Syntax  
  
```  
  
      inline BOOL AtlHexEncode(  
   const BYTE * pbSrcData,  
   int nSrcLen,  
   LPSTR szDest,  
   int * pnDestLen   
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
  
## Return Value  
 Returns **TRUE** on success, **FALSE** on failure.  
  
## Remarks  
 Each byte of source data is encoded as 2 hexadecimal characters.  
  
## Requirements  
 **Header:** atlenc.h  
  
## See Also  
 [ATL Concepts](../VS_csharp/active-template-library--atl--concepts.md)   
 [ATL Reference](../VS_csharp/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../VS_csharp/atl-functions-alphabetical-reference.md)   
 [AtlHexDecodeGetRequiredLength](../VS_csharp/atlhexdecodegetrequiredlength.md)   
 [AtlHexDecode](../VS_csharp/atlhexdecode.md)   
 [AtlHexEncodeGetRequiredLength](../VS_csharp/atlhexencodegetrequiredlength.md)