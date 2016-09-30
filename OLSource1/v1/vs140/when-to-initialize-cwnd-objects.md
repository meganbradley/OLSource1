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
You cannot create your own child windows or call any Windows API functions in the constructor of a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>-derived object. This is because the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> for the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object has not been created yet. Most Windows-specific initialization, such as adding child windows, must be done in an [OnCreate](../vs140/cwnd--oncreate.md) message handler.  
  
## What do you want to know more about?  
  
-   [Creating document frame windows](../vs140/creating-document-frame-windows.md)  
  
-   [Document/view creation](../vs140/document-view-creation.md)  
  
## See Also  
 [Using Frame Windows](../vs140/using-frame-windows.md)