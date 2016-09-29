---
title: "CDataRecoveryHandler::GetDocumentListName"
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
  - "GetDocumentListName"
  - "CDataRecoveryHandler::GetDocumentListName"
  - "CDataRecoveryHandler.GetDocumentListName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDocumentListName method"
ms.assetid: a4c11c76-54fa-4b97-a42f-925d62ad5743
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataRecoveryHandler::GetDocumentListName
Retrieves the document name from a `CDocument` object.  
  
## Syntax  
  
```  
virtual CString GetDocumentListName(  
   CDocument *pDocument  
) const;  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] `pDocument`|A pointer to a `CDocument`. `GetDocumentListName` retrieves the document name from this `CDocument`.|  
  
## Return Value  
 The document name from `pDocument`.  
  
## Remarks  
 The `CDataRecoveryHandler` uses the document name as the key in `m_mapDocNameToAutosaveName`, `m_mapDocNameToDocumentPtr`, and `m_mapDocNameToRestoreBool`. These parameter enable the `CDataRecoveryHandler` to monitor `CDocument` objects, the autosave file name, and the autosave settings.  
  
## Requirements  
 **Header:** afxdatarecovery.h  
  
## See Also  
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocument Class](../vs140/cdocument-class.md)