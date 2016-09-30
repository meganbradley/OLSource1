---
title: "CDataRecoveryHandler::SaveOpenDocumentList"
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
  - "CDataRecoveryHandler.SaveOpenDocumentList"
  - "SaveOpenDocumentList"
  - "CDataRecoveryHandler::SaveOpenDocumentList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SaveOpenDocumentList method"
ms.assetid: 9be4bb86-ee22-46ec-be7c-eb078626fb47
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataRecoveryHandler::SaveOpenDocumentList
Saves the current list of open documents to the Windows registry.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if there are no open documents to save or if they were saved successfully. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if there are documents to save to the registry, but they were not saved because an error occurred.  
  
## Remarks  
 The restart manager calls <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> when the application exits unexpectedly or when it exits for an upgrade. When the application restarts, it uses [CDataRecoveryHandler::ReadOpenDocumentList](../vs140/cdatarecoveryhandler--readopendocumentlist.md) to retrieve the list of open documents.  
  
 This method saves only the list of open documents. The method [CDataRecoveryHandler::AutosaveDocumentInfo](../vs140/cdatarecoveryhandler--autosavedocumentinfo.md) is responsible for saving the documents themselves.  
  
## Requirements  
 **Header:** afxdatarecovery.h  
  
## See Also  
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataRecoveryHandler::ReadOpenDocumentList](../vs140/cdatarecoveryhandler--readopendocumentlist.md)   
 [CDataRecoveryHandler::AutosaveDocumentInfo](../vs140/cdatarecoveryhandler--autosavedocumentinfo.md)