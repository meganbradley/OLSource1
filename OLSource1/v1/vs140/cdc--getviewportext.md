---
title: "CDC::GetViewportExt"
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
  - "CDC::GetViewportExt"
  - "CDC.GetViewportExt"
  - "GetViewportExt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, mapping functions"
  - "GetViewportExt method"
ms.assetid: 50c9e8e7-0255-46bd-a372-aa6a28a7ad9c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetViewportExt
Retrieves the x- and y-extents of the device context's viewport.  
  
## Syntax  
  
```  
  
CSize GetViewportExt( ) const;  
```  
  
## Return Value  
 The x- and y-extents (in device units) as a `CSize` object.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SetViewportExt](../vs140/cdc--setviewportext.md)   
 [CSize Class](../vs140/csize-class.md)   
 [CDC::SetWindowExt](../vs140/cdc--setwindowext.md)