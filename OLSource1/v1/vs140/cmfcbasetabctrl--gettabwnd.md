---
title: "CMFCBaseTabCtrl::GetTabWnd"
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
  - "CMFCBaseTabCtrl.GetTabWnd"
  - "CMFCBaseTabCtrl::GetTabWnd"
  - "GetTabWnd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTabWnd method"
ms.assetid: c060aac0-0bcb-49bc-b5d6-58784ec69944
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::GetTabWnd
Returns the pointer to the pane that resides on the specified tab.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The zero-based index of a tab.  
  
## Return Value  
 A pointer to the [CWnd](../vs140/cwnd-class.md) object that resides on the tab that <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> specifies. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is invalid.  
  
## Remarks  
 The returned object is the one that the application added when it called either [CMFCBaseTabCtrl::AddTab](../vs140/cmfcbasetabctrl--addtab.md) or [CMFCBaseTabCtrl::InsertTab](../vs140/cmfcbasetabctrl--inserttab.md).  
  
 If the object on a tab has a wrapper, this method will return the wrapper for the object. For more information about wrappers, see [CMFCBaseTabCtrl::CreateWrapper](../vs140/cmfcbasetabctrl--createwrapper.md). If you want to access a pointer to the direct object without the wrapper, use the method [CMFCBaseTabCtrl::GetTabWndNoWrapper](../vs140/cmfcbasetabctrl--gettabwndnowrapper.md).  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCBaseTabCtrl::GetTabWndNoWrapper](../vs140/cmfcbasetabctrl--gettabwndnowrapper.md)