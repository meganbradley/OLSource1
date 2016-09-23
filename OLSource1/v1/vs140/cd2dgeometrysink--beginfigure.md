---
title: "CD2DGeometrySink::BeginFigure"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - afxrendertarget/CD2DGeometrySink::BeginFigure
  - BeginFigure
dev_langs: 
  - C++
helpviewer_keywords: 
  - BeginFigure method
ms.assetid: f2cb19d5-2ec4-4a9e-9a52-3960fd6ecf78
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CD2DGeometrySink::BeginFigure
Starts a new figure at the specified point.  
  
## Syntax  
  
```  
void BeginFigure(  
   CD2DPointF startPoint,  
   D2D1_FIGURE_BEGIN figureBegin  
);  
```  
  
#### Parameters  
 `startPoint`  
 The point at which to begin the new figure.  
  
 `figureBegin`  
 Whether the new figure should be hollow or filled.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DGeometrySink Class](../vs140/cd2dgeometrysink-class.md)