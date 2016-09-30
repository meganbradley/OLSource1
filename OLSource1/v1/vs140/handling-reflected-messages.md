---
title: "Handling Reflected Messages"
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
  - "message handling, reflected messages"
  - "reflected messages, handling"
ms.assetid: 147a4e0c-51cc-4447-a8e1-c28b4cece578
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Handling Reflected Messages
Message reflection lets you handle messages for a control, such as `WM_CTLCOLOR`, **WM_COMMAND**, and **WM_NOTIFY**, within the control itself. This makes the control more self-contained and portable. The mechanism works with Windows common controls as well as with ActiveX controls (formerly called OLE controls).  
  
 Message reflection lets you reuse your `CWnd`-derived classes more readily. Message reflection works via [CWnd::OnChildNotify](../vs140/cwnd--onchildnotify.md), using special **ON_XXX_REFLECT** message map entries: for example, **ON_CTLCOLOR_REFLECT** and **ON_CONTROL_REFLECT**. [Technical Note 62](../vs140/tn062--message-reflection-for-windows-controls.md) explains message reflection in more detail.  
  
## What do you want to do?  
  
-   [Learn more about message reflection](../vs140/tn062--message-reflection-for-windows-controls.md)  
  
-   [Implement message reflection for a common control](../vs140/tn062--message-reflection-for-windows-controls.md)  
  
-   [Implement message reflection for an ActiveX control](../vs140/mfc-activex-controls--subclassing-a-windows-control.md)  
  
## See Also  
 [Declaring Message Handler Functions](../vs140/declaring-message-handler-functions.md)