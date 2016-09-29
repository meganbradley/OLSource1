---
title: "COleControl::SetFocus"
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
  - "COleControl.SetFocus"
  - "COleControl::SetFocus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetFocus method"
ms.assetid: 53088ba1-b7ba-497c-a199-65ccdf8f6875
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::SetFocus
Causes the control's container window to take possession of the input focus on the control's behalf.  
  
## Syntax  
  
```  
  
CWnd* SetFocus( );  
```  
  
## Return Value  
 A pointer to the **CWnd** window object that previously had the input focus, or **NULL** if there is no such window.  
  
## Remarks  
 If the control is activated and windowless, this function causes the control's container window to take possession of the input focus, on the control's behalf. The input focus directs keyboard input to the container's window, and the container dispatches all subsequent keyboard messages to the OLE object that calls `SetFocus`. Any window that previously had the input focus loses it.  
  
 If the control is not windowless, this function causes the control itself to take possession of the input focus (same as `CWnd::SetFocus`).  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::GetFocus](../vs140/colecontrol--getfocus.md)