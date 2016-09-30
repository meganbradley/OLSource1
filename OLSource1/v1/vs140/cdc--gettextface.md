---
title: "CDC::GetTextFace"
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
  - "CDC.GetTextFace"
  - "GetTextFace"
  - "CDC::GetTextFace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTextFace method"
  - "CDC class, text functions"
ms.assetid: e6ef3bc1-361a-4b4a-b89b-e7de0cdc4bfb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetTextFace
Call this member function to copy the typeface name of the current font into a buffer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the size of the buffer (in bytes). If the typeface name is longer than the number of bytes specified by this parameter, the name is truncated.  
  
 *lpszFacename*  
 Points to the buffer for the typeface name.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to a [CString](../vs140/cstringt-class.md) object.  
  
## Return Value  
 The number of bytes copied to the buffer, not including the terminating null character. It is 0 if an error occurs.  
  
## Remarks  
 The typeface name is copied as a null-terminated string.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetTextMetrics](../vs140/cdc--gettextmetrics.md)   
 [CDC::SetTextAlign](../vs140/cdc--settextalign.md)   
 [CDC::TextOut](../vs140/cdc--textout.md)   
 [GetTextFace](http://msdn.microsoft.com/library/windows/desktop/dd144940)