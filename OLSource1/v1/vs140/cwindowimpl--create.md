---
title: "CWindowImpl::Create"
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
  - ATL::CWindowImpl::Create
  - CWindowImpl::Create
  - CWindowImpl.Create
  - ATL.CWindowImpl.Create
dev_langs: 
  - C++
helpviewer_keywords: 
  - Create method [C++]
ms.assetid: 86587c87-55aa-47c9-b333-bef30914143d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWindowImpl::Create
Creates a window based on a new window class.  
  
## Syntax  
  
```  
  
      HWND Create(  
   HWND hWndParent,  
   _U_RECT rect = NULL,  
   LPCTSTR szWindowName = NULL,  
   DWORD dwStyle = 0,  
   DWORD dwExStyle = 0,  
   _U_MENUorID MenuOrID = 0U,  
   LPVOID lpCreateParam = NULL  
);  
```  
  
#### Parameters  
 `hWndParent`  
 [in] The handle to the parent or owner window.  
  
 `rect`  
 [in] A [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure specifying the position of the window. The `RECT` can be passed by pointer or by reference.  
  
 `szWindowName`  
 [in] Specifies the name of the window. The default value is **NULL**.  
  
 `dwStyle`  
 [in] The style of the window. This value is combined with the style provided by the traits class for the window. The default value gives the traits class full control over the style. For a list of possible values, see [CreateWindow](http://msdn.microsoft.com/library/windows/desktop/ms632679) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `dwExStyle`  
 [in] The extended window style. This value is combined with the style provided by the traits class for the window. The default value gives the traits class full control over the style. For a list of possible values, see [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `MenuOrID`  
 [in] For a child window, the window identifier. For a top-level window, a menu handle for the window. The default value is **0U**.  
  
 `lpCreateParam`  
 [in] A pointer to window-creation data. For a full description, see the description for the final parameter to [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680).  
  
## Return Value  
 If successful, the handle to the newly created window. Otherwise, **NULL**.  
  
## Remarks  
 **Create** first registers the window class if it has not yet been registered. The newly created window is automatically attached to the `CWindowImpl` object.  
  
> [!NOTE]
>  Do not call **Create** if you have already called [SubclassWindow](../vs140/cwindowimpl--subclasswindow.md).  
  
 To use a window class that is based on an existing window class, derive your class from `CWindowImpl` and include the [DECLARE_WND_SUPERCLASS](../vs140/declare_wnd_superclass.md) macro. The existing window class's window procedure is saved in [m_pfnSuperWindowProc](../vs140/cwindowimpl--m_pfnsuperwindowproc.md). For more information, see the [CWindowImpl](../vs140/cwindowimpl-class.md) overview.  
  
> [!NOTE]
>  If 0 is used as the value for the `MenuOrID` parameter, it must be specified as 0U (the default value) to avoid a compiler error.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindowImpl Class](../vs140/cwindowimpl-class.md)   
 [CWindowImpl::GetWndClassInfo](../vs140/cwindowimpl--getwndclassinfo.md)   
 [CWndClassInfo::Register](../vs140/cwndclassinfo--register.md)   
 [CWindow::m_hWnd](../vs140/cwindow--m_hwnd.md)