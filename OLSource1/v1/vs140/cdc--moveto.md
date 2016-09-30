---
title: "CDC::MoveTo"
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
  - "CDC.MoveTo"
  - "CDC::MoveTo"
  - "MoveTo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MoveTo method"
  - "CDC class, line-output functions"
ms.assetid: 3fe1531e-2d59-4c11-b25f-4cea279e73d0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::MoveTo
Moves the current position to the point specified by *x* and *y* (or by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *x*  
 Specifies the logical x-coordinate of the new position.  
  
 *y*  
 Specifies the logical y-coordinate of the new position.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the new position. You can pass either a **POINT** structure or a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object for this parameter.  
  
## Return Value  
 The x- and y-coordinates of the previous position as a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
## Example  
 See the example for [CRect::CenterPoint](../vs140/crect--centerpoint.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetCurrentPosition](../vs140/cdc--getcurrentposition.md)   
 [CDC::LineTo](../vs140/cdc--lineto.md)   
 [CPoint Class](../vs140/cpoint-class.md)   
 [POINT Structure](../vs140/point-structure.md)