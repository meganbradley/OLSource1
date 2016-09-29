---
title: "CRect::IsRectEmpty"
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
  - "IsRectEmpty"
  - "CRect::IsRectEmpty"
  - "CRect.IsRectEmpty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRect class, operations"
  - "IsRectEmpty method"
ms.assetid: 1ff0b971-52d3-442e-b918-b292e6de224d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRect::IsRectEmpty
Determines whether `CRect` is empty.  
  
## Syntax  
  
```  
  
BOOL IsRectEmpty( ) const throw( );  
  
```  
  
## Return Value  
 Nonzero if `CRect` is empty; 0 if `CRect` is not empty.  
  
## Remarks  
 A rectangle is empty if the width and/or height are 0 or negative. Differs from `IsRectNull`, which determines whether all coordinates of the rectangle are zero.  
  
> [!NOTE]
>  The rectangle must be normalized or this function may fail. You can call [NormalizeRect](../vs140/crect--normalizerect.md) to normalize the rectangle before calling this function.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#44](../vs140/codesnippet/CPP/crect--isrectempty_1.cpp)]  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CRect Class](../vs140/crect-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRect::IsRectNull](../vs140/crect--isrectnull.md)   
 [CRect::SetRectEmpty](../vs140/crect--setrectempty.md)   
 [CRect::NormalizeRect](../vs140/crect--normalizerect.md)   
 [IsRectEmpty](http://msdn.microsoft.com/library/windows/desktop/dd145017)