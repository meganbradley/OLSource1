---
title: "CControlBar::CalcInsideRect"
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
  - "CControlBar::CalcInsideRect"
  - "CalcInsideRect"
  - "CControlBar.CalcInsideRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CalcInsideRect method"
ms.assetid: 43fffea7-bbee-4f57-ba5f-6ffc4a2445f2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CControlBar::CalcInsideRect
The framework calls this function to calculate the client area of the control bar.  
  
## Syntax  
  
```  
  
      virtual void CalcInsideRect(  
   CRect& rect,  
   BOOL bHorz   
) const;  
```  
  
#### Parameters  
 `rect`  
 Contains the current dimensions of the control bar; including the borders.  
  
 `bHorz`  
 Indicates that the bar is horizontally or vertically oriented. The `bHorz` parameter is nonzero if the bar is horizontally oriented and is 0 if it is vertically oriented.  
  
## Remarks  
 This function is called before the control bar is painted.  
  
 Override this function to customize the rendering of the borders and gripper bar of the control bar.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CControlBar Class](../vs140/ccontrolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CControlBar::DrawBorders](../vs140/ccontrolbar--drawborders.md)   
 [CControlBar::DrawGripper](../vs140/ccontrolbar--drawgripper.md)