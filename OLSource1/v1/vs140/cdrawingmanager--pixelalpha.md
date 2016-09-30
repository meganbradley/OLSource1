---
title: "CDrawingManager::PixelAlpha"
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
  - "PixelAlpha"
  - "CDrawingManager.PixelAlpha"
  - "CDrawingManager::PixelAlpha"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PixelAlpha method"
ms.assetid: c3158758-c916-4e86-92a3-023ecd88966c
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDrawingManager::PixelAlpha
Calculates the final color for a semitransparent pixel.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The initial color for the pixel.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A number between 0 and 100 that represents the percentage of transparency. A value of 100 indicates that the initial color is completely transparent.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A number between 0 and 100 that represents the percentage of transparency for the red component.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A number between 0 and 100 that represents the percentage of transparency for the green component.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A number between 0 and 100 that represents the percentage of transparency for the blue component.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The base color for the pixel.  
  
## Return Value  
 The final color for the semitransparent pixel.  
  
## Remarks  
 This is a helper class for coloring semitransparent bitmaps and is not designed to be called directly by the programmer.  
  
 When you use the version of the method that has <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the final color is a combination of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> color is the partially transparent color over the base color of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxdrawmanager.h  
  
## See Also  
 [CDrawingManager Class](../vs140/cdrawingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)