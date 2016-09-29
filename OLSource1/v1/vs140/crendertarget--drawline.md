---
title: "CRenderTarget::DrawLine"
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
  - "DrawLine"
  - "afxrendertarget/CRenderTarget::DrawLine"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawLine method"
ms.assetid: b8c52d27-d177-4a14-b6f9-77107312c69c
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRenderTarget::DrawLine
Draws a line between the specified points using the specified stroke style.  
  
## Syntax  
  
```  
void DrawLine(  
   const CD2DPointF& ptFrom,  
   const CD2DPointF& ptTo,  
   CD2DBrush* pBrush,  
   FLOAT fStrokeWidth = 1.0,  
   ID2D1StrokeStyle* strokeStyle = NULL  
);  
```  
  
#### Parameters  
 `ptFrom`  
 The start point of the line, in device-independent pixels.  
  
 `ptTo`  
 The end point of the line, in device-independent pixels.  
  
 `pBrush`  
 The brush used to paint the line's stroke.  
  
 `fStrokeWidth`  
 A value greater than or equal to 0.0f that specifies the width of the stroke. If this parameter isn't specified, it defaults to 1.0f. The stroke is centered on the line.  
  
 `strokeStyle`  
 The style of stroke to paint, or NULL to paint a solid line.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CRenderTarget Class](../vs140/crendertarget-class.md)