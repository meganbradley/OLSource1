---
title: "AtlHexEncodeGetRequiredLength"
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
  - "ATL.AtlHexEncodeGetRequiredLength"
  - "AtlHexEncodeGetRequiredLength"
  - "ATL::AtlHexEncodeGetRequiredLength"
  - "ATLENC/AtlHexEncodeGetRequiredLength"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlHexEncodeGetRequiredLength function"
ms.assetid: 7decfd9b-7227-4676-b16f-f50ffc6c0caa
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlHexEncodeGetRequiredLength
Call this function to get the size in characters of a buffer that could contain a string encoded from data of the specified size.  
  
## Syntax  
  
```  
  
      inline int AtlHexEncodeGetRequiredLength(  
   int nSrcLen   
) throw( );  
```  
  
#### Parameters  
 `nSrcLen`  
 The number of bytes of data to be encoded.  
  
## Return Value  
 The number of characters required for a buffer that could hold encoded data of `nSrcLen` bytes.  
  
## Requirements  
 **Header:** atlenc.h  
  
## See Also  
 [ATL Concepts](../VS_csharp/active-template-library--atl--concepts.md)   
 [ATL Reference](../VS_csharp/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../VS_csharp/atl-functions-alphabetical-reference.md)   
 [AtlHexDecodeGetRequiredLength](../VS_csharp/atlhexdecodegetrequiredlength.md)   
 [AtlHexEncode](../VS_csharp/atlhexencode.md)   
 [AtlHexDecode](../VS_csharp/atlhexdecode.md)