---
title: "Window Destruction Sequence"
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
  - "destruction, windows"
  - "destroying windows"
  - "sequence [C++], window destruction"
  - "CWnd objects, destruction sequence"
  - "sequence [C++]"
  - "windows [C++], destroying"
ms.assetid: 2d819196-6240-415f-a308-db43745e616c
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Window Destruction Sequence
In the MFC framework, when the user closes the frame window, the window's default [OnClose](../vs140/cwnd--onclose.md) handler calls [DestroyWindow](../vs140/cwnd--destroywindow.md). The last member function called when the Windows window is destroyed is [OnNcDestroy](../vs140/cwnd--onncdestroy.md), which does some cleanup, calls the [Default](../vs140/cwnd--default.md) member function to perform Windows cleanup, and lastly calls the virtual member function [PostNcDestroy](../vs140/cwnd--postncdestroy.md). The [CFrameWnd](../vs140/cframewnd-class.md) implementation of <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> deletes the C++ window object.  
  
## What do you want to know more about?  
  
-   [Allocating and deallocating window memory](../vs140/allocating-and-deallocating-window-memory.md)  
  
-   [Detaching a CWnd from its HWND](../vs140/detaching-a-cwnd-from-its-hwnd.md)  
  
## See Also  
 [Destroying Window Objects](../vs140/destroying-window-objects.md)