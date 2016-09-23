---
title: "COleControl::FireMouseDown"
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
  - FireMouseDown
  - COleControl.FireMouseDown
  - COleControl::FireMouseDown
dev_langs: 
  - C++
helpviewer_keywords: 
  - FireMouseDown method
ms.assetid: 9383f5b3-c606-4cc2-972c-78f537f8df15
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleControl::FireMouseDown
Called by the framework when a mouse button is pressed over an active custom control.  
  
## Syntax  
  
```  
  
      void FireMouseDown(  
   short nButton,  
   short nShiftState,  
   OLE_XPOS_PIXELS x,  
   OLE_YPOS_PIXELS y   
);  
```  
  
#### Parameters  
 `nButton`  
 The numeric value of the mouse button pressed. It can contain one of the following values:  
  
-   **LEFT_BUTTON** The left mouse button was pressed down.  
  
-   **MIDDLE_BUTTON** The middle mouse button was pressed down.  
  
-   **RIGHT_BUTTON** The right mouse button was pressed down.  
  
 `nShiftState`  
 Contains a combination of the following flags:  
  
-   **SHIFT_MASK** The SHIFT key was pressed during the action.  
  
-   **CTRL_MASK** The CTRL key was pressed during the action.  
  
-   **ALT_MASK** The ALT key was pressed during the action.  
  
 *x*  
 The x-coordinate of the cursor when a mouse button was pressed down. The coordinate is relative to the upper-left corner of the control window.  
  
 *y*  
 The y-coordinate of the cursor when a mouse button was pressed down. The coordinate is relative to the upper-left corner of the control window.  
  
## Remarks  
 If this event is defined as a custom event, you determine when the event is fired.  
  
 For automatic firing of a MouseDown event to occur, the control's Event map must have a stock MouseDown event defined.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::FireMouseUp](../vs140/colecontrol--firemouseup.md)   
 [COleControl::FireMouseMove](../vs140/colecontrol--firemousemove.md)   
 [COleControl::FireClick](../vs140/colecontrol--fireclick.md)