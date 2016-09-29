---
title: "CWinApp::ApplicationRecoveryCallback"
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
  - "ApplicationRecoveryCallback"
  - "CWinApp.ApplicationRecoveryCallback"
  - "CWinApp::ApplicationRecoveryCallback"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ApplicationRecoveryCallback method"
ms.assetid: 477ec2db-40ea-4e42-9710-de1596cdb1fe
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::ApplicationRecoveryCallback
Called by the framework when the application unexpectedly exits.  
  
## Syntax  
  
```  
virtual DWORD ApplicationRecoveryCallback(  
   LPVOID lpvParam  
);  
```  
  
#### Parameters  
 [in] `lpvParam`  
 Reserved for future use.  
  
## Return Value  
 0 if this method is successful; nonzero if an error occurs.  
  
## Remarks  
 If your application supports the restart manager, the framework calls this function when your application unexpectedly exits.  
  
 The default implementation of `ApplicationRecoveryCallback` uses the `CDataRecoveryHandler` to save the list of currently open documents to the registry. This method does not autosave any files.  
  
 To customize the behavior, override this function in a derived [CWinApp Class](../vs140/cwinapp-class.md) or pass your own application recovery method as a parameter to [CWinApp::RegisterWithRestartManager](../vs140/cwinapp--registerwithrestartmanager.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::RegisterWithRestartManager](../vs140/cwinapp--registerwithrestartmanager.md)   
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)