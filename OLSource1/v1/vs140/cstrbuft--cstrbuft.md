---
title: "CStrBufT::CStrBufT"
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
  - "CStrBufT.CStrBufT"
  - "CStrBufT::CStrBufT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CStrBufT class, constructor"
ms.assetid: 34d71f8e-e38c-453e-9e3e-c97346ef00ff
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStrBufT::CStrBufT
Constructs a buffer object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The string object associated with the buffer. Typically, the developer will use the predefined typedefs of **CStrBuf** (**TCHAR** variant), **CStrBufA** (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> variant) and **CStrBufW** (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> variant).  
  
 *nMinLength*  
 The minimum length of the character buffer.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Determines if the string length is automatically determined. Can be one of the following:  
  
-   **AUTO_LENGTH** String length is automatically determined when [CSimpleStringT::Release](../vs140/csimplestringt--releasebuffer.md) is called. The string must be null-terminated. Default value.  
  
-   **SET_LENGTH** String length is set when [CSimpleStringT::GetBuffer](../vs140/csimplestringt--getbuffer.md) is called.  
  
## Remarks  
 Creates a string buffer for the associated string object. During construction, [CSimpleStringT::GetBuffer](../vs140/csimplestringt--getbuffer.md) or [CSimpleStringT::GetBufferSetLength](../vs140/csimplestringt--getbuffersetlength.md) is called.  
  
 Note that the copy constructor is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atlsimpstr.h  
  
## See Also  
 [CStrBufT Class](../vs140/cstrbuft-class.md)   
 [CStrBufT::StringType](../vs140/cstrbuft--stringtype.md)