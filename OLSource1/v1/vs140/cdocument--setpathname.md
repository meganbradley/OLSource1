---
title: "CDocument::SetPathName"
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
  - SetPathName
  - CDocument.SetPathName
  - CDocument::SetPathName
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDocument class, operations
  - SetPathName method
  - document path names
  - names [C++], document path
ms.assetid: 6568fb06-e34b-4307-a0cc-af7352db2ef4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDocument::SetPathName
Call this function to specify the fully qualified path of the document's disk file.  
  
## Syntax  
  
```  
  
      virtual void SetPathName(  
   LPCTSTR lpszPathName,  
   BOOL bAddToMRU = TRUE   
);  
```  
  
#### Parameters  
 `lpszPathName`  
 Points to the string to be used as the path for the document.  
  
 `bAddToMRU`  
 Determines whether the filename is added to the most recently used (MRU) file list. If **TRUE,** the filename is added; if **FALSE**, it is not added.  
  
## Remarks  
 Depending on the value of `bAddToMRU` the path is added, or not added, to the MRU list maintained by the application. Note that some documents are not associated with a disk file. Call this function only if you are overriding the default implementation for opening and saving files used by the framework.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocument::GetPathName](../vs140/cdocument--getpathname.md)   
 [CWinApp::AddToRecentFileList](../vs140/cwinapp--addtorecentfilelist.md)