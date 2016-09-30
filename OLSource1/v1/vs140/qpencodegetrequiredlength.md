---
title: "QPEncodeGetRequiredLength"
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
  - "QPEncodeGetRequiredLength"
  - "ATLENC/QPEncodeGetRequiredLength"
  - "ATL::QPEncodeGetRequiredLength"
  - "ATL.QPEncodeGetRequiredLength"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QPEncodeGetRequiredLength function"
ms.assetid: 68652cfd-17f0-45c6-a12a-3a6096ea11e5
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# QPEncodeGetRequiredLength
Call this function to get the size in characters of a buffer that could contain a string encoded from data of the specified size.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The number of bytes of data to be encoded.  
  
## Return Value  
 The number of characters required for a buffer that could hold encoded data of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> bytes.  
  
## Remarks  
 The quoted-printable encoding scheme is described in RFC 2045 ([http://www.ietf.org/rfc/rfc2045.txt](http://www.ietf.org/rfc/rfc2045.txt)).  
  
## Requirements  
 **Header:** atlenc.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)   
 [QPDecode](../vs140/qpdecode.md)   
 [QPDecodeGetRequiredLength](../vs140/qpdecodegetrequiredlength.md)   
 [QPEncode](../vs140/qpencode.md)