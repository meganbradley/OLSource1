---
title: "CMultiPageDHtmlDialog::CMultiPageDHtmlDialog"
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
  - "CMultiPageDHtmlDialog"
  - "CMultiPageDHtmlDialog::CMultiPageDHtmlDialog"
  - "CMultiPageDHtmlDialog.CMultiPageDHtmlDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMultiPageDHtmlDialog class, constructor"
ms.assetid: b2a7f758-90c9-43ec-9d2a-351c9ce51f8a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMultiPageDHtmlDialog::CMultiPageDHtmlDialog
Constructs a multipage (wizard-style) DHTML dialog object.  
  
## Syntax  
  
```  
  
      CMultiPageDHtmlDialog(  
   LPCTSTR lpszTemplateName,  
   LPCTSTR szHtmlResID = NULL,  
   CWnd * pParentWnd = NULL   
);  
CMultiPageDHtmlDialog(  
   UINT nIDTemplate,  
   UINT nHtmlResID = 0,  
   CWnd * pParentWnd = NULL   
);  
CMultiPageDHtmlDialog( );  
```  
  
#### Parameters  
 `lpszTemplateName`  
 The null-terminated string that is the name of a dialog-box template resource.  
  
 `szHtmlResID`  
 The null-terminated string that is the name of an HTML resource.  
  
 `pParentWnd`  
 A pointer to the parent or owner window object (of type [CWnd](../vs140/cwnd-class.md)) to which the dialog object belongs. If it is **NULL**, the dialog object's parent window is set to the main application window.  
  
 `nIDTemplate`  
 Contains the ID number of a dialog-box template resource.  
  
 `nHtmlResID`  
 Contains the ID number of an HTML resource.  
  
## Requirements  
 **Header:** afxdhtml.h  
  
## See Also  
 [CMultiPageDHtmlDialog Class](../vs140/cmultipagedhtmldialog-class.md)