---
title: "CContainedWindowT::Create"
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
  - "CContainedWindowT::Create"
  - "ATL::CContainedWindowT::Create"
  - "CContainedWindow::Create"
  - "CContainedWindow.Create"
  - "ATL.CContainedWindowT.Create"
  - "CContainedWindowT.Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
ms.assetid: 231b6925-490f-4ef3-be41-9f65ee1177ac
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CContainedWindowT::Create
Calls [RegisterWndSuperclass](../vs140/ccontainedwindowt--registerwndsuperclass.md) to register a window class that is based on an existing class but uses [CContainedWindowT::WindowProc](../vs140/ccontainedwindowt--windowproc.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The name of an existing window class on which the contained window will be based.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A pointer to the containing object that declares the message map. This object's class must derive from [CMessageMap](../vs140/cmessagemap-class.md).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Identifies the message map that will process the contained window's messages. The default value, 0, specifies the default message map declared with [BEGIN_MSG_MAP](../vs140/begin_msg_map.md). To use an alternate message map declared with [ALT_MSG_MAP(msgMapID)](../vs140/alt_msg_map.md), pass <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] The handle to the parent or owner window.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] A [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure specifying the position of the window. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> can be passed by pointer or by reference.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [in] Specifies the name of the window. The default value is **NULL**.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 [in] The style of the window. The default value is **WS_CHILD &#124; WS_VISIBLE**. For a list of possible values, see [CreateWindow](http://msdn.microsoft.com/library/windows/desktop/ms632679) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 [in] The extended window style. The default value is 0, meaning no extended style. For a list of possible values, see [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 [in] For a child window, the window identifier. For a top-level window, a menu handle for the window. The default value is **0U**.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 [in] A pointer to window-creation data. For a full description, see the description for the final parameter to [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680).  
  
## Return Value  
 If successful, the handle to the newly created window; otherwise, **NULL**.  
  
## Remarks  
 The existing window class name is saved in [m_lpszClassName](../vs140/ccontainedwindowt--m_lpszclassname.md). **Create** then creates a window based on this new class. The newly created window is automatically attached to the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.  
  
> [!NOTE]
>  Do not call **Create** if you have already called [SubclassWindow](../vs140/ccontainedwindowt--subclasswindow.md).  
  
> [!NOTE]
>  If 0 is used as the value for the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameter, it must be specified as 0U (the default value) to avoid a compiler error.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CContainedWindowT Class](../vs140/ccontainedwindowt-class.md)   
 [CWindow::m_hWnd](../vs140/cwindow--m_hwnd.md)