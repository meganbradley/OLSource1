---
title: "CRect::Width"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CRect.Width
  - CRect::Width
dev_langs: 
  - C++
helpviewer_keywords: 
  - Width method
  - CRect class, operations
ms.assetid: 3f561b92-c6dc-4597-9dd8-12cd60a45d7b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRect::Width
Calculates the width of `CRect` by subtracting the left value from the right value.  
  
## Syntax  
  
```  
  
int Width( ) const throw( );  
  
```  
  
## Return Value  
 The width of `CRect`.  
  
## Remarks  
 The width can be negative.  
  
> [!NOTE]
>  The rectangle must be normalized or this function may fail. You can call [NormalizeRect](../vs140/crect--normalizerect.md) to normalize the rectangle before calling this function.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#57](../vs140/codesnippet/CPP/crect--width_1.cpp)]
  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CRect Class](../vs140/crect-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRect::Height](../vs140/crect--height.md)   
 [CRect::Size](../vs140/crect--size.md)   
 [CRect::CenterPoint](../vs140/crect--centerpoint.md)   
 [CRect::IsRectEmpty](../vs140/crect--isrectempty.md)   
 [CRect::IsRectNull](../vs140/crect--isrectnull.md)   
 [CRect::NormalizeRect](../vs140/crect--normalizerect.md)