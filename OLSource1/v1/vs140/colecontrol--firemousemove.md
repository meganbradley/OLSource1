---
title: "COleControl::FireMouseMove"
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
  - FireMouseMove
  - COleControl.FireMouseMove
  - COleControl::FireMouseMove
dev_langs: 
  - C++
helpviewer_keywords: 
  - FireMouseMove method
ms.assetid: 0c290cea-ba65-43b0-8bc7-34ebd625216a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleControl::FireMouseMove
Called by the framework when the cursor is moved over an active custom control.  
  
## Syntax  
  
```  
  
      void FireMouseMove(  
   short nButton,  
   short nShiftState,  
   OLE_XPOS_PIXELS x,  
   OLE_YPOS_PIXELS y   
);  
```  
  
#### Parameters  
 `nButton`  
 The numeric value of the mouse buttons pressed. Contains a combination of the following values:  
  
-   **LEFT_BUTTON** The left mouse button was pressed down during the action.  
  
-   **MIDDLE_BUTTON** The middle mouse button was pressed down during the action.  
  
-   **RIGHT_BUTTON** The right mouse button was pressed down during the action.  
  
 `nShiftState`  
 Contains a combination of the following flags:  
  
-   **SHIFT_MASK** The SHIFT key was pressed during the action.  
  
-   **CTRL_MASK** The CTRL key was pressed during the action.  
  
-   **ALT_MASK** The ALT key was pressed during the action.  
  
 *x*  
 The x-coordinate of the cursor. The coordinate is relative to the upper-left corner of the control window.  
  
 *y*  
 The y-coordinate of the cursor. The coordinate is relative to the upper-left corner of the control window.  
  
## Remarks  
 If this event is defined as a custom event, you determine when the event is fired.  
  
 For automatic firing of a MouseMove event to occur, the control's Event map must have a stock MouseMove event defined.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)