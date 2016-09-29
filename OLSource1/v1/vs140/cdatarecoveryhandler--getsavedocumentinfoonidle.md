---
title: "CDataRecoveryHandler::GetSaveDocumentInfoOnIdle"
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
  - "CDataRecoveryHandler.GetSaveDocumentInfoOnIdle"
  - "GetSaveDocumentInfoOnIdle"
  - "CDataRecoveryHandler::GetSaveDocumentInfoOnIdle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSaveDocumentInfoOnIdle method"
ms.assetid: 3ceb02bd-767f-4961-a652-3bbd2bbcb00f
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataRecoveryHandler::GetSaveDocumentInfoOnIdle
Indicates whether the `CDataRecoveryHandler` performs an autosave on the current idle loop.  
  
## Syntax  
  
```  
virtual BOOL GetSaveDocumentInfoOnIdle() const;  
```  
  
## Return Value  
 `TRUE` indicates the `CDataRecoveryHandler` autosaves on the current idle loop; `FALSE` indicates it does not.  
  
## Requirements  
 **Header:** afxdatarecovery.h  
  
## See Also  
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataRecoveryHandler::SetSaveDocumentInfoOnIdle](../vs140/cdatarecoveryhandler--setsavedocumentinfoonidle.md)