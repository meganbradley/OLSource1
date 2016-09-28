---
title: "CRenderTarget::DrawGeometry"
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
  - "afxrendertarget/CRenderTarget::DrawGeometry"
  - "DrawGeometry"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawGeometry method"
ms.assetid: ef91ec3a-ce2b-49fa-bffd-7585feebcbb7
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRenderTarget::DrawGeometry
Draws the outline of the specified geometry using the specified stroke style.  
  
## Syntax  
  
```  
void DrawGeometry(  
   CD2DGeometry* pGeometry,  
   CD2DBrush* pBrush,  
   FLOAT fStrokeWidth = 1.0,  
   ID2D1StrokeStyle* strokeStyle = NULL  
);  
```  
  
#### Parameters  
 `pGeometry`  
 The geometry to draw.  
  
 `pBrush`  
 The brush used to paint the geometry's stroke.  
  
 `fStrokeWidth`  
 The thickness of the geometry's stroke. The stroke is centered on the geometry's outline.  
  
 `strokeStyle`  
 The style of stroke to apply to the geometry's outline, or NULL to paint a solid stroke.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CRenderTarget Class](../vs140/crendertarget-class.md)