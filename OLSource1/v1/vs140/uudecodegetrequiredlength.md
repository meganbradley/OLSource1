---
title: "UUDecodeGetRequiredLength"
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
  - "ATL::UUDecodeGetRequiredLength"
  - "ATLENC/UUDecodeGetRequiredLength"
  - "UUDecodeGetRequiredLength"
  - "ATL.UUDecodeGetRequiredLength"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UUDecodeGetRequiredLength function"
ms.assetid: abfa1d1f-caf6-4029-a94c-1a48937791dd
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# UUDecodeGetRequiredLength
Call this function to get the size in bytes of a buffer that could contain data decoded from a uuencoded string of the specified length.  
  
## Syntax  
  
```  
  
      inline int UUDecodeGetRequiredLength(  
   int nSrcLen   
) throw( );  
```  
  
#### Parameters  
 `nSrcLen`  
 The number of characters in the encoded string.  
  
## Return Value  
 The number of bytes required for a buffer that could hold a decoded string of `nSrcLen` characters.  
  
## Remarks  
 This uuencoding implementation follows the POSIX P1003.2b/D11 specification.  
  
## Requirements  
 **Header:** atlenc.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)   
 [UUDecode](../vs140/uudecode.md)   
 [UUEncode](../vs140/uuencode.md)   
 [UUEncodeGetRequiredLength](../vs140/uuencodegetrequiredlength.md)