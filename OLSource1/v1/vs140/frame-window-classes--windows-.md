---
title: "Frame Window Classes (Windows)"
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
  - "vc.classes.frame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "frame window classes, reference"
ms.assetid: 6342ec5f-f922-4da8-a78e-2f5f994c7142
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Frame Window Classes (Windows)
Frame windows are windows that frame an application or a part of an application. Frame windows usually contain other windows, such as views, tool bars, and status bars. In the case of <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, they may contain <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> objects indirectly.  
  
 [CFrameWnd](../vs140/cframewnd-class.md)  
 The base class for an SDI application's main frame window. Also the base class for all other frame window classes.  
  
 [CMDIFrameWnd](../vs140/cmdiframewnd-class.md)  
 The base class for an MDI application's main frame window.  
  
 [CMDIChildWnd](../vs140/cmdichildwnd-class.md)  
 The base class for an MDI application's document frame windows.  
  
 [CMiniFrameWnd](../vs140/cminiframewnd-class.md)  
 A half-height frame window typically seen around floating toolbars.  
  
 [COleIPFrameWnd](../vs140/coleipframewnd-class.md)  
 Provides the frame window for a view when a server document is being edited in place.  
  
## Related Class  
 Class <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> provides an interface through which to access your application's menus. It is useful for manipulating menus dynamically at run time; for example, when adding or deleting menu items according to context. Although menus are most often used with frame windows, they can also be used with dialog boxes and other nonchild windows.  
  
 [CMenu](../vs140/cmenu-class.md)  
 Encapsulates an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> handle to the application's menu bar and pop-up menus.  
  
## See Also  
 [Class Overview](../vs140/class-library-overview.md)