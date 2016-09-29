---
title: "CDataRecoveryHandler::ReopenPreviousDocuments"
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
  - "CDataRecoveryHandler::ReopenPreviousDocuments"
  - "CDataRecoveryHandler.ReopenPreviousDocuments"
  - "ReopenPreviousDocuments"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ReopenPreviousDocuments method"
ms.assetid: a8b0d496-63a0-4ec1-8d49-c0bcd5a06d0a
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataRecoveryHandler::ReopenPreviousDocuments
Opens the previously open documents.  
  
## Syntax  
  
```  
virtual BOOL ReopenPreviousDocuments();  
```  
  
## Return Value  
 `TRUE` if at least one document was opened; otherwise `FALSE`.  
  
## Remarks  
 This method opens the most recent save of the previously open documents. If a document was not saved or autosaved, `ReopenPreviousDocuments` opens a blank document based on the template for that file type.  
  
 To use this method, `AFX_RESTART_MANAGER_REOPEN_PREVIOUS_FILES` must be set in `m_dwRestartManagerSupportFlags`. See [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md) for more information about the `m_dwRestartManagerSupportFlags` parameter. If this parameter is not set, `ReopenPreviousDocuments` does nothing and returns `FALSE`.  
  
 If there are no documents stored in the list of previously open documents, `ReopenPreviousDocuments` does nothing and returns `FALSE`.  
  
## Requirements  
 **Header:** afxdatarecovery.h  
  
## See Also  
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataRecoveryHandler::QueryRestoreAutosavedDocuments](../vs140/cdatarecoveryhandler--queryrestoreautosaveddocuments.md)   
 [CDataRecoveryHandler::RestoreAutosavedDocuments](../vs140/cdatarecoveryhandler--restoreautosaveddocuments.md)