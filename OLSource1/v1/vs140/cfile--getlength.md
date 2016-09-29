---
title: "CFile::GetLength"
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
  - "CFile.GetLength"
  - "CFile::GetLength"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFile class, position"
  - "GetLength method"
ms.assetid: 63eb24ef-0e3a-4988-a93e-fe7726985967
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFile::GetLength
Obtains the current logical length of the file in bytes.  
  
## Syntax  
  
```  
  
virtual ULONGLONG GetLength( ) const;  
```  
  
## Return Value  
 The length of the file.  
  
## Example  
 [!code[NVC_MFCFiles#7](../vs140/codesnippet/CPP/cfile--getlength_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFile Class](../vs140/cfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFile::SetLength](../vs140/cfile--setlength.md)