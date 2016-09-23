---
title: "CFileFind::IsTemporary"
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
  - CFileFind.IsTemporary
  - CFileFind::IsTemporary
  - IsTemporary
dev_langs: 
  - C++
helpviewer_keywords: 
  - temporary files, finding
  - IsTemporary method
ms.assetid: 7c7adbc7-78b2-481d-825a-9f535f715d09
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFileFind::IsTemporary
Call this member function to determine if the found file is a temporary file.  
  
## Syntax  
  
```  
  
BOOL IsTemporary( ) const;  
  
```  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 A temporary file is marked with FILE_ATTRIBUTE_TEMPORARY, a file attribute identified in the [WIN32_FIND_DATA](http://msdn.microsoft.com/library/windows/desktop/aa365740) structure. A temporary file is used for temporary storage. Applications should write to the file only if absolutely necessary. Most of the file's data remains in memory without being flushed to the media because the file will soon be deleted.  
  
 You must call [FindNextFile](../vs140/cfilefind--findnextfile.md) at least once before calling `IsTemporary`.  
  
 See the member function [MatchesMask](../vs140/cfilefind--matchesmask.md) for a complete list of file attributes.  
  
## Example  
 See the example for [CFileFind::GetLength](../vs140/cfilefind--getlength.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFileFind Class](../vs140/cfilefind-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)