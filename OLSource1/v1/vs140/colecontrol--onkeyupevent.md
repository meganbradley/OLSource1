---
title: "COleControl::OnKeyUpEvent"
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
  - "COleControl::OnKeyUpEvent"
  - "OnKeyUpEvent"
  - "COleControl.OnKeyUpEvent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnKeyUpEvent method"
ms.assetid: c454cbd1-4f1a-437d-89a2-f930b1352f87
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnKeyUpEvent
Called by the framework after a stock KeyDown event has been processed.  
  
## Syntax  
  
```  
  
      virtual void OnKeyUpEvent(  
   USHORT nChar,  
   USHORT nShiftState   
);  
```  
  
#### Parameters  
 `nChar`  
 The virtual key code value of the pressed key. For a list of standard virtual key codes, see Winuser.h  
  
 `nShiftState`  
 Contains a combination of the following flags:  
  
-   **SHIFT_MASK** The SHIFT key was pressed during the action.  
  
-   **CTRL_MASK** The CTRL key was pressed during the action.  
  
-   **ALT_MASK** The ALT key was pressed during the action.  
  
## Remarks  
 Override this function if your control needs access to the key information after the event has been fired.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::OnKeyDownEvent](../vs140/colecontrol--onkeydownevent.md)   
 [COleControl::OnKeyPressEvent](../vs140/colecontrol--onkeypressevent.md)