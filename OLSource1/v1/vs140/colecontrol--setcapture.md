---
title: "COleControl::SetCapture"
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
  - "COleControl::SetCapture"
  - "COleControl.SetCapture"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetCapture method"
ms.assetid: f5f27828-82b7-44e6-99ec-b715afa7f765
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::SetCapture
Causes the control's container window to take possession of the mouse capture on the control's behalf.  
  
## Syntax  
  
```  
  
CWnd* SetCapture( );  
```  
  
## Return Value  
 A pointer to the **CWnd** window object that previously received mouse input.  
  
## Remarks  
 If the control is activated and windowless, this function causes the control's container window to take possession of the mouse capture, on the control's behalf. Otherwise, this function causes the control itself to take possession of the mouse capture (same as `CWnd::SetCapture`).  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::GetCapture](../vs140/colecontrol--getcapture.md)   
 [COleControl::ReleaseCapture](../vs140/colecontrol--releasecapture.md)