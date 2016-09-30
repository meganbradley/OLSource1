---
title: "CDC::FrameRgn"
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
  - "CDC.FrameRgn"
  - "CDC::FrameRgn"
  - "FrameRgn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, region functions"
  - "FrameRgn method"
ms.assetid: 994d2c49-67f3-4674-b72c-1907b920b567
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::FrameRgn
Draws a border around the region specified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> using the brush specified by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object that identifies the region to be enclosed in a border. The coordinates for the given region are specified in logical units.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Points to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object that identifies the brush to be used to draw the border.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies the width of the border in vertical brush strokes in device units.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Specifies the height of the border in horizontal brush strokes in device units.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Example  
 See the example for [CRgn::CombineRgn](../vs140/crgn--combinergn.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::Rectangle](../vs140/cdc--rectangle.md)   
 [CDC::FrameRect](../vs140/cdc--framerect.md)   
 [CBrush Class](../vs140/cbrush-class.md)   
 [CRgn Class](../vs140/crgn-class.md)   
 [FrameRgn](http://msdn.microsoft.com/library/windows/desktop/dd144839)