---
title: "CStdioFile::Open"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - Open
  - afx/CStdioFile::Open
dev_langs: 
  - C++
helpviewer_keywords: 
  - Open
ms.assetid: eca4684f-20ee-493c-ad25-1ef7e56ebd5d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CStdioFile::Open
Overloaded. Open is designed for use with the default `CStdioFile` constructor.  
  
## Syntax  
  
```  
virtual BOOL Open(  
   LPCTSTR lpszFileName,  
   UINT nOpenFlags,  
   CFileException* pError = NULL  
);  
virtual BOOL Open(  
   LPCTSTR lpszFileName,  
   UINT nOpenFlags,  
   CAtlTransactionManager* pTM,  
   CFileException* pError = NULL  
);  
```  
  
#### Parameters  
 `lpszFileName`  
 A string that is the path to the desired file. The path can be relative or absolute.  
  
 `nOpenFlags`  
 Sharing and access mode. Specifies the action to take when opening the file. You can combine options by using the bitwise-OR (&#124;) operator. One access permission and one share option are required; the modeCreate and modeNoInherit modes are optional.  
  
 `pError`  
 A pointer to an existing file-exception object that will receive the status of a failed operation.  
  
 `pTM`  
 Pointer to a `CAtlTransactionManager` object.  
  
## Return Value  
 `TRUE` if successful; otherwise `FALSE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CStdioFile Class](../vs140/cstdiofile-class.md)