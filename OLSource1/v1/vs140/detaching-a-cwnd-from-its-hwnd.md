---
title: "Detaching a CWnd from Its HWND"
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
  - "CWnd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HWND, detaching CWnd from"
  - "removing HWNDs from CWnds"
  - "CWnd objects, detaching from HWND"
  - "detaching CWnds from HWNDs"
  - "Detach method (CWnd class)"
ms.assetid: 6efadf84-0517-4a3f-acfd-216e088f19c6
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Detaching a CWnd from Its HWND
If you need to circumvent the object-`HWND` relationship, MFC provides another `CWnd` member function, [Detach](../vs140/cwnd--detach.md), which disconnects the C++ window object from the Windows window. This prevents the destructor from destroying the Windows window when the object is destroyed.  
  
## What do you want to know more about?  
  
-   [Creating windows](../vs140/creating-windows.md)  
  
-   [Window destruction sequence](../vs140/window-destruction-sequence.md)  
  
-   [Allocating and deallocating window memory](../vs140/allocating-and-deallocating-window-memory.md)  
  
## See Also  
 [Window Objects](../vs140/window-objects.md)