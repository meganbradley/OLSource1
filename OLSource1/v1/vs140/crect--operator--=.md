---
title: "CRect::operator +="
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
  - "CRect.operator+="
  - "CRect::operator+="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator +=, rectangles"
  - "+= operator, moving objects"
  - "operator+=, rectangles"
  - "CRect class, operators"
ms.assetid: 2ab28143-d50f-46d2-992a-ca4c7180c43c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRect::operator +=
The first two overloads move <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> by the specified offsets.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A [POINT](../vs140/point-structure.md) structure or [CPoint](../vs140/cpoint-class.md) object that specifies the number of units to move the rectangle.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or [CSize](../vs140/csize-class.md) object that specifies the number of units to move the rectangle.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Points to a [RECT](../vs140/rect-structure.md) structure or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object that contains the number of units to inflate each side of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 The parameter's *x* and *y* (or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) values are added to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 The third overload inflates <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> by the number of units specifed in each member of the parameter.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#62](../vs140/codesnippet/CPP/crect--operator--=_1.cpp)]  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CRect Class](../vs140/crect-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRect::OffsetRect](../vs140/crect--offsetrect.md)   
 [CRect::InflateRect](../vs140/crect--inflaterect.md)   
 [CRect::operator +](../vs140/crect--operator--.md)   
 [CRect::operator -=](../vs140/crect--operator--=.md)