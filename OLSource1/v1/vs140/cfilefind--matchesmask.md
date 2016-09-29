---
title: "CFileFind::MatchesMask"
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
  - "FILE_ATTRIBUTE_NORMAL"
  - "FILE_ATTRIBUTE_HIDDEN"
  - "FILE_ATTRIBUTE_READONLY"
  - "FILE_ATTRIBUTE_TEMPORARY"
  - "FILE_ATTRIBUTE_COMPRESSED"
  - "FILE_ATTRIBUTE_ARCHIVE"
  - "MatchesMask"
  - "CFileFind.MatchesMask"
  - "FILE_ATTRIBUTE_SYSTEM"
  - "FILE_ATTRIBUTE_DIRECTORY"
  - "CFileFind::MatchesMask"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FILE_ATTRIBUTE_DIRECTORY attribute"
  - "FILE_ATTRIBUTE_NORMAL attribute"
  - "FILE_ATTRIBUTE_TEMPORARY attribute"
  - "file searches [C++]"
  - "FILE_ATTRIBUTE_HIDDEN attribute"
  - "MatchesMask method"
  - "directories [C++], searching for"
  - "FILE_ATTRIBUTE_ARCHIVE attribute"
  - "FILE_ATTRIBUTE_READONLY attribute"
  - "FILE_ATTRIBUTE_COMPRESSED attribute"
  - "FILE_ATTRIBUTE_SYSTEM attribute"
ms.assetid: 622e060f-fa1a-4e23-9b24-ea33e7c60fdf
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileFind::MatchesMask
Call this member function to test the file attributes on the found file.  
  
## Syntax  
  
```  
virtual BOOL MatchesMask(  
   DWORD dwMask   
) const;  
```  
  
#### Parameters  
 `dwMask`  
 Specifies one or more file attributes, identified in the [WIN32_FIND_DATA](http://msdn.microsoft.com/library/windows/desktop/aa365740) structure, for the found file. To search for multiple attributes, use the bitwise OR (&#124;) operator. Any combination of the following attributes is acceptable:  
  
-   FILE_ATTRIBUTE_ARCHIVE   The file is an archive file. Applications use this attribute to mark files for backup or removal.  
  
-   FILE_ATTRIBUTE_COMPRESSED   The file or directory is compressed. For a file, this means that all of the data in the file is compressed. For a directory, this means that compression is the default for newly created files and subdirectories.  
  
-   FILE_ATTRIBUTE_DIRECTORY   The file is a directory.  
  
-   FILE_ATTRIBUTE_NORMAL   The file has no other attributes set. This attribute is valid only if used alone. All other file attributes override this attribute.  
  
-   FILE_ATTRIBUTE_HIDDEN   The file is hidden. It is not to be included in an ordinary directory listing.  
  
-   FILE_ATTRIBUTE_READONLY   The file is read only. Applications can read the file but cannot write to it or delete it.  
  
-   FILE_ATTRIBUTE_SYSTEM   The file is part of or is used exclusively by the operating system.  
  
-   FILE_ATTRIBUTE_TEMPORARY   The file is being used for temporary storage. Applications should write to the file only if absolutely necessary. Most of the file's data remains in memory without being flushed to the media because the file will soon be deleted.  
  
## Return Value  
 Nonzero if successful; otherwise 0. To get extended error information, call the Win32 function [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360).  
  
## Remarks  
 You must call [FindNextFile](../vs140/cfilefind--findnextfile.md) at least once before calling `MatchesMask`.  
  
## Example  
 [!code[NVC_MFCFiles#35](../vs140/codesnippet/CPP/cfilefind--matchesmask_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFileFind Class](../vs140/cfilefind-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileFind::IsDots](../vs140/cfilefind--isdots.md)   
 [CFileFind::IsReadOnly](../vs140/cfilefind--isreadonly.md)   
 [CFileFind::IsDirectory](../vs140/cfilefind--isdirectory.md)   
 [CFileFind::IsCompressed](../vs140/cfilefind--iscompressed.md)   
 [CFileFind::IsSystem](../vs140/cfilefind--issystem.md)   
 [CFileFind::IsHidden](../vs140/cfilefind--ishidden.md)   
 [CFileFind::IsTemporary](../vs140/cfilefind--istemporary.md)   
 [CFileFind::IsNormal](../vs140/cfilefind--isnormal.md)   
 [CFileFind::IsArchived](../vs140/cfilefind--isarchived.md)