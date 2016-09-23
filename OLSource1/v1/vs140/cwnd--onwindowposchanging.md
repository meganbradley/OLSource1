---
title: "CWnd::OnWindowPosChanging"
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
  - CWnd::OnWindowPosChanging
  - OnWindowPosChanging
  - CWnd.OnWindowPosChanging
  - WM_WINDOWPOSCHANGING
dev_langs: 
  - C++
helpviewer_keywords: 
  - WINDOWPOS
  - OnWindowPosChanging method
  - WM_WINDOWPOSCHANGING
ms.assetid: eaaccbe3-c00c-4836-b346-a96ac8ea4f40
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::OnWindowPosChanging
The framework calls this member function when the size, position, or Z-order is about to change as a result of a call to the [SetWindowPos](http://msdn.microsoft.com/library/windows/desktop/ms633545) member function or another window-management function.  
  
## Syntax  
  
```  
  
      afx_msg void OnWindowPosChanging(  
   WINDOWPOS* lpwndpos   
);  
```  
  
#### Parameters  
 `lpwndpos`  
 Points to a `WINDOWPOS` data structure that contains information about the window's new size and position.  
  
## Remarks  
 An application can prevent changes to the window by setting or clearing the appropriate bits in the **flags** member of the [WINDOWPOS](../vs140/windowpos-structure.md) structure.  
  
 For a window with the [WS_OVERLAPPED](../vs140/window-styles.md) or [WS_THICKFRAME](../vs140/window-styles.md) style, the default implementation sends a [WM_GETMINMAXINFO](http://msdn.microsoft.com/library/windows/desktop/ms632626) message to the window. This is done to validate the new size and position of the window and to enforce the **CS_BYTEALIGNCLIENT** and **CS_BYTEALIGN** client styles. An application can override this functionality by not calling its base class.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnWindowPosChanged](../vs140/cwnd--onwindowposchanged.md)   
 [WM_WINDOWPOSCHANGING](http://msdn.microsoft.com/library/windows/desktop/ms632653)