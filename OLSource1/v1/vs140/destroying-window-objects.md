---
title: "Destroying Window Objects"
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
  - "frame windows, destroying"
  - "window objects, deleting"
  - "window objects, destroying"
  - "window objects, removing"
ms.assetid: 3241fea0-c614-4a25-957d-20f21bd5fd0c
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Destroying Window Objects
Care must be taken with your own child windows to destroy the C++ window object when the user is finished with the window. If these objects are not destroyed, your application will not recover their memory. Fortunately, the framework manages window destruction as well as creation for frame windows, views, and dialog boxes. If you create additional windows, you are responsible for destroying them.  
  
## What do you want to know more about?  
  
-   [Window destruction sequence](../vs140/window-destruction-sequence.md)  
  
-   [Allocating and deallocating window memory](../vs140/allocating-and-deallocating-window-memory.md)  
  
-   [Detaching a CWnd from its HWND](../vs140/detaching-a-cwnd-from-its-hwnd.md)  
  
-   [General Window Creation Sequence](../vs140/general-window-creation-sequence.md)  
  
-   [Destroying frame windows](../vs140/destroying-frame-windows.md)  
  
## See Also  
 [Window Objects](../vs140/window-objects.md)