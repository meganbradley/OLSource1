---
title: "CD2DGeometry::CombineWithGeometry"
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
  - "CombineWithGeometry"
  - "afxrendertarget/CD2DGeometry::CombineWithGeometry"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CombineWithGeometry method"
ms.assetid: c87ecffc-bd15-4fc3-bee7-e415a006ee8e
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DGeometry::CombineWithGeometry
Combines this geometry with the specified geometry and stores the result in an ID2D1SimplifiedGeometrySink.  
  
## Syntax  
  
```  
BOOL CombineWithGeometry(  
   CD2DGeometry& inputGeometry,  
   D2D1_COMBINE_MODE combineMode,  
   const D2D1_MATRIX_3X2_F& inputGeometryTransform,  
   ID2D1SimplifiedGeometrySink* geometrySink,  
   FLOAT flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE  
) const;  
```  
  
#### Parameters  
 `inputGeometry`  
 The geometry to combine with this instance.  
  
 `combineMode`  
 The type of combine operation to perform.  
  
 `inputGeometryTransform`  
 The transform to apply to inputGeometry before combining.  
  
 `geometrySink`  
 The result of the combine operation.  
  
 `flatteningTolerance`  
 The maximum bounds on the distance between points in the polygonal approximation of the geometries. Smaller values produce more accurate results but cause slower execution.  
  
## Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DGeometry Class](../vs140/cd2dgeometry-class.md)