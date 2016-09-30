---
title: "CWinApp::OpenDocumentFile"
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
  - "CWinApp.OpenDocumentFile"
  - "CWinApp::OpenDocumentFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "document file operations"
  - "CWinApp class, operations"
  - "opening files, document files"
  - "OpenDocumentFile method"
  - "files [C++], opening"
ms.assetid: ec9d6752-8ae2-4922-8442-830d9fb15812
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::OpenDocumentFile
The framework calls this method to open the named [CDocument](../vs140/cdocument-class.md) file for the application.  
  
## Syntax  
  
```  
virtual CDocument* OpenDocumentFile(  
   LPCTSTR lpszFileName   
   BOOL bAddToMRU = TRUE  
);  
```  
  
#### Parameters  
 [in] `lpszFileName`  
 The name of the file to be opened.  
  
 [in] `bAddToMRU`  
 `TRUE` indicates the document is one of the most recent files; `FALSE` indicates the document is not one of the most recent files.  
  
## Return Value  
 A pointer to a `CDocument` if successful; otherwise `NULL`.  
  
## Remarks  
 If a document that has that name is already open, the first frame window that contains that document will get the focus. If an application supports multiple document templates, the framework uses the file name extension to find the appropriate document template to try to load the document. If successful, the document template then creates a frame window and view for the document.  
  
## Example  
 [!code[NVC_MFCWindowing#52](../vs140/codesnippet/CPP/cwinapp--opendocumentfile_1.cpp)]  
  
## Requirements  
 `Header:` afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)