---
title: "CFileFind::IsArchived"
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
  - "IsArchived"
  - "CFileFind.IsArchived"
  - "CFileFind::IsArchived"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsArchived method"
  - "archives [C++], finding archived files"
ms.assetid: 8ff1332a-d1a4-4198-b6ef-3d1c054c125d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileFind::IsArchived
Call this member function to determine if the found file is archived.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 Applications mark an archive file, which is to be backed up or removed, with FILE_ATTRIBUTE_ARCHIVE, a file attribute identified in the [WIN32_FIND_DATA](http://msdn.microsoft.com/library/windows/desktop/aa365740) structure.  
  
 You must call [FindNextFile](../vs140/cfilefind--findnextfile.md) at least once before calling <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 See the member function [MatchesMask](../vs140/cfilefind--matchesmask.md) for a complete list of file attributes.  
  
## Example  
 See the example for [CFileFind::GetLength](../vs140/cfilefind--getlength.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFileFind Class](../vs140/cfilefind-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)