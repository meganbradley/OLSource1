---
title: "CDrawingManager::HighlightRect"
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
  - "CDrawingManager.HighlightRect"
  - "HighlightRect"
  - "CDrawingManager::HighlightRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HighlightRect method"
ms.assetid: de85ae89-3df4-4779-8263-62c106ec6a80
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDrawingManager::HighlightRect
Highlights a rectangular area.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A rectangular area to highlight.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A percentage that indicates how transparent the highlight should be.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The transparent color.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 An integer between 0 and 255 that indicates the color tolerance.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The base color for blending.  
  
## Return Value  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the method is successful; otherwise <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is between 0 and 99, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> uses the alpha blending algorithm. For more information about alpha blending, see [Alpha Blending Lines and Fills](assetId:///5440f48c-3ac9-44c3-b170-c1c110bdbab8). If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is -1, this method uses the default highlight level. If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is 100, this method does nothing and returns <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 The method uses the parameter <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to determine whether to highlight the rectangular area. To highlight the rectangle, the difference between the background color of your application and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> must be less than <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> in each color component (red, green, and blue).  
  
## Requirements  
 **Header:** afxdrawmanager.h  
  
## See Also  
 [CDrawingManager Class](../vs140/cdrawingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)