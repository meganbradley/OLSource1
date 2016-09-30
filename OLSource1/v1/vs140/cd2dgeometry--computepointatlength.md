---
title: "CD2DGeometry::ComputePointAtLength"
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
  - "ComputePointAtLength"
  - "afxrendertarget/CD2DGeometry::ComputePointAtLength"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ComputePointAtLength method"
ms.assetid: 37994c4b-a152-429f-90bd-45e202b032c4
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DGeometry::ComputePointAtLength
Calculates the point and tangent vector at the specified distance along the geometry after it has been transformed by the specified matrix and flattened using the specified tolerance.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The distance along the geometry of the point and tangent to find. If this distance is less then 0, this method calculates the first point in the geometry. If this distance is greater than the length of the geometry, this method calculates the last point in the geometry.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The transform to apply to the geometry before calculating the specified point and tangent.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The location at the specified distance along the geometry. If the geometry is empty, this point contains NaN as its x and y values.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 When this method returns, contains a pointer to the tangent vector at the specified distance along the geometry. If the geometry is empty, this vector contains NaN as its x and y values. You must allocate storage for this parameter.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The maximum bounds on the distance between points in the polygonal approximation of the geometry. Smaller values produce more accurate results but cause slower execution.  
  
## Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DGeometry Class](../vs140/cd2dgeometry-class.md)