---
title: "Introduction to ATL Window Classes"
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
  - "window classes"
ms.assetid: 503efc2c-a269-495d-97cf-3fb300d52f3d
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Introduction to ATL Window Classes
The following ATL classes are designed to implement and manipulate windows:  
  
-   [CWindow](../vs140/cwindow-class.md) allows you to attach a window handle to the `CWindow` object. You then call `CWindow` methods to manipulate the window.  
  
-   [CWindowImpl](../vs140/cwindowimpl-class.md) allows you to implement a new window and process messages with a message map. You can create a window based on a new Windows class, superclass an existing class, or subclass an existing window.  
  
-   [CDialogImpl](../vs140/cdialogimpl-class.md) allows you to implement a modal or a modeless dialog box and process messages with a message map.  
  
-   [CContainedWindowT](../vs140/ccontainedwindowt-class.md) is a prebuilt class that implements a window whose message map is contained in another class. Using `CContainedWindowT` allows you to centralize message processing in one class.  
  
-   [CAxDialogImpl](../vs140/caxdialogimpl-class.md) allows you to implement a dialog box (modal or modeless) that hosts ActiveX controls.  
  
-   [CSimpleDialog](../vs140/csimpledialog-class.md) allows you to implement a modal dialog box with basic functionality.  
  
-   [CAxWindow](../vs140/caxwindow-class.md) allows you to implement a window that hosts an ActiveX control.  
  
-   [CAxWindow2T](../vs140/caxwindow2t-class.md) allows you to implement a window that hosts a licensed ActiveX control.  
  
 In addition to specific window classes, ATL provides several classes designed to make the implementation of an ATL window object easier. They are as follows:  
  
-   [CWndClassInfo](../vs140/cwndclassinfo-class.md) manages the information of a new window class.  
  
-   [CWinTraits](../vs140/cwintraits-class.md) and [CWinTraitsOR](../vs140/cwintraitsor-class.md) provide a simple method of standardizing the traits of an ATL window object.  
  
## See Also  
 [Window Classes](../vs140/atl-window-classes.md)