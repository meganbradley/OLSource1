---
title: "CDrawingManager::DrawShadow"
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
  - "DrawShadow"
  - "CDrawingManager.DrawShadow"
  - "CDrawingManager::DrawShadow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawShadow method"
ms.assetid: a127fa52-5d73-409f-b3c9-f4f225ab9d02
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDrawingManager::DrawShadow
Draws a shadow for a rectangular area.  
  
## Syntax  
  
```  
BOOL DrawShadow(  
   CRect rect,  
   int nDepth,  
   int iMinBrightness = 100,  
   int iMaxBrightness = 50,  
   CBitmap* pBmpSaveBottom = NULL,  
   CBitmap* pBmpSaveRight = NULL,  
   COLORREF clrBase = (COLORREF)-1,  
   BOOL bRightShadow = TRUE   
);  
```  
  
#### Parameters  
 [in] `rect`  
 A rectangular area in your application. The drawing manager will draw a shadow underneath this area.  
  
 [in] `nDepth`  
 The width and height of the shadow.  
  
 [in] `iMinBrightness`  
 The minimum brightness of the shadow.  
  
 [in] `iMaxBrightness`  
 The maximum brightness of the shadow.  
  
 [in] `pBmpSaveBottom`  
 A pointer to a bitmap that contains the image for the bottom part of the shadow.  
  
 [in] `pBmpSaveRight`  
 A pointer to a bitmap that contains the image for the shadow that is drawn on the right side of the rectangle.  
  
 [in] `clrBase`  
 The color of the shadow.  
  
 [in] `bRightShadow`  
 A Boolean parameter that indicates how the shadow is drawn. If `bRightShadow` is `TRUE`, `DrawShadow` draws a shadow on the right side of the rectangle.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 You can provide two valid bitmaps for the bottom and right shadows by using the parameters `pBmpSaveBottom` and `pBmpSaveRight`. If these [CBitmap](../vs140/cbitmap-class.md) objects have an attached GDI object, `DrawShadow` will use those bitmaps as the shadows. If the `CBitmap` parameters do not have an attached GDI object, `DrawShadow` draws the shadow and attaches the bitmaps to the parameters. In future calls to `DrawShadow`, you can provide these bitmaps to speed up the drawing process. For more information about the `CBitmap` class and GDI objects, see [Graphic Objects](../vs140/graphic-objects.md).  
  
 If either of these parameters is `NULL`, `DrawShadow` will automatically draw the shadow.  
  
 If you set `bRightShadow` to `FALSE`, the shadow will be drawn underneath and to the left of the rectangular area.  
  
## Example  
 The following example demonstrates how to use the `DrawShadow` method of the `CDrawingManager` class. This code snippet is part of the [Prop Sheet Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_PropSheetDemo#1](../vs140/codesnippet/CPP/cdrawingmanager--drawshadow_1.cpp)]  
  
## Requirements  
 **Header:** afxdrawmanager.h  
  
## See Also  
 [CDrawingManager Class](../vs140/cdrawingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)