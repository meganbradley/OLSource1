---
title: "CMFCRibbonButton::SetMenu"
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
  - "CMFCRibbonButton.SetMenu"
  - "CMFCRibbonButton::SetMenu"
  - "SetMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetMenu method"
ms.assetid: 253c08f1-5068-4e26-81df-f99dc9754270
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonButton::SetMenu
Assigns a pop-up menu to the ribbon button.  
  
## Syntax  
  
```  
void SetMenu(  
   HMENU hMenu,  
   BOOL bIsDefaultCommand=FALSE,  
   BOOL bRightAlign=FALSE   
);  
void SetMenu(  
   UINT uiMenuResID,  
   BOOL bIsDefaultCommand=FALSE,  
   BOOL bRightAlign=FALSE   
);  
```  
  
#### Parameters  
 `hMenu`  
 A handle to a Windows menu.  
  
 `bIsDefaultCommand`  
 If `TRUE`, the button can execute its default command; otherwise, the button displays a pop-up menu.  
  
 `bRightAlign`  
 If `TRUE`, the menu is right-aligned. Otherwise, the menu is left-aligned.  
  
 `uiMenuResID`  
 A menu resource ID.  
  
## Remarks  
 When the application assigns the menu to the button, the button displays an arrow on its right side. If `bIsDefaultCommand` is `TRUE`, the menu appears only when the user clicks the arrow. If the user clicks the button, its default command is executed. If `bIsDefaultCommand` is `FALSE`, the menu appears by clicking anywhere on the button.  
  
## Requirements  
 **Header:** afxribbonbutton.h  
  
## See Also  
 [CMFCRibbonButton Class](../vs140/cmfcribbonbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)