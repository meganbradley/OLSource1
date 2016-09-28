---
title: "CFileException::m_cause"
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
  - "CFileException.m_cause"
  - "CFileException::m_cause"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "enum CFileException"
  - "m_cause"
  - "CFileException class, data members"
  - "CFileException class, enumerated types"
ms.assetid: 5cb21301-2671-4007-9659-adae06ecb5ef
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileException::m_cause
Contains values defined by a `CFileException` enumerated type.  
  
## Syntax  
  
```  
int m_cause;  
```  
  
## Remarks  
 This data member is a public variable of type `int`. The enumerators and their meanings are as follows:  
  
-   `CFileException::none` 0: No error occurred.  
  
-   `CFileException::genericException` 1: An unspecified error occurred.  
  
-   `CFileException::fileNotFound` 2: The file could not be located.  
  
-   `CFileException::badPath` 3: All or part of the path is invalid.  
  
-   `CFileException::tooManyOpenFiles` 4: The permitted number of open files was exceeded.  
  
-   `CFileException::accessDenied` 5: The file could not be accessed.  
  
-   `CFileException::invalidFile` 6: There was an attempt to use an invalid file handle.  
  
-   `CFileException::removeCurrentDir` 7: The current working directory cannot be removed.  
  
-   `CFileException::directoryFull` 8: There are no more directory entries.  
  
-   `CFileException::badSeek` 9: There was an error trying to set the file pointer.  
  
-   `CFileException::hardIO` 10: There was a hardware error.  
  
-   `CFileException::sharingViolation` 11: SHARE.EXE was not loaded, or a shared region was locked.  
  
-   `CFileException::lockViolation` 12: There was an attempt to lock a region that was already locked.  
  
-   `CFileException::diskFull` 14: The disk is full.  
  
-   `CFileException::endOfFile` 15: The end of file was reached.  
  
    > [!NOTE]
    >  These `CFileException` cause enumerators are distinct from the `CArchiveException` cause enumerators.  
  
    > [!NOTE]
    >  `CArchiveException::generic` is deprecated. Use `genericException` instead. If `generic` is used in an application and built with /clr, the resulting syntax errors are not easy to decipher.  
  
## Example  
 [!code[NVC_MFCFiles#30](../vs140/codesnippet/CPP/cfileexception--m_cause_1.cpp)]  
  
## Requirements  
 Header: afx.h  
  
## See Also  
 [CFileException Class](../vs140/cfileexception-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)