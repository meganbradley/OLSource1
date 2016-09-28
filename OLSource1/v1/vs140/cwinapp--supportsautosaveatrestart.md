---
title: "CWinApp::SupportsAutosaveAtRestart"
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
  - "CWinApp::SupportsAutosaveAtRestart"
  - "SupportsAutosaveAtRestart"
  - "CWinApp.SupportsAutosaveAtRestart"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SupportsAutosaveAtRestart method"
ms.assetid: 43b3477d-be76-4d63-aa48-8ac80722056e
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::SupportsAutosaveAtRestart
Determines whether the restart manager autosaves any open documents when the application restarts.  
  
## Syntax  
  
```  
virtual BOOL SupportsAutosaveAtRestart() const;  
```  
  
## Return Value  
 `TRUE` indicates the restart manager autosaves open documents when the application restarts; `FALSE` indicates the restart manager does not.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::SupportsRestartManager](../vs140/cwinapp--supportsrestartmanager.md)   
 [CWinApp::SupportsApplicationRecovery](../vs140/cwinapp--supportsapplicationrecovery.md)   
 [CWinApp::SupportsAutosaveAtInterval](../vs140/cwinapp--supportsautosaveatinterval.md)   
 [CWinApp::ReopenPreviousFilesAtRestart](../vs140/cwinapp--reopenpreviousfilesatrestart.md)   
 [CWinApp::RestoreAutosavedFilesAtRestart](../vs140/cwinapp--restoreautosavedfilesatrestart.md)