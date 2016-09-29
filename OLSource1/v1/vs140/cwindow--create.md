---
title: "CWindow::Create"
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
  - "CWindow.Create"
  - "CWindow::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
  - "rcDefault method, CWindow class"
ms.assetid: 20ceef7d-18f7-490c-9221-20a57667407f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindow::Create
Creates a window.  
  
## Syntax  
  
```  
  
      HWND Create(  
   LPCTSTR lpstrWndClass,   
   HWND hWndParent,   
   _U_RECT rect = NULL,   
   LPCTSTR szWindowName = NULL,  
   DWORD dwStyle = 0,   
   DWORD dwExStyle = 0,  
   _U_MENUorID MenuOrID = 0U,   
   LPVOID lpCreateParam = NULL  
) throw();   
```  
  
#### Parameters  
 `lpstrWndClass`  
 [in] A pointer to the window's class.  
  
 `hWndParent`  
 [in] The handle to the parent or owner window.  
  
 `rect`  
 [in] A variable of type [_U_RECT](../vs140/_u_rect-class.md) specifying the position of the window. The default value is **NULL**. When this parameter is **NULL**, the value of `CWindow::rcDefault` is used.  
  
 `szWindowName`  
 [in] Specifies the name of the window. The default value is **NULL**.  
  
 `dwStyle`  
 [in] The style of the window. The default value is 0, meaning no style is specified. For a list of possible values, see [CreateWindow](http://msdn.microsoft.com/library/windows/desktop/ms632679) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `dwExStyle`  
 [in] The extended window style. The default value is 0, meaning no extended style is specified. For a list of possible values, see [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `MenuOrID`  
 [in] A variable of type [_U_MENUorID](../vs140/_u_menuorid-class.md) specifying a handle to a menu or a window identifier. The default value is 0U.  
  
 `lpCreateParam`  
 A pointer to the window-creation data contained in a [CREATESTRUCT](http://msdn.microsoft.com/library/windows/desktop/ms632603) structure.  
  
## Return Value  
 If successful, the handle to the newly created window, specified by [m_hWnd](../vs140/cwindow--m_hwnd.md). Otherwise, **NULL**.  
  
## Remarks  
 `CWindow::rcDefault` is defined as `__declspec(selectany) RECT CWindow::rcDefault = {CW_USEDEFAULT, CW_USEDEFAULT, 0, 0};`.  
  
 See [CreateWindow](http://msdn.microsoft.com/library/windows/desktop/ms632679) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
 **Note** If 0 is used as the value for the `MenuOrID` parameter, it must be specified as 0U (the default value) to avoid a compiler error.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::m_hWnd](../vs140/cwindow--m_hwnd.md)