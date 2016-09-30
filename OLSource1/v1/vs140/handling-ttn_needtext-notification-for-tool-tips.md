---
title: "Handling TTN_NEEDTEXT Notification for Tool Tips"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "TTN_NEEDTEXT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TTN_NEEDTEXT message"
  - "notifications, tool tips"
  - "tool tips [C++], notifications"
ms.assetid: d0370a65-21ba-4676-bcc5-8cf851bbb15c
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Handling TTN_NEEDTEXT Notification for Tool Tips
As part of [enabling tool tips](../vs140/enabling-tool-tips.md), you handle the **TTN_NEEDTEXT** message by adding the following entry to your owner window's message map:  
  
 [!code[NVC_MFCControlLadenDialog#40](../vs140/codesnippet/CPP/handling-ttn_needtext-notification-for-tool-tips_1.cpp)]  
  
 <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The member function to be called when text is needed for this button.  
  
 Note that the ID of a tool tip is always 0.  
  
 Declare your handler function in the class definition as follows:  
  
 [!code[NVC_MFCControlLadenDialog#53](../vs140/codesnippet/CPP/handling-ttn_needtext-notification-for-tool-tips_2.h)]  
  
 where the italicized parameters are:  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Identifier of the control that sent the notification. Not used. The control id is taken from the **NMHDR** structure.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the [NMTTDISPINFO](http://msdn.microsoft.com/library/windows/desktop/bb760258) structure. This structure is also discussed further in [The TOOLTIPTEXT Structure](../vs140/tooltiptext-structure.md).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to result code you can set before you return. **TTN_NEEDTEXT** handlers can ignore the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter.  
  
 As an example of a form-view notification handler:  
  
 [!code[NVC_MFCControlLadenDialog#54](../vs140/codesnippet/CPP/handling-ttn_needtext-notification-for-tool-tips_3.cpp)]  
  
 Call <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> (this fragment taken from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>):  
  
 [!code[NVC_MFCControlLadenDialog#55](../vs140/codesnippet/CPP/handling-ttn_needtext-notification-for-tool-tips_4.cpp)]  
  
## See Also  
 [Tool Tips in Windows Not Derived from CFrameWnd](../vs140/tool-tips-in-windows-not-derived-from-cframewnd.md)