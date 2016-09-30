---
title: "CRect::EqualRect"
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
  - "EqualRect"
  - "CRect::EqualRect"
  - "CRect.EqualRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRect class, operations"
  - "EqualRect method"
ms.assetid: f662ea04-e284-4d9a-9c43-83d27886376d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRect::EqualRect
Determines whether <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is equal to the given rectangle.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Points to a [RECT](../vs140/rect-structure.md) structure or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object that contains the upper-left and lower-right corner coordinates of a rectangle.  
  
## Return Value  
 Nonzero if the two rectangles have the same top, left, bottom, and right values; otherwise 0.  
  
> [!NOTE]
>  Both of the rectangles must be normalized or this function may fail. You can call [NormalizeRect](../vs140/crect--normalizerect.md) to normalize the rectangles before calling this function.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#40](../vs140/codesnippet/CPP/crect--equalrect_1.cpp)]  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CRect Class](../vs140/crect-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRect::operator ==](../vs140/crect--operator-==.md)   
 [CRect::operator !=](../vs140/crect--operator-!=.md)   
 [CRect::NormalizeRect](../vs140/crect--normalizerect.md)   
 [EqualRect](http://msdn.microsoft.com/library/windows/desktop/dd162699)