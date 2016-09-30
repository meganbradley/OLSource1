---
title: "CWndClassInfo::pWndProc"
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
  - "CWndClassInfo::pWndProc"
  - "CWndClassInfo.pWndProc"
  - "pWndProc"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "pWndProc method"
ms.assetid: 6d0a8d17-3a1c-46c6-9f25-db0863b378e4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWndClassInfo::pWndProc
Points to the window procedure of an existing window class.  
  
## Syntax  
  
```  
  
WNDPROC pWndProc;  
  
```  
  
## Remarks  
 `CWndClassInfo` uses `pWndProc` only when you include the [DECLARE_WND_SUPERCLASS](../vs140/declare_wnd_superclass.md) macro in your class definition. In this case, `CWndClassInfo` registers a window class that is based on an existing class but uses a different window procedure. The existing window class's window procedure is saved in `pWndProc`. For more information, see the [CWndClassInfo](../vs140/cwndclassinfo-class.md) overview.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWndClassInfo Class](../vs140/cwndclassinfo-class.md)   
 [CWndClassInfo::m_wc](../vs140/cwndclassinfo--m_wc.md)   
 [CWndClassInfo::m_lpszOrigName](../vs140/cwndclassinfo--m_lpszorigname.md)