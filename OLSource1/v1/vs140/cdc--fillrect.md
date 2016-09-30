---
title: "CDC::FillRect"
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
  - "CDC.FillRect"
  - "CDC::FillRect"
  - "FillRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FillRect method"
  - "CDC class, simple drawing functions"
ms.assetid: 4012ec08-2713-4806-ad30-31c36ab589ac
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::FillRect
Call this member function to fill a given rectangle using the specified brush.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to a [RECT](../vs140/rect-structure.md) structure that contains the logical coordinates of the rectangle to be filled. You can also pass a [CRect](../vs140/crect-class.md) object for this parameter.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Identifies the brush used to fill the rectangle.  
  
## Remarks  
 The function fills the complete rectangle, including the left and top borders, but it does not fill the right and bottom borders.  
  
 The brush needs to either be created using the [CBrush](../vs140/cbrush-class.md) member functions [CreateHatchBrush](../vs140/cbrush--createhatchbrush.md), [CreatePatternBrush](../vs140/cbrush--createpatternbrush.md), and [CreateSolidBrush](../vs140/cbrush--createsolidbrush.md), or retrieved by the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> Windows function.  
  
 When filling the specified rectangle, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> does not include the rectangle's right and bottom sides. GDI fills a rectangle up to, but does not include, the right column and bottom row, regardless of the current mapping mode. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> compares the values of the **top**, **bottom**, **left**, and **right** members of the specified rectangle. If **bottom** is less than or equal to **top**, or if **right** is less than or equal to **left**, the rectangle is not drawn.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is similar to [CDC::FillSolidRect](../vs140/cdc--fillsolidrect.md); however, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> takes a brush and therefore can be used to fill a rectangle with a solid color, a dithered color, hatched brushes, or a pattern. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> uses only solid colors (indicated by a **COLORREF** parameter). <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> usually is slower than <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBrush::CreateHatchBrush](../vs140/cbrush--createhatchbrush.md)   
 [CBrush::CreatePatternBrush](../vs140/cbrush--createpatternbrush.md)   
 [CBrush::CreateSolidBrush](../vs140/cbrush--createsolidbrush.md)   
 [FillRect](http://msdn.microsoft.com/library/windows/desktop/dd162719)   
 [RECT Structure](../vs140/rect-structure.md)   
 [CBrush Class](../vs140/cbrush-class.md)   
 [CDC::FillSolidRect](../vs140/cdc--fillsolidrect.md)