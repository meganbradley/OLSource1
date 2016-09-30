---
title: "CWinApp::AddToRecentFileList"
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
  - "CWinApp.AddToRecentFileList"
  - "CWinApp::AddToRecentFileList"
  - "AddToRecentFileList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinApp class, operations"
  - "AddToRecentFileList method"
  - "recent file list"
ms.assetid: 772cc033-bb63-4841-b62f-667b9c8559d2
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::AddToRecentFileList
Call this member function to add `lpszPathName` to the MRU file list.  
  
## Syntax  
  
```  
  
      virtual void AddToRecentFileList(  
   LPCTSTR lpszPathName   
);  
```  
  
#### Parameters  
 `lpszPathName`  
 The path of the file.  
  
## Remarks  
 You should call the [LoadStdProfileSettings](../vs140/cwinapp--loadstdprofilesettings.md) member function to load the current MRU file list before you use this member function.  
  
 The framework calls this member function when it opens a file or executes the Save As command to save a file with a new name.  
  
## Example  
 [!code[NVC_MFCWindowing#36](../vs140/codesnippet/CPP/cwinapp--addtorecentfilelist_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::LoadStdProfileSettings](../vs140/cwinapp--loadstdprofilesettings.md)