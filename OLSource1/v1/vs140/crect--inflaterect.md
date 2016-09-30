---
title: "CRect::InflateRect"
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
  - "InflateRect"
  - "CRect.InflateRect"
  - "CRect::InflateRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRect class, operations"
  - "InflateRect method"
ms.assetid: fdc656b0-5907-45d8-88ea-9553be7533c7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRect::InflateRect
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder> inflates <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> by moving its sides away from its center.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *x*  
 Specifies the number of units to inflate the left and right sides of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 *y*  
 Specifies the number of units to inflate the top and bottom of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) or [CSize](../vs140/csize-class.md) that specifies the number of units to inflate <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> value specifies the number of units to inflate the left and right sides and the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> value specifies the number of units to inflate the top and bottom.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Points to a [RECT](../vs140/rect-structure.md) structure or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> that specifies the number of units to inflate each side.  
  
 *l*  
 Specifies the number of units to inflate the left side of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 *t*  
 Specifies the number of units to inflate the top of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 *r*  
 Specifies the number of units to inflate the right side of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 *b*  
 Specifies the number of units to inflate the bottom of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
## Remarks  
 To do this, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> subtracts units from the left and top and adds units to the right and bottom. The parameters of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> are signed values; positive values inflate <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and negative values deflate it.  
  
 The first two overloads inflate both pairs of opposite sides of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> so that its total width is increased by two times *x* (or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>) and its total height is increased by two times *y* (or <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>). The other two overloads inflate each side of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> independently of the others.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#42](../vs140/codesnippet/CPP/crect--inflaterect_1.cpp)]  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CRect Class](../vs140/crect-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRect::DeflateRect](../vs140/crect--deflaterect.md)   
 [CRect::operator +](../vs140/crect--operator--.md)   
 [CRect::operator +=](../vs140/crect--operator--=.md)   
 [InflateRect](http://msdn.microsoft.com/library/windows/desktop/dd144994)