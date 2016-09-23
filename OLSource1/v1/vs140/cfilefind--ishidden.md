---
title: "CFileFind::IsHidden"
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
  - IsHidden
  - CFileFind.IsHidden
  - CFileFind::IsHidden
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsHidden method
  - hidden files
ms.assetid: d53ba7ff-e69a-40c0-99b1-4ca02014e2c2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFileFind::IsHidden
Call this member function to determine if the found file is hidden.  
  
## Syntax  
  
```  
  
BOOL IsHidden( ) const;  
  
```  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 Hidden files, which are marked with FILE_ATTRIBUTE_HIDDEN, a file attribute identified in the [WIN32_FIND_DATA](http://msdn.microsoft.com/library/windows/desktop/aa365740) structure. A hidden file is not included in an ordinary directory listing.  
  
 You must call [FindNextFile](../vs140/cfilefind--findnextfile.md) at least once before calling `IsHidden`.  
  
 See the member function [MatchesMask](../vs140/cfilefind--matchesmask.md) for a complete list of file attributes.  
  
## Example  
 See the example for [CFileFind::GetLength](../vs140/cfilefind--getlength.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFileFind Class](../vs140/cfilefind-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)