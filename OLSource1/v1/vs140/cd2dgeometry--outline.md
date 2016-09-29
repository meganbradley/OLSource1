---
title: "CD2DGeometry::Outline"
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
  - "Outline"
  - "afxrendertarget/CD2DGeometry::Outline"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Outline method"
ms.assetid: d731d8c7-4240-4029-88e5-6da8a1f4c8a2
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DGeometry::Outline
Computes the outline of the geometry and writes the result to an ID2D1SimplifiedGeometrySink.  
  
## Syntax  
  
```  
BOOL Outline(  
   const D2D1_MATRIX_3X2_F& worldTransform,  
   ID2D1SimplifiedGeometrySink* geometrySink,  
   FLOAT flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE  
) const;  
```  
  
#### Parameters  
 `worldTransform`  
 The transform to apply to the geometry outline.  
  
 `geometrySink`  
 The ID2D1SimplifiedGeometrySink to which the geometry transformed outline is appended.  
  
 `flatteningTolerance`  
 The maximum bounds on the distance between points in the polygonal approximation of the geometry. Smaller values produce more accurate results but cause slower execution.  
  
## Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DGeometry Class](../vs140/cd2dgeometry-class.md)