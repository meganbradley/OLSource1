---
title: "CRenderTarget::DrawTextLayout"
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
  - "afxrendertarget/CRenderTarget::DrawTextLayout"
  - "DrawTextLayout"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawTextLayout method"
ms.assetid: 18f34b6c-9e4e-4a0a-91c8-58c0dbeb4833
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRenderTarget::DrawTextLayout
Draws the formatted text described by the specified IDWriteTextLayout object.  
  
## Syntax  
  
```  
void DrawTextLayout(  
   const CD2DPointF& ptOrigin,  
   CD2DTextLayout* textLayout,  
   CD2DBrush* pBrushForeground,  
   D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE  
);  
```  
  
#### Parameters  
 `ptOrigin`  
 The point, described in device-independent pixels, at which the upper-left corner of the text described by textLayout is drawn.  
  
 `textLayout`  
 The formatted text to draw. Any drawing effects that do not inherit from ID2D1Resource are ignored. If there are drawing effects that inherit from ID2D1Resource that are not brushes, this method fails and the render target is put in an error state.  
  
 `pBrushForeground`  
 The brush used to paint any text in textLayout that does not already have a brush associated with it as a drawing effect (specified by the IDWriteTextLayout::SetDrawingEffect method).  
  
 `options`  
 A value that indicates whether the text should be snapped to pixel boundaries and whether the text should be clipped to the layout rectangle. The default value is D2D1_DRAW_TEXT_OPTIONS_NONE, which indicates that text should be snapped to pixel boundaries and it should not be clipped to the layout rectangle.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CRenderTarget Class](../vs140/crendertarget-class.md)