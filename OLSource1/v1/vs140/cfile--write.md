---
title: "CFile::Write"
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
  - "CFile::Write"
  - "CFile.Write"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFile class, input/output"
  - "Write method"
ms.assetid: 1b439e0e-277c-4d30-9a59-d881db478372
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFile::Write
Writes data from a buffer to the file associated with the `CFile` object.  
  
## Syntax  
  
```  
  
      virtual void Write(  
   const void* lpBuf,  
   UINT nCount   
);  
```  
  
#### Parameters  
 `lpBuf`  
 A pointer to the user-supplied buffer that contains the data to be written to the file.  
  
 `nCount`  
 The number of bytes to be transferred from the buffer. For text-mode files, carriage return–linefeed pairs are counted as single characters.  
  
## Remarks  
 **Write** throws an exception in response to several conditions, including the disk-full condition.  
  
## Example  
 [!code[NVC_MFCFiles#16](../vs140/codesnippet/CPP/cfile--write_1.cpp)]  
  
 In addition, see the examples for [CFile::CFile](../vs140/cfile--cfile.md) and [CFile::Open](../vs140/cfile--open.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFile Class](../vs140/cfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFile::Read](../vs140/cfile--read.md)   
 [CStdioFile::WriteString](../vs140/cstdiofile--writestring.md)