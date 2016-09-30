---
title: "CFileFind::FindNextFile"
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
  - "CFileFind::FindNextFile"
  - "CFileFind.FindNextFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "files [C++], finding"
  - "FindNextFile method"
  - "Internet files [C++], finding"
  - "searching [C++], continuing a search"
  - "URLs [C++], finding"
  - "CFileFind class, operations"
ms.assetid: 5fc32d17-8d3c-4ba6-baf0-0a94e3178603
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileFind::FindNextFile
Call this member function to continue a file search from a previous call to [FindFile](../vs140/cfilefind--findfile.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if there are more files; zero if the file found is the last one in the directory or if an error occurred. To get extended error information, call the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360). If the file found is the last file in the directory, or if no matching files can be found, the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function returns ERROR_NO_MORE_FILES.  
  
## Remarks  
 You must call <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> at least once before calling any of the following attribute member functions:  
  
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
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> wraps the Win32 function [FindNextFile](http://msdn.microsoft.com/library/windows/desktop/aa364428).  
  
## Example  
 See the example for [CFileFind::IsDirectory](../vs140/cfilefind--isdirectory.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFileFind Class](../vs140/cfilefind-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)