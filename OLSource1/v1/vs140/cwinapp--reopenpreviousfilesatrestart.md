---
title: "CWinApp::ReopenPreviousFilesAtRestart"
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
  - CWinApp.ReopenPreviousFilesAtRestart
  - ReopenPreviousFilesAtRestart
  - CWinApp::ReopenPreviousFilesAtRestart
dev_langs: 
  - C++
helpviewer_keywords: 
  - ReopenPreviousFilesAtRestart method
ms.assetid: 475af835-12fb-4c49-8187-31c1473045cf
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWinApp::ReopenPreviousFilesAtRestart
Determines whether the restart manager reopens the files that were open when the application exited unexpectedly.  
  
## Syntax  
  
```  
virtual BOOL ReopenPreviousFilesAtRestart() const;  
```  
  
## Return Value  
 `TRUE` indicates the restart manager reopens the previously open files; `FALSE` indicates the restart manager does not.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::SupportsRestartManager](../vs140/cwinapp--supportsrestartmanager.md)   
 [CWinApp::SupportsApplicationRecovery](../vs140/cwinapp--supportsapplicationrecovery.md)   
 [CWinApp::SupportsAutosaveAtRestart](../vs140/cwinapp--supportsautosaveatrestart.md)   
 [CWinApp::SupportsAutosaveAtInterval](../vs140/cwinapp--supportsautosaveatinterval.md)   
 [CWinApp::RestoreAutosavedFilesAtRestart](../vs140/cwinapp--restoreautosavedfilesatrestart.md)