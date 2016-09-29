---
title: "CRecentFileList::CRecentFileList"
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
  - "CRecentFileList.CRecentFileList"
  - "CRecentFileList::CRecentFileList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRecentFileList class, constructor"
ms.assetid: 408e19ed-0cd7-45c8-8c19-d50ea2d5c674
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecentFileList::CRecentFileList
Constructs a `CRecentFileList` object.  
  
## Syntax  
  
```  
  
      CRecentFileList(  
   UINT nStart,  
   LPCTSTR lpszSection,  
   LPCTSTR lpszEntryFormat,  
   int nSize,  
   int nMaxDispLen = AFX_ABBREV_FILENAME_LEN   
);  
```  
  
#### Parameters  
 `nStart`  
 Offset for the numbering in the menu display of the MRU (most recently used) file list.  
  
 `lpszSection`  
 Points to the name of the section of the registry or the application's .INI file where the MRU file list is read and/or written.  
  
 `lpszEntryFormat`  
 Points to a format string to be used for the names of the entries stored in the registry or the application's .INI file.  
  
 `nSize`  
 Maximum number of files in the MRU file list.  
  
 `nMaxDispLen`  
 Maximum length, in characters, available for the menu display of a filename in the MRU file list.  
  
## Remarks  
 The format string pointed to by `lpszEntryFormat` should contain "%d", which will be used for substituting the index of each MRU item. For example, if the format string is `"file%d"` then the entries will be named `file0`, `file1`, and so on.  
  
## Requirements  
 **Header:** afxadv.h  
  
## See Also  
 [CRecentFileList Class](../vs140/crecentfilelist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)