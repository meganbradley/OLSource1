---
title: "CRect::MoveToXY"
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
  - "CRect::MoveToXY"
  - "CRect.MoveToXY"
  - "MoveToXY"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MoveToXY method"
  - "CRect class, operations"
ms.assetid: 6b3ff451-7bb6-452d-9722-90fa868c6c54
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRect::MoveToXY
Call this function to move the rectangle to the absolute x- and y-coordinates specified.  
  
## Syntax  
  
```  
  
      void MoveToXY(   
   int x,   
   int y    
) throw( );  
void MoveToXY(   
   POINT point    
) throw( );  
```  
  
#### Parameters  
 *x*  
 The absolute x-coordinate for the upper-left corner of the rectangle.  
  
 *y*  
 The absolute y-coordinate for the upper-left corner of the rectangle.  
  
 `point`  
 A **POINT** structure specifying the absolute upper-left corner of the rectangle.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#47](../vs140/codesnippet/CPP/crect--movetoxy_1.cpp)]  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CRect Class](../vs140/crect-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRect::MoveToX](../vs140/crect--movetox.md)   
 [CRect::MoveToY](../vs140/crect--movetoy.md)