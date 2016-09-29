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
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRect::operator +
The first two overloads return a `CRect` object that is equal to `CRect` displaced by the specified offsets.  
  
## Syntax  
  
```  
  
      CRect operator +(   
   POINT point    
) const throw( );  
CRect operator +(   
   LPCRECT lpRect    
) const throw( );  
CRect operator +(   
   SIZE size    
) const throw( );  
```  
  
#### Parameters  
 `point`  
 A [POINT](../vs140/point-structure.md) structure or [CPoint](../vs140/cpoint-class.md) object that specifies the number of units to move the return value.  
  
 `size`  
 A [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) structure or [CSize](../vs140/csize-class.md) object that specifies the number of units to move the return value.  
  
 `lpRect`  
 Points to a [RECT](../vs140/rect-structure.md) structure or `CRect` object that contains the number of units to inflate each side of the return value.  
  
## Return Value  
 The `CRect` resulting from moving or inflating `CRect` by the number of units specified in the parameter.  
  
## Remarks  
 The parameter's *x* and *y* (or `cx` and `cy`) parameters are added to `CRect`'s position.  
  
 The third overload returns a new `CRect` that is equal to `CRect` inflated by the number of units specifed in each member of the parameter.  
  
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