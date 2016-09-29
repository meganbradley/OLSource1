---
title: "Frame Windows"
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
  - "document frame windows"
  - "windows [C++], MDI"
  - "window classes [C++], frame"
  - "single document interface (SDI)"
  - "single document interface (SDI), frame windows"
  - "views [C++], and frame windows"
  - "CFrameWnd class, frame windows"
  - "frame windows [C++]"
  - "frame windows [C++], about frame widows"
  - "MFC [C++], frame windows"
  - "MDI [C++], frame windows"
  - "splitter windows, and frame windows"
ms.assetid: 40677339-8135-4f5e-aba6-3fced3078077
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Frame Windows
When an application runs under Windows, the user interacts with documents displayed in frame windows. A document frame window has two major components: the frame and the contents that it frames. A document frame window can be a [single document interface](../VS_csharp/sdi-and-mdi.md) (SDI) frame window or a [multiple document interface](../VS_csharp/sdi-and-mdi.md) (MDI) child window. Windows manages most of the user's interaction with the frame window: moving and resizing the window, closing it, and minimizing and maximizing it. You manage the contents inside the frame.  
  
## Frame Windows and Views  
 The MFC framework uses frame windows to contain views. The two components — frame and contents — are represented and managed by two different classes in MFC. A frame-window class manages the frame, and a view class manages the contents. The view window is a child of the frame window. Drawing and other user interaction with the document take place in the view's client area, not the frame window's client area. The frame window provides a visible frame around a view, complete with a caption bar and standard window controls such as a control menu, buttons to minimize and maximize the window, and controls for resizing the window. The "contents" consist of the window's client area, which is fully occupied by a child window — the view. The following figure shows the relationship between a frame window and a view.  
  
 ![Frame window view](../VS_csharp/media/vc37fx1.gif "vc37FX1")  
Frame Window and View  
  
## Frame Windows and Splitter Windows  
 Another common arrangement is for the frame window to frame multiple views, usually using a [splitter window](../VS_csharp/multiple-document-types--views--and-frame-windows.md). In a splitter window, the frame window's client area is occupied by a splitter window, which in turn has multiple child windows, called panes, which are views.  
  
### What do you want to know more about?  
 **General Frame Window Topics**  
  
-   [Window objects](../VS_csharp/window-objects.md)  
  
-   [Frame window classes](../VS_csharp/frame-window-classes.md)  
  
-   [The Frame-Window classes created by the Application Wizard](../VS_csharp/frame-window-classes-created-by-the-application-wizard.md)  
  
-   [Frame window styles](../VS_csharp/frame-window-styles--c---.md)  
  
-   [What frame windows do](../VS_csharp/what-frame-windows-do.md)  
  
 **Topics on Using Frame Windows**  
  
-   [Using frame windows](../VS_csharp/using-frame-windows.md)  
  
-   [Creating document frame windows](../VS_csharp/creating-document-frame-windows.md)  
  
-   [Destroying frame windows](../VS_csharp/destroying-frame-windows.md)  
  
-   [Managing MDI child windows](../VS_csharp/managing-mdi-child-windows.md)  
  
-   [Managing the current view](../VS_csharp/managing-the-current-view.md) in a frame window that contains more than one view  
  
-   [Managing menus, control bars, and accelerators (other objects that share the frame window's space)](../VS_csharp/managing-menus--control-bars--and-accelerators.md)  
  
 **Topics on Special Frame Window Capabilities**  
  
-   [Dragging and dropping files](../VS_csharp/dragging-and-dropping-files-in-a-frame-window.md) from File Explorer or File Manager into a frame window  
  
-   [Responding to dynamic data exchange (DDE)](../VS_csharp/responding-to-dynamic-data-exchange--dde-.md)  
  
-   [Semimodal states: Context-sensitive Windows Help (Orchestrating other window actions)](../VS_csharp/orchestrating-other-window-actions.md)  
  
-   [Semimodal states: printing and print preview (Orchestrating other window actions)](../VS_csharp/orchestrating-other-window-actions.md)  
  
 **Topics on Other Kinds of Windows**  
  
-   [Using Views](../VS_csharp/using-views.md)  
  
-   [Dialog boxes](../VS_csharp/dialog-boxes.md)  
  
-   [Controls](../VS_csharp/controls--mfc-.md)  
  
## See Also  
 [Windows](../VS_csharp/windows.md)