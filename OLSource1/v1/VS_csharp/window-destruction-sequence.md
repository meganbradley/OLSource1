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
In the MFC framework, when the user closes the frame window, the window's default [OnClose](../Topic/CWnd::OnClose.md) handler calls [DestroyWindow](../Topic/CWnd::DestroyWindow.md). The last member function called when the Windows window is destroyed is [OnNcDestroy](../Topic/CWnd::OnNcDestroy.md), which does some cleanup, calls the [Default](../Topic/CWnd::Default.md) member function to perform Windows cleanup, and lastly calls the virtual member function [PostNcDestroy](../Topic/CWnd::PostNcDestroy.md). The [CFrameWnd](../VS_csharp/cframewnd-class.md) implementation of `PostNcDestroy` deletes the C++ window object.  
  
## What do you want to know more about?  
  
-   [Allocating and deallocating window memory](../VS_csharp/allocating-and-deallocating-window-memory.md)  
  
-   [Detaching a CWnd from its HWND](../VS_csharp/detaching-a-cwnd-from-its-hwnd.md)  
  
## See Also  
 [Destroying Window Objects](../VS_csharp/destroying-window-objects.md)