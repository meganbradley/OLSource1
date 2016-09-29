---
title: "CRect::IntersectRect"
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
  - "CRect.IntersectRect"
  - "IntersectRect"
  - "CRect::IntersectRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IntersectRect method"
  - "CRect class, operations"
ms.assetid: 6d3fa6d6-2eb6-4576-b97e-d6a4bceee462
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRect::IntersectRect
Makes a `CRect` equal to the intersection of two existing rectangles.  
  
## Syntax  
  
```  
  
      BOOL IntersectRect(   
   LPCRECT lpRect1,   
   LPCRECT lpRect2    
) throw( );  
```  
  
#### Parameters  
 `lpRect1`  
 Points to a [RECT](../vs140/rect-structure.md) structure or `CRect` object that contains a source rectangle.  
  
 `lpRect2`  
 Points to a `RECT` structure or `CRect` object that contains a source rectangle.  
  
## Return Value  
 Nonzero if the intersection is not empty; 0 if the intersection is empty.  
  
## Remarks  
 The intersection is the largest rectangle contained in both existing rectangles.  
  
> [!NOTE]
>  Both of the rectangles must be normalized or this function may fail. You can call [NormalizeRect](../vs140/crect--normalizerect.md) to normalize the rectangles before calling this function.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#43](../vs140/codesnippet/CPP/crect--intersectrect_1.cpp)]  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CRect Class](../vs140/crect-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRect::operator &=](../vs140/crect--operator--=.md)   
 [CRect::operator &](../vs140/crect--operator--.md)   
 [CRect::UnionRect](../vs140/crect--unionrect.md)   
 [CRect::SubtractRect](../vs140/crect--subtractrect.md)   
 [CRect::NormalizeRect](../vs140/crect--normalizerect.md)   
 [IntersectRect](http://msdn.microsoft.com/library/windows/desktop/dd145001)