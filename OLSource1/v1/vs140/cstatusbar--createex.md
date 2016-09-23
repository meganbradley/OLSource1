---
title: "CStatusBar::CreateEx"
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
  - CStatusBar::CreateEx
  - CStatusBar.CreateEx
dev_langs: 
  - C++
helpviewer_keywords: 
  - CStatusBar class, construction/destruction
  - CreateEx method
  - status bars, constructing
ms.assetid: bc040d75-3275-4601-940d-5e37616f98f0
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CStatusBar::CreateEx
Call this function to create a status bar (a child window) and associate it with the `CStatusBar` object.  
  
## Syntax  
  
```  
  
   virtual BOOL CreateEx(  
CWnd* pParentWnd,  
DWORD dwCtrlStyle = 0 ,  
DWORD dwStyle = WS_CHILD | WS_VISIBLE | CBRS_BOTTOM,  
UINT nID = AFX_IDW_STATUS_BAR );  
```  
  
#### Parameters  
 `pParentWnd`  
 Pointer to the [CWnd](../vs140/cwnd-class.md) object whose Windows window is the parent of the status bar.  
  
 `dwCtrlStyle`  
 Additional styles for the creation of the embedded [CStatusBarCtrl](../vs140/cstatusbarctrl-class.md) object. The default specifies a status bar without a sizing grip or tooltip support. Status bar styles supported are:  
  
-   **SBARS_SIZEGRIP** The status bar control includes a sizing grip at the right end of the status bar. A sizing grip is similar to a sizing border; it is a rectangular area that the user can click and drag to resize the parent window.  
  
-   **SBT_TOOLTIPS** The status bar supports tooltips.  
  
 For details on these styles, see [Settings for the CStatusBarCtrl](../vs140/settings-for-the-cstatusbarctrl.md).  
  
 `dwStyle`  
 The status bar style. The default specifies that a visible status bar be created at the bottom of the frame window. Apply any combination of status bar control styles listed in [Window Styles](../vs140/window-styles.md) and [CDialogBar::Create](../vs140/cdialogbar--create.md). However, this parameter should always include the WS_CHILD and WS_VISIBLE styles.  
  
 `nID`  
 The status bar's child-window ID.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This function also sets the initial font and sets the status bar's height to a default value.  
  
 Use `CreateEx`, instead of [Create](../vs140/cstatusbar--create.md), when certain styles need to be present during the creation of the embedded status bar control. For example, set `dwCtrlStyle` to **SBT_TOOLTIPS** to display tooltips in a status bar object.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CStatusBar Class](../vs140/cstatusbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)