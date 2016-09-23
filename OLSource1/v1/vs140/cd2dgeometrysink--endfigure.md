---
title: "CD2DGeometrySink::EndFigure"
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
  - afxrendertarget/CD2DGeometrySink::EndFigure
  - EndFigure
dev_langs: 
  - C++
helpviewer_keywords: 
  - EndFigure method
ms.assetid: 2c2d7190-e7a4-4069-a34a-1cd6b21c24be
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CD2DGeometrySink::EndFigure
Ends the current figure; optionally, closes it.  
  
## Syntax  
  
```  
void EndFigure(  
   D2D1_FIGURE_END figureEnd  
);  
```  
  
#### Parameters  
 `figureEnd`  
 A value that indicates whether the current figure is closed. If the figure is closed, a line is drawn between the current point and the start point specified by BeginFigure.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DGeometrySink Class](../vs140/cd2dgeometrysink-class.md)