---
title: "CFileFind::IsNormal"
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
  - "CFileFind::IsNormal"
  - "IsNormal"
  - "CFileFind.IsNormal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "normal files"
  - "IsNormal method"
ms.assetid: 5ab9e670-b99d-412c-b8d7-423b647cbf55
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileFind::IsNormal
Call this member function to determine if the found file is a normal file.  
  
## Syntax  
  
```  
  
BOOL IsNormal( ) const;  
  
```  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 Files marked with FILE_ATTRIBUTE_NORMAL, a file attribute identified in the [WIN32_FIND_DATA](http://msdn.microsoft.com/library/windows/desktop/aa365740) structure. A normal file has no other attributes set. All other file attributes override this attribute.  
  
 You must call [FindNextFile](../vs140/cfilefind--findnextfile.md) at least once before calling `IsNormal`.  
  
 See the member function [MatchesMask](../vs140/cfilefind--matchesmask.md) for a complete list of file attributes.  
  
## Example  
 See the example for [CFileFind::GetLength](../vs140/cfilefind--getlength.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFileFind Class](../vs140/cfilefind-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)