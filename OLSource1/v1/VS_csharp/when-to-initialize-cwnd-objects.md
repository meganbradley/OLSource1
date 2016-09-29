---
title: "When to Initialize CWnd Objects"
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
  - "window objects, when to initialize CWnd"
  - "initializing CWnd objects"
  - "initializing objects, CWnd"
  - "CWnd objects, when HWND is attached"
  - "HWND, when attached to CWnd object"
  - "CWnd objects, when to initialize"
ms.assetid: 4d31bcb1-73db-4f2f-b71c-89b087569a10
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# When to Initialize CWnd Objects
You cannot create your own child windows or call any Windows API functions in the constructor of a `CWnd`-derived object. This is because the `HWND` for the `CWnd` object has not been created yet. Most Windows-specific initialization, such as adding child windows, must be done in an [OnCreate](../Topic/CWnd::OnCreate.md) message handler.  
  
## What do you want to know more about?  
  
-   [Creating document frame windows](../VS_csharp/creating-document-frame-windows.md)  
  
-   [Document/view creation](../VS_csharp/document-view-creation.md)  
  
## See Also  
 [Using Frame Windows](../VS_csharp/using-frame-windows.md)