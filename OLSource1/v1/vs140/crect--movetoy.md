---
title: "CRect::MoveToY"
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
  - CRect::MoveToY
  - CRect.MoveToY
  - MoveToY
dev_langs: 
  - C++
helpviewer_keywords: 
  - MoveToY method
  - CRect class, operations
ms.assetid: bcfcbed5-2ea6-446f-96d0-5192cd380678
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRect::MoveToY
Call this function to move the rectangle to the absolute y-coordinate specified by *y*.  
  
## Syntax  
  
```  
  
      void MoveToY(   
   int y    
) throw( );  
```  
  
#### Parameters  
 *y*  
 The absolute y-coordinate for the upper-left corner of the rectangle.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#48](../vs140/codesnippet/CPP/crect--movetoy_1.cpp)]
  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CRect Class](../vs140/crect-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRect::MoveToXY](../vs140/crect--movetoxy.md)   
 [CRect::MoveToX](../vs140/crect--movetox.md)