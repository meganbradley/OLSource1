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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The number of bytes of data to be encoded.  
  
## Return Value  
 The number of characters required for a buffer that could hold encoded data of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> bytes.  
  
## Remarks  
 This uuencoding implementation follows the POSIX P1003.2b/D11 specification.  
  
## Requirements  
 **Header:** atlenc.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)   
 [UUDecode](../vs140/uudecode.md)   
 [UUDecodeGetRequiredLength](../vs140/uudecodegetrequiredlength.md)   
 [UUEncode](../vs140/uuencode.md)