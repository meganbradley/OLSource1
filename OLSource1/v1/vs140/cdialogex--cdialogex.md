---
title: "CDialogEx::CDialogEx"
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
  - "CDialogEx"
  - "CDialogEx::CDialogEx"
  - "CDialogEx.CDialogEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDialogEx class, constructor"
ms.assetid: 66242dfe-6778-4769-ae9e-4f89b11ec22b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDialogEx::CDialogEx
Constructs a `CDialogEx` object.  
  
## Syntax  
  
```  
CDialogEx(  
   UINT nIDTemplate,  
   CWnd* pParent=NULL   
);  
CDialogEx(  
   LPCTSTR lpszTemplateName,  
   CWnd* pParentWnd=NULL   
);  
```  
  
#### Parameters  
 [in] `nIDTemplate`  
 The resource ID of a dialog box template.  
  
 [in] `lpszTemplateName`  
 The resource name of a dialog box template.  
  
 [in] `pParent`  
 A pointer to the parent window. The default value is `NULL`.  
  
 [in] `pParentWnd`  
 A pointer to the parent window. The default value is `NULL`.  
  
## Return Value  
  
## Remarks  
  
## Requirements  
 **Header:** afxdialogex.h  
  
## See Also  
 [CDialogEx Class](../vs140/cdialogex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)