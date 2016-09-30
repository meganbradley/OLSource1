---
title: "CDC::GetWindowOrg"
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
  - "GetWindowOrg"
  - "CDC.GetWindowOrg"
  - "CDC::GetWindowOrg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, mapping functions"
  - "GetWindowOrg method"
ms.assetid: f12d84ad-9bd9-4331-a403-9e5da503884c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetWindowOrg
Retrieves the x- and y-coordinates of the origin of the window associated with the device context.  
  
## Syntax  
  
```  
  
CPoint GetWindowOrg( ) const;  
```  
  
## Return Value  
 The origin of the window (in logical coordinates) as a `CPoint` object.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetViewportOrg](../vs140/cdc--getviewportorg.md)   
 [CDC::SetWindowOrg](../vs140/cdc--setwindoworg.md)   
 [CPoint Class](../vs140/cpoint-class.md)