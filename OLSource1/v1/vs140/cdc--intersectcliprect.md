---
title: "CDC::IntersectClipRect"
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
  - "CDC::IntersectClipRect"
  - "IntersectClipRect"
  - "CDC.IntersectClipRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, clipping functions"
  - "IntersectClipRect method"
ms.assetid: 157e2969-e7e7-4eec-a63d-c0220ab48dfa
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::IntersectClipRect
Creates a new clipping region by forming the intersection of the current region and the rectangle specified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the logical x-coordinate of the upper-left corner of the rectangle.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the logical y-coordinate of the upper-left corner of the rectangle.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies the logical x-coordinate of the lower-right corner of the rectangle.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Specifies the logical y-coordinate of the lower-right corner of the rectangle.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Specifies the rectangle. You can pass either a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object or a pointer to a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> structure for this parameter.  
  
## Return Value  
 The new clipping region's type. It can be any one of the following values:  
  
-   **COMPLEXREGION** New clipping region has overlapping borders.  
  
-   **ERROR** Device context is not valid.  
  
-   **NULLREGION** New clipping region is empty.  
  
-   **SIMPLEREGION** New clipping region has no overlapping borders.  
  
## Remarks  
 GDI clips all subsequent output to fit within the new boundary. The width and height must not exceed 32,767.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [IntersectClipRect](http://msdn.microsoft.com/library/windows/desktop/dd144998)   
 [CRect Class](../vs140/crect-class.md)   
 [RECT Structure](../vs140/rect-structure.md)