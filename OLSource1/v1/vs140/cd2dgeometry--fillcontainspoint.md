---
title: "CD2DGeometry::FillContainsPoint"
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
  - "afxrendertarget/CD2DGeometry::FillContainsPoint"
  - "FillContainsPoint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FillContainsPoint method"
ms.assetid: fbd3e8f5-5732-4a8b-9f5e-80e76ce0312a
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DGeometry::FillContainsPoint
Indicates whether the area filled by the geometry would contain the specified point given the specified flattening tolerance.  
  
## Syntax  
  
```  
BOOL FillContainsPoint(  
   CD2DPointF point,  
   const D2D1_MATRIX_3X2_F& worldTransform,  
   BOOL* contains,  
   FLOAT flatteningTolerance = D2D1_DEFAULT_FLATTENING_TOLERANCE  
) const;  
```  
  
#### Parameters  
 `point`  
 The point to test.  
  
 `worldTransform`  
 The transform to apply to the geometry prior to testing for containment.  
  
 `contains`  
 When this method returns, contains a bool value that is TRUE if the area filled by the geometry contains point; otherwise, FALSE. You must allocate storage for this parameter.  
  
 `flatteningTolerance`  
 The numeric accuracy with which the precise geometric path and path intersection is calculated. Points missing the fill by less than the tolerance are still considered inside. Smaller values produce more accurate results but cause slower execution.  
  
## Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DGeometry Class](../vs140/cd2dgeometry-class.md)