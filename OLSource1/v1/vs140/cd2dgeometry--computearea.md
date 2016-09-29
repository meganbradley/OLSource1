---
title: "CD2DGeometry::ComputeArea"
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
  - "ComputeArea"
  - "afxrendertarget/CD2DGeometry::ComputeArea"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ComputeArea method"
ms.assetid: 6f4577d9-eb45-4cd0-a9a2-49f2ac611611
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DGeometry::ComputeArea
Computes the area of the geometry after it has been transformed by the specified matrix and flattened using the specified tolerance.  
  
## Syntax  
  
```  
BOOL ComputeArea(  
   const D2D1_MATRIX_3X2_F& worldTransform,  
   FLOAT& area,  
   FLOAT flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE  
) const;  
```  
  
#### Parameters  
 `worldTransform`  
 The transform to apply to this geometry before computing its area.  
  
 `area`  
 When this method returns, contains a pointer to the area of the transformed, flattened version of this geometry. You must allocate storage for this parameter.  
  
 `flatteningTolerance`  
 The maximum bounds on the distance between points in the polygonal approximation of the geometry. Smaller values produce more accurate results but cause slower execution.  
  
## Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DGeometry Class](../vs140/cd2dgeometry-class.md)