---
title: "Tool Tips in Windows Not Derived from CFrameWnd"
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
  - "enabling tool tips"
  - "TOOLTIPTEXT structure"
  - "Help, tool tips for controls"
  - "TTN_NEEDTEXT message"
  - "controls [MFC], tool tips"
  - "handler functions, tool tips"
ms.assetid: cad5ef0f-02e3-4151-ad0d-3d42e6932b0e
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Tool Tips in Windows Not Derived from CFrameWnd
This article family covers enabling tool tips for controls contained in a window that is not derived from [CFrameWnd](../vs140/cframewnd-class.md). The article [Toolbars Tool Tips](../vs140/toolbar-tool-tips.md) provides information about tool tips for controls in a `CFrameWnd`.  
  
 Topics covered in this article family include:  
  
-   [Enabling Tool Tips](../vs140/enabling-tool-tips.md)  
  
-   [Handling TTN_NEEDTEXT Notification for Tool Tips](../vs140/handling-ttn_needtext-notification-for-tool-tips.md)  
  
-   [The TOOLTIPTEXT Structure](../vs140/tooltiptext-structure.md)  
  
 Tool tips are automatically displayed for buttons and other controls contained in a parent window derived from `CFrameWnd`. This is because `CFrameWnd` has a default handler for the [TTN_GETDISPINFO](http://msdn.microsoft.com/library/windows/desktop/bb760269) notification, which handles **TTN_NEEDTEXT** notifications from tool tip controls associated with controls.  
  
 However, this default handler is not called when the **TTN_NEEDTEXT** notification is sent from a tool tip control associated with a control in a window that is not a `CFrameWnd`, such as a control on a dialog box or a form view. Therefore, it is necessary for you to provide a handler function for the **TTN_NEEDTEXT** notification message in order to display tool tips for child controls.  
  
 The default tool tips provided for your windows by [CWnd::EnableToolTips](../vs140/cwnd--enabletooltips.md) do not have text associated with them. To retrieve text for the tool tip to display, the **TTN_NEEDTEXT** notification is sent to the tool tip control's parent window just before the tool tip window is displayed. If there is no handler for this message to assign some value to the **pszText** member of the **TOOLTIPTEXT** structure, there will be no text displayed for the tool tip.  
  
## See Also  
 [Tool Tips](../vs140/tool-tips.md)