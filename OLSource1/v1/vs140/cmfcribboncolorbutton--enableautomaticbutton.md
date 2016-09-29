---
title: "CMFCRibbonColorButton::EnableAutomaticButton"
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
  - "CMFCRibbonColorButton.EnableAutomaticButton"
  - "CMFCRibbonColorButton::EnableAutomaticButton"
  - "EnableAutomaticButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableAutomaticButton method"
ms.assetid: 62b80a92-f563-49eb-abdf-7c806e52739b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonColorButton::EnableAutomaticButton
Specifies whether the **Automatic** button is enabled.  
  
## Syntax  
  
```  
void EnableAutomaticButton(  
   LPCTSTR lpszLabel,  
   COLORREF colorAutomatic,  
   BOOL bEnable=TRUE,  
   LPCTSTR lpszToolTip=NULL,  
   BOOL bOnTop=TRUE,  
   BOOL bDrawBorder=FALSE   
);  
```  
  
#### Parameters  
 [in] `lpszLabel`  
 The label for the **Automatic** button.  
  
 [in] `colorAutomatic`  
 An RGB value that specifies the **Automatic** button's default color.  
  
 [in] `bEnable`  
 `TRUE` if the **Automatic** button is enabled; `FALSE` if it is disabled.  
  
 [in] `lpszToolTip`  
 The tooltip of the **Automatic** button.  
  
 [in] `bOnTop`  
 Specifies whether the **Automatic** button is at the top, before color palette.  
  
 [in] `bDrawBorder`  
 `TRUE` if the application draws a border around the color bar on the ribbon color button. Color bar displays the currently selected color. `FALSE` if the application does not draw a border  
  
## Requirements  
 **Header:** afxribboncolorbutton.h  
  
## See Also  
 [CMFCRibbonColorButton Class](../vs140/cmfcribboncolorbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)