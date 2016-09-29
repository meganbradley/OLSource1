---
title: "CMFCBaseTabCtrl::ShowTab"
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
  - "CMFCBaseTabCtrl::ShowTab"
  - "CMFCBaseTabCtrl.ShowTab"
  - "ShowTab"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ShowTab method"
ms.assetid: 5abcee0d-1930-43cc-894b-917d69a6381b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::ShowTab
Shows or hides the specified tab.  
  
## Syntax  
  
```  
virtual BOOL ShowTab(  
   int iTab,  
   BOOL bShow = TRUE,  
   BOOL bRecalcLayout = TRUE,  
   BOOL bActivate = FALSE  
);  
```  
  
#### Parameters  
 [in] `iTab`  
 The index of the tab that `ShowTab` will show or hide.  
  
 [in] `bShow`  
 A Boolean parameter that indicates whether to show the tab.  
  
 [in] `bRecalcLayout`  
 A Boolean parameter that indicates whether to immediately recalculate the window layout.  
  
 [in] `bActivate`  
 A Boolean parameter that indicates whether to select the tab specified by `iTab`.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The parameter `bActivate` only applies if `bShow` is `TRUE`. If `bActivate` is `TRUE` and if `ShowTab` is successful, `ShowTab` will send the message AFX_WM_CHANGE_ACTIVE_TAB to the parent of the tab window.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)