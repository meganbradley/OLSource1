---
title: "CFileFind::GetFilePath"
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
  - "CFileFind.GetFilePath"
  - "CFileFind::GetFilePath"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFilePath method"
  - "files [C++], finding paths"
  - "URLs [C++], finding"
ms.assetid: b1304f2a-24e4-42d9-826a-fe88f07a96d2
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileFind::GetFilePath
Call this member function to get the full path of the specified file.  
  
## Syntax  
  
```  
  
virtual CString GetFilePath( ) const;  
  
```  
  
## Return Value  
 The path of the specified file.  
  
## Remarks  
 You must call [FindNextFile](../vs140/cfilefind--findnextfile.md) at least once before calling `GetFilePath`.  
  
 `GetFilePath` is one of three `CFileFind` member functions that return some form of the file name. The following list describes the three and how they vary:  
  
-   [GetFileName](../vs140/cfilefind--getfilename.md) returns the file name, including the extension. For example, calling `GetFileName` to generate a user message about the file `c:\myhtml\myfile.txt` returns the file name `myfile.txt`.  
  
-   `GetFilePath` returns the entire path for the file. For example, calling `GetFilePath` to generate a user message about the file `c:\myhtml\myfile.txt` returns the file path `c:\myhtml\myfile.txt`.  
  
-   [GetFileTitle](../vs140/cfilefind--getfiletitle.md) returns the file name, excluding the file extension. For example, calling `GetFileTitle` to generate a user message about the file `c:\myhtml\myfile.txt` returns the file title `myfile`.  
  
## Example  
 See the example for [CFileFind::GetFileName](../vs140/cfilefind--getfilename.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFileFind Class](../vs140/cfilefind-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileFind::FindFile](../vs140/cfilefind--findfile.md)