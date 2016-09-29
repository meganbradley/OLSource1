---
title: "COleUpdateDialog::COleUpdateDialog"
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
  - "COleUpdateDialog.COleUpdateDialog"
  - "COleUpdateDialog::COleUpdateDialog"
  - "COleUpdateDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleUpdateDialog class, constructor"
  - "COleUpdateDialog class, construction"
ms.assetid: 144bd094-b824-498c-9767-ce69887302da
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleUpdateDialog::COleUpdateDialog
Constructs a `COleUpdateDialog` object.  
  
## Syntax  
  
```  
  
      explicit COleUpdateDialog(   
   COleDocument* pDoc,   
   BOOL bUpdateLinks = TRUE,   
   BOOL bUpdateEmbeddings = FALSE,   
   CWnd* pParentWnd = NULL    
);  
```  
  
#### Parameters  
 `pDoc`  
 Points to the document containing the links that may need updating.  
  
 *bUpdateLinks*  
 Flag that determines whether linked objects are to be updated.  
  
 *bUpdateEmbeddings*  
 Flag that determines whether embedded objects are to be updated.  
  
 `pParentWnd`  
 Points to the parent or owner window object (of type `CWnd`) to which the dialog object belongs. If it is **NULL**, the parent window of the dialog box will be set to the main application window.  
  
## Remarks  
 This function constructs only a `COleUpdateDialog` object. To display the dialog box, call [DoModal](../vs140/colelinksdialog--domodal.md). This class should be used instead of `COleLinksDialog` when you want to update only existing linked or embedded items.  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COleUpdateDialog Class](../vs140/coleupdatedialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDialog Class](../vs140/coledialog-class.md)   
 [COleLinksDialog Class](../vs140/colelinksdialog-class.md)   
 [COleDocument Class](../vs140/coledocument-class.md)   
 [CWnd Class](../vs140/cwnd-class.md)   
 [CDialog Class](../vs140/cdialog-class.md)   
 [COleUpdateDialog::DoModal](../vs140/coleupdatedialog--domodal.md)