---
title: "MFC Toolbar Implementation"
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
  - "toolbars [C++], creating"
  - "buttons [C++], MFC toolbars"
  - "toolbars [C++], docking"
  - "CToolBar class, creating toolbars"
  - "MFC toolbars"
  - "floating toolbars"
  - "toolbars [C++], floating"
  - "docking toolbars"
  - "bitmaps [C++], toolbar"
  - "toolbar controls [MFC]"
  - "CToolBarCtrl class, implementing toolbars"
  - "tool tips [C++], enabling"
  - "toolbars [C++]"
  - "toolbars [C++], implementing MFC toolbars"
ms.assetid: af3319ad-c430-4f90-8361-e6a2c06fd084
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# MFC Toolbar Implementation
A toolbar is a [control bar](../vs140/control-bars.md) that contains the bitmap images of controls. These images can behave like pushbuttons, check boxes, or radio buttons. MFC supplies class [CToolbar](../vs140/ctoolbar-class.md) to manage toolbars.  
  
 If you enable it, users of MFC toolbars can dock them to the edge of a window or "float" them anywhere within the application window. MFC doesn't support customizable toolbars like those in the development environment.  
  
 MFC also supports tool tips: small pop-up windows that describe a toolbar button's purpose when you position the mouse over the button. By default, when the user presses a toolbar button, a status string appears in the status bar (if there is one). You can activate "fly by" status bar updating to display the status string when the mouse is positioned over the button without pressing it.  
  
> [!NOTE]
>  As of MFC version 4.0, toolbars and tool tips are implemented using Windows 95 and later functionality instead of the previous implementation specific to MFC.  
  
 For backward compatibility, MFC retains the older toolbar implementation in class **COldToolBar**. The documentation for earlier versions of MFC describe **COldToolBar** under `CToolBar`.  
  
 Create the first toolbar in your program by selecting the Toolbar option in the Application Wizard. You can also create additional toolbars.  
  
 The following are introduced in this article:  
  
-   [Toolbar buttons](#_core_toolbar_buttons)  
  
-   [Docking and floating toolbars](#_core_docking_and_floating_toolbars)  
  
-   [Toolbars and tool tips](#_core_toolbars_and_tool_tips)  
  
-   [The CToolBar and CToolBarCtrl classes](#_core_the_ctoolbar_and_ctoolbarctrl_classes)  
  
-   [The Toolbar bitmap](#_core_the_toolbar_bitmap)  
  
##  <a name="_core_toolbar_buttons"></a> Toolbar Buttons  
 The buttons in a toolbar are analogous to the items in a menu. Both kinds of user-interface objects generate commands, which your program handles by providing handler functions. Often toolbar buttons duplicate the functionality of menu commands, providing an alternative user interface to the same functionality. Such duplication is arranged simply by giving the button and the menu item the same ID.  
  
 You can make the buttons in a toolbar appear and behave as pushbuttons, check boxes, or radio buttons. For more information, see class [CToolBar](../vs140/ctoolbar-class.md).  
  
##  <a name="_core_docking_and_floating_toolbars"></a> Docking and Floating Toolbars  
 An MFC toolbar can:  
  
-   Remain stationary along one side of its parent window.  
  
-   Be dragged and "docked," or attached, by the user to any side or sides of the parent window you specify.  
  
-   Be "floated," or detached from the frame window, in its own mini-frame window so the user can move it around to any convenient position.  
  
-   Be resized while floating.  
  
 For more information, see the article [Docking and Floating Toolbars](../vs140/docking-and-floating-toolbars.md).  
  
##  <a name="_core_toolbars_and_tool_tips"></a> Toolbars and Tool Tips  
 MFC toolbars can also be made to display "tool tips" — tiny popup windows containing a short text description of a toolbar button's purpose. As the user moves the mouse over a toolbar button, the tool tip window pops up to offer a hint. For more information, see the article [Toolbar Tool Tips](../vs140/toolbar-tool-tips.md).  
  
##  <a name="_core_the_ctoolbar_and_ctoolbarctrl_classes"></a> The CToolBar and CToolBarCtrl Classes  
 You manage your application's toolbars via class [CToolBar](../vs140/ctoolbar-class.md). As of MFC version 4.0, `CToolBar` has been reimplemented to use the toolbar common control available under Windows 95 or later and Windows NT version 3.51 or later.  
  
 This reimplementation results in less MFC code for toolbars, because MFC makes use of the operating system support. The reimplementation also improves capability. You can use `CToolBar` member functions to manipulate toolbars, or you can obtain a reference to the underlying [CToolBarCtrl](../vs140/ctoolbarctrl-class.md) object and call its member functions for toolbar customization and additional functionality.  
  
> [!TIP]
>  If you have invested heavily in the older MFC implementation of `CToolBar`, that support is still available. See the article [Using Your Old Toolbars](../vs140/using-your-old-toolbars.md).  
  
 Also see the MFC General sample [DOCKTOOL](../vs140/visual-c---samples.md).  
  
##  <a name="_core_the_toolbar_bitmap"></a> The Toolbar Bitmap  
 Once constructed, a `CToolBar` object creates the toolbar image by loading a single bitmap that contains one image for each button. The Application Wizard creates a standard toolbar bitmap that you can customize with the Visual C++ [toolbar editor](../vs140/toolbar-editor.md).  
  
### What do you want to know more about?  
  
-   [Toolbar fundamentals](../vs140/toolbar-fundamentals.md)  
  
-   [Docking and floating toolbars](../vs140/docking-and-floating-toolbars.md)  
  
-   [Toolbar tool tips](../vs140/toolbar-tool-tips.md)  
  
-   [Working with the Toolbar Control](../vs140/working-with-the-toolbar-control.md)  
  
-   [Using Your Old Toolbars](../vs140/using-your-old-toolbars.md)  
  
-   The [CToolBar](../vs140/ctoolbar-class.md) and [CToolBarCtrl](../vs140/ctoolbarctrl-class.md) classes  
  
## See Also  
 [Toolbars](../vs140/toolbars.md)   
 [Toolbar Editor](../vs140/toolbar-editor.md)