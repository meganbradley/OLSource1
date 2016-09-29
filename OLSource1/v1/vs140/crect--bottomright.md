---
title: "CRect::BottomRight"
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
  - "CRect.BottomRight"
  - "CRect::BottomRight"
  - "BottomRight"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRect class, operations"
  - "BottomRight method"
ms.assetid: 2eb5a9da-5df8-4818-b9ea-ee1d9b458d05
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRect::BottomRight
The coordinates are returned as a reference to a [CPoint](../vs140/cpoint-class.md) object that is contained in `CRect`.  
  
## Syntax  
  
```  
  
      CPoint& BottomRight( ) throw( );   
const CPoint& BottomRight( ) const throw( );  
```  
  
## Return Value  
 The coordinates of the bottom-right corner of the rectangle.  
  
## Remarks  
 You can use this function to either get or set the bottom-right corner of the rectangle. Set the corner by using this function on the left side of the assignment operator.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#35](../vs140/codesnippet/CPP/crect--bottomright_1.cpp)]  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CRect Class](../vs140/crect-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRect::TopLeft](../vs140/crect--topleft.md)   
 [CPoint Class](../vs140/cpoint-class.md)   
 [CRect::CenterPoint](../vs140/crect--centerpoint.md)