---
title: "CDC::StrokeAndFillPath"
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
  - "StrokeAndFillPath"
  - "CDC.StrokeAndFillPath"
  - "CDC::StrokeAndFillPath"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "StrokeAndFillPath method"
  - "CDC class, path functions"
ms.assetid: 581e12ed-4ebc-42cd-9682-55260778ef19
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::StrokeAndFillPath
Closes any open figures in a path, strokes the outline of the path by using the current pen, and fills its interior by using the current brush.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The device context must contain a closed path. The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function has the same effect as closing all the open figures in the path, and stroking and filling the path separately, except that the filled region will not overlap the stroked region even if the pen is wide.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::BeginPath](../vs140/cdc--beginpath.md)   
 [CDC::FillPath](../vs140/cdc--fillpath.md)   
 [CDC::SetPolyFillMode](../vs140/cdc--setpolyfillmode.md)   
 [CDC::StrokePath](../vs140/cdc--strokepath.md)   
 [StrokeAndFillPath](http://msdn.microsoft.com/library/windows/desktop/dd145123)