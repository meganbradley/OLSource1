---
title: "CDC::GetWindowExt"
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
  - "CDC::GetWindowExt"
  - "GetWindowExt"
  - "CDC.GetWindowExt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, mapping functions"
  - "GetWindowExt method"
ms.assetid: aab8812d-a2e0-4c4b-83c1-a531dbb553ad
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetWindowExt
Retrieves the x- and y-extents of the window associated with the device context.  
  
## Syntax  
  
```  
  
CSize GetWindowExt( ) const;  
```  
  
## Return Value  
 The x- and y-extents (in logical units) as a `CSize` object.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SetWindowExt](../vs140/cdc--setwindowext.md)   
 [CSize Class](../vs140/csize-class.md)   
 [CDC::GetViewportExt](../vs140/cdc--getviewportext.md)