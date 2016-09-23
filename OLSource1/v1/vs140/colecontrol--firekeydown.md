---
title: "COleControl::FireKeyDown"
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
  - FireKeyDown
  - COleControl.FireKeyDown
  - COleControl::FireKeyDown
dev_langs: 
  - C++
helpviewer_keywords: 
  - FireKeyDown method
ms.assetid: 882a1781-3db6-4524-abc6-32f62f9b6b02
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleControl::FireKeyDown
Called by the framework when a key is pressed while the control is UI active.  
  
## Syntax  
  
```  
  
      void FireKeyDown(  
   USHORT* pnChar,  
   short nShiftState   
);  
```  
  
#### Parameters  
 `pnChar`  
 Pointer to the virtual key code value of the pressed key. For a list of of standard virtual key codes, see Winuser.h  
  
 `nShiftState`  
 Contains a combination of the following flags:  
  
-   **SHIFT_MASK** The SHIFT key was pressed during the action.  
  
-   **CTRL_MASK** The CTRL key was pressed during the action.  
  
-   **ALT_MASK** The ALT key was pressed during the action.  
  
## Remarks  
 If this event is defined as a custom event, you determine when the event is fired.  
  
 For automatic firing of a KeyDown event to occur, the control's Event map must have a stock KeyDown event defined.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::FireKeyUp](../vs140/colecontrol--firekeyup.md)   
 [COleControl::FireKeyPress](../vs140/colecontrol--firekeypress.md)   
 [COleControl::OnKeyPressEvent](../vs140/colecontrol--onkeypressevent.md)