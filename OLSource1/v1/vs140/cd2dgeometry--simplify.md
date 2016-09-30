---
title: "CD2DGeometry::Simplify"
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
  - "afxrendertarget/CD2DGeometry::Simplify"
  - "Simplify"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Simplify method"
ms.assetid: 8cd2a0fa-c1a1-44cd-adb8-7396e0db1851
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DGeometry::Simplify
Creates a simplified version of the geometry that contains only lines and (optionally) cubic Bezier curves and writes the result to an ID2D1SimplifiedGeometrySink.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A value that specifies whether the simplified geometry should contain curves.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The transform to apply to the simplified geometry.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The ID2D1SimplifiedGeometrySink to which the simplified geometry is appended.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The maximum bounds on the distance between points in the polygonal approximation of the geometry. Smaller values produce more accurate results but cause slower execution.  
  
## Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DGeometry Class](../vs140/cd2dgeometry-class.md)