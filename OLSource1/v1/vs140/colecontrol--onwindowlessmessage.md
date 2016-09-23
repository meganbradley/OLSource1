---
title: "COleControl::OnWindowlessMessage"
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
  - OnWindowlessMessage
  - COleControl.OnWindowlessMessage
  - COleControl::OnWindowlessMessage
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnWindowlessMessage method
ms.assetid: 29e355e9-b6cd-4fdf-a5d4-9c922b6fad9c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleControl::OnWindowlessMessage
Called by the framework in response to a container's **IOleInPlaceObjectWindowless::OnWindowMessage** request.  
  
## Syntax  
  
```  
  
      virtual BOOL OnWindowlessMessage(  
   UINT msg,  
   WPARAM wParam,  
   LPARAM lParam,  
   LRESULT* plResult   
);  
```  
  
#### Parameters  
 `msg`  
 Message identifier as passed by Windows.  
  
 `wParam`  
 As passed by Windows. Specifies additional message-specific information. The contents of this parameter depend on the value of the `msg` parameter.  
  
 `lParam`  
 As passed by Windows. Specifies additional message-specific information. The contents of this parameter depend on the value of the `msg` parameter.  
  
 *plResult*  
 Windows result code. Specifies the result of the message processing and depends on the message sent.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 Processes window messages for windowless controls. `COleControl`'s `OnWindowlessMessage` should be used for window messages other than mouse messages and keyboard messages. `COleControl` provides [SetCapture](../vs140/colecontrol--setcapture.md) and [SetFocus](../vs140/colecontrol--setfocus.md) specifically to get mouse capture and keyboard focus for windowless OLE objects.  
  
 Because windowless objects do not have a window, they need a mechanism to let the container dispatch messages to them. A windowless OLE object gets messages from its container, through the `OnWindowMessage` method on the `IOleInPlaceObjectWindowless` interface (an extension of [IOleInPlaceObject](http://msdn.microsoft.com/library/windows/desktop/ms692646) for windowless support). `OnWindowMessage` does not take an `HWND` parameter.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::SetCapture](../vs140/colecontrol--setcapture.md)   
 [COleControl::SetFocus](../vs140/colecontrol--setfocus.md)   
 [COleControl::GetWindowlessDropTarget](../vs140/colecontrol--getwindowlessdroptarget.md)