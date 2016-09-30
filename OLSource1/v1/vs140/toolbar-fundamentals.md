---
title: "Toolbar Fundamentals"
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
  - "RT_TOOLBAR"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "embedding toolbar in frame window class"
  - "application wizards [C++], installing default application toolbars"
  - "toolbars [C++], creating"
  - "resources [MFC], toolbar"
  - "toolbar controls [MFC], toolbars created using Application Wizard"
  - "toolbar controls [MFC], command ID"
  - "RT_TOOLBAR resource"
  - "toolbars [C++], adding default using Application Wizard"
  - "LoadBitmap method, toolbars"
  - "Toolbar editor, Application Wizard"
  - "command IDs, toolbar buttons"
  - "SetButtons method"
  - "CToolBar class, default toolbars in Application Wizard"
  - "frame window classes, toolbar embedded in"
  - "LoadToolBar method"
ms.assetid: cc00aaff-8a56-433b-b0c0-b857d76b4ffd
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Toolbar Fundamentals
This article describes the fundamental MFC implementation that lets you add a default toolbar to your application by selecting an option in the Application Wizard. Topics covered include:  
  
-   [The Application Wizard toolbar option](#_core_the_appwizard_toolbar_option)  
  
-   [The toolbar in code](#_core_the_toolbar_in_code)  
  
-   [Editing the toolbar resource](#_core_editing_the_toolbar_resource)  
  
-   [Multiple toolbars](#_core_multiple_toolbars)  
  
##  \<a name="_core_the_appwizard_toolbar_option">\</a> The Application Wizard Toolbar Option  
 To get a single toolbar with default buttons, select the Standard Docking toolbar option on the page labeled User Interface Features. This adds code to your application that:  
  
-   Creates the toolbar object.  
  
-   Manages the toolbar, including its ability to dock or to float.  
  
##  \<a name="_core_the_toolbar_in_code">\</a> The Toolbar in Code  
 The toolbar is a [CToolBar](../vs140/ctoolbar-class.md) object declared as a data member of your application's **CMainFrame** class. In other words, the toolbar object is embedded in the main frame window object. This means that MFC creates the toolbar when it creates the frame window and destroys the toolbar when it destroys the frame window. The following partial class declaration, for a multiple document interface (MDI) application, shows data members for an embedded toolbar and an embedded status bar. It also shows the override of the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> member function.  
  
 [!code[NVC_MFCListView#6](../vs140/codesnippet/CPP/toolbar-fundamentals_1.h)]  
  
 Toolbar creation occurs in **CMainFrame::OnCreate**. MFC calls [OnCreate](../vs140/cwnd--oncreate.md) after creating the window for the frame but before it becomes visible. The default <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> that the Application Wizard generates does the following toolbar tasks:  
  
1.  Calls the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object's [Create](../vs140/ctoolbar--create.md) member function to create the underlying [CToolBarCtrl](../vs140/ctoolbarctrl-class.md) object.  
  
2.  Calls [LoadToolBar](../vs140/ctoolbar--loadtoolbar.md) to load the toolbar resource information.  
  
3.  Calls functions to enable docking, floating, and tool tips. For details about these calls, see the article [Docking and Floating Toolbars](../vs140/docking-and-floating-toolbars.md).  
  
> [!NOTE]
>  The MFC General sample [DOCKTOOL](../vs140/visual-c---samples.md) includes illustrations of both old and new MFC toolbars. The toolbars that use **COldToolbar** require calls in step 2 to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> (rather than <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) and to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. The new toolbars require calls to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 The docking, floating, and tool tips calls are optional. You can remove those lines from <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if you prefer. The result is a toolbar that remains fixed, unable to float or redock and unable to display tool tips.  
  
##  \<a name="_core_editing_the_toolbar_resource">\</a> Editing the Toolbar Resource  
 The default toolbar you get with the Application Wizard is based on an **RT_TOOLBAR** custom resource, introduced in MFC version 4.0. You can edit this resource with the [toolbar editor](../vs140/toolbar-editor.md). The editor lets you easily add, delete, and rearrange buttons. It contains a graphical editor for the buttons that is very similar to the general graphics editor in Visual C++. If you edited toolbars in previous versions of Visual C++, you'll find the task much easier now.  
  
 To connect a toolbar button to a command, you give the button a command ID, such as <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Specify the command ID in the button's property page in the toolbar editor. Then create a handler function for the command (see [Mapping Messages to Functions](../vs140/mapping-messages-to-functions.md) for more information).  
  
 New [CToolBar](../vs140/ctoolbar-class.md) member functions work with the **RT_TOOLBAR** resource. [LoadToolBar](../vs140/ctoolbar--loadtoolbar.md) now takes the place of [LoadBitmap](../vs140/ctoolbar--loadbitmap.md) to load the bitmap of the toolbar button images, and [SetButtons](../vs140/ctoolbar--setbuttons.md) to set the button styles and connect buttons with bitmap images.  
  
 For details about using the toolbar editor, see [Toolbar Editor](../vs140/toolbar-editor.md).  
  
##  \<a name="_core_multiple_toolbars">\</a> Multiple Toolbars  
 The Application Wizard provides you with one default toolbar. If you need more than one toolbar in your application, you can model your code for additional toolbars based on the wizard-generated code for the default toolbar.  
  
 If you want to display a toolbar as the result of a command, you'll need to:  
  
-   Create a new toolbar resource with the toolbar editor and load it in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> with the [LoadToolbar](../vs140/ctoolbar--loadtoolbar.md) member function.  
  
-   Embed a new [CToolBar](../vs140/ctoolbar-class.md) object in your main frame window class.  
  
-   Make the appropriate function calls in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to dock or float the toolbar, set its styles, and so on.  
  
### What do you want to know more about?  
  
-   [MFC Toolbar Implementation (overview information on toolbars)](../vs140/mfc-toolbar-implementation.md)  
  
-   [Docking and floating toolbars](../vs140/docking-and-floating-toolbars.md)  
  
-   [Toolbar tool tips](../vs140/toolbar-tool-tips.md)  
  
-   The [CToolBar](../vs140/ctoolbar-class.md) and [CToolBarCtrl](../vs140/ctoolbarctrl-class.md) classes  
  
-   [Working with the toolbar control](../vs140/working-with-the-toolbar-control.md)  
  
-   [Using your old toolbars](../vs140/using-your-old-toolbars.md)  
  
## See Also  
 [MFC Toolbar Implementation](../vs140/mfc-toolbar-implementation.md)