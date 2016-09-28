---
title: "CDocument::OnOpenDocument"
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
  - "CDocument::OnOpenDocument"
  - "OnOpenDocument"
  - "CDocument.OnOpenDocument"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDocument class, overridables"
  - "OnOpenDocument method"
  - "opening files, document files"
  - "files [C++], opening"
ms.assetid: 357b6f7b-091b-426c-b1a5-9affadf1e3d3
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::OnOpenDocument
Called by the framework as part of the File Open command.  
  
## Syntax  
  
```  
  
      virtual BOOL OnOpenDocument(  
   LPCTSTR lpszPathName   
);  
```  
  
#### Parameters  
 `lpszPathName`  
 Points to the path of the document to be opened.  
  
## Return Value  
 Nonzero if the document was successfully loaded; otherwise 0.  
  
## Remarks  
 The default implementation of this function opens the specified file, calls the [DeleteContents](../vs140/cdocument--deletecontents.md) member function to ensure that the document is empty, calls [CObject::Serialize](../vs140/cobject--serialize.md) to read the file's contents, and then marks the document as clean. Override this function if you want to use something other than the archive mechanism or the file mechanism. For example, you might write an application where documents represent records in a database rather than separate files.  
  
 If the user chooses the File Open command in an SDI application, the framework uses this function to reinitialize the existing **CDocument** object, rather than creating a new one. If the user chooses File Open in an MDI application, the framework constructs a new **CDocument** object each time and then calls this function to initialize it. You must place your initialization code in this function instead of in the constructor for the File Open command to be effective in SDI applications.  
  
## Example  
 The following examples illustrate alternative methods of initializing a document object.  
  
 [!code[NVC_MFCDocView#60](../vs140/codesnippet/CPP/cdocument--onopendocument_1.cpp)]  
  
 [!code[NVC_MFCDocView#61](../vs140/codesnippet/CPP/cdocument--onopendocument_2.cpp)]  
  
 [!code[NVC_MFCDocView#62](../vs140/codesnippet/CPP/cdocument--onopendocument_3.cpp)]  
  
 [!code[NVC_MFCDocView#63](../vs140/codesnippet/CPP/cdocument--onopendocument_4.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocument::DeleteContents](../vs140/cdocument--deletecontents.md)   
 [CDocument::OnCloseDocument](../vs140/cdocument--onclosedocument.md)   
 [CDocument::OnNewDocument](../vs140/cdocument--onnewdocument.md)   
 [CDocument::OnSaveDocument](../vs140/cdocument--onsavedocument.md)   
 [CDocument::ReportSaveLoadException](../vs140/cdocument--reportsaveloadexception.md)   
 [CObject::Serialize](../vs140/cobject--serialize.md)