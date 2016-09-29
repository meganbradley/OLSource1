---
title: "CFile::Read"
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
  - "CFile::Read"
  - "CFile.Read"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Read method"
  - "CFile class, input/output"
ms.assetid: 72afe77e-8a6f-4308-8c1a-3899ad4f8a36
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFile::Read
Reads data into a buffer from the file associated with the `CFile` object.  
  
## Syntax  
  
```  
  
      virtual UINT Read(  
   void* lpBuf,  
   UINT nCount   
);  
```  
  
#### Parameters  
 `lpBuf`  
 Pointer to the user-supplied buffer that is to receive the data read from the file.  
  
 `nCount`  
 The maximum number of bytes to be read from the file. For text-mode files, carriage return–linefeed pairs are counted as single characters.  
  
## Return Value  
 The number of bytes transferred to the buffer. Note that for all `CFile` classes, the return value may be less than `nCount` if the end of file was reached.  
  
## Example  
 [!code[NVC_MFCFiles#15](../vs140/codesnippet/CPP/cfile--read_1.cpp)]  
  
 For another example see [CFile::Open](../vs140/cfile--open.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFile Class](../vs140/cfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)