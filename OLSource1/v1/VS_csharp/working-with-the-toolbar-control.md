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
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Working with the Toolbar Control
This article explains how you can access the [CToolBarCtrl](../VS_csharp/ctoolbarctrl-class.md) object underlying a [CToolBar](../VS_csharp/ctoolbar-class.md) for greater control over your toolbars. This is an advanced topic.  
  
## Procedures  
  
#### To access the toolbar common control underlying your CToolBar object  
  
1.  Call [CToolBar::GetToolBarCtrl](../Topic/CToolBar::GetToolBarCtrl.md).  
  
 `GetToolBarCtrl` returns a reference to a [CToolBarCtrl](../VS_csharp/ctoolbarctrl-class.md) object. You can use the reference to call member functions of the toolbar control class.  
  
> [!CAUTION]
>  While calling `CToolBarCtrl` **Get** functions is safe, use caution if you call the **Set** functions. This is an advanced topic. Normally you shouldn't need to access the underlying toolbar control.  
  
### What do you want to know more about?  
  
-   [Controls (Windows common controls)](../VS_csharp/controls--mfc-.md)  
  
-   [Toolbar fundamentals](../VS_csharp/toolbar-fundamentals.md)  
  
-   [Docking and floating toolbars](../VS_csharp/docking-and-floating-toolbars.md)  
  
-   [Dynamically resizing the toolbar](../VS_csharp/docking-and-floating-toolbars.md)  
  
-   [Toolbar tool tips](../VS_csharp/toolbar-tool-tips.md)  
  
-   [Flyby status bar updates](../VS_csharp/toolbar-tool-tips.md)  
  
-   [Handling tool tip notifications](../VS_csharp/handling-tool-tip-notifications.md)  
  
-   The [CToolBar](../VS_csharp/ctoolbar-class.md) and [CToolBarCtrl](../VS_csharp/ctoolbarctrl-class.md) classes  
  
-   [Handling customization notifications](../VS_csharp/handling-customization-notifications.md)  
  
-   [Multiple toolbars](../VS_csharp/toolbar-fundamentals.md)  
  
-   [Using your old toolbars](../VS_csharp/using-your-old-toolbars.md)  
  
-   [Control bars](../VS_csharp/control-bars.md)  
  
 For general information about using Windows common controls, see [Common Controls](http://msdn.microsoft.com/library/windows/desktop/bb775493).  
  
## See Also  
 [MFC Toolbar Implementation](../VS_csharp/mfc-toolbar-implementation.md)