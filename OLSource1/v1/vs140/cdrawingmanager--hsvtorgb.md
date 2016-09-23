---
title: "CDrawingManager::HSVtoRGB"
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
  - HSVtoRGB
  - CDrawingManager::HSVtoRGB
  - CDrawingManager.HSVtoRGB
dev_langs: 
  - C++
helpviewer_keywords: 
  - HSVtoRGB method
ms.assetid: 39b5385f-63d1-4813-b196-fea1dcc56440
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDrawingManager::HSVtoRGB
Converts a color from a HSV representation to a RGB representation.  
  
## Syntax  
  
```  
static COLORREF __stdcall HSVtoRGB(  
   double H,  
   double S,  
   double V  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] `H`|A number between 0 and 360 that indicates the hue for the color.|  
|[in] `S`|A number between 0 and 1 that indicates the saturation for the color.|  
|[in] `V`|A number between 0 and 1 that indicates the value for the color.|  
  
## Return Value  
 The RGB representation of the HSV color provided.  
  
## Remarks  
 A color can be represented as HSV (hue, saturation, and value), HSL (hue, saturation, and luminosity), or RGB (red, green, and blue). For more information about the different representations of color, see [Color](http://go.microsoft.com/fwlink/?LinkID=119126).  
  
## Requirements  
 **Header:** afxdrawmanager.h  
  
## See Also  
 [CDrawingManager Class](../vs140/cdrawingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CDrawingManager::RGBtoHSV](../vs140/cdrawingmanager--rgbtohsv.md)