---
title: "CDataRecoveryHandler::RestoreAutosavedDocuments"
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
  - "CDataRecoveryHandler.RestoreAutosavedDocuments"
  - "RestoreAutosavedDocuments"
  - "CDataRecoveryHandler::RestoreAutosavedDocuments"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RestoreAutosavedDocuments method"
ms.assetid: 67046a50-6b6f-4111-99f4-47e7fbc48934
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataRecoveryHandler::RestoreAutosavedDocuments
Restores the autosaved documents based on user input.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if this method successfully restores the documents.  
  
## Remarks  
 This method calls [CDataRecoveryHandler::QueryRestoreAutosavedDocuments](../vs140/cdatarecoveryhandler--queryrestoreautosaveddocuments.md) to determine which documents the user wants to restore. If a user decides not to restore an autosaved document, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> deletes the autosave file. Otherwise, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> replaces the open document with the autosaved version.  
  
 To use this method, either <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> must be set in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. See [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md) for more information about the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter.  
  
## Requirements  
 **Header:** afxdatarecovery.h  
  
## See Also  
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataRecoveryHandler::ReopenPreviousDocuments](../vs140/cdatarecoveryhandler--reopenpreviousdocuments.md)   
 [CDataRecoveryHandler::QueryRestoreAutosavedDocuments](../vs140/cdatarecoveryhandler--queryrestoreautosaveddocuments.md)