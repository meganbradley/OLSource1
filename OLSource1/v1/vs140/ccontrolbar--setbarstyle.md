---
title: "CControlBar::SetBarStyle"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CBRS_ALIGN_LEFT
  - CBRS_FLYBY
  - CBRS_FLOAT_MULTI
  - CBRS_ALIGN_RIGHT
  - CBRS_BORDER_RIGHT
  - CControlBar::SetBarStyle
  - CBRS_ALIGN_ANY
  - CBRS_TOOLTIPS
  - CBRS_BORDER_TOP
  - CBRS_BORDER_LEFT
  - CBRS_ALIGN_TOP
  - CBRS_ALIGN_BOTTOM
  - CBRS_BORDER_BOTTOM
  - SetBarStyle
  - CControlBar.SetBarStyle
dev_langs: 
  - C++
helpviewer_keywords: 
  - CBRS_ALIGN_RIGHT constant
  - CControlBar class, attributes
  - CBRS_ALIGN_ANY constant
  - CBRS_TOOLTIPS constant
  - SetBarStyle method
  - CBRS_BORDER_BOTTOM constant
  - CBRS_BORDER_LEFT constant
  - CBRS_ALIGN_TOP constant
  - CBRS_BORDER_RIGHT constant
  - CBRS_FLYBY constant
  - CBRS_BORDER_TOP constant
  - CBRS_ALIGN_BOTTOM constant
  - CBRS_FLOAT_MULTI constant
  - CBRS_ALIGN_LEFT constant
ms.assetid: 1c56ed8c-4d5a-4351-811b-fb82014e68c8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CControlBar::SetBarStyle
Call this function to set the desired **CBRS_** styles for the control bar.  
  
## Syntax  
  
```  
  
      void SetBarStyle(  
   DWORD dwStyle   
);  
```  
  
#### Parameters  
 `dwStyle`  
 The desired styles for the control bar. Can be one or more of the following:  
  
-   `CBRS_ALIGN_TOP` Allows the control bar to be docked to the top of the client area of a frame window.  
  
-   `CBRS_ALIGN_BOTTOM` Allows the control bar to be docked to the bottom of the client area of a frame window.  
  
-   `CBRS_ALIGN_LEFT` Allows the control bar to be docked to the left side of the client area of a frame window.  
  
-   `CBRS_ALIGN_RIGHT` Allows the control bar to be docked to the right side of the client area of a frame window.  
  
-   `CBRS_ALIGN_ANY` Allows the control bar to be docked to any side of the client area of a frame window.  
  
-   `CBRS_BORDER_TOP` Causes a border to be drawn on the top edge of the control bar when it would be visible.  
  
-   `CBRS_BORDER_BOTTOM` Causes a border to be drawn on the bottom edge of the control bar when it would be visible.  
  
-   `CBRS_BORDER_LEFT` Causes a border to be drawn on the left edge of the control bar when it would be visible.  
  
-   `CBRS_BORDER_RIGHT` Causes a border to be drawn on the right edge of the control bar when it would be visible.  
  
-   `CBRS_FLOAT_MULTI` Allows multiple control bars to be floated in a single mini-frame window.  
  
-   `CBRS_TOOLTIPS` Causes tool tips to be displayed for the control bar.  
  
-   `CBRS_FLYBY` Causes message text to be updated at the same time as tool tips.  
  
-   **CBRS_GRIPPER** Causes a gripper, similar to that used on bands in a **CReBar** object, to be drawn for any `CControlBar`-derived class.  
  
## Remarks  
 Does not affect the **WS_** (window style) settings.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CControlBar Class](../vs140/ccontrolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CControlBar::GetBarStyle](../vs140/ccontrolbar--getbarstyle.md)