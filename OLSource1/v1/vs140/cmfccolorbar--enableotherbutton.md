---
title: "CMFCColorBar::EnableOtherButton"
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
  - "CMFCColorBar::EnableOtherButton"
  - "CMFCColorBar.EnableOtherButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableOtherButton method"
ms.assetid: bcee6718-d9d5-4c16-90cc-4894a26c7007
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorBar::EnableOtherButton
Enables or disables the display of a dialog box that lets the user select more colors.  
  
## Syntax  
  
```  
void EnableOtherButton(  
   LPCTSTR lpszLabel,  
   BOOL bAltColorDlg=TRUE,  
   BOOL bEnable=TRUE   
);  
```  
  
#### Parameters  
 [in] `lpszLabel`  
 The text label of the *other* button, which displays more color choices, or `NULL`.  
  
 The standard label for this button is **More Colors...**.  
  
 [in] `bAltColorDlg`  
 `TRUE` to display the [CMFCColorDialog](../vs140/cmfccolordialog-class.md) dialog box; `FALSE` to display the standard [CColorDialog](../vs140/ccolordialog-class.md) dialog box. The default value is `TRUE`.  
  
 [in] `bEnable`  
 `TRUE` to enable thebutton; `FALSE` to disable the button. The default value is `TRUE`.  
  
## Requirements  
 **Header:** afxcolorbar.h  
  
## See Also  
 [CMFCColorBar Class](../vs140/cmfccolorbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCColorDialog Class](../vs140/cmfccolordialog-class.md)   
 [CColorDialog Class](../vs140/ccolordialog-class.md)