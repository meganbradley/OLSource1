---
title: "CWnd::OnWindowMaximizedChanged"
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
  - CWnd::OnWindowMaximizedChanged
dev_langs: 
  - C++
helpviewer_keywords: 
  - CWnd::OnWindowMaximizedChanged
ms.assetid: a24b6757-1eb9-4c10-931a-eb18bc44e599
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::OnWindowMaximizedChanged
The framework calls this member when the current window is maximized, and the window is composed by the Desktop Window Manager (DWM).  
  
## Syntax  
  
```  
afx_msg void OnWindowMaximizedChanged(  
    BOOL bIsMaximized  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `bIsMaximized`|`true` if the current window is maximized, and `false` if it is not.|  
  
## Remarks  
 This method receives the [WM_DWMWINDOWMAXIMIZEDCHANGE](http://msdn.microsoft.com/library/windows/desktop/dd388201) notification message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_DWMWINDOWMAXIMIZEDCHANGE](http://msdn.microsoft.com/library/windows/desktop/dd388201)