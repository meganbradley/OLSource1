---
title: "CFileFind::IsReadOnly"
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
  - "CFileFind.IsReadOnly"
  - "CFileFind::IsReadOnly"
  - "IsReadOnly"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "read-only files"
  - "IsReadOnly method"
ms.assetid: 77271c2c-ceb9-431f-b3a2-20cdc36584b9
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileFind::IsReadOnly
Call this member function to determine if the found file is read-only.  
  
## Syntax  
  
```  
  
BOOL IsReadOnly( ) const;  
  
```  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 A read-only file is marked with FILE_ATTRIBUTE_READONLY, a file attribute identified in the [WIN32_FIND_DATA](http://msdn.microsoft.com/library/windows/desktop/aa365740) structure. Applications can read such a file, but they cannot write to it or delete it.  
  
 You must call [FindNextFile](../vs140/cfilefind--findnextfile.md) at least once before calling `IsReadOnly`.  
  
 See the member function [MatchesMask](../vs140/cfilefind--matchesmask.md) for a complete list of file attributes.  
  
## Example  
 See the example for [CFileFind::GetLength](../vs140/cfilefind--getlength.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFileFind Class](../vs140/cfilefind-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)