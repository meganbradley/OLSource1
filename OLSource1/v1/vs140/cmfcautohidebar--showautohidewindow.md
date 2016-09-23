---
title: "CMFCAutoHideBar::ShowAutoHideWindow"
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
  - CMFCAutoHideBar::ShowAutoHideWindow
  - CMFCAutoHideBar.ShowAutoHideWindow
  - ShowAutoHideWindow
dev_langs: 
  - C++
helpviewer_keywords: 
  - ShowAutoHideWindow method
ms.assetid: 0fa2b92a-ce1f-451b-9131-ef4ab9e03505
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCAutoHideBar::ShowAutoHideWindow
Shows the auto-hide window.  
  
## Syntax  
  
```  
 BOOL ShowAutoHideWindow(  
		CDockablePane* pAutoHideWnd,  
		BOOL bShow,  
		BOOL bDelay  
	);  
  
```  
  
#### Parameters  
 [in] CDockablePane* `pAutoHideWnd`  
  [in] BOOL `bShow`  
 TRUE to show the window.  
  
 [in] BOOL `bDelay`  
 This parameter is ignored.  
  
## Return Value  
 TRUE if successful; otherwise FALSE.  
  
## Remarks  
  
## Requirements  
 **Header:** afxautohidebar.h  
  
## See Also  
 [CMFCAutoHideBar Class](../vs140/cmfcautohidebar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)