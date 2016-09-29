---
title: "CWinApp::SaveAllModified"
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
  - "CWinApp.SaveAllModified"
  - "SaveAllModified"
  - "CWinApp::SaveAllModified"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SaveAllModified method"
  - "saving files"
  - "files [C++], saving"
  - "CWinApp class, overridables"
ms.assetid: aa73335f-0ec9-42dc-a40f-e438e1a41332
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::SaveAllModified
Called by the framework to save all documents when the application's main frame window is to be closed, or through a `WM_QUERYENDSESSION` message.  
  
## Syntax  
  
```  
  
virtual BOOL SaveAllModified( );  
```  
  
## Return Value  
 Nonzero if safe to terminate the application; 0 if not safe to terminate the application.  
  
## Remarks  
 The default implementation of this member function calls the [CDocument::SaveModified](../vs140/cdocument--savemodified.md) member function in turn for all modified documents within the application.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)