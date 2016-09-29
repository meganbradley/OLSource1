---
title: "COleControl::FireKeyUp"
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
  - "COleControl.FireKeyUp"
  - "COleControl::FireKeyUp"
  - "FireKeyUp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FireKeyUp method"
ms.assetid: 5ce6cc02-d4fd-4609-8c1a-3b802ce3c424
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::FireKeyUp
Called by the framework when a key is released while the custom control is UI Active within the container.  
  
## Syntax  
  
```  
  
      void FireKeyUp(  
   USHORT* pnChar,  
   short nShiftState   
);  
```  
  
#### Parameters  
 `pnChar`  
 Pointer to the virtual key code value of the released key. For a list of of standard virtual key codes, see Winuser.h  
  
 `nShiftState`  
 Contains a combination of the following flags:  
  
-   **SHIFT_MASK** The SHIFT key was pressed during the action.  
  
-   **CTRL_MASK** The CTRL key was pressed during the action.  
  
-   **ALT_MASK** The ALT key was pressed during the action.  
  
## Remarks  
 If this event is defined as a custom event, you determine when the event is fired.  
  
 For automatic firing of a KeyUp event to occur, the control's Event map must have a stock KeyUp event defined.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::FireKeyDown](../vs140/colecontrol--firekeydown.md)   
 [COleControl::FireKeyPress](../vs140/colecontrol--firekeypress.md)   
 [COleControl::OnKeyUpEvent](../vs140/colecontrol--onkeyupevent.md)