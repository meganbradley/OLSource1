---
title: "CD2DGeometry::CompareWithGeometry"
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
  - CompareWithGeometry
  - afxrendertarget/CD2DGeometry::CompareWithGeometry
dev_langs: 
  - C++
helpviewer_keywords: 
  - CompareWithGeometry method
ms.assetid: 7ce9b5b3-b36b-4b2a-8c04-7bb9e231410a
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CD2DGeometry::CompareWithGeometry
Describes the intersection between this geometry and the specified geometry. The comparison is performed using the specified flattening tolerance.  
  
## Syntax  
  
```  
D2D1_GEOMETRY_RELATION CompareWithGeometry(  
   CD2DGeometry& inputGeometry,  
   const D2D1_MATRIX_3X2_F& inputGeometryTransform,  
   FLOAT flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE  
) const;  
```  
  
#### Parameters  
 `inputGeometry`  
 The geometry to test.  
  
 `inputGeometryTransform`  
 The transform to apply to inputGeometry.  
  
 `flatteningTolerance`  
 The maximum bounds on the distance between points in the polygonal approximation of the geometries. Smaller values produce more accurate results but cause slower execution.  
  
## Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DGeometry Class](../vs140/cd2dgeometry-class.md)