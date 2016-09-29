---
title: "CDrawingManager::HLStoRGB_TWO"
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
  - "HLStoRGB_TWO"
  - "CDrawingManager::HLStoRGB_TWO"
  - "CDrawingManager.HLStoRGB_TWO"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HLStoRGB_TWO method"
ms.assetid: ee374475-367a-4df6-9457-141689a979fe
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDrawingManager::HLStoRGB_TWO
Converts a color from a HLS representation to a RGB representation.  
  
## Syntax  
  
```  
static COLORREF __stdcall HLStoRGB_TWO(  
   double H,  
   double L,  
   double S  
);  
```  
  
#### Parameters  
 [in] `H`  
 A number between 0 and 360 that represents the hue for the color.  
  
 [in] `L`  
 A number between 0 and 1 that indicates the luminosity for the color.  
  
 [in] `S`  
 A number between 0 and 1 that indicates the saturation for the color.  
  
## Return Value  
 The RGB representation of the HLS color provided.  
  
## Remarks  
 A color can be represented as HSV (hue, saturation, and value), HSL (hue, saturation, and luminosity), or RGB (red, green, and blue). For more information about the different representations of color, see [Color](http://go.microsoft.com/fwlink/?LinkID=119126).  
  
 This method and the [CDrawingManager::HLStoRGB_ONE](../vs140/cdrawingmanager--hlstorgb_one.md) method perform the same operation, but require different values for the `H` parameter. In this method, `H` is a degree value between 0 and 360, which both represent red. In the [CDrawingManager::HLStoRGB_ONE](../vs140/cdrawingmanager--hlstorgb_one.md) method, `H` is a percentage of the circle. For example, with `HLStoRGB_ONE`, a value of 0.25 for `H` is equivalent to a value of 90 with `HLStoRGB_TWO`.  
  
## Requirements  
 **Header:** afxdrawmanager.h  
  
## See Also  
 [CDrawingManager Class](../vs140/cdrawingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CDrawingManager::RGBtoHSL](../vs140/cdrawingmanager--rgbtohsl.md)   
 [CDrawingManager::HLStoRGB_ONE](../vs140/cdrawingmanager--hlstorgb_one.md)