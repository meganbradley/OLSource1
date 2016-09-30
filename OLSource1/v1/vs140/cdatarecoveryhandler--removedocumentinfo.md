---
title: "CDataRecoveryHandler::RemoveDocumentInfo"
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
  - "CDataRecoveryHandler.RemoveDocumentInfo"
  - "RemoveDocumentInfo"
  - "CDataRecoveryHandler::RemoveDocumentInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveDocumentInfo method"
ms.assetid: abfe415d-5032-405c-8dd6-47d54695c4ac
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataRecoveryHandler::RemoveDocumentInfo
Removes the supplied document from the open document list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|A pointer to the document to remove.|  
  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> was removed from the list; <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if an error occurred.  
  
## Remarks  
 When the user closes a document, the framework uses this method to remove it from the list of open documents.  
  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> cannot find <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in the list of open documents, it does nothing and returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 To use this method, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> must be set in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. See [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md) for more information about the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter.  
  
## Requirements  
 **Header:** afxdatarecovery.h  
  
## See Also  
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataRecoveryHandler::CreateDocumentInfo](../vs140/cdatarecoveryhandler--createdocumentinfo.md)   
 [CDataRecoveryHandler::UpdateDocumentInfo](../vs140/cdatarecoveryhandler--updatedocumentinfo.md)