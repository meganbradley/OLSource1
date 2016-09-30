---
title: "CDC::FillSolidRect"
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
  - "CDC.FillSolidRect"
  - "CDC::FillSolidRect"
  - "FillSolidRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, simple drawing functions"
  - "FillSolidRect method"
ms.assetid: 51aa0f73-bca4-4555-af74-2741304c3978
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::FillSolidRect
Call this member function to fill the given rectangle with the specified solid color.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the bounding rectangle (in logical units). You can pass either a pointer to a [RECT](../vs140/rect-structure.md) data structure or a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object for this parameter.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> Specifies the color to be used to fill the rectangle.  
  
 *x*  
 Specifies the logical x-coordinate of the upper-left corner of the rectangle.  
  
 *y*  
 Specifies the logical y-coordinate of the upper-left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the width of the rectangle.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the height of the rectangle.  
  
## Remarks  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is very similar to [CDC::FillRect](../vs140/cdc--fillrect.md); however, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> uses only solid colors (indicated by the **COLORREF** parameter), while <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> takes a brush and therefore can be used to fill a rectangle with a solid color, a dithered color, hatched brushes, or a pattern. <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> usually is faster than <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  When you call <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, the background color, which was previously set using [SetBkColor](../vs140/cdc--setbkcolor.md), is set to the color indicated by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [RECT Structure](../vs140/rect-structure.md)   
 [CRect Class](../vs140/crect-class.md)   
 [CDC::FillRect](../vs140/cdc--fillrect.md)