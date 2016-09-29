---
title: "CFile::SeekToEnd"
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
  - "CFile.SeekToEnd"
  - "CFile::SeekToEnd"
  - "SeekToEnd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFile class, position"
  - "SeekToEnd method"
ms.assetid: 7c53dac3-e0db-4112-a3da-f332cb74388d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFile::SeekToEnd
Sets the value of the file pointer to the logical end of the file.  
  
## Syntax  
  
```  
  
ULONGLONG SeekToEnd( );  
```  
  
## Return Value  
 The length of the file in bytes.  
  
## Remarks  
 `SeekToEnd()` is equivalent to `CFile::Seek( 0L, CFile::end )`.  
  
## Example  
 [!code[NVC_MFCFiles#19](../vs140/codesnippet/CPP/cfile--seektoend_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFile Class](../vs140/cfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFile::GetLength](../vs140/cfile--getlength.md)   
 [CFile::Seek](../vs140/cfile--seek.md)   
 [CFile::SeekToBegin](../vs140/cfile--seektobegin.md)