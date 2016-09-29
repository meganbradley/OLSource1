---
title: "COleControl::OnInactiveMouseMove"
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
  - "COleControl.OnInactiveMouseMove"
  - "COleControl::OnInactiveMouseMove"
  - "OnInactiveMouseMove"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnInactiveMouseMove method"
ms.assetid: f8ca7554-3158-47b0-82ae-3aad25cb074b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnInactiveMouseMove
Called by the container for the inactive object under the mouse pointer on receipt of a `WM_MOUSEMOVE` message.  
  
## Syntax  
  
```  
  
      virtual void OnInactiveMouseMove(  
   LPCRECT lprcBounds,  
   long x,  
   long y,  
   DWORD dwKeyState   
);  
```  
  
#### Parameters  
 `lprcBounds`  
 The object bounding rectangle, in client coordinates of the containing window. Tells the object its exact position and size on the screen when the `WM_MOUSEMOVE` message was received.  
  
 *x*  
 The x coordinate of the mouse location in client coordinates of the containing window.  
  
 *y*  
 The y coordinate of the mouse location in client coordinates of the containing window.  
  
 `dwKeyState`  
 Identifies the current state of the keyboard modifier keys on the keyboard. Valid values can be a combination of any of the flags **MK_CONTROL**, **MK_SHIFT**, **MK_ALT**, **MK_BUTTON**, **MK_LBUTTON**, **MK_MBUTTON**, and **MK_RBUTTON**.  
  
## Remarks  
 Note that window client coordinates (pixels) are used to pass the mouse cursor position. This is made possible by also passing the bounding rectangle of the object in the same coordinate system.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::GetActivationPolicy](../vs140/colecontrol--getactivationpolicy.md)   
 [COleControl::OnInactiveSetCursor](../vs140/colecontrol--oninactivesetcursor.md)