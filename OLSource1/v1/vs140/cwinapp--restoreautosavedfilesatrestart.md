---
title: "CWinApp::RestoreAutosavedFilesAtRestart"
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
  - "RestoreAutosavedFilesAtRestart"
  - "CWinApp.RestoreAutosavedFilesAtRestart"
  - "CWinApp::RestoreAutosavedFilesAtRestart"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RestoreAutosavedFilesAtRestart method"
ms.assetid: 4a43dfec-96e8-4968-bab7-98cb6cf37e22
caps.latest.revision: 10
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::RestoreAutosavedFilesAtRestart
Determines whether the restart manager restores the autosaved files when it restarts the application.  
  
## Syntax  
  
```  
virtual BOOL RestoreAutosavedFilesAtRestart() const;  
```  
  
## Return Value  
 `TRUE` indicates the restart manager restores autosaved files; `FALSE` indicates the restart manager does not.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::SupportsRestartManager](../vs140/cwinapp--supportsrestartmanager.md)   
 [CWinApp::SupportsApplicationRecovery](../vs140/cwinapp--supportsapplicationrecovery.md)   
 [CWinApp::SupportsAutosaveAtRestart](../vs140/cwinapp--supportsautosaveatrestart.md)   
 [CWinApp::SupportsAutosaveAtInterval](../vs140/cwinapp--supportsautosaveatinterval.md)   
 [CWinApp::ReopenPreviousFilesAtRestart](../vs140/cwinapp--reopenpreviousfilesatrestart.md)