---
title: "CStdioFile::CStdioFile"
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
  - CStdioFile::CStdioFile
  - CStdioFile.CStdioFile
dev_langs: 
  - C++
helpviewer_keywords: 
  - CStdioFile method
  - CStdioFile class, construction/destruction
ms.assetid: db832846-c0b6-4026-92bc-3e745c95da04
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CStdioFile::CStdioFile
Constructs and initializes a `CStdioFile` object.  
  
## Syntax  
  
```  
  
      CStdioFile();  
CStdioFile(  
   CAtlTransactionManager* pTM  
);  
CStdioFile(  
   FILE* pOpenStream   
);  
CStdioFile(  
   LPCTSTR lpszFileName,  
   UINT nOpenFlags   
);  
CStdioFile(  
   LPCTSTR lpszFileName,  
   UINT nOpenFlags,  
   CAtlTransactionManager* pTM  
);  
```  
  
#### Parameters  
 `pOpenStream`  
 Specifies the file pointer returned by a call to the C run-time function [fopen](../vs140/fopen--_wfopen.md).  
  
 `lpszFileName`  
 Specifies a string that is the path to the desired file. The path can be relative or absolute.  
  
 `nOpenFlags`  
 Specifies options for file creation, file sharing, and file access modes. You can specify multiple options by using the bitwise OR (`|`) operator.  
  
 One file access mode option is required; other modes are optional. See [CFile::CFile](../vs140/cfile--cfile.md) for a list of mode options and other flags. In MFC version 3.0 and later, share flags are allowed.  
  
 `pTM`  
 Pointer to CAtlTransactionManager object.  
  
## Remarks  
 The default constructor does not attach a file to the `CStdioFile` object. When using this constructor, you must use the `CStdioFile::Open` method to open a file and attach it to the `CStdioFile` object.  
  
 The single-parameter constructor attaches an open file stream to the `CStdioFile` object. Allowed pointer values include the predefined input/output file pointers `stdin`, `stdout`, or `stderr`.  
  
 The two-parameter constructor creates a `CStdioFile` object and opens the corresponding file with the given path.  
  
 If you pass `NULL` for either `pOpenStream` or `lpszFileName`, the constructor throws a `CInvalidArgException*`.  
  
 If the file cannot be opened or created, the constructor throws a `CFileException*`.  
  
## Example  
 [!code[NVC_MFCFiles#37](../vs140/codesnippet/CPP/cstdiofile--cstdiofile_1.cpp)]
  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CStdioFile Class](../vs140/cstdiofile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)