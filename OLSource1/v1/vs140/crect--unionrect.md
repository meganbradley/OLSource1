---
title: "CRect::UnionRect"
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
  - "CRect::UnionRect"
  - "CRect.UnionRect"
  - "UnionRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UnionRect method"
  - "CRect class, operations"
ms.assetid: 22fb6e72-1e2b-453e-a139-87869c88a3fa
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRect::UnionRect
Makes the dimensions of `CRect` equal to the union of the two source rectangles.  
  
## Syntax  
  
```  
  
      BOOL UnionRect(   
   LPCRECT lpRect1,   
   LPCRECT lpRect2    
) throw( );  
```  
  
#### Parameters  
 `lpRect1`  
 Points to a [RECT](../vs140/rect-structure.md) or `CRect` that contains a source rectangle.  
  
 `lpRect2`  
 Points to a `RECT` or `CRect` that contains a source rectangle.  
  
## Return Value  
 Nonzero if the union is not empty; 0 if the union is empty.  
  
## Remarks  
 The union is the smallest rectangle that contains both source rectangles.  
  
 Windows ignores the dimensions of an empty rectangle; that is, a rectangle that has no height or has no width.  
  
> [!NOTE]
>  Both of the rectangles must be normalized or this function may fail. You can call [NormalizeRect](../vs140/crect--normalizerect.md) to normalize the rectangles before calling this function.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#56](../vs140/codesnippet/CPP/crect--unionrect_1.cpp)]  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CRect Class](../vs140/crect-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRect::operator &#124;=](../vs140/crect--operator--=.md)   
 [CRect::operator &#124;](../vs140/crect--operator--.md)   
 [CRect::IntersectRect](../vs140/crect--intersectrect.md)   
 [CRect::SubtractRect](../vs140/crect--subtractrect.md)   
 [CRect::NormalizeRect](../vs140/crect--normalizerect.md)   
 [UnionRect](http://msdn.microsoft.com/library/windows/desktop/dd145163)