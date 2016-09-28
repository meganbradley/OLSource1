---
title: "COleInsertDialog::COleInsertDialog"
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
  - "COleInsertDialog"
  - "COleInsertDialog::COleInsertDialog"
  - "COleInsertDialog.COleInsertDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleInsertDialog class, constructor"
ms.assetid: 4dce8898-e800-4a4f-b763-d6afbd6d8fd5
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleInsertDialog::COleInsertDialog
This function constructs only a `COleInsertDialog` object.  
  
## Syntax  
  
```  
  
      COleInsertDialog (  
   DWORD dwFlags = IOF_SELECTCREATENEW,  
   CWnd* pParentWnd = NULL   
);  
```  
  
#### Parameters  
 `dwFlags`  
 Creation flag that contains any number of the following values to be combined using the bitwise-OR operator:  
  
-   **IOF_SHOWHELP** Specifies that the Help button will be displayed when the dialog box is called.  
  
-   **IOF_SELECTCREATENEW** Specifies that the Create New radio button will be selected initially when the dialog box is called. This is the default and cannot be used with **IOF_SELECTCREATEFROMFILE**.  
  
-   **IOF_SELECTCREATEFROMFILE** Specifies that the Create From File radio button will be selected initially when the dialog box is called. Cannot be used with **IOF_SELECTCREATENEW**.  
  
-   **IOF_CHECKLINK** Specifies that the Link check box will be checked initially when the dialog box is called.  
  
-   **IOF_DISABLELINK** Specifies that the Link check box will be disabled when the dialog box is called.  
  
-   **IOF_CHECKDISPLAYASICON** Specifies that the Display As Icon check box will be checked initially, the current icon will be displayed, and the Change Icon button will be enabled when the dialog box is called.  
  
-   **IOF_VERIFYSERVERSEXIST** Specifies that the dialog box should validate the classes it adds to the list box by ensuring that the servers specified in the registration database exist before the dialog box is displayed. Setting this flag can significantly impair performance.  
  
 `pParentWnd`  
 Points to the parent or owner window object (of type `CWnd`) to which the dialog object belongs. If it is **NULL**, the parent window of the dialog object is set to the main application window.  
  
## Remarks  
 To display the dialog box, call the [DoModal](../vs140/coleinsertdialog--domodal.md) function.  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COleInsertDialog Class](../vs140/coleinsertdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleInsertDialog::DoModal](../vs140/coleinsertdialog--domodal.md)