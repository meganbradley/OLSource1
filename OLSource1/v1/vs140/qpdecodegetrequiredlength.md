---
title: "QPDecodeGetRequiredLength"
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
  - "QPDecodeGetRequiredLength"
  - "ATLENC/QPDecodeGetRequiredLength"
  - "ATL::QPDecodeGetRequiredLength"
  - "ATL.QPDecodeGetRequiredLength"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QPDecodeGetRequiredLength function"
ms.assetid: 84750f57-75c3-4c0d-bcfa-57a55d034198
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QPDecodeGetRequiredLength
Call this function to get the size in bytes of a buffer that could contain data decoded from quoted-printable-encoded string of the specified length.  
  
## Syntax  
  
```  
  
      inline int QPDecodeGetRequiredLength(  
   int nSrcLen   
) throw( );  
```  
  
#### Parameters  
 `nSrcLen`  
 The number of characters in the encoded string.  
  
## Return Value  
 The number of bytes required for a buffer that could hold a decoded string of `nSrcLen` characters.  
  
## Remarks  
 The quoted-printable encoding scheme is described in RFC 2045 ([http://www.ietf.org/rfc/rfc2045.txt](http://www.ietf.org/rfc/rfc2045.txt)).  
  
## Requirements  
 **Header:** atlenc.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)   
 [QPDecode](../vs140/qpdecode.md)   
 [QPEncode](../vs140/qpencode.md)   
 [QPEncodeGetRequiredLength](../vs140/qpencodegetrequiredlength.md)