---
title: "CDrawingManager::RGBtoHSL"
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
  - "RGBtoHSL"
  - "CDrawingManager.RGBtoHSL"
  - "CDrawingManager::RGBtoHSL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RGBtoHSL method"
ms.assetid: 5a0711e7-7fd5-41aa-aa34-19b37ccaba77
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDrawingManager::RGBtoHSL
Converts a color from a red, green, and blue (RGB) representation to a hue, saturation, and lightness (HSL) representation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The color in RGB values.|  
|[out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|A pointer to a double where the method stores the hue for the color.|  
|[out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|A pointer to a double where the method stores the saturation for the color.|  
|[out] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|A pointer to a double where the method stores the lightness for the color.|  
  
## Remarks  
 A color can be represented as HSV (hue, saturation, and value), HSL (hue, saturation, and luminosity), or RGB (red, green, and blue). For more information about the different representations of color, see [Color](http://go.microsoft.com/fwlink/?LinkID=119126).  
  
 The returned value for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is represented as a fraction between 0 and 1 where both 0 and 1 represent red. The returned values for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> are numbers between 0 and 1.  
  
## Requirements  
 **Header:** afxdrawmanager.h  
  
## See Also  
 [CDrawingManager Class](../vs140/cdrawingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CDrawingManager::HLStoRGB_ONE](../vs140/cdrawingmanager--hlstorgb_one.md)   
 [CDrawingManager::HLStoRGB_TWO](../vs140/cdrawingmanager--hlstorgb_two.md)