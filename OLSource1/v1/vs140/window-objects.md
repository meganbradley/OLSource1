---
title: "Window Objects"
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
  - "objects [C++], window"
  - "Windows window [C++]"
  - "MFC [C++], windows"
  - "frame windows [C++], C++ window objects"
  - "window objects [C++]"
  - "windows [C++], C++ window objects"
  - "window messages [C++]"
  - "HWND"
  - "messages [C++], Windows"
  - "Visual C++, window objects"
  - "HWND, window objects"
ms.assetid: 28b33ce2-af05-4617-9d03-1cb9a02be687
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Window Objects
MFC supplies class [CWnd](../vs140/cwnd-class.md) to encapsulate the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> handle of a window. The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object is a C++ window object, distinct from the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> that represents a Windows window but containing it. Use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to derive your own child window classes, or use one of the many MFC classes derived from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Class <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is the base class for all windows, including frame windows, dialog boxes, child windows, controls, and control bars such as toolbars. A good understanding of [the relationship between a C++ window object and an HWND](../vs140/relationship-between-a-c---window-object-and-an-hwnd.md) is crucial for effective programming with MFC.  
  
 MFC provides some default functionality and management of windows, but you can derive your own class from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and use its member functions to customize the provided functionality. You can create child windows by constructing a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object and calling its [Create](../vs140/cwnd--create.md) member function, then customize the child windows using <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> member functions. You can embed objects derived from [CView](../vs140/cview-class.md), such as form views or tree views, in a frame window. And you can support multiple views of your documents via splitter panes, supplied by class [CSplitterWnd](../vs140/csplitterwnd-class.md).  
  
 Each object derived from class <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> contains a message map, through which you can map Windows messages or command IDs to your own handlers.  
  
 The general literature on programming for Windows is a good resource for learning how to use the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> member functions, which encapsulate the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> APIs.  
  
## Functions for Operating On a CWnd  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and its [derived window classes](../vs140/derived-window-classes.md) provide constructors, destructors, and member functions to initialize the object, create the underlying Windows structures, and access the encapsulated <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> also provides member functions that encapsulate Windows APIs for sending messages, accessing the window's state, converting coordinates, updating, scrolling, accessing the Clipboard, and many other tasks. Most Windows window-management APIs that take an <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> argument are encapsulated as member functions of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. The names of the functions and their parameters are preserved in the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> member function. For details about the Windows APIs encapsulated by <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, see class [CWnd](../vs140/cwnd-class.md).  
  
## CWnd and Windows Messages  
 One of the primary purposes of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is to provide an interface for handling Windows messages, such as <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. Many of the member functions of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> are handlers for standard messages — those beginning with the identifier **afx_msg** and the prefix "On," such as <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and **OnMouseMove**. [Message Handling and Mapping](../vs140/message-handling-and-mapping.md) covers messages and message handling in detail. The information there applies equally to the framework's windows and those that you create yourself for special purposes.  
  
### What do you want to know more about?  
  
-   [The relationship between a C++ window object and an HWND](../vs140/relationship-between-a-c---window-object-and-an-hwnd.md)  
  
-   [Derived window classes](../vs140/derived-window-classes.md)  
  
-   [Creating windows](../vs140/creating-windows.md)  
  
-   [Destroying window objects](../vs140/destroying-window-objects.md)  
  
-   [Detaching a CWnd from Its HWND](../vs140/detaching-a-cwnd-from-its-hwnd.md)  
  
-   [Working with window objects](../vs140/working-with-window-objects.md)  
  
-   [Device contexts](../vs140/device-contexts.md): objects that make Windows drawing device independent  
  
-   [Graphic objects](../vs140/graphic-objects.md): pens, brushes, fonts, bitmaps, palettes, regions  
  
## See Also  
 [Windows](../vs140/windows.md)