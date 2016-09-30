---
title: "COleLinksDialog::COleLinksDialog"
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
  - "COleLinksDialog::COleLinksDialog"
  - "COleLinksDialog.COleLinksDialog"
  - "COleLinksDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleLinksDialog class, constructor"
ms.assetid: d3831cb1-5a3c-4f6e-84c6-83678bbdcf80
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleLinksDialog::COleLinksDialog
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to the OLE document that contains the links to be edited.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to the current view on <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Creation flag, which contains either 0 or **ELF_SHOWHELP** to specify whether the Help button will be displayed when the dialog box is displayed.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Points to the parent or owner window object (of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) to which the dialog object belongs. If it is **NULL**, the parent window of the dialog box is set to the main application window.  
  
## Remarks  
 This function constructs only a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object. To display the dialog box, call the [DoModal](../vs140/colelinksdialog--domodal.md) function.  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COleLinksDialog Class](../vs140/colelinksdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDocument Class](../vs140/coledocument-class.md)   
 [COleLinksDialog::DoModal](../vs140/colelinksdialog--domodal.md)   
 [CView Class](../vs140/cview-class.md)   
 [CWnd Class](../vs140/cwnd-class.md)