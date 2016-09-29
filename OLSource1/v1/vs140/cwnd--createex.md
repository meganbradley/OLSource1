---
title: "CWnd::CreateEx"
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
  - "CWnd::CreateEx"
  - "CWnd.CreateEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateEx method"
  - "CWnd class, protected initialization"
ms.assetid: 9c6b7bdd-6ae5-4150-843f-493380a0b266
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::CreateEx
Creates the specified window and attaches it to the `CWnd` object.  
  
## Syntax  
  
```  
virtual BOOL CreateEx(  
   DWORD dwExStyle,  
   LPCTSTR lpszClassName,  
   LPCTSTR lpszWindowName,  
   DWORD dwStyle,  
   int x,  
   int y,  
   int nWidth,  
   int nHeight,  
   HWND hWndParent,  
   HMENU nIDorHMenu,  
   LPVOID lpParam = NULL   
);  
virtual BOOL CreateEx(  
   DWORD dwExStyle,  
   LPCTSTR lpszClassName,  
   LPCTSTR lpszWindowName,  
   DWORD dwStyle,  
   const RECT& rect,  
   CWnd* pParentWnd,  
   UINT nID,  
   LPVOID lpParam = NULL  
);  
```  
  
#### Parameters  
 `dwExStyle`  
 Bitwise combination (OR) of [extended window styles](../vs140/extended-window-styles.md); otherwise `NULL` for the default extended window style.  
  
 `lpszClassName`  
 Pointer to a null-terminated string that contains the name of a registered system window class; or the name of a predefined system window class.  
  
 `lpszWindowName`  
 Pointer to a null-terminated string that contains the window display name; otherwise `NULL` for no window display name.  
  
 `dwStyle`  
 Bitwise combination (OR) of [window styles](../vs140/window-styles.md); otherwise `NULL` for the default window style.  
  
 `x`  
 The initial horizontal distance of the window from the left side of the screen or the parent window.  
  
 `y`  
 The initial vertical distance of the window from the top of the screen or the parent window.  
  
 `nWidth`  
 The width, in pixels, of the window.  
  
 `nHeight`  
 The height, in pixels, of the window.  
  
 `hwndParent`  
 For a child window, the handle to the parent window; otherwise, the handle of the owner window if the window has an owner.  
  
 `nIDorHMenu`  
 For a child window, the window ID; otherwise, the ID of a menu for the window.  
  
 `lpParam`  
 Pointer to user data that is passed to the [CWnd::OnCreate](../vs140/cwnd--oncreate.md) method in the `lpCreateParams` field.  
  
 `rect`  
 The size and location of the window relative to the screen or the parent window.  
  
 `pParentWnd`  
 For a child window, pointer to the parent window; otherwise, pointer to the owner window if the window has an owner.  
  
 `nID`  
 For a child window, the window ID; otherwise, the ID of a menu for the window.  
  
## Return Value  
 `TRUE` if the method was successful; otherwise `FALSE`.  
  
## Remarks  
  
> [!WARNING]
>  `CWnd::PreCreateWindow` now assigns the hMenu member of its `CREATESTRUCT` parameter to the `this` pointer if the menu is `NULL` and the style contains `WS_CHILD`. For proper functionality, ensure that your dialog control has an ID that is not `NULL`.  
>   
>  This change fixes a crash in managed/native interop scenarios. A `TRACE` statement in `CWnd::Create` alerts the developer of the problem.  
  
 The default extended window style is `WS_EX_LEFT`. The default window style is `WS_OVERLAPPED`.  
  
 Use the [AfxRegisterWndClass](../vs140/afxregisterwndclass.md) function to register window classes. User defined window classes are available in the module where they are registered.  
  
 Dimensions for child windows are relative to the top-left corner of the client area of the parent window. Dimensions for top-level windows are relative to the top-left corner of the screen.  
  
 The [CWnd::OnCreate](../vs140/cwnd--oncreate.md) method is called before the `CreateEx` method returns, and before the window becomes visible.  
  
## Example  
 [!code[NVC_MFCWindowing#82](../vs140/codesnippet/CPP/cwnd--createex_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::Create](../vs140/cwnd--create.md)   
 [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680)