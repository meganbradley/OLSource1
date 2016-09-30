---
title: "CDataRecoveryHandler::AutosaveAllDocumentInfo"
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
  - "AutosaveAllDocumentInfo"
  - "CDataRecoveryHandler.AutosaveAllDocumentInfo"
  - "CDataRecoveryHandler::AutosaveAllDocumentInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AutosaveAllDocumentInfo method"
ms.assetid: 3378b2c4-df7b-4eae-a7cb-9868f7168085
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataRecoveryHandler::AutosaveAllDocumentInfo
Autosaves each file registered with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> saved all the documents; <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if any document was not saved.  
  
## Remarks  
 This method returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if there are no documents that must be saved. It also returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> without saving any documents if retrieving the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> for the application generates an error.  
  
 To use this method, either <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> must be set in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. See [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md) for more information about the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter.  
  
## Requirements  
 **Header:** afxdatarecovery.h  
  
## See Also  
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [CDataRecoveryHandler::AutosaveDocumentInfo](../vs140/cdatarecoveryhandler--autosavedocumentinfo.md)