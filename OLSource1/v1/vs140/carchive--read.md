---
title: "CArchive::Read"
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
  - "CArchive.Read"
  - "CArchive::Read"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CArchive class, basic input/output"
  - "Read method"
ms.assetid: 41e0d014-5bfe-49b3-bb39-003fdb810ee0
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArchive::Read
Reads a specified number of bytes from the archive.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a user-supplied buffer that is to receive the data read from the archive.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An unsigned integer specifying the number of bytes to be read from the archive.  
  
## Return Value  
 An unsigned integer containing the number of bytes actually read. If the return value is less than the number requested, the end of file has been reached. No exception is thrown on the end-of-file condition.  
  
## Remarks  
 The archive does not interpret the bytes.  
  
 You can use the **Read** member function within your <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function for reading ordinary structures that are contained in your objects.  
  
## Example  
 [!code[NVC_MFCSerialization#24](../vs140/codesnippet/CPP/carchive--read_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CArchive Class](../vs140/carchive-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)