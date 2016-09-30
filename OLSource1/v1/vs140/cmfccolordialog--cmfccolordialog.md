---
title: "CMFCColorDialog::CMFCColorDialog"
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
  - "CMFCColorDialog"
  - "CMFCColorDialog::CMFCColorDialog"
  - "CMFCColorDialog.CMFCColorDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCColorDialog class, constructor"
ms.assetid: d37885fc-05ea-4ab5-9ac1-9c930d083eb8
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorDialog::CMFCColorDialog
Constructs a `CMFCColorDialog` object.  
  
## Syntax  
  
```  
CMFCColorDialog(  
   COLORREF clrInit=0,  
   DWORD dwFlags=0,  
   CWnd* pParentWnd=NULL,  
   HPALETTE hPal=NULL   
);  
```  
  
#### Parameters  
 [in] `clrInit`  
 The default color selection. If no value is specified, the default is RGB(0,0,0) (black).  
  
 [in] `dwFlags`  
 (Reserved.)  
  
 [in] `pParentWnd`  
 A pointer to the dialog box's parent or owner window.  
  
 [in] `hPal`  
 A handle to a color palette.  
  
## Return Value  
  
## Remarks  
  
## Requirements  
 **Header:** afxcolordialog.h  
  
## See Also  
 [CMFCColorDialog Class](../vs140/cmfccolordialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)