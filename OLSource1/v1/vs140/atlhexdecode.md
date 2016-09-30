---
title: "AtlHexDecode"
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
  - "AtlHexDecode"
  - "ATLENC/AtlHexDecode"
  - "ATL::AtlHexDecode"
  - "ATL.AtlHexDecode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlHexDecode function"
ms.assetid: 305ccc56-7f96-4795-b297-b04e58c98187
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlHexDecode
Decodes a string of data that has been encoded as hexadecimal text such as by a previous call to [AtlHexEncode](../vs140/atlhexencode.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The string containing the data to be decoded.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The length in characters of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Caller-allocated buffer to receive the decoded data.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Pointer to a variable that contains the length in bytes of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. If the function succeeds, the variable receives the number of bytes written to the buffer. If the function fails, the variable receives the required length in bytes of the buffer.  
  
## Return Value  
 Returns **TRUE** on success, **FALSE** on failure.  
  
## Requirements  
 **Header:** atlenc.h  
  
## See Also  
 [ATL Concepts](../vs140/active-template-library--atl--concepts.md)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)   
 [ATL Functions Alphabetical Reference](../vs140/atl-functions-alphabetical-reference.md)   
 [AtlHexDecodeGetRequiredLength](../vs140/atlhexdecodegetrequiredlength.md)   
 [AtlHexEncode](../vs140/atlhexencode.md)   
 [AtlHexEncodeGetRequiredLength](../vs140/atlhexencodegetrequiredlength.md)