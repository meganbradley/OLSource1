---
title: "Working with the Toolbar Control"
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
  - "GetToolBarCtrl method"
  - "toolbars [C++], accessing common control"
  - "CToolBarCtrl class, accessing toolbar"
  - "toolbar controls [MFC], accessing"
ms.assetid: b19409d5-3831-42c7-80ae-195c49dc9085
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Working with the Toolbar Control
This article explains how you can access the [CToolBarCtrl](../vs140/ctoolbarctrl-class.md) object underlying a [CToolBar](../vs140/ctoolbar-class.md) for greater control over your toolbars. This is an advanced topic.  
  
## Procedures  
  
#### To access the toolbar common control underlying your CToolBar object  
  
1.  Call [CToolBar::GetToolBarCtrl](../vs140/ctoolbar--gettoolbarctrl.md).  
  
 `GetToolBarCtrl` returns a reference to a [CToolBarCtrl](../vs140/ctoolbarctrl-class.md) object. You can use the reference to call member functions of the toolbar control class.  
  
> [!CAUTION]
>  While calling `CToolBarCtrl` **Get** functions is safe, use caution if you call the **Set** functions. This is an advanced topic. Normally you shouldn't need to access the underlying toolbar control.  
  
### What do you want to know more about?  
  
-   [Controls (Windows common controls)](../vs140/controls--mfc-.md)  
  
-   [Toolbar fundamentals](../vs140/toolbar-fundamentals.md)  
  
-   [Docking and floating toolbars](../vs140/docking-and-floating-toolbars.md)  
  
-   [Dynamically resizing the toolbar](../vs140/docking-and-floating-toolbars.md)  
  
-   [Toolbar tool tips](../vs140/toolbar-tool-tips.md)  
  
-   [Flyby status bar updates](../vs140/toolbar-tool-tips.md)  
  
-   [Handling tool tip notifications](../vs140/handling-tool-tip-notifications.md)  
  
-   The [CToolBar](../vs140/ctoolbar-class.md) and [CToolBarCtrl](../vs140/ctoolbarctrl-class.md) classes  
  
-   [Handling customization notifications](../vs140/handling-customization-notifications.md)  
  
-   [Multiple toolbars](../vs140/toolbar-fundamentals.md)  
  
-   [Using your old toolbars](../vs140/using-your-old-toolbars.md)  
  
-   [Control bars](../vs140/control-bars.md)  
  
 For general information about using Windows common controls, see [Common Controls](http://msdn.microsoft.com/library/windows/desktop/bb775493).  
  
## See Also  
 [MFC Toolbar Implementation](../vs140/mfc-toolbar-implementation.md)