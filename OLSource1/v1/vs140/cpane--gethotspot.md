---
title: "CPane::GetHotSpot"
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
  - "GetHotSpot"
  - "CPane::GetHotSpot"
  - "CPane.GetHotSpot"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetHotSpot method"
ms.assetid: 5dca2abe-e466-435e-9374-10b10ea8eb05
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::GetHotSpot
Returns the hot spot that is stored in an underlying `CMFCDragFrameImpl` object.  
  
## Syntax  
  
```  
CPoint GetHotSpot() const;  
```  
  
## Return Value  
  
## Remarks  
 The `CPane` class contains a `CMFCDragFrameImpl` object, `m_dragFrameImpl`, that is responsible for drawing the rectangle that appears when the user moves a pane in the standard docking mode. The hot spot is used to draw the rectangle relative to the current mouse position as the user moves the pane.  
  
## Requirements  
 **Header:** afxpane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCDragFrameImpl Class](../vs140/cmfcdragframeimpl-class.md)