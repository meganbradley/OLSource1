---
title: "CDocument::ReportSaveLoadException"
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
  - "ReportSaveLoadException"
  - "CDocument::ReportSaveLoadException"
  - "CDocument.ReportSaveLoadException"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ReportSaveLoadException method"
  - "reports, reporting exceptions"
  - "CDocument class, overridables"
  - "document exceptions"
  - "document exception handling"
  - "error handling, in CDocument"
  - "exception handling, saving and loading documents"
ms.assetid: 45b348bf-a972-4e5f-a315-65419732ac22
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::ReportSaveLoadException
Called if an exception is thrown (typically a [CFileException](../vs140/cfileexception-class.md) or [CArchiveException](../vs140/carchiveexception-class.md)) while saving or loading the document.  
  
## Syntax  
  
```  
  
      virtual void ReportSaveLoadException(  
   LPCTSTR lpszPathName,  
   CException* e,  
   BOOL bSaving,  
   UINT nIDPDefault   
);  
```  
  
#### Parameters  
 `lpszPathName`  
 Points to name of document that was being saved or loaded.  
  
 *e*  
 Points to the exception that was thrown. May be **NULL**.  
  
 *bSaving*  
 Flag indicating what operation was in progress; nonzero if the document was being saved, 0 if the document was being loaded.  
  
 `nIDPDefault`  
 Identifier of the error message to be displayed if the function does not specify a more specific one.  
  
## Remarks  
 The default implementation examines the exception object and looks for an error message that specifically describes the cause. If a specific message is not found or if *e* is **NULL**, the general message specified by the `nIDPDefault` parameter is used. The function then displays a message box containing the error message. Override this function if you want to provide additional, customized failure messages. This is an advanced overridable.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocument::OnOpenDocument](../vs140/cdocument--onopendocument.md)   
 [CDocument::OnSaveDocument](../vs140/cdocument--onsavedocument.md)   
 [CFileException Class](../vs140/cfileexception-class.md)   
 [CArchiveException Class](../vs140/carchiveexception-class.md)