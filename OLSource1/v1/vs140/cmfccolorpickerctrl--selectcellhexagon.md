---
title: "CMFCColorPickerCtrl::SelectCellHexagon"
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
  - "CMFCColorPickerCtrl.SelectCellHexagon"
  - "SelectCellHexagon"
  - "CMFCColorPickerCtrl::SelectCellHexagon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SelectCellHexagon method"
ms.assetid: 32bfe7f8-4b56-4157-8743-a4c31ba44858
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorPickerCtrl::SelectCellHexagon
Sets the current color to the color defined by the specified RGB color components or the specified cell hexagon.  
  
## Syntax  
  
```  
void SelectCellHexagon(  
   BYTE R,  
   BYTE G,  
   BYTE B   
);  
BOOL SelectCellHexagon(  
   int x,  
   int y   
);  
```  
  
#### Parameters  
 [in] `R`  
 The red color component.  
  
 [in] `G`  
 The green color component.  
  
 [in] `B`  
 The blue color component.  
  
 [in] `x`  
 The x-coordinate of the cursor, which points to a cell hexagon.  
  
 [in] `y`  
 The y-coordinate of the cursor, which points to a cell hexagon.  
  
## Return Value  
 The second overload of this method always returns `FALSE`.  
  
## Remarks  
 The first overload of this method sets the current color to the color that corresponds to the color selection control's specified red, green, and blue color components.  
  
 The second overload of this method sets the current color to the color of the cell hexagon that is pointed to by the specified cursor location.  
  
## Requirements  
 **Header:** afxcolorpickerctrl.h  
  
## See Also  
 [CMFCColorPickerCtrl Class](../vs140/cmfccolorpickerctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)