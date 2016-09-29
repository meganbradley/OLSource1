---
title: "CDC::GetCurrentPosition"
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
  - "CDC.GetCurrentPosition"
  - "CDC::GetCurrentPosition"
  - "GetCurrentPosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, line-output functions"
  - "GetCurrentPosition method"
ms.assetid: fb8888d3-a207-424a-9a96-b8340a3f2f73
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetCurrentPosition
Retrieves the current position (in logical coordinates).  
  
## Syntax  
  
```  
  
CPoint GetCurrentPosition( ) const;  
```  
  
## Return Value  
 The current position as a `CPoint` object.  
  
## Remarks  
 The current position can be set with the `MoveTo` member function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::MoveTo](../vs140/cdc--moveto.md)   
 [CPoint Class](../vs140/cpoint-class.md)