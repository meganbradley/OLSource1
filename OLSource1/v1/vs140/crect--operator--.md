---
title: "CRect::operator +"
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
  - "CRect.operator+"
  - "CRect::operator+"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "+ operator, with specific objects"
  - "CRect class, operators"
ms.assetid: 215ee000-bd0a-487e-a004-2daa46d5bfdd
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRect::operator +
The first two overloads return a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object that is equal to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> displaced by the specified offsets.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A [POINT](../vs140/point-structure.md) structure or [CPoint](../vs140/cpoint-class.md) object that specifies the number of units to move the return value.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or [CSize](../vs140/csize-class.md) object that specifies the number of units to move the return value.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Points to a [RECT](../vs140/rect-structure.md) structure or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object that contains the number of units to inflate each side of the return value.  
  
## Return Value  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> resulting from moving or inflating <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> by the number of units specified in the parameter.  
  
## Remarks  
 The parameter's *x* and *y* (or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) parameters are added to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>'s position.  
  
 The third overload returns a new <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> that is equal to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> inflated by the number of units specifed in each member of the parameter.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#65](../vs140/codesnippet/CPP/crect--operator--_1.cpp)]  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CRect Class](../vs140/crect-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRect::operator +=](../vs140/crect--operator--=.md)   
 [CRect::operator -](../vs140/crect--operator--.md)   
 [CRect::OffsetRect](../vs140/crect--offsetrect.md)   
 [CRect::InflateRect](../vs140/crect--inflaterect.md)