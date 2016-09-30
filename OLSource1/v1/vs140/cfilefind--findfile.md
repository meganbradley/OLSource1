---
title: "CFileFind::FindFile"
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
  - "CFileFind::FindFile"
  - "CFileFind.FindFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "files [C++], finding"
  - "FindFile method"
  - "Internet files [C++], finding"
  - "URLs [C++], finding"
  - "CFileFind class, operations"
ms.assetid: 4e59db30-9d52-4fc8-9ef0-d817040e1ef1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileFind::FindFile
Call this member function to open a file search.  
  
## Syntax  
  
```  
  
      virtual BOOL FindFile(  
   LPCTSTR pstrName = NULL,  
   DWORD dwUnused = 0   
);  
```  
  
#### Parameters  
 `pstrName`  
 A pointer to a string containing the name of the file to find. If you pass **NULL** for `pstrName`, **FindFile** does a wildcard (*.\*) search.  
  
 *dwUnused*  
 Reserved to make **FindFile** polymorphic with derived classes. Must be 0.  
  
## Return Value  
 Nonzero if successful; otherwise 0. To get extended error information, call the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360).  
  
## Remarks  
 After calling **FindFile** to begin the file search, call [FindNextFile](../vs140/cfilefind--findnextfile.md) to retrieve subsequent files. You must call `FindNextFile` at least once before calling any of the following attribute member functions:  
  
-   [GetCreationTime](../vs140/cfilefind--getcreationtime.md)  
  
-   [GetFileName](../vs140/cfilefind--getfilename.md)  
  
-   [GetFileTitle](../vs140/cfilefind--getfiletitle.md)  
  
-   [GetFilePath](../vs140/cfilefind--getfilepath.md)  
  
-   [GetFileURL](../vs140/cfilefind--getfileurl.md)  
  
-   [GetLastAccessTime](../vs140/cfilefind--getlastaccesstime.md)  
  
-   [GetLastWriteTime](../vs140/cfilefind--getlastwritetime.md)  
  
-   [GetLength](../vs140/cfilefind--getlength.md)  
  
-   [GetRoot](../vs140/cfilefind--getroot.md)  
  
-   [IsArchived](../vs140/cfilefind--isarchived.md)  
  
-   [IsCompressed](../vs140/cfilefind--iscompressed.md)  
  
-   [IsDirectory](../vs140/cfilefind--isdirectory.md)  
  
-   [IsDots](../vs140/cfilefind--isdots.md)  
  
-   [IsHidden](../vs140/cfilefind--ishidden.md)  
  
-   [IsNormal](../vs140/cfilefind--isnormal.md)  
  
-   [IsReadOnly](../vs140/cfilefind--isreadonly.md)  
  
-   [IsSystem](../vs140/cfilefind--issystem.md)  
  
-   [IsTemporary](../vs140/cfilefind--istemporary.md)  
  
-   [MatchesMask](../vs140/cfilefind--matchesmask.md)  
  
## Example  
 See the example for [CFileFind::IsDirectory](../vs140/cfilefind--isdirectory.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFileFind Class](../vs140/cfilefind-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileFind::FindNextFile](../vs140/cfilefind--findnextfile.md)