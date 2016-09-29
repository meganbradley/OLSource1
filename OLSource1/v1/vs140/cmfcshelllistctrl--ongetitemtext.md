---
title: "CMFCShellListCtrl::OnGetItemText"
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
  - "CMFCShellListCtrl.OnGetItemText"
  - "OnGetItemText"
  - "CMFCShellListCtrl::OnGetItemText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnGetItemText method"
ms.assetid: f9aad72f-22f0-4470-8c6c-d07c41256c8a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCShellListCtrl::OnGetItemText
The framework calls this method when it must retrieve the text of a shell item.  
  
## Syntax  
  
```  
virtual CString OnGetItemText(  
   int iItem,  
   int iColumn,  
   LPAFX_SHELLITEMINFO pItem   
);  
```  
  
#### Parameters  
 [in] `iItem`  
 The item index.  
  
 [in] `iColumn`  
 The column of interest.  
  
 [in] `pItem`  
 A `LPAFX_SHELLITEMINFO` parameter that describes the item.  
  
## Return Value  
 A `CString` that contains the text associated with the item.  
  
## Remarks  
 Each item in the [CMFCShellListCtrl](../vs140/cmfcshelllistctrl-class.md) object may have text in one or more columns. When the framework calls this method, it specifies the column that it is interested in. If you call this function manually, you must also specify the column that you are interested in.  
  
 By default, this method relies on the `pItem` parameter to determine which item to process. The value of `iItem` is not used in the default implementation.  
  
## Requirements  
 **Header:** afxshelllistctrl.h  
  
## See Also  
 [CMFCShellListCtrl Class](../vs140/cmfcshelllistctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)