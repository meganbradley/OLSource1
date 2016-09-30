---
title: "CFileFind::IsDirectory"
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
  - "CFileFind::IsDirectory"
  - "CFileFind.IsDirectory"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsDirectory method"
  - "directories [C++], finding"
ms.assetid: f1911844-bbcf-4442-b59b-6dcc4121611b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileFind::IsDirectory
Call this member function to determine if the found file is a directory.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 A file that is a directory is marked with FILE_ATTRIBUTE_DIRECTORY a file attribute identified in the [WIN32_FIND_DATA](http://msdn.microsoft.com/library/windows/desktop/aa365740) structure.  
  
 You must call [FindNextFile](../vs140/cfilefind--findnextfile.md) at least once before calling <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 See the member function [MatchesMask](../vs140/cfilefind--matchesmask.md) for a complete list of file attributes.  
  
## Example  
 This small program recurses every directory on the C:\ drive and prints the name of the directory.  
  
 [!code[NVC_MFCFiles#34](../vs140/codesnippet/CPP/cfilefind--isdirectory_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFileFind Class](../vs140/cfilefind-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)