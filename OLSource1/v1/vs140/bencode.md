---
title: "BEncode"
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
  - "BEncode"
  - "ATLENC/BEncode"
  - "ATL::BEncode"
  - "ATL.BEncode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BEncode function"
ms.assetid: cb8f07fb-d0a6-438f-97e9-459ac34df11f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEncode
Call this function to convert some data using the "B" encoding.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The buffer containing the data to be encoded.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The length in bytes of the data to be encoded.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Caller-allocated buffer to receive the encoded data.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to a variable that contains the length in characters of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If the function succeeds, the variable receives the number of characters written to the buffer. If the function fails, the variable receives the required length in characters of the buffer.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The character set to use for the conversion.  
  
## Return Value  
 Returns **TRUE** on success, **FALSE** on failure.  
  
## Remarks  
 The "B" encoding scheme is described in RFC 2047 ([http://www.ietf.org/rfc/rfc2047.txt](http://www.ietf.org/rfc/rfc2047.txt)).  
  
## Requirements  
 **Header:** atlenc.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)   
 [BEncodeGetRequiredLength](../vs140/bencodegetrequiredlength.md)