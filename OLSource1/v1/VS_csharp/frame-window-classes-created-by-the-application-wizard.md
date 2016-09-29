---
title: "Frame-Window Classes Created by the Application Wizard"
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
  - "CMainFrame"
  - "CMainFrame::PreCreateWindow"
  - "CMainFrame.PreCreateWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "application wizards [C++], frame window classes created by"
  - "window classes"
  - "classes [C++], frame-window"
  - "CMDIFrameWnd class, frame windows"
  - "window classes, frame"
  - "CFrameWnd class, frame windows"
  - "CMDIChildWnd class, frame windows"
  - "frame window classes, created by application wizards"
  - "CMainFrame class"
ms.assetid: 9947df73-4470-49a0-ac61-7b6ee401a74e
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Frame-Window Classes Created by the Application Wizard
When you use the [Application Wizard](../VS_csharp/creating-desktop-projects-by-using-application-wizards.md) to create a skeleton application, in addition to application, document, and view classes, the Application Wizard creates a derived frame-window class for your application's main frame window. The class is called `CMainFrame` by default, and the files that contain it are named MAINFRM.H and MAINFRM.CPP.  
  
 If your application is SDI, your `CMainFrame` class is derived from class [CFrameWnd](../VS_csharp/cframewnd-class.md).  
  
 If your application is MDI, `CMainFrame` is derived from class [CMDIFrameWnd](../VS_csharp/cmdiframewnd-class.md). In this case `CMainFrame` implements the main frame, which holds the menu, toolbar, and status bars. The Application Wizard does not derive a new document frame-window class for you. Instead, it uses the default implementation in [CMDIChildWnd Class](../VS_csharp/cmdichildwnd-class.md). The MFC framework creates a child window to contain each view (which can be of type `CScrollView`, `CEditView`, `CTreeView`, `CListView`, and so on) that the application requires. If you need to customize your document frame window, you can create a new document frame-window class (see [Adding a Class](../VS_csharp/adding-a-class--visual-c---.md)).  
  
 If you choose to support a toolbar, the class also has member variables of type [CToolBar](../VS_csharp/ctoolbar-class.md) and [CStatusBar](../VS_csharp/cstatusbar-class.md) and an `OnCreate` message-handler function to initialize the two [control bars](../VS_csharp/control-bars.md).  
  
 These frame-window classes work as created, but to enhance their functionality, you must add member variables and member functions. You may also want to have your window classes handle other Windows messages. For more information, see [Changing the Styles of a Window Created by MFC](../VS_csharp/changing-the-styles-of-a-window-created-by-mfc.md).  
  
## See Also  
 [Frame-Window Classes](../VS_csharp/frame-window-classes.md)   
 [MFC Program or Control Source and Header Files](../VS_csharp/mfc-program-or-control-source-and-header-files.md)