---
title: "COleControl::OnKeyPressEvent"
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
  - "OnKeyPressEvent"
  - "COleControl.OnKeyPressEvent"
  - "COleControl::OnKeyPressEvent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnKeyPressEvent method"
ms.assetid: 3366347f-e792-4c2a-87c3-7c56041aeb72
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnKeyPressEvent
Called by the framework after the stock KeyPress event has been fired.  
  
## Syntax  
  
```  
  
      virtual void OnKeyPressEvent(  
   USHORT nChar   
);  
```  
  
#### Parameters  
 `nChar`  
 Contains the virtual key code value of the key pressed. For a list of standard virtual key codes, see Winuser.h  
  
## Remarks  
 Note that the `nChar` value may have been modified by the container.  
  
 Override this function if you want notification after this event occurs.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::FireKeyPress](../vs140/colecontrol--firekeypress.md)