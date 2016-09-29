---
title: "CMFCBaseTabCtrl::GetTabWndNoWrapper"
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
  - "CMFCBaseTabCtrl::GetTabWndNoWrapper"
  - "GetTabWndNoWrapper"
  - "CMFCBaseTabCtrl.GetTabWndNoWrapper"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTabWndNoWrapper method"
ms.assetid: fc8a2f3e-dd1d-4450-85d8-f03a535dd389
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::GetTabWndNoWrapper
Returns a pointer to the control that resides on a tab, even if the control has a wrapper.  
  
## Syntax  
  
```  
virtual CWnd* GetTabWndNoWrapper(  
   int iTab   
) const;  
```  
  
#### Parameters  
 [in] `iTab`  
 The zero-based index of a tab.  
  
## Return Value  
 A pointer to the [CWnd](../vs140/cwnd-class.md) object that resides on the specified tab; `NULL` if `iTab` is invalid.  
  
## Remarks  
 This method retrieves a direct pointer to the `CWnd` object that you added by using either the method [CMFCBaseTabCtrl::AddTab](../vs140/cmfcbasetabctrl--addtab.md) or [CMFCBaseTabCtrl::InsertTab](../vs140/cmfcbasetabctrl--inserttab.md). `GetTabWndNoWrapper` will retrieve a pointer to the added `CWnd`, even if the framework added a wrapper for the object. For more information about wrappers and the [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md), see [CMFCBaseTabCtrl::CreateWrapper](../vs140/cmfcbasetabctrl--createwrapper.md).  
  
 Use the method [CMFCBaseTabCtrl::GetTabWnd](../vs140/cmfcbasetabctrl--gettabwnd.md) if you do not want to ignore the wrapper class.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCBaseTabCtrl::GetTabWnd](../vs140/cmfcbasetabctrl--gettabwnd.md)