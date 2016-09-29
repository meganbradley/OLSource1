---
title: "CColorDialog::OnColorOK"
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
  - "OnColorOK"
  - "CColorDialog.OnColorOK"
  - "CColorDialog::OnColorOK"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CColorDialog class, overridables"
  - "OnColorOK method"
ms.assetid: 9324ecc8-46e8-4132-a597-8d1ed330819b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CColorDialog::OnColorOK
Override to validate the color entered into the dialog box.  
  
## Syntax  
  
```  
  
virtual BOOL OnColorOK( );  
```  
  
## Return Value  
 Nonzero if the dialog box should not be dismissed; otherwise 0 to accept the color that was entered.  
  
## Remarks  
 Override this function only if you want to provide custom validation of the color the user selects in the color dialog box.  
  
 The user can select a color by one of the following two methods:  
  
-   Clicking a color on the color palette. The selected color's RGB values are then reflected in the appropriate RGB edit boxes.  
  
-   Entering values in the RGB edit boxes  
  
 Overriding `OnColorOK` allows you to reject a color the user enters into a common color dialog box for any application-specific reason.  
  
 Normally, you do not need to use this function because the framework provides default validation of colors and displays a message box if an invalid color is entered.  
  
 You can call [SetCurrentColor](../vs140/ccolordialog--setcurrentcolor.md) from within `OnColorOK` to force a color selection. Once `OnColorOK` has been fired (that is, the user clicks **OK** to accept the color change), you can call [GetColor](../vs140/ccolordialog--getcolor.md) to get the RGB value of the new color.  
  
## Example  
 [!code[NVC_MFCDocView#52](../vs140/codesnippet/CPP/ccolordialog--oncolorok_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CColorDialog Class](../vs140/ccolordialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)