---
title: "CRenderTarget::DrawText"
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
  - "afxrendertarget/CRenderTarget::DrawText"
  - "DrawText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawText method"
ms.assetid: b1858d69-9336-408e-8fe6-b3b2a903a647
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRenderTarget::DrawText
Draws the specified text using the format information provided by an IDWriteTextFormat object.  
  
## Syntax  
  
```  
void DrawText(  
   const CString& strText,  
   const CD2DRectF& rect,  
   CD2DBrush* pForegroundBrush,  
   CD2DTextFormat* textFormat = NULL,  
   D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE,  
   DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL  
);  
```  
  
#### Parameters  
 `strText`  
 A pointer to an array of Unicode characters to draw.  
  
 `rect`  
 The size and position of the area in which the text is drawn.  
  
 `pForegroundBrush`  
 The brush used to paint the text.  
  
 `textFormat`  
 An object that describes formatting details of the text to draw, such as the font, the font size, and flow direction.  
  
 `options`  
 A value that indicates whether the text should be snapped to pixel boundaries and whether the text should be clipped to the layout rectangle. The default value is D2D1_DRAW_TEXT_OPTIONS_NONE, which indicates that text should be snapped to pixel boundaries and it should not be clipped to the layout rectangle.  
  
 `measuringMode`  
 A value that indicates how glyph metrics are used to measure text when it is formatted. The default value is DWRITE_MEASURING_MODE_NATURAL.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CRenderTarget Class](../vs140/crendertarget-class.md)