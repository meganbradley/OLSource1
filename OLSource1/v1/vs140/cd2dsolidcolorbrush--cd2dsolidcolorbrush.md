---
title: "CD2DSolidColorBrush::CD2DSolidColorBrush"
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
  - "CD2DSolidColorBrush"
  - "afxrendertarget/CD2DSolidColorBrush::CD2DSolidColorBrush"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DSolidColorBrush class, constructor"
ms.assetid: fae53a54-145d-4bce-92ea-df0f0b02799b
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DSolidColorBrush::CD2DSolidColorBrush
Constructs a CD2DSolidColorBrush object.  
  
## Syntax  
  
```  
CD2DSolidColorBrush(  
   CRenderTarget* pParentTarget,  
   D2D1_COLOR_F color,  
   CD2DBrushProperties* pBrushProperties = NULL,  
   BOOL bAutoDestroy = TRUE  
);  
CD2DSolidColorBrush(  
   CRenderTarget* pParentTarget,  
   COLORREF color,  
   int nAlpha = 255,  
   CD2DBrushProperties* pBrushProperties = NULL,  
   BOOL bAutoDestroy = TRUE  
);  
```  
  
#### Parameters  
 `pParentTarget`  
 A pointer to the render target.  
  
 `color`  
 The red, green, blue, and alpha values of the brush's color.  
  
 `pBrushProperties`  
 A pointer to the opacity and transformation of a brush.  
  
 `bAutoDestroy`  
 Indicates that the object will be destroyed by owner (pParentTarget).  
  
 `nAlpha`  
 The opacity of the brush's color.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DSolidColorBrush Class](../vs140/cd2dsolidcolorbrush-class.md)