---
title: "CDrawingManager::HLStoRGB_ONE"
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
  - "HLStoRGB_ONE"
  - "CDrawingManager::HLStoRGB_ONE"
  - "CDrawingManager.HLStoRGB_ONE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HLStoRGB_ONE method"
ms.assetid: 778127b4-63dd-47aa-9d14-6f53909fedf7
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDrawingManager::HLStoRGB_ONE
Converts a color from a HLS representation to a RGB representation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A number between 0 and 1 that represents the hue for the color.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A number between 0 and 1 that indicates the luminosity for the color.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A number between 0 and 1 that indicates the saturation for the color.  
  
## Return Value  
 The RGB representation of the HLS color provided.  
  
## Remarks  
 A color can be represented as HSV (hue, saturation, and value), HSL (hue, saturation, and luminosity), or RGB (red, green, and blue). For more information about the different representations of color, see [Color](http://go.microsoft.com/fwlink/?LinkID=119126).  
  
 This method and the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method perform the same operation, but require different values for the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter. In this method, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is a percentage of the circle. In the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is a degree value between 0 and 360, which both represent red. For example, with <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, a value of 0.25 for <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is equivalent to a value of 90 with <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxdrawmanager.h  
  
## See Also  
 [CDrawingManager Class](../vs140/cdrawingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CDrawingManager::RGBtoHSL](../vs140/cdrawingmanager--rgbtohsl.md)