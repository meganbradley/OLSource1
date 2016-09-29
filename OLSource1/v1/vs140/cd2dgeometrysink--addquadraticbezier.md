---
title: "CD2DGeometrySink::AddQuadraticBezier"
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
  - "afxrendertarget/CD2DGeometrySink::AddQuadraticBezier"
  - "AddQuadraticBezier"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddQuadraticBezier method"
ms.assetid: 98ecdd6b-ac4a-45b2-a5cd-ce8e29b9c9aa
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DGeometrySink::AddQuadraticBezier
Creates a quadratic Bezier curve between the current point and the specified end point.  
  
## Syntax  
  
```  
void AddQuadraticBezier(  
   const D2D1_QUADRATIC_BEZIER_SEGMENT& bezier  
);  
```  
  
#### Parameters  
 `bezier`  
 A structure that describes the control point and the end point of the quadratic Bezier curve to add.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DGeometrySink Class](../vs140/cd2dgeometrysink-class.md)