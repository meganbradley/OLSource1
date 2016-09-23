---
title: "AtlHexDecodeGetRequiredLength"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATL::AtlHexDecodeGetRequiredLength
  - ATLENC/AtlHexDecodeGetRequiredLength
  - ATL.AtlHexDecodeGetRequiredLength
  - AtlHexDecodeGetRequiredLength
dev_langs: 
  - C++
helpviewer_keywords: 
  - AtlHexDecodeGetRequiredLength function
ms.assetid: d2a28877-fe5e-420d-93b4-3b46d910d752
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AtlHexDecodeGetRequiredLength
Call this function to get the size in bytes of a buffer that could contain data decoded from a hex-encoded string of the specified length.  
  
## Syntax  
  
```  
  
      inline int AtlHexDecodeGetRequiredLength(  
   int nSrcLen   
) throw( );  
```  
  
#### Parameters  
 `nSrcLen`  
 The number of characters in the encoded string.  
  
## Return Value  
 The number of bytes required for a buffer that could hold a decoded string of `nSrcLen` characters.  
  
## Requirements  
 **Header:** atlenc.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)   
 [AtlHexDecode](../vs140/atlhexdecode.md)   
 [AtlHexEncode](../vs140/atlhexencode.md)   
 [AtlHexEncodeGetRequiredLength](../vs140/atlhexencodegetrequiredlength.md)