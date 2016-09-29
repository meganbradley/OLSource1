---
title: "Slider Notification Messages"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSliderCtrl class, notifications"
  - "slider controls, notification messages"
  - "messages, notification"
  - "notifications, CSliderCtrl"
ms.assetid: b9121104-3889-4a10-92bf-f3723f1af9d0
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Slider Notification Messages
A slider control notifies its parent window of user actions by sending the parent `WM_HSCROLL` or `WM_VSCROLL` messages, depending on the orientation of the slider control. To handle these messages, add handlers for the `WM_HSCROLL` and `WM_VSCROLL` messages to the parent window. The [OnHScroll](../vs140/cwnd--onhscroll.md) and [OnVScroll](../vs140/cwnd--onvscroll.md) member functions will be passed a notification code, the position of the slider, and a pointer to the [CSliderCtrl](../vs140/csliderctrl-class.md) object. Note that the pointer is of type **CScrollBar \*** even though it points to a `CSliderCtrl` object. You may need to typecast this pointer if you need to manipulate the slider control.  
  
 Rather than using the scroll bar notification codes, slider controls send a different set of notification codes. A slider control sends the **TB_BOTTOM**, **TB_LINEDOWN**, **TB_LINEUP**, and **TB_TOP** notification codes only when the user interacts with a slider control by using the keyboard. The **TB_THUMBPOSITION** and **TB_THUMBTRACK** notification messages are only sent when the user is using the mouse. The **TB_ENDTRACK**, **TB_PAGEDOWN**, and **TB_PAGEUP** notification codes are sent in both cases.  
  
 The following table lists the slider control notification messages and the events (virtual key codes or mouse events) that cause the notifications to be sent. (For a list of standard virtual key codes, see Winuser.h.)  
  
|Notification message|Event causing notification to be sent|  
|--------------------------|-------------------------------------------|  
|**TB_BOTTOM**|**VK_END**|  
|**TB_ENDTRACK**|`WM_KEYUP` (the user released a key that sent a relevant virtual key code)|  
|**TB_LINEDOWN**|**VK_RIGHT** or **VK_DOWN**|  
|**TB_LINEUP**|**VK_LEFT** or **VK_UP**|  
|**TB_PAGEDOWN**|**VK_NEXT** (the user clicked the channel below or to the right of the slider)|  
|**TB_PAGEUP**|**VK_PRIOR** (the user clicked the channel above or to the left of the slider)|  
|**TB_THUMBPOSITION**|`WM_LBUTTONUP` following a **TB_THUMBTRACK** notification message|  
|**TB_THUMBTRACK**|Slider movement (the user dragged the slider)|  
|**TB_TOP**|**VK_HOME**|  
  
## See Also  
 [Using CSliderCtrl](../vs140/using-csliderctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)