---
title: "UUEncodeGetRequiredLength"
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
  - "ATLENC/UUEncodeGetRequiredLength"
  - "UUEncodeGetRequiredLength"
  - "ATL.UUEncodeGetRequiredLength"
  - "ATL::UUEncodeGetRequiredLength"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UUEncodeGetRequiredLength function"
ms.assetid: df54060a-ed3b-4883-bdae-5d4b28db7c86
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# UUEncodeGetRequiredLength
Call this function to get the size in characters of a buffer that could contain a string encoded from data of the specified size.  
  
## Syntax  
  
```  
  
      inline int UUEncodeGetRequiredLength(  
   int nSrcLen   
) throw( );  
```  
  
#### Parameters  
 `nSrcLen`  
 The number of bytes of data to be encoded.  
  
## Return Value  
 The number of characters required for a buffer that could hold encoded data of `nSrcLen` bytes.  
  
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
 [UUEncode](../VS_csharp/uuencode.md)