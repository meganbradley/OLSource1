---
title: "CRect::NormalizeRect"
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
  - "NormalizeRect"
  - "CRect.NormalizeRect"
  - "CRect::NormalizeRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "NormalizeRect method"
  - "CRect class, operations"
ms.assetid: 0c8fd2fa-53bd-4218-abd6-11923eef7d01
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRect::NormalizeRect
Normalizes `CRect` so that both the height and width are positive.  
  
## Syntax  
  
```  
  
void NormalizeRect( ) throw( );  
  
```  
  
## Remarks  
 The rectangle is normalized for fourth-quadrant positioning, which Windows typically uses for coordinates. `NormalizeRect` compares the top and bottom values, and swaps them if the top is greater than the bottom. Similarly, it swaps the left and right values if the left is greater than the right. This function is useful when dealing with different mapping modes and inverted rectangles.  
  
> [!NOTE]
>  The following `CRect` member functions require normalized rectangles in order to work properly: [Height](../vs140/crect--height.md), [Width](../vs140/crect--width.md), [Size](../vs140/crect--size.md), [IsRectEmpty](../vs140/crect--isrectempty.md), [PtInRect](../vs140/crect--ptinrect.md), [EqualRect](../vs140/crect--equalrect.md), [UnionRect](../vs140/crect--unionrect.md), [IntersectRect](../vs140/crect--intersectrect.md), [SubtractRect](../vs140/crect--subtractrect.md), [operator ==](../vs140/crect--operator-==.md), [operator !=](../vs140/crect--operator-!=.md), [operator &#124;](../vs140/crect--operator--.md), [operator &#124;=](../vs140/crect--operator--=.md), [operator &](../vs140/crect--operator--.md), and [operator &=](../vs140/crect--operator--=.md).  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#49](../vs140/codesnippet/CPP/crect--normalizerect_1.cpp)]  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CRect Class](../vs140/crect-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)