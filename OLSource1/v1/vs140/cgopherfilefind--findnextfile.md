---
title: "CGopherFileFind::FindNextFile"
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
  - CGopherFileFind.FindNextFile
  - CGopherFileFind::FindNextFile
dev_langs: 
  - C++
helpviewer_keywords: 
  - FindNextFile method
  - CGopherFileFind class, attributes
ms.assetid: 2ab74d73-1b50-4397-9c6c-ee0718f4e2ca
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CGopherFileFind::FindNextFile
Call this member function to continue a file search begun with a call to [CGopherFileFind::FindFile](../vs140/cgopherfilefind--findfile.md).  
  
## Syntax  
  
```  
  
virtual BOOL FindNextFile( );  
  
```  
  
## Return Value  
 Nonzero if there are more files; zero if the file found is the last one in the directory or if an error occurred. To get extended error information, call the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360). If the file found is the last file in the directory, or if no matching files can be found, the `GetLastError` function returns ERROR_NO_MORE_FILES.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CGopherFileFind Class](../vs140/cgopherfilefind-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileFind::FindNextFile](../vs140/cfilefind--findnextfile.md)