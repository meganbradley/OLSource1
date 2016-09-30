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
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DGeometry::CombineWithGeometry
Combines this geometry with the specified geometry and stores the result in an ID2D1SimplifiedGeometrySink.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The geometry to combine with this instance.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type of combine operation to perform.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The transform to apply to inputGeometry before combining.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The result of the combine operation.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The maximum bounds on the distance between points in the polygonal approximation of the geometries. Smaller values produce more accurate results but cause slower execution.  
  
## Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DGeometry Class](../vs140/cd2dgeometry-class.md)