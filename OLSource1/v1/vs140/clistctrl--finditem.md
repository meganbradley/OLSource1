---
title: "CListCtrl::FindItem"
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
  - "CListCtrl::FindItem"
  - "LVFI_STRING"
  - "LV_FINDINFO"
  - "LVFI_PARAM"
  - "LVFI_NEARESTXY"
  - "LVFI_WRAP"
  - "CListCtrl.FindItem"
  - "LVFI_PARTIAL"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LVFI_STRING"
  - "LVFI_PARAM"
  - "LVFI_NEARESTXY"
  - "LV_FINDINFO"
  - "LVFI_PARTIAL"
  - "LVFI_WRAP"
  - "FindItem method"
ms.assetid: 98082f05-3dbf-41e8-9427-8e4f0491b893
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::FindItem
Searches for a list view item having specified characteristics.  
  
## Syntax  
  
```  
  
      int FindItem(  
   LVFINDINFO* pFindInfo,  
   int nStart = -1   
) const;  
```  
  
#### Parameters  
 `pFindInfo`  
 A pointer to an [LVFINDINFO](http://msdn.microsoft.com/library/windows/desktop/bb774745) structure containing information about the item to be searched for.  
  
 `nStart`  
 Index of the item to begin the search with, or -1 to start from the beginning. The item at `nStart` is excluded from the search if `nStart` is not equal to -1.  
  
## Return Value  
 The index of the item if successful or -1 otherwise.  
  
## Remarks  
 The `pFindInfo` parameter points to an **LVFINDINFO** structure, which contains information used to search for a list view item.  
  
## Example  
 [!code[NVC_MFC_CListCtrl#9](../vs140/codesnippet/CPP/clistctrl--finditem_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::SortItems](../vs140/clistctrl--sortitems.md)