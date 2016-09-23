---
title: "CWindow::CWindow"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CWindow.CWindow
  - CWindow::CWindow
  - ATL::CWindow::CWindow
  - ATL.CWindow.CWindow
dev_langs: 
  - C++
helpviewer_keywords: 
  - CWindow method
  - CWindow class, constructor
ms.assetid: 220eae07-2451-46ad-824c-d6de4dc1d6ee
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWindow::CWindow
The constructor.  
  
## Syntax  
  
```  
  
      CWindow(  
   HWND hWnd = NULL   
) throw();  
```  
  
#### Parameters  
 `hWnd`  
 [in] The handle to a window.  
  
## Remarks  
 Initializes the [m_hWnd](../vs140/cwindow--m_hwnd.md) member to `hWnd`, which by default is **NULL**.  
  
> [!NOTE]
>  `CWindow::CWindow` does not create a window. Classes [CWindowImpl](../vs140/cwindowimpl-class.md), [CContainedWindow](../vs140/ccontainedwindowt-class.md), and [CDialogImpl](../vs140/cdialogimpl-class.md) (all of which derive from `CWindow`) provide a method to create a window or dialog box, which is then assigned to `CWindow::m_hWnd`. You can also use the [CreateWindow](http://msdn.microsoft.com/library/windows/desktop/ms632679) Win32 function.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)