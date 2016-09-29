---
title: "CDrawingManager::DrawRect"
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
  - "CDrawingManager::DrawRect"
  - "DrawRect"
  - "CDrawingManager.DrawRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawRect method"
ms.assetid: 0130c018-39d7-41b3-ad62-7fd24c013fed
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDrawingManager::DrawRect
Draws a rectangle with the supplied fill and border colors.  
  
## Syntax  
  
```  
void DrawRect(  
   const CRect& rect,  
   COLORREF clrFill,  
   COLORREF clrLine  
);  
```  
  
#### Parameters  
 [in] `rect`  
 The boundaries for the rectangle.  
  
 [in] `clrFill`  
 The color this method uses to fill the rectangle.  
  
 [in] `clrLine`  
 The color this method uses for the border of the rectangle.  
  
## Remarks  
 This method returns without drawing a rectangle if either color is set to -1. It also returns if either dimension of the rectangle is 0.  
  
## Requirements  
 **Header:** afxdrawmanager.h  
  
## See Also  
 [CDrawingManager Class](../vs140/cdrawingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)