---
title: "CPoint::operator !="
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
  - "CPoint.operator!="
  - "CPoint::operator!="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "!= operator"
  - "operator!=, points"
  - "operator !=, points"
ms.assetid: 7d94f119-4e4d-4c77-bcc7-8d54d3b84c8f
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPoint::operator !=
Checks for inequality between two points.  
  
## Syntax  
  
```  
  
      BOOL operator!=(  
   POINT point   
) const throw( );  
```  
  
#### Parameters  
 `point`  
 Contains a [POINT](../vs140/point-structure.md) structure or `CPoint` object.  
  
## Return Value  
 Nonzero if the points are not equal; otherwise 0.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#30](../vs140/codesnippet/CPP/cpoint--operator-!=_1.cpp)]  
  
## Requirements  
 **Header:** atltypes.h  
  
## See Also  
 [CPoint Class](../vs140/cpoint-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPoint::operator ==](../vs140/cpoint--operator-==.md)