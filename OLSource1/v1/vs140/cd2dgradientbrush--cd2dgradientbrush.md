---
title: "CD2DGradientBrush::CD2DGradientBrush"
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
  - "CD2DGradientBrush"
  - "afxrendertarget/CD2DGradientBrush::CD2DGradientBrush"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DGradientBrush class, constructor"
ms.assetid: fc0add8d-71b8-48ef-a107-f7a3fcc047dc
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DGradientBrush::CD2DGradientBrush
Constructs a CD2DGradientBrush object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the render target.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to an array of D2D1_GRADIENT_STOP structures.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A value greater than or equal to 1 that specifies the number of gradient stops in the gradientStops array.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The space in which color interpolation between the gradient stops is performed.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The behavior of the gradient outside the [0,1] normalized range.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A pointer to the opacity and transformation of a brush.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Indicates that the object will be destroyed by owner (pParentTarget).  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DGradientBrush Class](../vs140/cd2dgradientbrush-class.md)