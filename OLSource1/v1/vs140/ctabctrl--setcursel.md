---
title: "CTabCtrl::SetCurSel"
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
  - "CTabCtrl::SetCurSel"
  - "CTabCtrl.SetCurSel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetCurSel method"
ms.assetid: c77d2468-0801-444d-8286-2710b3c32c94
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabCtrl::SetCurSel
Selects a tab in a tab control.  
  
## Syntax  
  
```  
  
      int SetCurSel(  
  int nItem   
);  
```  
  
#### Parameters  
 `nItem`  
 The zero-based index of the item to be selected.  
  
## Return Value  
 Zero-based index of the previously selected tab if successful, otherwise – 1.  
  
## Remarks  
 A tab control does not send a **TCN_SELCHANGING** or **TCN_SELCHANGE** notification message when a tab is selected using this function. These notifications are sent, using **WM_NOTIFY**, when the user clicks or uses the keyboard to change tabs.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTabCtrl Class](../vs140/ctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTabCtrl::GetCurSel](../vs140/ctabctrl--getcursel.md)   
 [CTabCtrl::GetCurFocus](../vs140/ctabctrl--getcurfocus.md)