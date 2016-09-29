---
title: "CD2DGeometrySink::AddBezier"
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
  - "afxrendertarget/CD2DGeometrySink::AddBezier"
  - "AddBezier"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddBezier method"
ms.assetid: 4bd67cb2-6dd6-4e3f-a3cb-33dd72b11c36
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DGeometrySink::AddBezier
Creates a cubic Bezier curve between the current point and the specified end point.  
  
## Syntax  
  
```  
void AddBezier(  
   const D2D1_BEZIER_SEGMENT& bezier  
);  
```  
  
#### Parameters  
 `bezier`  
 A structure that describes the control points and end point of the Bezier curve to add.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DGeometrySink Class](../vs140/cd2dgeometrysink-class.md)