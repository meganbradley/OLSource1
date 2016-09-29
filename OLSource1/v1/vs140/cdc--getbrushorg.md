---
title: "CDC::GetBrushOrg"
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
  - "CDC::GetBrushOrg"
  - "CDC.GetBrushOrg"
  - "GetBrushOrg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, drawing tool functions"
  - "GetBrushOrg method"
ms.assetid: 7aa9dd42-f6b7-405a-b99c-79e148dcc0ed
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetBrushOrg
Retrieves the origin (in device units) of the brush currently selected for the device context.  
  
## Syntax  
  
```  
  
CPoint GetBrushOrg( ) const;  
```  
  
## Return Value  
 The current origin of the brush (in device units) as a [CPoint](../vs140/cpoint-class.md) object.  
  
## Remarks  
 The initial brush origin is at (0,0) of the client area. The return value specifies this point in device units relative to the origin of the desktop window.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SetBrushOrg](../vs140/cdc--setbrushorg.md)   
 [CPoint Class](../vs140/cpoint-class.md)