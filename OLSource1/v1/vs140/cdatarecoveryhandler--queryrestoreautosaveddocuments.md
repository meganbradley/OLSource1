---
title: "CDataRecoveryHandler::QueryRestoreAutosavedDocuments"
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
  - "CDataRecoveryHandler.QueryRestoreAutosavedDocuments"
  - "CDataRecoveryHandler::QueryRestoreAutosavedDocuments"
  - "QueryRestoreAutosavedDocuments"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "QueryRestoreAutosavedDocuments method"
ms.assetid: acdfe062-07d1-4a33-b84b-de19091c0355
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataRecoveryHandler::QueryRestoreAutosavedDocuments
Displays a dialog box to the user for each document that the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> autosaved. The dialog box determines whether the user wants to restore the autosaved document.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If your application is Unicode, this method displays a [CTaskDialog](../vs140/ctaskdialog-class.md) to the user. Otherwise, the framework uses [AfxMessageBox](../vs140/afxmessagebox.md) to query the user.  
  
 After <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> gathers all the responses from the user, it stores the information in the member variable <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. This method does not restore the autosaved documents.  
  
## Requirements  
 **Header:** afxdatarecovery.h  
  
## See Also  
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataRecoveryHandler::ReopenPreviousDocuments](../vs140/cdatarecoveryhandler--reopenpreviousdocuments.md)   
 [CDataRecoveryHandler::RestoreAutosavedDocuments](../vs140/cdatarecoveryhandler--restoreautosaveddocuments.md)