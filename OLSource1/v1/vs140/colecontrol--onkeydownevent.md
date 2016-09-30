---
title: "COleControl::OnKeyDownEvent"
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
  - "COleControl::OnKeyDownEvent"
  - "COleControl.OnKeyDownEvent"
  - "OnKeyDownEvent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnKeyDownEvent method"
ms.assetid: 674bb3e7-9ccf-447a-956a-415e532d90fc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnKeyDownEvent
Called by the framework after a stock KeyDown event has been processed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The virtual key code value of the pressed key. For a list of standard virtual key codes, see Winuser.h  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
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
 [COleControl::OnKeyUpEvent](../vs140/colecontrol--onkeyupevent.md)   
 [COleControl::OnKeyPressEvent](../vs140/colecontrol--onkeypressevent.md)