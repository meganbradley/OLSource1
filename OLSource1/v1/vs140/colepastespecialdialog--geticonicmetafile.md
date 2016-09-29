---
title: "COlePasteSpecialDialog::GetIconicMetafile"
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
  - "COlePasteSpecialDialog::GetIconicMetafile"
  - "GetIconicMetafile"
  - "COlePasteSpecialDialog.GetIconicMetafile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COlePasteSpecialDialog class, operations and attributes"
  - "GetIconicMetafile method"
ms.assetid: 52ea8938-4855-4843-a672-61464c44cb17
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COlePasteSpecialDialog::GetIconicMetafile
Gets the metafile associated with the item selected by the user.  
  
## Syntax  
  
```  
  
HGLOBAL GetIconicMetafile( ) const;  
```  
  
## Return Value  
 The handle to the metafile containing the iconic aspect of the selected item, if the Display As Icon check box was selected when the dialog box was dismissed by choosing **OK**; otherwise **NULL**.  
  
## Requirements  
 **Header:** afxodlgs.h  
  
## See Also  
 [COlePasteSpecialDialog Class](../vs140/colepastespecialdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COlePasteSpecialDialog::GetDrawAspect](../vs140/colepastespecialdialog--getdrawaspect.md)   
 [COlePasteSpecialDialog::DoModal](../vs140/colepastespecialdialog--domodal.md)