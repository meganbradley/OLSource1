---
title: "CRect::PtInRect"
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
  - "CRect::PtInRect"
  - "CRect.PtInRect"
  - "PtInRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PtInRect method"
  - "CRect class, operations"
ms.assetid: a1c8f490-8034-44f9-a0e3-71b5832268d8
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRect::PtInRect
Determines whether the specified point lies within `CRect`.  
  
## Syntax  
  
```  
  
      BOOL PtInRect(   
   POINT point    
) const throw( );  
```  
  
#### Parameters  
 `point`  
 Contains a [POINT](../vs140/point-structure.md) structure or [CPoint](../vs140/cpoint-class.md) object.  
  
## Return Value  
 Nonzero if the point lies within `CRect`; otherwise 0.  
  
## Remarks  
 A point is within `CRect` if it lies on the left or top side or is within all four sides. A point on the right or bottom side is outside `CRect`.  
  
> [!NOTE]
>  The rectangle must be normalized or this function may fail. You can call [NormalizeRect](../vs140/crect--normalizerect.md) to normalize the rectangle before calling this function.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#51](../vs140/codesnippet/CPP/crect--ptinrect_1.cpp)]  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CRect Class](../vs140/crect-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRect::NormalizeRect](../vs140/crect--normalizerect.md)   
 [PtInRect](http://msdn.microsoft.com/library/windows/desktop/dd162882)