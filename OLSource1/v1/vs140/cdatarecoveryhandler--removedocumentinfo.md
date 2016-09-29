---
title: "CDataRecoveryHandler::RemoveDocumentInfo"
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
  - "CDataRecoveryHandler.RemoveDocumentInfo"
  - "RemoveDocumentInfo"
  - "CDataRecoveryHandler::RemoveDocumentInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveDocumentInfo method"
ms.assetid: abfe415d-5032-405c-8dd6-47d54695c4ac
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataRecoveryHandler::RemoveDocumentInfo
Removes the supplied document from the open document list.  
  
## Syntax  
  
```  
virtual BOOL RemoveDocumentInfo(  
   CDocument *pDocument  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] `pDocument`|A pointer to the document to remove.|  
  
## Return Value  
 `TRUE` if `pDocument` was removed from the list; `FALSE` if an error occurred.  
  
## Remarks  
 When the user closes a document, the framework uses this method to remove it from the list of open documents.  
  
 If `RemoveDocumentInfo` cannot find `pDocument` in the list of open documents, it does nothing and returns `TRUE`.  
  
 To use this method, `AFX_RESTART_MANAGER_REOPEN_PREVIOUS_FILES` must be set in `m_dwRestartManagerSupportFlags`. See [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md) for more information about the `m_dwRestartManagerSupportFlags` parameter.  
  
## Requirements  
 **Header:** afxdatarecovery.h  
  
## See Also  
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataRecoveryHandler::CreateDocumentInfo](../vs140/cdatarecoveryhandler--createdocumentinfo.md)   
 [CDataRecoveryHandler::UpdateDocumentInfo](../vs140/cdatarecoveryhandler--updatedocumentinfo.md)