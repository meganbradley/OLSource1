---
title: "CWnd::OnUnInitMenuPopup"
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
  - CWnd::OnUnInitMenuPopup
dev_langs: 
  - C++
helpviewer_keywords: 
  - CWnd::OnUnInitMenuPopup
ms.assetid: 64675739-8565-4334-88c7-c7c2a55429e0
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::OnUnInitMenuPopup
The framework calls this member function when a drop-down menu or submenu has been destroyed.  
  
## Syntax  
  
```  
afx_msg void OnUnInitMenuPopup(  
    CMenu* pPopupMenu,   
    UINT nFlags  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `pMenu`|Pointer to the [CMenu](../vs140/cmenu-class.md) object that represents the menu or submenu.|  
|[in] `nFlags`|The menu that was destroyed. Currently, it can only be the window menu, `MF_SYSMENU`.|  
  
## Remarks  
 This method receives the [WM_UNINITMENUPOPUP](http://msdn.microsoft.com/library/windows/desktop/ms647614) notification, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_UNINITMENUPOPUP](http://msdn.microsoft.com/library/windows/desktop/ms647614)