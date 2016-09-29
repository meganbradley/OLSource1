---
title: "CDataRecoveryHandler::CreateDocumentInfo"
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
  - "CDataRecoveryHandler::CreateDocumentInfo"
  - "CreateDocumentInfo"
  - "CDataRecoveryHandler.CreateDocumentInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateDocumentInfo method"
ms.assetid: 8e74a5cb-018c-4572-acf0-6f57627eab75
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataRecoveryHandler::CreateDocumentInfo
Adds a document to the list of open documents.  
  
## Syntax  
  
```  
virtual BOOL CreateDocumentInfo(  
   CDocument *pDocument  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] `pDocument`|A pointer to a `CDocument`. This method creates the document information for this `CDocument`.|  
  
## Return Value  
 The default implementation returns `TRUE`.  
  
## Remarks  
 This method checks if `pDocument` is already in the list of documents before it adds the document. If `pDocument` is already in the list, this method deletes the autosaved file associated with `pDocument`.  
  
 To use this method, either `AFX_RESTART_MANAGER_AUTOSAVE_AT_RESTART` or `AFX_RESTARTMANAGER_AUTOSAVE_AT_INTERVAL` must be set in `m_dwRestartManagerSupportFlags`. See [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md) for more information about the `m_dwRestartManagerSupportFlags` parameter.  
  
## Requirements  
 **Header:** afxdatarecovery.h  
  
## See Also  
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocument Class](../vs140/cdocument-class.md)   
 [CDataRecoveryHandler::UpdateDocumentInfo](../vs140/cdatarecoveryhandler--updatedocumentinfo.md)   
 [CDataRecoveryHandler::RemoveDocumentInfo](../vs140/cdatarecoveryhandler--removedocumentinfo.md)