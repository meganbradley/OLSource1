---
title: "CDataRecoveryHandler::SetSaveDocumentInfoOnIdle"
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
  - "SetSaveDocumentInfoOnIdle"
  - "CDataRecoveryHandler.SetSaveDocumentInfoOnIdle"
  - "CDataRecoveryHandler::SetSaveDocumentInfoOnIdle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetSaveDocumentInfoOnIdle method"
ms.assetid: 17beb7b3-2215-465e-a1f5-c0487a10a680
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataRecoveryHandler::SetSaveDocumentInfoOnIdle
Sets whether the `CDataRecoveryHandler` saves the open document information to the Windows registry during the current idle cycle.  
  
## Syntax  
  
```  
virtual void SetSaveDocumentInfoOnIdle(  
   BOOL bSaveOnIdle  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] `bSaveOnIdle`|`TRUE` to save document information during the current idle cycle; `FALSE to not perform a save`.|  
  
## Requirements  
 **Header:** afxdatarecovery.h  
  
## See Also  
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataRecoveryHandler::GetSaveDocumentInfoOnIdle](../vs140/cdatarecoveryhandler--getsavedocumentinfoonidle.md)