---
title: "COlePasteSpecialDialog::GetDrawAspect"
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
  - "COlePasteSpecialDialog::GetDrawAspect"
  - "COlePasteSpecialDialog.GetDrawAspect"
  - "GetDrawAspect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COlePasteSpecialDialog class, operations and attributes"
  - "GetDrawAspect method"
ms.assetid: 8013427e-2242-4cfb-b66d-ec12567f6fc3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COlePasteSpecialDialog::GetDrawAspect
Determines if the user chose to display the selected item as an icon.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The method needed to render the object.  
  
-   <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> Returned if the Display As Icon check box was not checked when the dialog box was dismissed.  
  
-   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> Returned if the Display As Icon check box was checked when the dialog box was dismissed.  
  
## Remarks  
 Only call this function after [DoModal](../vs140/colepastespecialdialog--domodal.md) returns **IDOK**.  
  
 For more information on drawing aspect, see the [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COlePasteSpecialDialog Class](../vs140/colepastespecialdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COlePasteSpecialDialog::DoModal](../vs140/colepastespecialdialog--domodal.md)