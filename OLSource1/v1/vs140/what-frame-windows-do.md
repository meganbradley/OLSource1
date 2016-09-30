---
title: "What Frame Windows Do"
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
  - "frame windows, about frame widows"
  - "frame windows, tasks"
  - "MFC, frame windows"
ms.assetid: 1148a952-6786-4622-b5a8-68a2d7eae584
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# What Frame Windows Do
Besides simply framing a view, frame windows are responsible for numerous tasks involved in coordinating the frame with its view and with the application. [CMDIFrameWnd](../vs140/cmdiframewnd-class.md) and [CMDIChildWnd](../vs140/cmdichildwnd-class.md) inherit from [CFrameWnd](../vs140/cframewnd-class.md), so they have <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> capabilities as well as new capabilities that they add. Examples of child windows include views, controls such as buttons and list boxes, and control bars, including toolbars, status bars, and dialog bars.  
  
 The frame window is responsible for managing the layout of its child windows. In the MFC framework, a frame window positions any control bars, views, and other child windows inside its client area.  
  
 The frame window also forwards commands to its views and can respond to notification messages from control windows.  
  
## What do you want to know more about?  
  
-   [Control bars (how they fit into the frame window)](../vs140/control-bars.md)  
  
-   [Managing menus, control bars, and accelerators (how they fit into the frame window)](../vs140/managing-menus--control-bars--and-accelerators.md)  
  
-   [Command Routing (from the frame window to its view and other command targets)](../vs140/command-routing.md)  
  
-   [Document /View Architecture](../vs140/document-view-architecture.md)  
  
-   [Control bars](../vs140/control-bars.md)  
  
-   [Controls](../vs140/controls--mfc-.md)  
  
## See Also  
 [Frame Windows](../vs140/frame-windows.md)