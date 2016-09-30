---
title: "CD2DGeometry::StrokeContainsPoint"
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
  - "afxrendertarget/CD2DGeometry::StrokeContainsPoint"
  - "StrokeContainsPoint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "StrokeContainsPoint method"
ms.assetid: 18f3c347-3e38-480c-84a2-733867b48f6a
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DGeometry::StrokeContainsPoint
Determines whether the geometry's stroke contains the specified point given the specified stroke thickness, style, and transform.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The point to test for containment.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The thickness of the stroke to apply.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The style of the stroke to apply.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The transform to apply to the stroked geometry.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 When this method returns, contains a boolean value set to TRUE if the geometry's stroke contains the specified point; otherwise, FALSE. You must allocate storage for this parameter.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The numeric accuracy with which the precise geometric path and path intersection is calculated. Points missing the stroke by less than the tolerance are still considered inside. Smaller values produce more accurate results but cause slower execution.  
  
## Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DGeometry Class](../vs140/cd2dgeometry-class.md)