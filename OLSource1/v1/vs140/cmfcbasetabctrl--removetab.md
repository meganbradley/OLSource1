---
title: "CMFCBaseTabCtrl::RemoveTab"
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
  - "CMFCBaseTabCtrl.RemoveTab"
  - "CMFCBaseTabCtrl::RemoveTab"
  - "RemoveTab"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveTab method"
ms.assetid: 36461f6b-0da1-4965-a967-37f3d7cea75d
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::RemoveTab
Removes a tab from the tab control.  
  
## Syntax  
  
```  
virtual BOOL RemoveTab(  
   int iTab,  
   BOOL bRecalcLayout = TRUE  
);  
```  
  
#### Parameters  
 [in] `iTab`  
 The zero-based index of a tab.  
  
 [in] `bRecalcLayout`  
 A Boolean parameter that specifies whether to recalculate the layout of the tab.  
  
## Return Value  
 `TRUE` if the method removes the tab successfully; otherwise `FALSE`.  
  
## Remarks  
 If [CMFCBaseTabCtrl::m_bAutoDestroyWindow](../vs140/cmfcbasetabctrl--m_bautodestroywindow.md) is `TRUE`, `RemoveTab` destroys the [CWnd](../vs140/cwnd-class.md) object associated with the specified tab.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)