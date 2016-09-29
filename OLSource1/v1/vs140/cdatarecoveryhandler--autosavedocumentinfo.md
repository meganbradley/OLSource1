---
title: "CDataRecoveryHandler::AutosaveDocumentInfo"
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
  - "CDataRecoverHandler::AutosaveDocumentInfo"
  - "AutosaveDocumentInfo"
  - "CDataRecoveryHandler.AutosaveDocumentInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AutosaveDocumentInfo method"
ms.assetid: a60b3773-f9ee-449f-a3d6-fe09a4ce403a
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataRecoveryHandler::AutosaveDocumentInfo
Autosaves the specified document.  
  
## Syntax  
  
```  
virtual BOOL AutosaveDocumentInfo(  
   CDocument *pDocument,  
   BOOL bResetModifiedFlag = TRUE  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] `pDocument`|A pointer to the `CDocument` to save.|  
|[in] `bResetModifiedFlag`|`TRUE` indicates that the `CDataRecoveryHandler` considers `pDocument` to be modified; `FALSE` indicates that the framework considers `pDocument` to be unmodified. See the Remarks section for more information about the effect of this flag.|  
  
## Return Value  
 `TRUE` if the appropriate flags are set and `pDocument` is a valid `CDocument` object.  
  
## Remarks  
 Each `CDocument` object has a flag that indicates if it has changed since the last save. Use [CDocument::IsModified](../vs140/cdocument--ismodified.md) to determine the state of this flag. If a `CDocument` has not changed since the last save, `AutosaveDocumentInfo` deletes any autosaved files for that document. If a document has changed since the last save, closing it prompts the user to save the document before closing.  
  
> [!NOTE]
>  Using `bResetModifiedFlag` to change the state of the document to unmodified may cause the user to lose unsaved data. If the framework considers a document unmodified, closing it does not prompt the user to save.  
  
 This method throws an exception with the [ASSERT (MFC)](../vs140/assert--mfc-.md) macro if `pDocument` is not a valid `CDocument` object.  
  
 To use this method, either `AFX_RESTART_MANAGER_AUTOSAVE_AT_RESTART` or `AFX_RESTARTMANAGER_AUTOSAVE_AT_INTERVAL` must be set in `m_dwRestartManagerSupportFlags`. See [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md) for more information about the `m_dwRestartManagerSupportFlags` parameter.  
  
## Requirements  
 **Header:** afxdatarecovery.h  
  
## See Also  
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataRecoveryHandler::AutosaveAllDocumentInfo](../vs140/cdatarecoveryhandler--autosavealldocumentinfo.md)   
 [CDocument Class](../vs140/cdocument-class.md)