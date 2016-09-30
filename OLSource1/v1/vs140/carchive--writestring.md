---
title: "CArchive::WriteString"
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
  - "CArchive::WriteString"
  - "CArchive.WriteString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WriteString method"
ms.assetid: 9b48db3f-3b79-4796-af3f-60778ae5c39b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArchive::WriteString
Use this member function to write data from a buffer to the file associated with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies a pointer to a buffer containing a null-terminated text string.  
  
## Remarks  
 The terminating null character ('\0') is not written to the file; nor is a newline automatically written.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> throws an exception in response to several conditions, including the disk-full condition.  
  
 **Write** is also available, but rather than terminating on a null character, it writes the requested number of bytes to the file.  
  
## Example  
 [!code[NVC_MFCSerialization#30](../vs140/codesnippet/CPP/carchive--writestring_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CArchive Class](../vs140/carchive-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)