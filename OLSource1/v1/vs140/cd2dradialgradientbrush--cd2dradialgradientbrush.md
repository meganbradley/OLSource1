---
title: "CD2DRadialGradientBrush::CD2DRadialGradientBrush"
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
  - "afxrendertarget/CD2DRadialGradientBrush::CD2DRadialGradientBrush"
  - "CD2DRadialGradientBrush"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DRadialGradientBrush class, constructor"
ms.assetid: 340e76d8-5d58-411e-bfe2-33e654992e2e
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DRadialGradientBrush::CD2DRadialGradientBrush
Constructs a CD2DLinearGradientBrush object.  
  
## Syntax  
  
```  
CD2DRadialGradientBrush(  
   CRenderTarget* pParentTarget,  
   const D2D1_GRADIENT_STOP* gradientStops,  
   UINT gradientStopsCount,  
   D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES RadialGradientBrushProperties,  
   D2D1_GAMMA colorInterpolationGamma = D2D1_GAMMA_2_2,  
   D2D1_EXTEND_MODE extendMode = D2D1_EXTEND_MODE_CLAMP,  
   CD2DBrushProperties* pBrushProperties = NULL,  
   BOOL bAutoDestroy = TRUE  
);  
```  
  
#### Parameters  
 `pParentTarget`  
 A pointer to the render target.  
  
 `gradientStops`  
 A pointer to an array of D2D1_GRADIENT_STOP structures.  
  
 `gradientStopsCount`  
 A value greater than or equal to 1 that specifies the number of gradient stops in the gradientStops array.  
  
 `RadialGradientBrushProperties`  
 The center, gradient origin offset, and x-radius and y-radius of the brush's gradient.  
  
 `colorInterpolationGamma`  
 The space in which color interpolation between the gradient stops is performed.  
  
 `extendMode`  
 The behavior of the gradient outside the [0,1] normalized range.  
  
 `pBrushProperties`  
 A pointer to the opacity and transformation of a brush.  
  
 `bAutoDestroy`  
 Indicates that the object will be destroyed by owner (pParentTarget).  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DRadialGradientBrush Class](../vs140/cd2dradialgradientbrush-class.md)