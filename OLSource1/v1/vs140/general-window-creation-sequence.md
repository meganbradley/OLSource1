---
title: "General Window Creation Sequence"
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
  - "sequence [C++], window creation"
  - "frame windows [C++], creating"
  - "windows [C++], creating"
  - "sequence [C++]"
ms.assetid: 9cd8c7ea-5e24-429e-b6d9-d7b6041d8ba6
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# General Window Creation Sequence
When you create a window of your own, such as a child window, the framework uses much the same process as that described in [Document/View Creation](../vs140/document-view-creation.md).  
  
 All the window classes provided by MFC employ [two-stage construction](../vs140/one-stage-and-two-stage-construction-of-objects.md). That is, during an invocation of the C++ **new** operator, the constructor allocates and initializes a C++ object but does not create a corresponding Windows window. That is done afterward by calling the [Create](../vs140/cwnd--create.md) member function of the window object.  
  
 The **Create** member function makes the Windows window and stores its `HWND` in the C++ object's public data member [m_hWnd](../vs140/cwnd--m_hwnd.md). **Create** gives complete flexibility over the creation parameters. Before calling **Create**, you may want to register a window class with the global function [AfxRegisterWndClass](../vs140/afxregisterwndclass.md) in order to set the icon and class styles for the frame.  
  
 For frame windows, you can use the [LoadFrame](../vs140/cframewnd--loadframe.md) member function instead of **Create**. `LoadFrame` makes the Windows window using fewer parameters. It gets many default values from resources, including the frame's caption, icon, accelerator table, and menu.  
  
> [!NOTE]
>  Your icon, accelerator table, and menu resources must have a common resource ID, such as **IDR_MAINFRAME**, for them to be loaded by LoadFrame.  
  
## What do you want to know more about?  
  
-   [Window objects](../vs140/window-objects.md)  
  
-   [Registering window "classes"](../vs140/registering-window-classes.md)  
  
-   [Destroying window objects](../vs140/destroying-window-objects.md)  
  
-   [Creating document frame windows](../vs140/creating-document-frame-windows.md)  
  
## See Also  
 [Creating Windows](../vs140/creating-windows.md)