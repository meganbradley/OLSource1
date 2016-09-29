---
title: "CDocument::SaveModified"
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
  - "CDocument.SaveModified"
  - "CDocument::SaveModified"
  - "SaveModified"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SaveModified method"
  - "CDocument class, overridables"
  - "saving documents"
  - "documents, saving"
ms.assetid: 1ef1a570-8cb6-4995-b69c-b373bc47883e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::SaveModified
Called by the framework before a modified document is to be closed.  
  
## Syntax  
  
```  
  
virtual BOOL SaveModified( );  
```  
  
## Return Value  
 Nonzero if it is safe to continue and close the document; 0 if the document should not be closed.  
  
## Remarks  
 The default implementation of this function displays a message box asking the user whether to save the changes to the document, if any have been made. Override this function if your program requires a different prompting procedure. This is an advanced overridable.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocument::CanCloseFrame](../vs140/cdocument--cancloseframe.md)   
 [CDocument::IsModified](../vs140/cdocument--ismodified.md)   
 [CDocument::OnNewDocument](../vs140/cdocument--onnewdocument.md)   
 [CDocument::OnOpenDocument](../vs140/cdocument--onopendocument.md)   
 [CDocument::OnSaveDocument](../vs140/cdocument--onsavedocument.md)