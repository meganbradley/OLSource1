---
title: "CWnd::OnEnterSizeMove"
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
  - CWnd::OnEnterSizeMove
dev_langs: 
  - C++
helpviewer_keywords: 
  - CWnd::OnEnterSizeMove
ms.assetid: 5ae74c25-160a-4b9b-b9ad-a4599cd8986d
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::OnEnterSizeMove
The framework calls this member function one time after the affected window enters a moving or sizing modal loop.  
  
## Syntax  
  
```  
afx_msg void OnEnterSizeMove();  
```  
  
## Remarks  
 This method receives the [WM_ENTERSIZEMOVE](http://msdn.microsoft.com/library/windows/desktop/ms632622) notification, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 A window enters a moving or sizing modal loop when the user clicks the window's title bar or sizing border, or when the window passes the [WM_SYSCOMMAND](http://msdn.microsoft.com/library/windows/desktop/ms646360) message to the [CWnd::DefWindowProc](../vs140/cwnd--defwindowproc.md) function and the `wParam` parameter of that message specifies `SC_MOVE` or `SC_SIZE`.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_ENTERSIZEMOVE](http://msdn.microsoft.com/library/windows/desktop/ms632622)   
 [WM_SYSCOMMAND](http://msdn.microsoft.com/library/windows/desktop/ms646360)