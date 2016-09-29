---
title: "CMFCRibbonColorButton::AddColorsGroup"
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
  - "AddColorsGroup"
  - "CMFCRibbonColorButton::AddColorsGroup"
  - "CMFCRibbonColorButton.AddColorsGroup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddColorsGroup method"
ms.assetid: 33041488-ed1c-4527-b53b-b31ee46becf0
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonColorButton::AddColorsGroup
Adds a group of colors to the regular color area.  
  
## Syntax  
  
```  
void AddColorsGroup(  
   LPCTSTR lpszName,  
   const CList<COLORREF,COLORREF>& lstColors,  
   BOOL bContiguousColumns=FALSE   
);  
```  
  
#### Parameters  
 [in] `lpszName`  
 The group name.  
  
 [in] `lstColors`  
 The list of colors.  
  
 [in] `bContiguousColumns`  
 Controls how the color items are displayed in the group. If `TRUE`, the color items are drawn without a vertical spacing. If `FALSE`, the color items are drawn with a vertical spacing.  
  
## Remarks  
 Use this function to make the color pop-up display several groups of colors. You can control how the colors are displayed in group.  
  
## Requirements  
 **Header:** afxribboncolorbutton.h  
  
## See Also  
 [CMFCRibbonColorButton Class](../vs140/cmfcribboncolorbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)