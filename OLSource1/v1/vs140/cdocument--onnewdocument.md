---
title: "CDocument::OnNewDocument"
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
  - "OnNewDocument"
  - "CDocument.OnNewDocument"
  - "CDocument::OnNewDocument"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnNewDocument method"
  - "CDocument class, overridables"
  - "new documents"
ms.assetid: 8a31fa20-81b6-450d-81d4-064d39111909
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::OnNewDocument
Called by the framework as part of the File New command.  
  
## Syntax  
  
```  
  
virtual BOOL OnNewDocument( );  
```  
  
## Return Value  
 Nonzero if the document was successfully initialized; otherwise 0.  
  
## Remarks  
 The default implementation of this function calls the [DeleteContents](../vs140/cdocument--deletecontents.md) member function to ensure that the document is empty and then marks the new document as clean. Override this function to initialize the data structure for a new document. You should call the base class version of this function from your override.  
  
 If the user chooses the File New command in an SDI application, the framework uses this function to reinitialize the existing document, rather than creating a new one. If the user chooses File New in a multiple document interface (MDI) application, the framework creates a new document each time and then calls this function to initialize it. You must place your initialization code in this function instead of in the constructor for the File New command to be effective in SDI applications.  
  
 Note that there are cases where `OnNewDocument` is called twice. This occurs when the document is embedded as an ActiveX Document Server. The function is first called by the `CreateInstance` method (exposed by the `COleObjectFactory`-derived class) and a second time by the `InitNew` method (exposed by the `COleServerDoc`-derived class).  
  
## Example  
 The following examples illustrate alternative methods of initializing a document object.  
  
 [!code[NVC_MFCDocView#60](../vs140/codesnippet/CPP/cdocument--onnewdocument_1.cpp)]  
  
 [!code[NVC_MFCDocView#61](../vs140/codesnippet/CPP/cdocument--onnewdocument_2.cpp)]  
  
 [!code[NVC_MFCDocView#62](../vs140/codesnippet/CPP/cdocument--onnewdocument_3.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocument::CDocument](../vs140/cdocument--cdocument.md)   
 [CDocument::DeleteContents](../vs140/cdocument--deletecontents.md)   
 [CDocument::OnCloseDocument](../vs140/cdocument--onclosedocument.md)   
 [CDocument::OnOpenDocument](../vs140/cdocument--onopendocument.md)   
 [CDocument::OnSaveDocument](../vs140/cdocument--onsavedocument.md)