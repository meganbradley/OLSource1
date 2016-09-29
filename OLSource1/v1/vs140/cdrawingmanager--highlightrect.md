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
  
```  
BOOL HighlightRect(  
   CRect rect,  
   int nPercentage = -1,  
   COLORREF clrTransparent = (COLORREF)-1,  
   int nTolerance = 0,  
   COLORREF clrBlend = (COLORREF)-1  
);  
```  
  
#### Parameters  
 [in] `rect`  
 A rectangular area to highlight.  
  
 [in] `nPercentage`  
 A percentage that indicates how transparent the highlight should be.  
  
 [in] `clrTransparent`  
 The transparent color.  
  
 [in] `nTolerance`  
 An integer between 0 and 255 that indicates the color tolerance.  
  
 [in] `clrBlend`  
 The base color for blending.  
  
## Return Value  
 `TRUE` if the method is successful; otherwise `FALSE`.  
  
## Remarks  
 If `nPercentage` is between 0 and 99, `HighlightRect` uses the alpha blending algorithm. For more information about alpha blending, see [Alpha Blending Lines and Fills](assetId:///5440f48c-3ac9-44c3-b170-c1c110bdbab8). If `nPercentage` is -1, this method uses the default highlight level. If `nPercentage` is 100, this method does nothing and returns `TRUE`.  
  
 The method uses the parameter `nTolerance` to determine whether to highlight the rectangular area. To highlight the rectangle, the difference between the background color of your application and `clrTransparent` must be less than `nTolerance` in each color component (red, green, and blue).  
  
## Requirements  
 **Header:** afxdrawmanager.h  
  
## See Also  
 [CDrawingManager Class](../vs140/cdrawingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)