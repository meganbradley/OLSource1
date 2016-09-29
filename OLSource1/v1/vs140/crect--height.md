---
title: "CRect::Height"
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
  - "Height"
  - "CRect.Height"
  - "CRect::Height"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRect class, operations"
  - "Height method"
ms.assetid: cf540367-f531-4a76-a607-3c1f6875a105
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRect::Height
Calculates the height of `CRect` by subtracting the top value from the bottom value.  
  
## Syntax  
  
```  
  
int Height( ) const throw( );  
  
```  
  
## Return Value  
 The height of `CRect`.  
  
## Remarks  
 The resulting value can be negative.  
  
> [!NOTE]
>  The rectangle must be normalized or this function may fail. You can call [NormalizeRect](../vs140/crect--normalizerect.md) to normalize the rectangle before calling this function.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#41](../vs140/codesnippet/CPP/crect--height_1.cpp)]  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CRect Class](../vs140/crect-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRect::Width](../vs140/crect--width.md)   
 [CRect::Size](../vs140/crect--size.md)   
 [CRect::CenterPoint](../vs140/crect--centerpoint.md)   
 [CRect::IsRectEmpty](../vs140/crect--isrectempty.md)   
 [CRect::IsRectNull](../vs140/crect--isrectnull.md)   
 [CRect::NormalizeRect](../vs140/crect--normalizerect.md)