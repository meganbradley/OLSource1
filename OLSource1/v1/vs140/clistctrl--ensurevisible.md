---
title: "CListCtrl::EnsureVisible"
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
  - "CListCtrl.EnsureVisible"
  - "CListCtrl::EnsureVisible"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnsureVisible method"
ms.assetid: d4bd6522-4ca8-4a3e-a2d1-3237bd1b5642
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::EnsureVisible
Ensures that a list view item is at least partially visible.  
  
## Syntax  
  
```  
  
      BOOL EnsureVisible(  
   int nItem,  
   BOOL bPartialOK   
);  
```  
  
#### Parameters  
 `nItem`  
 Index of the list view item that is to be visible.  
  
 `bPartialOK`  
 Specifies whether partial visibility is acceptable.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 The list view control is scrolled if necessary. If the `bPartialOK` parameter is nonzero, no scrolling occurs if the item is partially visible.  
  
## Example  
 [!code[NVC_MFC_CListCtrl#8](../vs140/codesnippet/CPP/clistctrl--ensurevisible_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::Scroll](../vs140/clistctrl--scroll.md)