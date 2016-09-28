---
title: "CFileFind::GetLength"
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
  - "CFileFind.GetLength"
  - "CFileFind::GetLength"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lengths, file"
  - "files [C++], length"
  - "retrieving file lengths"
  - "GetLength method"
  - "file lengths [C++]"
ms.assetid: bb82cd97-6174-449e-8ecc-6afa8ee4da26
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileFind::GetLength
Call this member function to get the length of the found file, in bytes.  
  
## Syntax  
  
```  
  
ULONGLONG GetLength( ) const;  
  
```  
  
## Return Value  
 The length of the found file, in bytes.  
  
## Remarks  
 You must call [FindNextFile](../vs140/cfilefind--findnextfile.md) at least once before calling `GetLength`.  
  
 `GetLength` uses the Win32 structure [WIN32_FIND_DATA](http://msdn.microsoft.com/library/windows/desktop/aa365740) to get and return the value of the file size, in bytes.  
  
> [!NOTE]
>  As of MFC 7.0, `GetLength` supports 64-bit integer types. Previously existing code built with this newer version of the library may result in truncation warnings.  
  
## Example  
 [!code[NVC_MFCFiles#33](../vs140/codesnippet/CPP/cfilefind--getlength_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFileFind Class](../vs140/cfilefind-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)