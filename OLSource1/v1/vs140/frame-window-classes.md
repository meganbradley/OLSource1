---
title: "Frame-Window Classes"
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
  - "frame window classes, about frame window classes"
  - "frame window classes"
  - "windows [C++], MDI"
  - "document frame windows, classes"
  - "single document interface (SDI), frame windows"
  - "window classes, frame"
  - "MFC [C++], frame windows"
  - "MDI [C++], frame windows"
  - "classes [C++], window"
ms.assetid: c27e43a7-8ad0-4759-b1b7-43f4725f4132
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Frame-Window Classes
Each application has one "main frame window," a desktop window that usually has the application name in its caption. Each document usually has one "document frame window." A document frame window contains at least one view, which presents the document's data.  
  
## Frame Windows in SDI and MDI Applications  
 For an SDI application, there is one frame window derived from class [CFrameWnd](../vs140/cframewnd-class.md). This window is both the main frame window and the document frame window. For an MDI application, the main frame window is derived from class [CMDIFrameWnd](../vs140/cmdiframewnd-class.md), and the document frame windows, which are MDI child windows, are derived from class [CMDIChildWnd](../vs140/cmdichildwnd-class.md).  
  
## Use the Frame-Window Class, or Derive from It?  
 These classes provide most of the frame-window functionality you need for your applications. Under normal circumstances, the default behavior and appearance they provide will suit your needs. If you need additional functionality, derive from these classes.  
  
### What do you want to know more about?  
  
-   [Frame-window classes created by the Application Wizard](../vs140/frame-window-classes-created-by-the-application-wizard.md)  
  
-   [Frame-window styles](../vs140/frame-window-styles--c---.md)  
  
-   [Changing the styles of a window created by MFC](../vs140/changing-the-styles-of-a-window-created-by-mfc.md)  
  
## See Also  
 [Frame Windows](../vs140/frame-windows.md)