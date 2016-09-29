---
title: "CListCtrl::SetCheck"
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
  - "CListCtrl::SetCheck"
  - "CListCtrl.SetCheck"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetCheck method"
ms.assetid: cf7a2785-a6fb-4c46-84c8-3c40fb9be5bd
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::SetCheck
Determines if the state image of a list control item is visible.  
  
## Syntax  
  
```  
  
      BOOL SetCheck(  
   int nItem,  
   BOOL fCheck = TRUE   
);  
```  
  
#### Parameters  
 `nItem`  
 The zero-based index of a list control item.  
  
 `fCheck`  
 Specifies whether the state image of the item should be visible or not. By default, *fCheck* is **TRUE** and the state image is visible. If `fCheck` is **FALSE**, it is not visible.  
  
## Return Value  
 Nonzero if the item is checked, otherwise 0.  
  
## Example  
 [!code[NVC_MFC_CListCtrl#43](../vs140/codesnippet/CPP/clistctrl--setcheck_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::GetCheck](../vs140/clistctrl--getcheck.md)