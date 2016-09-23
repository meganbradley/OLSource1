---
title: "CWnd::OnNcCalcSize"
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
  - CWnd.OnNcCalcSize
  - WM_NCCALCSIZE
  - CWnd::OnNcCalcSize
  - OnNcCalcSize
dev_langs: 
  - C++
helpviewer_keywords: 
  - WM_NCCALCSIZE
  - OnNcCalcSize method
  - NCCALCSIZE_PARAMS
ms.assetid: 5a2d7aef-3c83-4886-9824-df5309fdccad
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::OnNcCalcSize
The framework calls this member function when the size and position of the client area needs to be calculated.  
  
## Syntax  
  
```  
  
      afx_msg void OnNcCalcSize(  
   BOOL bCalcValidRects,  
   NCCALCSIZE_PARAMS* lpncsp   
);  
```  
  
#### Parameters  
 `bCalcValidRects`  
 Specifies whether the application should specify which part of the client area contains valid information. Windows will copy the valid information to the specified area within the new client area. If this parameter is **TRUE**, the application should specify which part of the client area is valid.  
  
 `lpncsp`  
 Points to a [NCCALCSIZE_PARAMS](../vs140/nccalcsize_params-structure.md) data structure that contains information an application can use to calculate the new size and position of the `CWnd` rectangle (including client area, borders, caption, scroll bars, and so on).  
  
## Remarks  
 By processing this message, an application can control the contents of the window's client area when the size or position of the window changes.  
  
 Regardless of the value of `bCalcValidRects`, the first rectangle in the array specified by the **rgrc** structure member of the `NCCALCSIZE_PARAMS` structure contains the coordinates of the window. For a child window, the coordinates are relative to the parent window's client area. For top-level windows, the coordinates are screen coordinates. An application should modify the **rgrc[0]** rectangle to reflect the size and position of the client area.  
  
 The **rgrc[1]** and **rgrc[2]** rectangles are valid only if `bCalcValidRects` is **TRUE**. In this case, the **rgrc[1]** rectangle contains the coordinates of the window before it was moved or resized. The **rgrc[2]** rectangle contains the coordinates of the window's client area before the window was moved. All coordinates are relative to the parent window or screen.  
  
 The default implementation calculates the size of the client area based on the window characteristics (presence of scroll bars, menu, and so on), and places the result in `lpncsp`.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_NCCALCSIZE](http://msdn.microsoft.com/library/windows/desktop/ms632634)   
 [CWnd::MoveWindow](../vs140/cwnd--movewindow.md)   
 [CWnd::SetWindowPos](../vs140/cwnd--setwindowpos.md)