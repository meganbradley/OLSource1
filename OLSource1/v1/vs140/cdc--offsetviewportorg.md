---
title: "CDC::OffsetViewportOrg"
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
  - "CDC::OffsetViewportOrg"
  - "CDC.OffsetViewportOrg"
  - "OffsetViewportOrg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, mapping functions"
  - "OffsetViewportOrg method"
ms.assetid: 784c6724-73e9-46fa-9c75-aa040f00af0b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::OffsetViewportOrg
Modifies the coordinates of the viewport origin relative to the coordinates of the current viewport origin.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the number of device units to add to the current origin's x-coordinate.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the number of device units to add to the current origin's y-coordinate.  
  
## Return Value  
 The previous viewport origin (in device coordinates) as a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetViewportOrg](../vs140/cdc--getviewportorg.md)   
 [CDC::OffsetWindowOrg](../vs140/cdc--offsetwindoworg.md)   
 [CDC::SetViewportOrg](../vs140/cdc--setviewportorg.md)   
 [CPoint Class](../vs140/cpoint-class.md)