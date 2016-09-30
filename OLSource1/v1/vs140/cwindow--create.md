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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] A pointer to the window's class.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The handle to the parent or owner window.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] A variable of type [_U_RECT](../vs140/_u_rect-class.md) specifying the position of the window. The default value is **NULL**. When this parameter is **NULL**, the value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is used.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] Specifies the name of the window. The default value is **NULL**.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] The style of the window. The default value is 0, meaning no style is specified. For a list of possible values, see [CreateWindow](http://msdn.microsoft.com/library/windows/desktop/ms632679) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in] The extended window style. The default value is 0, meaning no extended style is specified. For a list of possible values, see [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [in] A variable of type [_U_MENUorID](../vs140/_u_menuorid-class.md) specifying a handle to a menu or a window identifier. The default value is 0U.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A pointer to the window-creation data contained in a [CREATESTRUCT](http://msdn.microsoft.com/library/windows/desktop/ms632603) structure.  
  
## Return Value  
 If successful, the handle to the newly created window, specified by [m_hWnd](../vs140/cwindow--m_hwnd.md). Otherwise, **NULL**.  
  
## Remarks  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is defined as <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 See [CreateWindow](http://msdn.microsoft.com/library/windows/desktop/ms632679) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
 **Note** If 0 is used as the value for the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter, it must be specified as 0U (the default value) to avoid a compiler error.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::m_hWnd](../vs140/cwindow--m_hwnd.md)