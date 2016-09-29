---
title: "CDocument::DeleteContents"
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
  - "DeleteContents"
  - "CDocument::DeleteContents"
  - "CDocument.DeleteContents"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "contents of documents"
  - "CDocument class, overridables"
  - "documents, deleting data in"
  - "document overridables"
  - "DeleteContents method"
  - "contents of documents, deleting"
ms.assetid: 14f57f45-0c5f-4d83-b75f-64769e01814d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::DeleteContents
Called by the framework to delete the document's data without destroying the **CDocument** object itself.  
  
## Syntax  
  
```  
  
virtual void DeleteContents( );  
```  
  
## Remarks  
 It is called just before the document is to be destroyed. It is also called to ensure that a document is empty before it is reused. This is particularly important for an SDI application, which uses only one document; the document is reused whenever the user creates or opens another document. Call this function to implement an "Edit Clear All" or similar command that deletes all of the document's data. The default implementation of this function does nothing. Override this function to delete the data in your document.  
  
## Example  
 [!code[NVC_MFCDocView#57](../vs140/codesnippet/CPP/cdocument--deletecontents_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocument::OnCloseDocument](../vs140/cdocument--onclosedocument.md)   
 [CDocument::OnNewDocument](../vs140/cdocument--onnewdocument.md)   
 [CDocument::OnOpenDocument](../vs140/cdocument--onopendocument.md)