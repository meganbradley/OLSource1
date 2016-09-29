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
  
-   [_U_MENUorID](../VS_csharp/_u_menuorid-class.md) Provides wrappers for **CreateWindow** and **CreateWindowEx**.  
  
-   [CWindow](../VS_csharp/cwindow-class.md) Contains methods for manipulating a window. `CWindow` is the base class for `CWindowImpl`, `CDialogImpl`, and `CContainedWindow`.  
  
-   [CWindowImpl](../VS_csharp/cwindowimpl-class.md) Implements a window based on a new window class. Also allows you to subclass or superclass the window.  
  
-   [CDialogImpl](../VS_csharp/cdialogimpl-class.md) Implements a dialog box.  
  
-   [CAxDialogImpl](../VS_csharp/caxdialogimpl-class.md) Implements a dialog box (modal or modeless) that hosts ActiveX controls.  
  
-   [CSimpleDialog](../VS_csharp/csimpledialog-class.md) Implements a dialog box (modal or modeless) with basic functionality.  
  
-   [CAxWindow](../VS_csharp/caxwindow-class.md) Manipulates a window that hosts an ActiveX control.  
  
-   [CAxWindow2T](../VS_csharp/caxwindow2t-class.md) Provides methods for manipulating a window that hosts an ActiveX control and also has support for hosting licensed ActiveX controls.  
  
-   [CContainedWindowT](../VS_csharp/ccontainedwindowt-class.md) Implements a window contained within another object.  
  
-   [CWndClassInfo](../VS_csharp/cwndclassinfo-class.md) Manages the information of a new window class.  
  
-   [CDynamicChain](../VS_csharp/cdynamicchain-class.md) Supports dynamic chaining of message maps.  
  
-   [CMessageMap](../VS_csharp/cmessagemap-class.md) Allows an object to expose its message maps to other objects.  
  
-   [CWinTraits](../VS_csharp/cwintraits-class.md) Provides a simple method of standardizing the traits of an ATL window object.  
  
-   [CWinTraitsOR](../VS_csharp/cwintraitsor-class.md) Provides default values for window styles and extended styles used to create a window. These values are added, using the logical-OR operator, to values provided during the creation of a window.  
  
## Related Articles  
 [ATL Window Classes](../VS_csharp/atl-window-classes.md)  
  
 [ATL Tutorial](../VS_csharp/active-template-library--atl--tutorial.md)  
  
## See Also  
 [Class Overview](../VS_csharp/atl-class-overview.md)   
 [Message Map Macros](../VS_csharp/message-map-macros--atl-.md)   
 [Window Class Macros](../VS_csharp/window-class-macros.md)