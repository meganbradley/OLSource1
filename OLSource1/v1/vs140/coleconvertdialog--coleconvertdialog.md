---
title: "COleConvertDialog::COleConvertDialog"
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
  - "COleConvertDialog.COleConvertDialog"
  - "COleConvertDialog"
  - "COleConvertDialog::COleConvertDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleConvertDialog class, constructor"
ms.assetid: fd53972a-3849-4712-b627-5dc09d132b00
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleConvertDialog::COleConvertDialog
Constructs only a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to the item to be converted or activated.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Creation flag, which contains any number of the following values combined using the bitwise-or operator:  
  
-   **CF_SELECTCONVERTTO** Specifies that the Convert To radio button will be selected initially when the dialog box is called. This is the default.  
  
-   **CF_SELECTACTIVATEAS** Specifies that the Activate As radio button will be selected initially when the dialog box is called.  
  
-   **CF_SETCONVERTDEFAULT** Specifies that the class whose **CLSID** is specified by the **clsidConvertDefault** member of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> structure will be used as the default selection in the class list box when the Convert To radio button is selected.  
  
-   **CF_SETACTIVATEDEFAULT** Specifies that the class whose **CLSID** is specified by the **clsidActivateDefault** member of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure will be used as the default selection in the class list box when the Activate As radio button is selected.  
  
-   **CF_SHOWHELPBUTTON** Specifies that the Help button will be displayed when the dialog box is called.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Points to the CLSID of the item to be converted or activated. If **NULL**, the **CLSID** associated with <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> will be used.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Points to the parent or owner window object (of type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>) to which the dialog object belongs. If it is **NULL**, the parent window of the dialog box is set to the main application window.  
  
## Remarks  
 To display the dialog box, call the [DoModal](../vs140/coleconvertdialog--domodal.md) function.  
  
 For more information, see [CLSID Key](http://msdn.microsoft.com/library/windows/desktop/ms691424) and the [OLEUICONVERT](http://msdn.microsoft.com/library/windows/desktop/ms686657) structure.  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COleConvertDialog Class](../vs140/coleconvertdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleConvertDialog::DoModal](../vs140/coleconvertdialog--domodal.md)   
 [COleConvertDialog::m_cv](../vs140/coleconvertdialog--m_cv.md)