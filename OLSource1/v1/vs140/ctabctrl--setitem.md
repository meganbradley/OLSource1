---
title: "CTabCtrl::SetItem"
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
  - "CTabCtrl.SetItem"
  - "CTabCtrl::SetItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetItem method"
ms.assetid: 82b7202b-5c64-4365-90dd-d0085d2e9350
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabCtrl::SetItem
Sets some or all of a tab's attributes.  
  
## Syntax  
  
```  
  
      BOOL SetItem(  
  int nItem,  
  TCITEM* pTabCtrlItem   
);  
```  
  
#### Parameters  
 `nItem`  
 Zero-based index of the item.  
  
 `pTabCtrlItem`  
 Pointer to a [TCITEM](http://msdn.microsoft.com/library/windows/desktop/bb760554) structure that contains the new item attributes. The **mask** member specifies which attributes to set. If the **mask** member specifies the `TCIF_TEXT` value, the **pszText** member is the address of a null-terminated string and the **cchTextMax** member is ignored.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Example  
 See the example for [GetItem](../vs140/ctabctrl--getitem.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTabCtrl Class](../vs140/ctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTabCtrl::InsertItem](../vs140/ctabctrl--insertitem.md)   
 [CTabCtrl::GetItem](../vs140/ctabctrl--getitem.md)