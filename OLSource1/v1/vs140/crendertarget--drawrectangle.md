---
title: "CRenderTarget::DrawRectangle"
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
  - "afxrendertarget/CRenderTarget::DrawRectangle"
  - "DrawRectangle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawRectangle method"
ms.assetid: a21550df-ab42-4dd3-88b9-8049fa966bb3
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRenderTarget::DrawRectangle
Draws the outline of a rectangle that has the specified dimensions and stroke style.  
  
## Syntax  
  
```  
void DrawRectangle(  
   const CD2DRectF& rect,  
   CD2DBrush* pBrush,  
   FLOAT fStrokeWidth = 1.0,  
   ID2D1StrokeStyle* strokeStyle = NULL  
);  
```  
  
#### Parameters  
 `rect`  
 The dimensions of the rectangle to draw, in device-independent pixels  
  
 `pBrush`  
 The brush used to paint the rectangle's stroke  
  
 `fStrokeWidth`  
 A value greater than or equal to 0.0f that specifies the width of the rectangle's stroke. The stroke is centered on the rectangle's outline.  
  
 `strokeStyle`  
 The style of stroke to paint, or NULL to paint a solid stroke.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CRenderTarget Class](../vs140/crendertarget-class.md)