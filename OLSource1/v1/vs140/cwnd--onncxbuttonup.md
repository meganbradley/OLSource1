---
title: "CWnd::OnNcXButtonUp"
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
  - CWnd::OnNcXButtonUp
dev_langs: 
  - C++
helpviewer_keywords: 
  - CWnd::OnNcXButtonUp
ms.assetid: b4dee716-432d-4a55-94a3-71e38e157be1
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::OnNcXButtonUp
The framework calls this member function when the user releases XBUTTON1 or XBUTTON2 of the mouse while the cursor is in the nonclient area of a window.  
  
## Syntax  
  
```  
afx_msg void OnNcXButtonUp(  
    short nHitTest,   
    UINT nButton,   
    CPoint point  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `nHitTest`|The hit-test value returned by the [CWnd::DefWindowProc](../vs140/cwnd--defwindowproc.md) function as a result of processing the [WM_NCHITTEST](http://msdn.microsoft.com/library/windows/desktop/ms645618) message.|  
|[in] `nButton`|A value of `XBUTTON1` if the first mouse X button is released, or `XBUTTON2` if the second X button is released.|  
|[in] `point`|A [CPoint](../vs140/cpoint-class.md) object that specifies the *x* and *y* coordinates of the cursor relative to the upper-left corner of the screen.|  
  
## Remarks  
 This method receives the [WM_NCXBUTTONUP](http://msdn.microsoft.com/library/windows/desktop/ms646240) notification, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. This message is posted to the window that contains the cursor. If a window has captured the mouse, this message is not posted.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_NCXBUTTONUP](http://msdn.microsoft.com/library/windows/desktop/ms646240)