---
title: "UUEncode"
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
  - "UUEncode"
  - "ATL::UUEncode"
  - "ATLENC/UUEncode"
  - "ATL.UUEncode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UUEncode function"
ms.assetid: 26fc4290-23ed-4f40-935a-93f30edab161
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# UUEncode
Call this function to uuencode some data.  
  
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
  
 *lpszFile*  
 The file to be added to the header when ATLSMTP_UUENCODE_HEADER is specified in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Flags controlling the behavior of this function. See [ATLSMTP_UUENCODE Flags](../vs140/atlsmtp_uuencode-flags.md).  
  
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
 [UUDecode](../vs140/uudecode.md)   
 [UUDecodeGetRequiredLength](../vs140/uudecodegetrequiredlength.md)   
 [UUEncodeGetRequiredLength](../vs140/uuencodegetrequiredlength.md)