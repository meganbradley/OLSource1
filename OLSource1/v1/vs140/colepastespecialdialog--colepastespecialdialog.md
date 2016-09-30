---
title: "COlePasteSpecialDialog::COlePasteSpecialDialog"
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
  - "PSF_SELECTPASTELINK"
  - "COlePasteSpecialDialog"
  - "PSF_CHECKDISPLAYASICON"
  - "COlePasteSpecialDialog.COlePasteSpecialDialog"
  - "COlePasteSpecialDialog::COlePasteSpecialDialog"
  - "PSF_SHOWHELP"
  - "PSF_SELECTPASTE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PSF_SHOWHELP"
  - "PSF_SELECTPASTE"
  - "PSF_SELECTPASTELINK"
  - "COlePasteSpecialDialog class, constructor"
  - "PSF_CHECKDISPLAYASICON"
ms.assetid: 7a442726-9060-4518-ae89-c1d078efa3f6
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COlePasteSpecialDialog::COlePasteSpecialDialog
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Creation flag, contains any number of the following flags combined using the bitwise-OR operator:  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> Specifies that the Paste radio button will be checked initially when the dialog box is called. Cannot be used in combination with <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. This is the default.  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> Specifies that the Paste Link radio button will be checked initially when the dialog box is called. Cannot be used in combination with <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> Specifies that the Display As Icon check box will be checked initially when the dialog box is called.  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> Specifies that the Help button will be displayed when the dialog box is called.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Points to the [COleDataObject](../vs140/coledataobject-class.md) for pasting. If this value is **NULL**, it gets the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> from the Clipboard.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Points to the parent or owner window object (of type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>) to which the dialog object belongs. If it is **NULL**, the parent window of the dialog box is set to the main application window.  
  
## Remarks  
 This function only constructs a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object. To display the dialog box, call the [DoModal](../vs140/colepastespecialdialog--domodal.md) function.  
  
 For more information, see the [OLEUIPASTEFLAG](http://msdn.microsoft.com/library/windows/desktop/ms682172) enumerated type in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COlePasteSpecialDialog Class](../vs140/colepastespecialdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataObject Class](../vs140/coledataobject-class.md)   
 [COlePasteSpecialDialog::DoModal](../vs140/colepastespecialdialog--domodal.md)