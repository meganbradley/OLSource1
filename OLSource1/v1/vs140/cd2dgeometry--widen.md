---
title: "CD2DGeometry::Widen"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - Widen
  - afxrendertarget/CD2DGeometry::Widen
dev_langs: 
  - C++
helpviewer_keywords: 
  - Widen method
ms.assetid: 5f7d577a-4e35-452e-9f6f-47ab0d3cb640
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CD2DGeometry::Widen
Widens the geometry by the specified stroke and writes the result to an ID2D1SimplifiedGeometrySink after it has been transformed by the specified matrix and flattened using the specified tolerance.  
  
## Syntax  
  
```  
BOOL Widen(  
   FLOAT strokeWidth,  
   ID2D1StrokeStyle* strokeStyle,  
   const D2D1_MATRIX_3X2_F& worldTransform,  
   ID2D1SimplifiedGeometrySink* geometrySink,  
   FLOAT flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE  
) const;  
```  
  
#### Parameters  
 `strokeWidth`  
 The amount by which to widen the geometry.  
  
 `strokeStyle`  
 The style of stroke to apply to the geometry, or NULL.  
  
 `worldTransform`  
 The transform to apply to the geometry after widening it.  
  
 `geometrySink`  
 The ID2D1SimplifiedGeometrySink to which the widened geometry is appended.  
  
 `flatteningTolerance`  
 The maximum bounds on the distance between points in the polygonal approximation of the geometry. Smaller values produce more accurate results but cause slower execution.  
  
## Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DGeometry Class](../vs140/cd2dgeometry-class.md)