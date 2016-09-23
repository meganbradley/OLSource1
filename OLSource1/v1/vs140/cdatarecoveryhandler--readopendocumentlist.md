---
title: "CDataRecoveryHandler::ReadOpenDocumentList"
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
  - ReadOpenDocumentList
  - CDataRecoveryHandler::ReadOpenDocumentList
  - CDataRecoveryHandler.ReadOpenDocumentList
dev_langs: 
  - C++
helpviewer_keywords: 
  - ReadOpenDocumentList method
ms.assetid: 886b1cd0-8591-45c1-ac0a-c9b6f272bc19
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDataRecoveryHandler::ReadOpenDocumentList
Loads the open document list from the registry.  
  
## Syntax  
  
```  
virtual BOOL ReadOpenDocumentList();  
```  
  
## Return Value  
 `TRUE` indicates that `ReadOpenDocumentList` loaded the information for at least one document from the registry; `FALSE` indicates no document information was loaded.  
  
## Remarks  
 This function loads the open document information from the registry and stores it in the member variable `m_mapDocNameToAutosaveName`.  
  
 After `ReadOpenDocumentList` loads all the data, it deletes the document information from the registry.  
  
## Requirements  
 **Header:** afxdatarecovery.h  
  
## See Also  
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataRecoveryHandler::SaveOpenDocumentList](../vs140/cdatarecoveryhandler--saveopendocumentlist.md)