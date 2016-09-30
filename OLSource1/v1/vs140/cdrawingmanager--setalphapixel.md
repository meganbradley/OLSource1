---
title: "CDrawingManager::SetAlphaPixel"
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
  - "CDrawingManager::SetAlphaPixel"
  - "CDrawingManager.SetAlphaPixel"
  - "SetAlphaPixel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAlphaPixel method"
ms.assetid: 15631f6b-e0cc-41ab-af89-a46be6cd281d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDrawingManager::SetAlphaPixel
Colors a transparent pixel in a bitmap.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the bit values for the bitmap.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A rectangular area in your application. The drawing manager draws a shadow underneath and to the right of this area.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The horizontal coordinate of the pixel to color.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The vertical coordinate of the pixel to color.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The percentage of transparency.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The width and height of the shadow.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The color of the shadow.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates which pixel to color. See the Remarks section for more information.  
  
## Remarks  
 This method is a helper method that is used by the [CDrawingManager::DrawShadow](../vs140/cdrawingmanager--drawshadow.md) method. We recommend that if you want to draw a shadow, call <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> instead.  
  
 If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, the pixel to color is measured <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> pixels from the right edge of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. If it is <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, the pixel to color is measured <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> pixels from the left edge of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxdrawmanager.h  
  
## See Also  
 [CDrawingManager Class](../vs140/cdrawingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CDrawingManager::DrawShadow](../vs140/cdrawingmanager--drawshadow.md)