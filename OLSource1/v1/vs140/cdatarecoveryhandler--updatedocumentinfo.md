---
title: "CDataRecoveryHandler::UpdateDocumentInfo"
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
  - "CDataRecoveryHandler.UpdateDocumentInfo"
  - "CDataRecoveryHandler::UpdateDocumentInfo"
  - "UpdateDocumentInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UpdateDocumentInfo method"
ms.assetid: 8041d538-3091-4516-ad43-8b4611c3dfb6
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataRecoveryHandler::UpdateDocumentInfo
Updates the information for a document because the user saved it.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|A pointer to the saved document.|  
  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if this method deleted the autosaved document and updated the document information; <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if an error occurred.  
  
## Remarks  
 When a user saves a document, the application removes the autosaved file because it is no longer needed. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> deletes the autosaved file by calling [CDataRecoveryHandler::RemoveDocumentInfo](../vs140/cdatarecoveryhandler--removedocumentinfo.md). <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> then adds the information from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to the list of currently open documents because <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> deletes that information, but the saved document is still open.  
  
 To use this method, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> must be set in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. See [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md) for more information about the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter.  
  
## Requirements  
 **Header:** afxdatarecovery.h  
  
## See Also  
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataRecoveryHandler::RemoveDocumentInfo](../vs140/cdatarecoveryhandler--removedocumentinfo.md)