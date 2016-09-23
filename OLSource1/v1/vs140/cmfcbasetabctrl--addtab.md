---
title: "CMFCBaseTabCtrl::AddTab"
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
  - AddTab
  - CMFCBaseTabCtrl.AddTab
  - CMFCBaseTabCtrl::AddTab
dev_langs: 
  - C++
helpviewer_keywords: 
  - AddTab method
ms.assetid: 607bd3d7-a279-4c82-b433-c23063b5e80f
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCBaseTabCtrl::AddTab
Adds a new tab to the tab control.  
  
## Syntax  
  
```  
virtual void AddTab(  
   CWnd* pTabWnd,  
   LPCTSTR lpszTabLabel,  
   UINT uiImageId = (UINT)-1,,  
   BOOL bDetachable = TRUE  
);  
virtual void AddTab(  
   CWnd* pTabWnd,  
   UINT uiResTabLabel,  
   UINT uiImageId = (UINT)-1,  
   BOOL bDetachable = TRUE  
);  
```  
  
#### Parameters  
 [in] `pTabWnd`  
 A pointer to the window that this method represents as a new tab.  
  
 [in] `lpszTabLabel`  
 A string that contains the label for the new tab.  
  
 [in] `uiImageId`  
 An image ID from the image list. The tab control uses this image as the icon for the new tab.  
  
 [in] `uiResTabLabel`  
 The resource ID for the label.  
  
 [in] `bDetachable`  
 A Boolean parameter that determines whether the new tab is detachable.  
  
## Remarks  
 If `pTabWnd` points to an object that is not derived from the [CDockablePane Class](../vs140/cdockablepane-class.md) and if `bDetachable` is `TRUE`, the framework automatically creates a wrapper for the `pTabWnd` object. The wrapper makes the `pTabWnd` object detachable. By default, the wrapper is an instance of the [CDockablePaneAdapter Class](../vs140/cdockablepaneadapter-class.md). If the functionality offered by the default wrapper is unacceptable, use the [CMFCBaseTabCtrl::SetDockingBarWrapperRTC](../vs140/cmfcbasetabctrl--setdockingbarwrapperrtc.md) method to specify a different wrapper.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [CDockablePaneAdapter Class](../vs140/cdockablepaneadapter-class.md)