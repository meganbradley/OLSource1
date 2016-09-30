---
title: "CRect::CRect"
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
  - "CRect.CRect"
  - "CRect::CRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRect class, construction/destruction"
  - "CRect class, constructor"
ms.assetid: f8244ffe-d418-4ea2-a33b-7260759a88b1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRect::CRect
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *l*  
 Specifies the left position of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 *t*  
 Specifies the top of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 *r*  
 Specifies the right position of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 *b*  
 Specifies the bottom of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 *srcRect*  
 Refers to the [RECT](../vs140/rect-structure.md) structure with the coordinates for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Points to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> structure with the coordinates for <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Specifies the origin point for the rectangle to be constructed. Corresponds to the top-left corner.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Specifies the displacement from the top-left corner to the bottom-right corner of the rectangle to be constructed.  
  
 *topLeft*  
 Specifies the top-left position of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 *bottomRight*  
 Specifies the bottom-right position of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Remarks  
 If no arguments are given, **left**, **top**, **right**, and **bottom** members are not initialized.  
  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>( **const RECT&** ) and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>( **LPCRECT** ) constructors perform a [CopyRect](../vs140/crect--copyrect.md). The other constructors initialize the member variables of the object directly.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#38](../vs140/codesnippet/CPP/crect--crect_1.cpp)]  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CRect Class](../vs140/crect-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRect::SetRect](../vs140/crect--setrect.md)   
 [CRect::CopyRect](../vs140/crect--copyrect.md)   
 [CRect::operator =](../vs140/crect--operator-=.md)   
 [CRect::SetRectEmpty](../vs140/crect--setrectempty.md)