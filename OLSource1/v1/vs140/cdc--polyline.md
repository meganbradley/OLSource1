---
title: "CDC::Polyline"
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
  - "CDC::Polyline"
  - "CDC.Polyline"
  - "Polyline"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Polyline method"
  - "CDC class, line-output functions"
ms.assetid: afb30642-057a-46ef-b7df-61a4397be3b0
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::Polyline
Draws a set of line segments connecting the points specified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to an array of **POINT** structures or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> objects to be connected.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the number of points in the array. This value must be at least 2.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The lines are drawn from the first point through subsequent points using the current pen. Unlike the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> member function, the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> function neither uses nor updates the current position.  
  
 For more information, see [PolyLine](http://msdn.microsoft.com/library/windows/desktop/dd162815) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::LineTo](../vs140/cdc--lineto.md)   
 [CDC::Polygon](../vs140/cdc--polygon.md)   
 [POINT Structure](../vs140/point-structure.md)   
 [CPoint Class](../vs140/cpoint-class.md)