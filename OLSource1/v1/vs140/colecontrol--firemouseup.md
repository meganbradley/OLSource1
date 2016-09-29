---
title: "COleControl::FireMouseUp"
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
  - "COleControl::FireMouseUp"
  - "FireMouseUp"
  - "COleControl.FireMouseUp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FireMouseUp method"
ms.assetid: 37763443-bb81-4353-9747-935a1c8240e3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::FireMouseUp
Called by the framework when a mouse button is released over an active custom control.  
  
## Syntax  
  
```  
  
      void FireMouseUp(  
   short nButton,  
   short nShiftState,  
   OLE_XPOS_PIXELS x,  
   OLE_YPOS_PIXELS y   
);  
```  
  
#### Parameters  
 `nButton`  
 The numeric value of the mouse button released. It can have one of the following values:  
  
-   **LEFT_BUTTON** The left mouse button was released.  
  
-   **MIDDLE_BUTTON** The middle mouse button was released.  
  
-   **RIGHT_BUTTON** The right mouse button was released.  
  
 `nShiftState`  
 Contains a combination of the following flags:  
  
-   **SHIFT_MASK** The SHIFT key was pressed during the action.  
  
-   **CTRL_MASK** The CTRL key was pressed during the action.  
  
-   **ALT_MASK** The ALT key was pressed during the action.  
  
 *x*  
 The x-coordinate of the cursor when a mouse button was released. The coordinate is relative to the upper-left corner of the control window.  
  
 *y*  
 The y-coordinate of a cursor when a mouse button was released. The coordinate is relative to the upper-left corner of the control window.  
  
## Remarks  
 If this event is defined as a custom event, you determine when the event is fired.  
  
 For automatic firing of a MouseUp event to occur, the control's Event map must have a stock MouseUp event defined.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::FireMouseDown](../vs140/colecontrol--firemousedown.md)   
 [COleControl::FireClick](../vs140/colecontrol--fireclick.md)   
 [COleControl::FireDblClick](../vs140/colecontrol--firedblclick.md)