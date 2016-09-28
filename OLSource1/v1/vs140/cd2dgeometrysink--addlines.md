---
title: "CD2DGeometrySink::AddLines"
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
  - "afxrendertarget/CD2DGeometrySink::AddLines"
  - "AddLines"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddLines method"
ms.assetid: 576aa108-ed5c-46a2-854c-5c8c528d6bde
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DGeometrySink::AddLines
Creates a sequence of lines using the specified points and adds them to the geometry sink.  
  
## Syntax  
  
```  
void AddLines(  
   const CArray<CD2DPointF,  
   CD2DPointF>& points  
);  
```  
  
#### Parameters  
 `points`  
 An array of one or more points that describe the lines to draw. A line is drawn from the geometry sink's current point (the end point of the last segment drawn or the location specified by BeginFigure) to the first point in the array. if the array contains additional points, a line is drawn from the first point to the second point in the array, from the second point to the third point, and so on. An array of a sequence of the end points of the lines to draw.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DGeometrySink Class](../vs140/cd2dgeometrysink-class.md)