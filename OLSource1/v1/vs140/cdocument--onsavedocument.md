---
title: "CDocument::OnSaveDocument"
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
  - "OnSaveDocument"
  - "CDocument.OnSaveDocument"
  - "CDocument::OnSaveDocument"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDocument class, overridables"
  - "OnSaveDocument method"
  - "saving documents"
  - "documents, saving"
ms.assetid: f697323b-0f9a-4dd0-8296-fc899db96ab6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::OnSaveDocument
Called by the framework as part of the File Save or File Save As command.  
  
## Syntax  
  
```  
  
      virtual BOOL OnSaveDocument(  
   LPCTSTR lpszPathName   
);  
```  
  
#### Parameters  
 `lpszPathName`  
 Points to the fully qualified path to which the file should be saved.  
  
## Return Value  
 Nonzero if the document was successfully saved; otherwise 0.  
  
## Remarks  
 The default implementation of this function opens the specified file, calls [CObject::Serialize](../vs140/cobject--serialize.md) to write the document's data to the file, and then marks the document as clean. Override this function if you want to perform special processing when the framework saves a document. For example, you might write an application where documents represent records in a database rather than separate files.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocument::OnCloseDocument](../vs140/cdocument--onclosedocument.md)   
 [CDocument::OnNewDocument](../vs140/cdocument--onnewdocument.md)   
 [CDocument::OnOpenDocument](../vs140/cdocument--onopendocument.md)   
 [CDocument::ReportSaveLoadException](../vs140/cdocument--reportsaveloadexception.md)   
 [CObject::Serialize](../vs140/cobject--serialize.md)