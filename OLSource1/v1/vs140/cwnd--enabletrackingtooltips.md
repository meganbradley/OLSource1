---
title: "CWnd::EnableTrackingToolTips"
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
  - "EnableTrackingToolTips"
  - "CWnd::EnableTrackingToolTips"
  - "CWnd.EnableTrackingToolTips"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "tool tips [C++], tracking"
  - "EnableTrackingTooltips method"
ms.assetid: 6c7ab4e9-b50b-4adb-9eb0-209fbb8b9430
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::EnableTrackingToolTips
Enables or disables tracking tooltips.  
  
## Syntax  
  
```  
  
      BOOL EnableTrackingToolTips(  
   BOOL bEnable = TRUE   
);  
```  
  
#### Parameters  
 `bEnable`  
 Specifies whether tracking tool tips are enabled or disabled. If this parameter is **TRUE**, the tracking tool tips will be enabled. If this parameter is **FALSE**, the tracking tool tips will be disabled.  
  
## Return Value  
 Indicates the state before the `EnableWindow` member function was called. The return value is nonzero if the window was previously disabled. The return value is 0 if the window was previously enabled or an error occurred.  
  
## Remarks  
 Tracking tool tips are tool tip windows that you can dynamically position on the screen. By rapidly updating the position, the tool tip window appears to move smoothly, or "track." This functionality can be useful if you need tool tip text to follow the position of the pointer as it moves.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::EnableToolTips](../vs140/cwnd--enabletooltips.md)   
 [Tooltip Controls](http://msdn.microsoft.com/library/windows/desktop/bb760250)