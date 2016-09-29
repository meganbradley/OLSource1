---
title: "CDataRecoveryHandler::AutosaveAllDocumentInfo"
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
  - "AutosaveAllDocumentInfo"
  - "CDataRecoveryHandler.AutosaveAllDocumentInfo"
  - "CDataRecoveryHandler::AutosaveAllDocumentInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AutosaveAllDocumentInfo method"
ms.assetid: 3378b2c4-df7b-4eae-a7cb-9868f7168085
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataRecoveryHandler::AutosaveAllDocumentInfo
Autosaves each file registered with the `CDataRecoveryHandler` class.  
  
## Syntax  
  
```  
virtual BOOL AutosaveAllDocumentInfo();  
```  
  
## Return Value  
 `TRUE` if the `CDataRecoveryHandler` saved all the documents; `FALSE` if any document was not saved.  
  
## Remarks  
 This method returns `TRUE` if there are no documents that must be saved. It also returns `TRUE` without saving any documents if retrieving the `CWinApp` or `CDocManager` for the application generates an error.  
  
 To use this method, either `AFX_RESTART_MANAGER_AUTOSAVE_AT_RESTART` or `AFX_RESTART_MANAGER_AUTOSAVE_AT_INTERVAL` must be set in `m_dwRestartManagerSupportFlags`. See [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md) for more information about the `m_dwRestartManagerSupportFlags` parameter.  
  
## Requirements  
 **Header:** afxdatarecovery.h  
  
## See Also  
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [CDataRecoveryHandler::AutosaveDocumentInfo](../vs140/cdatarecoveryhandler--autosavedocumentinfo.md)