---
title: "CD2DGeometry::Tessellate"
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
  - "Tessellate"
  - "afxrendertarget/CD2DGeometry::Tessellate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Tessellate method"
ms.assetid: d7703793-0b87-4349-8346-48cca75dc287
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DGeometry::Tessellate
Creates a set of clockwise-wound triangles that cover the geometry after it has been transformed using the specified matrix and flattened using the specified tolerance.  
  
## Syntax  
  
```  
BOOL Tessellate(  
   const D2D1_MATRIX_3X2_F& worldTransform,  
   ID2D1TessellationSink* tessellationSink,  
   FLOAT flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE  
) const;  
```  
  
#### Parameters  
 `worldTransform`  
 The transform to apply to this geometry, or NULL.  
  
 `tessellationSink`  
 The ID2D1TessellationSink to which the tessellated is appended.  
  
 `flatteningTolerance`  
 The maximum bounds on the distance between points in the polygonal approximation of the geometry. Smaller values produce more accurate results but cause slower execution.  
  
## Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DGeometry Class](../vs140/cd2dgeometry-class.md)