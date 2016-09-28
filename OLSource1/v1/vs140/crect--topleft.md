---
title: "CRect::TopLeft"
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
  - "TopLeft"
  - "CRect.TopLeft"
  - "CRect::TopLeft"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TopLeft method"
  - "CRect class, operations"
ms.assetid: 2cc40f1a-5117-4d22-b553-f0f32c2ff83d
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRect::TopLeft
The coordinates are returned as a reference to a [CPoint](../vs140/cpoint-class.md) object that is contained in `CRect`.  
  
## Syntax  
  
```  
  
      CPoint& TopLeft( ) throw( );   
const CPoint& TopLeft( ) const throw( );  
```  
  
## Return Value  
 The coordinates of the top-left corner of the rectangle.  
  
## Remarks  
 You can use this function to either get or set the top-left corner of the rectangle. Set the corner by using this function on the left side of the assignment operator.  
  
## Example  
 See the example for [CRect::CenterPoint](../vs140/crect--centerpoint.md).  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CRect Class](../vs140/crect-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRect::BottomRight](../vs140/crect--bottomright.md)   
 [CPoint Class](../vs140/cpoint-class.md)   
 [CRect::CenterPoint](../vs140/crect--centerpoint.md)