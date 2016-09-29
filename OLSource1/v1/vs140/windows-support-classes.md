---
title: "Windows Support Classes"
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
  - "vc.atl.windows"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATL, windows"
  - "windows [C++], ATL"
ms.assetid: 750b14d5-d787-4d2b-9728-ac199ccad489
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Windows Support Classes
The following classes provide support for windows:  
  
-   [_U_MENUorID](../vs140/_u_menuorid-class.md) Provides wrappers for **CreateWindow** and **CreateWindowEx**.  
  
-   [CWindow](../vs140/cwindow-class.md) Contains methods for manipulating a window. `CWindow` is the base class for `CWindowImpl`, `CDialogImpl`, and `CContainedWindow`.  
  
-   [CWindowImpl](../vs140/cwindowimpl-class.md) Implements a window based on a new window class. Also allows you to subclass or superclass the window.  
  
-   [CDialogImpl](../vs140/cdialogimpl-class.md) Implements a dialog box.  
  
-   [CAxDialogImpl](../vs140/caxdialogimpl-class.md) Implements a dialog box (modal or modeless) that hosts ActiveX controls.  
  
-   [CSimpleDialog](../vs140/csimpledialog-class.md) Implements a dialog box (modal or modeless) with basic functionality.  
  
-   [CAxWindow](../vs140/caxwindow-class.md) Manipulates a window that hosts an ActiveX control.  
  
-   [CAxWindow2T](../vs140/caxwindow2t-class.md) Provides methods for manipulating a window that hosts an ActiveX control and also has support for hosting licensed ActiveX controls.  
  
-   [CContainedWindowT](../vs140/ccontainedwindowt-class.md) Implements a window contained within another object.  
  
-   [CWndClassInfo](../vs140/cwndclassinfo-class.md) Manages the information of a new window class.  
  
-   [CDynamicChain](../vs140/cdynamicchain-class.md) Supports dynamic chaining of message maps.  
  
-   [CMessageMap](../vs140/cmessagemap-class.md) Allows an object to expose its message maps to other objects.  
  
-   [CWinTraits](../vs140/cwintraits-class.md) Provides a simple method of standardizing the traits of an ATL window object.  
  
-   [CWinTraitsOR](../vs140/cwintraitsor-class.md) Provides default values for window styles and extended styles used to create a window. These values are added, using the logical-OR operator, to values provided during the creation of a window.  
  
## Related Articles  
 [ATL Window Classes](../vs140/atl-window-classes.md)  
  
 [ATL Tutorial](../vs140/active-template-library--atl--tutorial.md)  
  
## See Also  
 [Class Overview](../vs140/atl-class-overview.md)   
 [Message Map Macros](../vs140/message-map-macros--atl-.md)   
 [Window Class Macros](../vs140/window-class-macros.md)