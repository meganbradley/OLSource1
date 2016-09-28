---
title: "CDC::GetBoundsRect"
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
  - "CDC.GetBoundsRect"
  - "GetBoundsRect"
  - "CDC::GetBoundsRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetBoundsRect method"
  - "CDC class, clipping functions"
ms.assetid: 4d591bac-b199-4d3e-b472-151db4f86f72
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetBoundsRect
Returns the current accumulated bounding rectangle for the specified device context.  
  
## Syntax  
  
```  
  
      UINT GetBoundsRect(  
   LPRECT lpRectBounds,  
   UINT flags   
);  
```  
  
#### Parameters  
 `lpRectBounds`  
 Points to a buffer that will receive the current bounding rectangle. The rectangle is returned in logical coordinates.  
  
 `flags`  
 Specifies whether the bounding rectangle is to be cleared after it is returned. This parameter should be  zero or set to the following value:  
  
-   **DCB_RESET** Forces the bounding rectangle to be cleared after it is returned.  
  
## Return Value  
 Specifies the current state of the bounding rectangle if the function is successful. It can be a combination of the following values:  
  
-   **DCB_ACCUMULATE** Bounding rectangle accumulation is occurring.  
  
-   **DCB_RESET** Bounding rectangle is empty.  
  
-   **DCB_SET** Bounding rectangle is not empty.  
  
-   **DCB_ENABLE** Bounding accumulation is on.  
  
-   **DCB_DISABLE** Bounding accumulation is off.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SetBoundsRect](../vs140/cdc--setboundsrect.md)   
 [GetBoundsRect](http://msdn.microsoft.com/library/windows/desktop/dd144854)