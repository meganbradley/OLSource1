---
title: "CColorDialog::CColorDialog"
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
  - "CColorDialog::CColorDialog"
  - "CColorDialog.CColorDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CColorDialog class, constructor"
ms.assetid: 2ac0bd98-885a-41c0-8c06-da90ca248ad2
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CColorDialog::CColorDialog
Constructs a `CColorDialog` object.  
  
## Syntax  
  
```  
  
      CColorDialog(  
   COLORREF clrInit = 0,  
   DWORD dwFlags = 0,  
   CWnd* pParentWnd = NULL   
);  
```  
  
#### Parameters  
 *clrInit*  
 The default color selection. If no value is specified, the default is RGB(0,0,0) (black).  
  
 `dwFlags`  
 A set of flags that customize the function and appearance of the dialog box. For more information, see the [CHOOSECOLOR](http://msdn.microsoft.com/library/windows/desktop/ms646830) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `pParentWnd`  
 A pointer to the dialog box's parent or owner window.  
  
## Example  
 [!code[NVC_MFCDocView#49](../vs140/codesnippet/CPP/ccolordialog--ccolordialog_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CColorDialog Class](../vs140/ccolordialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDialog::DoModal](../vs140/cdialog--domodal.md)