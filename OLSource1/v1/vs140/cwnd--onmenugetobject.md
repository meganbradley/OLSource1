---
title: "CWnd::OnMenuGetObject"
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
  - CWnd::OnMenuGetObject
dev_langs: 
  - C++
helpviewer_keywords: 
  - CWnd::OnMenuGetObject
ms.assetid: 10fc6f17-3e0b-42c7-aec8-7fbea029c428
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::OnMenuGetObject
The framework calls this member function of the current drag-and-drop menu when the mouse cursor enters a menu item or moves from the center of the item to the top or bottom of the item.  
  
## Syntax  
  
```  
afx_msg UINT OnMenuGetObject(  
    MENUGETOBJECTINFO* pMenuGetObjectInfo  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `pMenu`|Pointer to a [MENUGETOBJECTINFO](http://msdn.microsoft.com/library/windows/desktop/ms647572) structure that contains information about the drag-and-drop menu the mouse cursor is on.|  
  
## Return Value  
  
|Return Value|Meaning|  
|------------------|-------------|  
|`MNGO_NOERROR`|An interface pointer that supports drop-and-drag operations is returned in the `pvObj` member of the [MENUGETOBJECTINFO](http://msdn.microsoft.com/library/windows/desktop/ms647572) structure. Currently, only the [IDropTarget](http://msdn.microsoft.com/library/windows/desktop/ms679679) interface is supported.|  
|`MNGO_NOINTERFACE`|No drop-and-drag interface is supported.|  
  
## Remarks  
 This method receives the [WM_MENUGETOBJECT](http://msdn.microsoft.com/library/windows/desktop/ms647607) notification, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 <xref:System.Windows.Forms.IDropTarget?qualifyHint=False>   
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_MENUGETOBJECT](http://msdn.microsoft.com/library/windows/desktop/ms647607)   
 [IDropTarget](http://msdn.microsoft.com/library/windows/desktop/ms679679)