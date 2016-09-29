---
title: "CWnd::OnWindowPosChanged"
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
  - "CWnd::OnWindowPosChanged"
  - "WM_WINDOWPOSCHANGED"
  - "OnWindowPosChanged"
  - "CWnd.OnWindowPosChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnWindowPosChanged method"
  - "WM_WINDOWPOSCHANGED"
ms.assetid: 0438c4d0-4e2f-4f5f-9efc-78ba7626fded
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnWindowPosChanged
The framework calls this member function when the size, position, or Z-order has changed as a result of a call to the [SetWindowPos](http://msdn.microsoft.com/library/windows/desktop/ms633545) member function or another window-management function.  
  
## Syntax  
  
```  
  
      afx_msg void OnWindowPosChanged(  
   WINDOWPOS* lpwndpos   
);  
```  
  
#### Parameters  
 `lpwndpos`  
 Points to a [WINDOWPOS](../vs140/windowpos-structure.md) data structure that contains information about the window's new size and position.  
  
## Remarks  
 The default implementation sends the [WM_SIZE](http://msdn.microsoft.com/library/windows/desktop/ms632646) and [WM_MOVE](http://msdn.microsoft.com/library/windows/desktop/ms632631) messages to the window. These messages are not sent if an application handles the `OnWindowPosChanged` call without calling its base class. It is more efficient to perform any move or size change processing during the call to `OnWindowPosChanged` without calling its base class.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_WINDOWPOSCHANGED](http://msdn.microsoft.com/library/windows/desktop/ms632652)