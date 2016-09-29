---
title: "CWnd::OnMenuDrag"
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
  - "CWnd::OnMenuDrag"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWnd::OnMenuDrag"
ms.assetid: e1d53927-d5d2-439c-adcd-7f37fa2917ae
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnMenuDrag
The framework calls this member function of the current drag-and-drop menu when the user begins to drag a menu item.  
  
## Syntax  
  
```  
afx_msg UINT OnMenuDrag(  
    UINT nPos,   
    CMenu* pMenu  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `nPos`|The index position of the menu item when the drag operation begins.|  
|[in] `pMenu`|Pointer to the [CMenu](../vs140/cmenu-class.md) object that contains the menu item.|  
  
## Return Value  
  
|Return Value|Meaning|  
|------------------|-------------|  
|`MND_CONTINUE`|The menu should remain active. If the mouse is released, it should be ignored.|  
|`MND_ENDMENU`|The menu should be ended.|  
  
## Remarks  
 This method receives the [WM_MENUDRAG](http://msdn.microsoft.com/library/windows/desktop/ms647606) notification, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_MENUDRAG](http://msdn.microsoft.com/library/windows/desktop/ms647606)