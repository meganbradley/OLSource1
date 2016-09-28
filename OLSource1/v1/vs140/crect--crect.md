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
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRect::CRect
Constructs a `CRect` object.  
  
## Syntax  
  
```  
  
      CRect( ) throw( );   
CRect(   
   int l,   
   int t,   
   int r,   
   int b    
) throw( );  
CRect(   
   const RECT& srcRect    
) throw( );  
CRect(   
   LPCRECT lpSrcRect    
) throw( );  
CRect(   
   POINT point,   
   SIZE size    
) throw( );  
CRect(   
   POINT topLeft,   
   POINT bottomRight    
) throw( );  
```  
  
#### Parameters  
 *l*  
 Specifies the left position of `CRect`.  
  
 *t*  
 Specifies the top of `CRect`.  
  
 *r*  
 Specifies the right position of `CRect`.  
  
 *b*  
 Specifies the bottom of `CRect`.  
  
 *srcRect*  
 Refers to the [RECT](../vs140/rect-structure.md) structure with the coordinates for `CRect`.  
  
 `lpSrcRect`  
 Points to the `RECT` structure with the coordinates for `CRect`.  
  
 `point`  
 Specifies the origin point for the rectangle to be constructed. Corresponds to the top-left corner.  
  
 `size`  
 Specifies the displacement from the top-left corner to the bottom-right corner of the rectangle to be constructed.  
  
 *topLeft*  
 Specifies the top-left position of `CRect`.  
  
 *bottomRight*  
 Specifies the bottom-right position of `CRect`.  
  
## Remarks  
 If no arguments are given, **left**, **top**, **right**, and **bottom** members are not initialized.  
  
 The `CRect`( **const RECT&** ) and `CRect`( **LPCRECT** ) constructors perform a [CopyRect](../vs140/crect--copyrect.md). The other constructors initialize the member variables of the object directly.  
  
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