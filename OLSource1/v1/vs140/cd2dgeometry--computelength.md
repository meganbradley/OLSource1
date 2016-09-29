---
title: "CD2DGeometry::ComputeLength"
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
  - "afxrendertarget/CD2DGeometry::ComputeLength"
  - "ComputeLength"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ComputeLength method"
ms.assetid: 792fcc28-3557-49fa-93ec-f236c77ad5e5
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DGeometry::ComputeLength
Calculates the length of the geometry as though each segment were unrolled into a line.  
  
## Syntax  
  
```  
BOOL ComputeLength(  
   const D2D1_MATRIX_3X2_F& worldTransform,  
   FLOAT& length,  
   FLOAT flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE  
) const;  
```  
  
#### Parameters  
 `worldTransform`  
 The transform to apply to the geometry before calculating its length.  
  
 `length`  
 When this method returns, contains a pointer to the length of the geometry. For closed geometries, the length includes an implicit closing segment. You must allocate storage for this parameter.  
  
 `flatteningTolerance`  
 The maximum bounds on the distance between points in the polygonal approximation of the geometry. Smaller values produce more accurate results but cause slower execution.  
  
## Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DGeometry Class](../vs140/cd2dgeometry-class.md)