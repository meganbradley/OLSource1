---
title: "QEncodeGetRequiredLength"
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
  - "ATL.QEncodeGetRequiredLength"
  - "ATL::QEncodeGetRequiredLength"
  - "QEncodeGetRequiredLength"
  - "ATLENC/QEncodeGetRequiredLength"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QEncodeGetRequiredLength function"
ms.assetid: 7f9faf68-66a5-4f33-87c4-dcd97eeaae4f
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QEncodeGetRequiredLength
Call this function to get the size in characters of a buffer that could contain a string encoded from data of the specified size.  
  
## Syntax  
  
```  
  
      inline int QEncodeGetRequiredLength(  
   int nSrcLen,  
   int nCharsetLen   
) throw( );  
```  
  
#### Parameters  
 `nSrcLen`  
 The number of bytes of data to be encoded.  
  
 `nCharsetLen`  
 The length in characters of the character set to use for the conversion.  
  
## Return Value  
 The number of characters required for a buffer that could hold encoded data of `nSrcLen` bytes.  
  
## Remarks  
 The "Q" encoding scheme is described in RFC 2047 ([http://www.ietf.org/rfc/rfc2047.txt](http://www.ietf.org/rfc/rfc2047.txt)).  
  
## Requirements  
 **Header:** atlenc.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)   
 [QEncode](../vs140/qencode.md)