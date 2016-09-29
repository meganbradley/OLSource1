---
title: "CListCtrl::GetNextItem"
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
  - "LVNI_BELOW"
  - "LVNI_MARKED"
  - "LVNI_ABOVE"
  - "LVNI_FOCUSED"
  - "LVNI_TORIGHT"
  - "LVNI_PREVIOUS"
  - "LVNI_DROPHILITED"
  - "LVNI_ALL"
  - "LVNI_TOLEFT"
  - "CListCtrl.GetNextItem"
  - "LVNI_SELECTED"
  - "CListCtrl::GetNextItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LVNI_DROPHILITED"
  - "GetNextItem method"
  - "LVNI_MARKED"
  - "LVNI_BELOW"
  - "LVNI_SELECTED"
  - "LVNI_TOLEFT"
  - "LVNI_TORIGHT"
  - "LVNI_ABOVE"
  - "LVNI_PREVIOUS."
  - "LVNI_ALL"
  - "LVNI_FOCUSED"
ms.assetid: 09b4803c-dd88-42b1-a823-a897bc3d9c49
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::GetNextItem
Searches for a list view item that has the specified properties and that bears the specified relationship to a given item.  
  
## Syntax  
  
```  
  
      int GetNextItem(  
   int nItem,  
   int nFlags   
) const;  
```  
  
#### Parameters  
 `nItem`  
 Index of the item to begin the searching with, or -1 to find the first item that matches the specified flags. The specified item itself is excluded from the search.  
  
 `nFlags`  
 Geometric relation of the requested item to the specified item, and the state of the requested item. The geometric relation can be one of these values:  
  
-   `LVNI_ABOVE` Searches for an item that is above the specified item.  
  
-   `LVNI_ALL` Searches for a subsequent item by index (the default value).  
  
-   `LVNI_BELOW` Searches for an item that is below the specified item.  
  
-   `LVNI_TOLEFT` Searches for an item to the left of the specified item.  
  
-   `LVNI_TORIGHT` Searches for an item to the right of the specified item.  
  
 The state can be zero, or it can be one or more of these values:  
  
-   `LVNI_DROPHILITED` The item has the `LVIS_DROPHILITED` state flag set.  
  
-   `LVNI_FOCUSED` The item has the `LVIS_FOCUSED` state flag set.  
  
-   `LVNI_SELECTED` The item has the `LVIS_SELECTED` state flag set.  
  
 If an item does not have all of the specified state flags set, the search continues with the next item.  
  
## Return Value  
 The index of the next item if successful, or -1 otherwise.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::GetItem](../vs140/clistctrl--getitem.md)