---
title: "UUDecode"
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
  - "UUDecode"
  - "ATLENC/UUDecode"
  - "ATL.UUDecode"
  - "ATL::UUDecode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UUDecode function"
ms.assetid: 5841f625-166f-4f4a-a4f8-841982fa7a22
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# UUDecode
Decodes a string of data that has been uuencoded such as by a previous call to [UUEncode](../vs140/uuencode.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The string containing the data to be decoded.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The length in bytes of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Caller-allocated buffer to receive the decoded data.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to a variable that contains the length in bytes of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. If the function succeeds, the variable receives the number of bytes written to the buffer. If the function fails, the variable receives the required length in bytes of the buffer.  
  
## Return Value  
 Returns **TRUE** on success, **FALSE** on failure.  
  
## Remarks  
 This uuencoding implementation follows the POSIX P1003.2b/D11 specification.  
  
## Requirements  
 **Header:** atlenc.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)   
 [UUDecodeGetRequiredLength](../vs140/uudecodegetrequiredlength.md)   
 [UUEncode](../vs140/uuencode.md)   
 [UUEncodeGetRequiredLength](../vs140/uuencodegetrequiredlength.md)