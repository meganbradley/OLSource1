---
title: "CD2DLinearGradientBrush::CD2DLinearGradientBrush"
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
  - "CD2DLinearGradientBrush"
  - "afxrendertarget/CD2DLinearGradientBrush::CD2DLinearGradientBrush"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DLinearGradientBrush class, constructor"
ms.assetid: d985c0e3-144a-46cf-8c60-0abf9b3a05db
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DLinearGradientBrush::CD2DLinearGradientBrush
Constructs a CD2DLinearGradientBrush object.  
  
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
 The start and end points of the gradient.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The space in which color interpolation between the gradient stops is performed.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The behavior of the gradient outside the [0,1] normalized range.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A pointer to the opacity and transformation of a brush.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Indicates that the object will be destroyed by owner (pParentTarget).  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DLinearGradientBrush Class](../vs140/cd2dlineargradientbrush-class.md)