---
title: "CWndClassInfo::m_wc"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CWndClassInfo::m_wc"
  - "CWndClassInfo.m_wc"
  - "m_wc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_wc"
ms.assetid: 240a8e76-d789-4cfe-a97c-4d819483c33b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWndClassInfo::m_wc
Maintains the window class information in a [WNDCLASSEX](http://msdn.microsoft.com/library/windows/desktop/ms633577) structure.  
  
## Syntax  
  
```  
  
WNDCLASSEX m_wc;  
  
```  
  
## Remarks  
 If you have specified the [DECLARE_WND_CLASS](../vs140/declare_wnd_class.md) (the default in [CWindowImpl](../vs140/cwindowimpl-class.md)) or the [DECLARE_WND_CLASS_EX](../vs140/declare_wnd_class_ex.md) macro, `m_wc` contains information about a new window class.  
  
 If you have specified the [DECLARE_WND_SUPERCLASS](../vs140/declare_wnd_superclass.md) macro, `m_wc` contains information about a superclass — a window class that is based on an existing class but uses a different window procedure. [m_lpszOrigName](../vs140/cwndclassinfo--m_lpszorigname.md) and [pWndProc](../vs140/cwndclassinfo--pwndproc.md) save the existing window class's name and window procedure, respectively.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWndClassInfo Class](../vs140/cwndclassinfo-class.md)