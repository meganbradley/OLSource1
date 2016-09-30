---
title: "CMFCColorButton::EnableOtherButton"
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
  - "EnableOtherButton"
  - "CMFCColorButton::EnableOtherButton"
  - "CMFCColorButton.EnableOtherButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableOtherButton method"
ms.assetid: e727c983-9cf9-47b9-8aa3-8d0b43071203
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorButton::EnableOtherButton
Enable or disable the "other" button, which appears below regular color buttons.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the button's text.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies whether the [CMFCColorDialog](../vs140/cmfccolordialog-class.md) dialog box or the system color dialog box is opened when the user clicks the button.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies whether the "other" button is enabled or disabled.  
  
## Remarks  
 Click the "other" button to display a color dialog box. If the *bAltColorDlg* parameter is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the [CMFCColorDialog Class](../vs140/cmfccolordialog-class.md) is displayed; otherwise, the system color dialog box is displayed.  
  
## Requirements  
 **Header:** afxcolorbutton.h  
  
## See Also  
 [CMFCColorButton Class](../vs140/cmfccolorbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)