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
`InflateRect` inflates `CRect` by moving its sides away from its center.  
  
## Syntax  
  
```  
  
      void InflateRect(   
   int x,   
   int y    
) throw( );  
void InflateRect(   
   SIZE size    
) throw( );  
void InflateRect(   
   LPCRECT lpRect    
) throw( );  
void InflateRect(   
   int l,   
   int t,   
   int r,   
   int b    
) throw( );  
```  
  
#### Parameters  
 *x*  
 Specifies the number of units to inflate the left and right sides of `CRect`.  
  
 *y*  
 Specifies the number of units to inflate the top and bottom of `CRect`.  
  
 `size`  
 A [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106) or [CSize](../vs140/csize-class.md) that specifies the number of units to inflate `CRect`. The `cx` value specifies the number of units to inflate the left and right sides and the `cy` value specifies the number of units to inflate the top and bottom.  
  
 `lpRect`  
 Points to a [RECT](../vs140/rect-structure.md) structure or `CRect` that specifies the number of units to inflate each side.  
  
 *l*  
 Specifies the number of units to inflate the left side of `CRect`.  
  
 *t*  
 Specifies the number of units to inflate the top of `CRect`.  
  
 *r*  
 Specifies the number of units to inflate the right side of `CRect`.  
  
 *b*  
 Specifies the number of units to inflate the bottom of `CRect`.  
  
## Remarks  
 To do this, `InflateRect` subtracts units from the left and top and adds units to the right and bottom. The parameters of `InflateRect` are signed values; positive values inflate `CRect` and negative values deflate it.  
  
 The first two overloads inflate both pairs of opposite sides of `CRect` so that its total width is increased by two times *x* (or `cx`) and its total height is increased by two times *y* (or `cy`). The other two overloads inflate each side of `CRect` independently of the others.  
  
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