---
title: "CDataRecoveryHandler::CreateDocumentInfo"
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
  - "CDataRecoveryHandler::CreateDocumentInfo"
  - "CreateDocumentInfo"
  - "CDataRecoveryHandler.CreateDocumentInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateDocumentInfo method"
ms.assetid: 8e74a5cb-018c-4572-acf0-6f57627eab75
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataRecoveryHandler::CreateDocumentInfo
Adds a document to the list of open documents.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|A pointer to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. This method creates the document information for this <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.|  
  
## Return Value  
 The default implementation returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method checks if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is already in the list of documents before it adds the document. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is already in the list, this method deletes the autosaved file associated with <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 To use this method, either <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> must be set in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. See [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md) for more information about the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter.  
  
## Requirements  
 **Header:** afxdatarecovery.h  
  
## See Also  
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocument Class](../vs140/cdocument-class.md)   
 [CDataRecoveryHandler::UpdateDocumentInfo](../vs140/cdatarecoveryhandler--updatedocumentinfo.md)   
 [CDataRecoveryHandler::RemoveDocumentInfo](../vs140/cdatarecoveryhandler--removedocumentinfo.md)