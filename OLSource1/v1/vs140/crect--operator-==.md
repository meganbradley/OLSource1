---
title: "CRect::operator =="
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
  - "CRect::operator=="
  - "CRect.operator=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator ==, rectangles"
  - "operator==, rectangles"
  - "== operator"
  - "CRect class, operators"
ms.assetid: 7e35f922-42e0-42e7-ab92-9dd6f5ce885b
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRect::operator ==
Determines whether `rect` is equal to `CRect` by comparing the coordinates of their upper-left and lower-right corners.  
  
## Syntax  
  
```  
  
      BOOL operator ==(   
   const RECT& rect    
) const throw( );  
```  
  
#### Parameters  
 `rect`  
 Refers to a source rectangle. Can be a [RECT](../vs140/rect-structure.md) or `CRect`.  
  
## Return Value  
 Nonzero if equal; otherwise 0.  
  
## Remarks  
  
> [!NOTE]
>  Both of the rectangles must be normalized or this function may fail. You can call [NormalizeRect](../vs140/crect--normalizerect.md) to normalize the rectangles before calling this function.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#60](../vs140/codesnippet/CPP/crect--operator-==_1.cpp)]  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CRect Class](../vs140/crect-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRect::operator !=](../vs140/crect--operator-!=.md)   
 [CRect::NormalizeRect](../vs140/crect--normalizerect.md)   
 [EqualRect](http://msdn.microsoft.com/library/windows/desktop/dd162699)