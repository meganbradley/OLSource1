---
title: "CWinApp::SupportsApplicationRecovery"
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
  - "CWinApp.SupportsApplicationRecovery"
  - "SupportsApplicationRecovery"
  - "CWinApp::SupportsApplicationRecovery"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SupportsApplicationRecovery method"
ms.assetid: 9f07ecf1-4f52-4bee-a8ce-bb4dd0b49504
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::SupportsApplicationRecovery
Determines whether the restart manager recovers an application that exited unexpectedly.  
  
## Syntax  
  
```  
virtual BOOL SupportsApplicationRecovery() const;  
```  
  
## Return Value  
 `TRUE` indicates the restart manager recovers the application; `FALSE` indicates the restart manager does not.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::SupportsRestartManager](../vs140/cwinapp--supportsrestartmanager.md)   
 [CWinApp::SupportsAutosaveAtRestart](../vs140/cwinapp--supportsautosaveatrestart.md)   
 [CWinApp::SupportsAutosaveAtInterval](../vs140/cwinapp--supportsautosaveatinterval.md)   
 [CWinApp::ReopenPreviousFilesAtRestart](../vs140/cwinapp--reopenpreviousfilesatrestart.md)   
 [CWinApp::RestoreAutosavedFilesAtRestart](../vs140/cwinapp--restoreautosavedfilesatrestart.md)