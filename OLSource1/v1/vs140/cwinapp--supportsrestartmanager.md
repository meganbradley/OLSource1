---
title: "CWinApp::SupportsRestartManager"
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
  - "CWinApp::SupportsRestartManager"
  - "CWinApp.SupportsRestartManager"
  - "SupportsRestartManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SupportsRestartManager method"
ms.assetid: 80048c46-e95d-4538-adf1-fc1bc9c2b29a
caps.latest.revision: 11
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::SupportsRestartManager
Determines whether the application supports the restart manager.  
  
## Syntax  
  
```  
virtual BOOL SupportsRestartManager() const;  
```  
  
## Return Value  
 `TRUE` indicates the application supports the restart manager; `FALSE` indicates the application does not.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::SupportsApplicationRecovery](../vs140/cwinapp--supportsapplicationrecovery.md)   
 [CWinApp::SupportsAutosaveAtRestart](../vs140/cwinapp--supportsautosaveatrestart.md)   
 [CWinApp::SupportsAutosaveAtInterval](../vs140/cwinapp--supportsautosaveatinterval.md)   
 [CWinApp::ReopenPreviousFilesAtRestart](../vs140/cwinapp--reopenpreviousfilesatrestart.md)   
 [CWinApp::RestoreAutosavedFilesAtRestart](../vs140/cwinapp--restoreautosavedfilesatrestart.md)   
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)