---
title: "CPoint::operator -"
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
  - "CPoint::operator-"
  - "CPoint.operator-"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CPoint class, operators returning CPoint values"
  - "- operator, difference between two points"
ms.assetid: 9eeea929-34fe-4f30-8640-a78aa729ea74
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPoint::operator -
Use one of the first two overloads to subtract a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A [POINT](../vs140/point-structure.md) structure or [CPoint](../vs140/cpoint-class.md) object.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or [CSize](../vs140/csize-class.md) object.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A pointer to a [RECT](../vs140/rect-structure.md) structure or a [CRect](../vs140/crect-class.md) object.  
  
## Return Value  
 A <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> that is the difference between two points, a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> that is offset by the negation of a size, a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> that is offset by the negation of a point, or a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> that is the negation of a point.  
  
## Remarks  
 The third overload offsets a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> by the negation of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. Finally, use the unary operator to negate <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 For example, using the first overload to find the difference between two points <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 Subtracting a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> from <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> does the same calculation as above but returns a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object, not a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object. For example, using the second overload to find the difference between the point <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and the size <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
 Subtracting a rectangle from a point returns the rectangle offset by the negatives of the **x** and **y** values specified in the point. For example, using the last overload to offset the rectangle <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> by the point <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
 Use the unary operator to negate a point. For example, using the unary operator with the point <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#34](../vs140/codesnippet/CPP/cpoint--operator--_1.cpp)]  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CPoint Class](../vs140/cpoint-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPoint::operator -=](../vs140/cpoint--operator--=.md)   
 [CPoint::operator +=](../vs140/cpoint--operator--=.md)   
 [CPoint::operator +](../vs140/cpoint--operator--.md)   
 [CSize::operator -](../vs140/csize--operator--.md)   
 [CRect::operator -](../vs140/crect--operator--.md)   
 [CPoint::Offset](../vs140/cpoint--offset.md)   
 [CRect::OffsetRect](../vs140/crect--offsetrect.md)