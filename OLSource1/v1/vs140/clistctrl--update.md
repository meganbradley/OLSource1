---
title: "CListCtrl::Update"
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
  - "CListCtrl::Update"
  - "CListCtrl.Update"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Update method"
ms.assetid: c1334675-fe35-4c0c-8840-9aa3b6e53f08
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::Update
Forces the list view control to repaint the item specified by `nItem`.  
  
## Syntax  
  
```  
  
      BOOL Update(  
   int nItem   
);  
```  
  
#### Parameters  
 `nItem`  
 Index of the item to be updated.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 This function also arranges the list view control if it has the `LVS_AUTOARRANGE` style.  
  
## Example  
 See the example for [CListCtrl::GetSelectedCount](../vs140/clistctrl--getselectedcount.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::DrawItem](../vs140/clistctrl--drawitem.md)