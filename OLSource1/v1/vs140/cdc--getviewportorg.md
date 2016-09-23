---
title: "CDC::GetViewportOrg"
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
  - CDC.GetViewportOrg
  - CDC::GetViewportOrg
  - GetViewportOrg
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDC class, mapping functions
  - GetViewportOrg method
ms.assetid: 7408ef38-0349-4562-9337-ac0144de3cd7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::GetViewportOrg
Retrieves the x- and y-coordinates of the origin of the viewport associated with the device context.  
  
## Syntax  
  
```  
  
CPoint GetViewportOrg( ) const;  
```  
  
## Return Value  
 The origin of the viewport (in device coordinates) as a `CPoint` object.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetWindowOrg](../vs140/cdc--getwindoworg.md)   
 [CPoint Class](../vs140/cpoint-class.md)   
 [CDC::SetViewportOrg](../vs140/cdc--setviewportorg.md)