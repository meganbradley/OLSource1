---
title: "CPane::MoveByAlignment"
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
  - "CPane::MoveByAlignment"
  - "CPane.MoveByAlignment"
  - "MoveByAlignment"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MoveByAlignment method"
ms.assetid: dc006322-3de2-433d-a49f-411e2aeda0e0
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::MoveByAlignment
Moves the pane and the virtual rectangle by the specified amount.  
  
## Syntax  
  
```  
BOOL MoveByAlignment(  
   DWORD dwAlignment,  
   int nOffset  
);  
```  
  
#### Parameters  
 [in] `dwAlignment`  
 Specifies pane alignment.  
  
 [in] `nOffset`  
 The amount, in pixels, by which to move the pane and the virtual rectangle.  
  
## Return Value  
  
## Remarks  
 `dwAlignment` can be any of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|`CBRS_ALIGN_TOP`|Enables the pane to be docked to the top of the client area of a frame window.|  
|`CBRS_ALIGN_BOTTOM`|Enables the pane to be docked to the bottom of the client area of a frame window.|  
|`CBRS_ALIGN_LEFT`|Enables the pane to be docked to the left side of the client area of a frame window.|  
|`CBRS_ALIGN_RIGHT`|Enables the pane to be docked to the right side of the client area of a frame window.|  
|`CBRS_ALIGN_ANY`|Enables the pane to be docked to any side of the client area of a frame window.|  
  
 If `dwAlignment` contains the `CBRS_ALIGN_LEFT` or `CBRS_ALIGN_RIGHT` flag, the pane and virtual rectangle are moved horizontally; otherwise, if `dwAlignment` contains the `CBRS_ALIGN_TOP` or `CBRS_ALIGN_BOTTOM` flag, the pane and virtual rectangle are moved vertically.  
  
## Requirements  
 **Header:** afxpane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)