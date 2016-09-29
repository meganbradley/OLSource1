---
title: "CDrawingManager::RGBtoHSV"
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
  - "CDrawingManager::RGBtoHSV"
  - "RGBtoHSV"
  - "CDrawingManager.RGBtoHSV"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RGBtoHSV method"
ms.assetid: c82ea7a4-0fc5-4690-85b1-9428b882aca7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDrawingManager::RGBtoHSV
Converts a color from a RGB representation to a HSV representation.  
  
## Syntax  
  
```  
static void __stdcall RGBtoHSV(  
   COLORREF rgb,  
   double *H,  
   double *S,  
   double *V  
);  
```  
  
#### Parameters  
 [in] `rgb`  
 The color to convert in a RGB representation.  
  
 [out] `H`  
 A pointer to a double where this method stores the resulting hue for the color.  
  
 [out] `S`  
 A pointer to a double where this method stores the resulting saturation for the color.  
  
 [out] `V`  
 A pointer to a double where this method stores the resulting value for the color.  
  
## Remarks  
 A color can be represented as HSV (hue, saturation, and value), HSL (hue, saturation, and luminosity), or RGB (red, green, and blue). For more information about the different representations of color, see [Color](http://go.microsoft.com/fwlink/?LinkID=119126).  
  
 The returned value for `H` is a number between 0 and 360 where both 0 and 360 indicate red. The return values for `S` and `V` are numbers between 0 and 1.  
  
## Requirements  
 **Header:** afxdrawmanager.h  
  
## See Also  
 [CDrawingManager Class](../vs140/cdrawingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CDrawingManager::HSVtoRGB](../vs140/cdrawingmanager--hsvtorgb.md)