---
title: "CRenderTarget::DrawRoundedRectangle"
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
  - "DrawRoundedRectangle"
  - "afxrendertarget/CRenderTarget::DrawRoundedRectangle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawRoundedRectangle method"
ms.assetid: f4025373-8b11-4496-997f-b2b20d340366
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRenderTarget::DrawRoundedRectangle
Draws the outline of the specified rounded rectangle using the specified stroke style.  
  
## Syntax  
  
```  
void DrawRoundedRectangle(  
   const CD2DRoundedRect& rectRounded,  
   CD2DBrush* pBrush,  
   FLOAT fStrokeWidth = 1.0,  
   ID2D1StrokeStyle* strokeStyle = NULL  
);  
```  
  
#### Parameters  
 `rectRounded`  
 The dimensions of the rounded rectangle to draw, in device-independent pixels.  
  
 `pBrush`  
 The brush used to paint the rounded rectangle's outline.  
  
 `fStrokeWidth`  
 The width of the rounded rectangle's stroke. The stroke is centered on the rounded rectangle's outline. The default value is 1.0f.  
  
 `strokeStyle`  
 The style of the rounded rectangle's stroke, or NULL to paint a solid stroke. The default value is NULL.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CRenderTarget Class](../vs140/crendertarget-class.md)