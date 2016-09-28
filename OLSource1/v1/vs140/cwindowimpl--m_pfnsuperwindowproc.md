---
title: "CWindowImpl::m_pfnSuperWindowProc"
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
  - "m_pfnSuperWindowProc"
  - "CWindowImpl.m_pfnSuperWindowProc"
  - "CWindowImpl::m_pfnSuperWindowProc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_pfnSuperWindowProc"
ms.assetid: 76f2f0df-932b-4fd1-8295-8876ff21090c
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindowImpl::m_pfnSuperWindowProc
Depending on the window, points to one of the following window procedures.  
  
## Syntax  
  
```  
  
WNDPROC m_pfnSuperWindowProc;  
  
```  
  
## Remarks  
  
|Type of window|Window procedure|  
|--------------------|----------------------|  
|A window based on a new window class, specified through the [DECLARE_WND_CLASS](../vs140/declare_wnd_class.md) macro.|The [DefWindowProc](http://msdn.microsoft.com/library/windows/desktop/ms633572) Win32 function.|  
|A window based on a window class that modifies an existing class, specified through the [DECLARE_WND_SUPERCLASS](../vs140/declare_wnd_superclass.md) macro.|The existing window class's window procedure.|  
|A subclassed window.|The subclassed window's original window procedure.|  
  
 [CWindowImpl::DefWindowProc](../vs140/cwindowimpl--defwindowproc.md) sends message information to the window procedure saved in `m_pfnSuperWindowProc`.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindowImpl Class](../vs140/cwindowimpl-class.md)   
 [CWindowImpl::Create](../vs140/cwindowimpl--create.md)   
 [CWindowImpl::SubclassWindow](../vs140/cwindowimpl--subclasswindow.md)