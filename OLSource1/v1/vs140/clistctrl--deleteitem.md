---
title: "CListCtrl::DeleteItem"
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
  - "CListCtrl::DeleteItem"
  - "CListCtrl.DeleteItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DeleteItem method"
ms.assetid: 9f1a4325-5fd7-4592-9ee5-33467e36b58e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::DeleteItem
Deletes an item from a list view control.  
  
## Syntax  
  
```  
  
      BOOL DeleteItem(  
   int nItem   
);  
```  
  
#### Parameters  
 `nItem`  
 Specifies the index of the item to be deleted.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Example  
 [!code[NVC_MFC_CListCtrl#6](../vs140/codesnippet/CPP/clistctrl--deleteitem_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::InsertItem](../vs140/clistctrl--insertitem.md)   
 [CListCtrl::DeleteAllItems](../vs140/clistctrl--deleteallitems.md)