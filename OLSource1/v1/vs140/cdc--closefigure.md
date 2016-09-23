---
title: "CDC::CloseFigure"
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
  - CDC.CloseFigure
  - CDC::CloseFigure
  - CloseFigure
dev_langs: 
  - C++
helpviewer_keywords: 
  - CloseFigure method
  - CDC class, path functions
ms.assetid: 1fd77b2a-5bd5-4860-8ff7-272020bd0dd9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::CloseFigure
Closes an open figure in a path.  
  
## Syntax  
  
```  
  
BOOL CloseFigure( );  
```  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The function closes the figure by drawing a line from the current position to the first point of the figure (usually, the point specified by the most recent call to the `MoveTo` member function) and connects the lines by using the line join style. If a figure is closed by using the `LineTo` member function instead of `CloseFigure`, end caps are used to create the corner instead of a join. `CloseFigure` should only be called if there is an open path bracket in the device context.  
  
 A figure in a path is open unless it is explicitly closed by using this function. (A figure can be open even if the current point and the starting point of the figure are the same.) Any line or curve added to the path after `CloseFigure` starts a new figure.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::BeginPath](../vs140/cdc--beginpath.md)   
 [CDC::EndPath](../vs140/cdc--endpath.md)   
 [CDC::MoveTo](../vs140/cdc--moveto.md)   
 [CloseFigure](http://msdn.microsoft.com/library/windows/desktop/dd183443)