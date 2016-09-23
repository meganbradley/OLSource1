---
title: "CMFCRibbonColorButton::EnableOtherButton"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - EnableOtherButton
  - CMFCRibbonColorButton::EnableOtherButton
  - CMFCRibbonColorButton.EnableOtherButton
dev_langs: 
  - C++
helpviewer_keywords: 
  - EnableOtherButton method
ms.assetid: e9a146de-dafb-4d28-aa32-3380e5ce020f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonColorButton::EnableOtherButton
Enables the **Other** button.  
  
## Syntax  
  
```  
void EnableOtherButton(  
   LPCTSTR lpszLabel,  
   LPCTSTR lpszToolTip=NULL   
);  
```  
  
#### Parameters  
 `lpszLabel`  
 The button's label.  
  
 `lpszToolTip`  
 The tooltip text for the **Other** button.  
  
## Remarks  
 The **Other** button is the button that is displayed below the group of colors. When the user clicks the **Other** button, it displays a color dialog.  
  
## Requirements  
 **Header:** afxribboncolorbutton.h  
  
## See Also  
 [CMFCRibbonColorButton Class](../vs140/cmfcribboncolorbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)