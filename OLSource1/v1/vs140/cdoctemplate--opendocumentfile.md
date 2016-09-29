---
title: "CDocTemplate::OpenDocumentFile"
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
  - "CDocTemplate.OpenDocumentFile"
  - "CDocTemplate::OpenDocumentFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDocTemplate class, overridables"
  - "opening files, document files"
  - "OpenDocumentFile method"
  - "files [C++], opening"
  - "document files, opening"
ms.assetid: dcaee16a-4971-4cea-bac9-ca1969525854
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocTemplate::OpenDocumentFile
Opens a file specified by a path.  
  
## Syntax  
  
```  
virtual CDocument* OpenDocumentFile(  
   LPCTSTR lpszPathName) = 0;  
  
virtual CDocument* OpenDocumentFile(  
   LPCTSTR lpszPathName,  
   BOOL bAddToMRU) = 0;  
```  
  
#### Parameters  
 [in] `lpszPathName`  
 Pointer to the path of the file that contains the document to be opened.  
  
 [in] `bAddToMRU`  
 `TRUE` indicates the document is one of the most recent files; `FALSE` indicates the document is not one of the most recent files.  
  
## Return Value  
 A pointer to the document whose file is named by `lpszPathName`; `NULL` if unsuccessful.  
  
## Remarks  
 Opens the file whose path is specified by `lpszPathName`. If `lpszPathName` is `NULL`, a new file that contains a document of the type associated with this template is created.  
  
## Requirements  
 `Header:` afxwin.h  
  
## See Also  
 [CDocTemplate Class](../vs140/cdoctemplate-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocTemplate::CloseAllDocuments](../vs140/cdoctemplate--closealldocuments.md)