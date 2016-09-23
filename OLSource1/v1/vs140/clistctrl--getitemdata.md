---
title: "CListCtrl::GetItemData"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CListCtrl.GetItemData
  - CListCtrl::GetItemData
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetItemData method
ms.assetid: d0e1b9b1-dcca-48bb-8b93-75e47ebaf434
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CListCtrl::GetItemData
Retrieves the 32-bit application-specific value associated with the item specified by `nItem`.  
  
## Syntax  
  
```  
  
      DWORD_PTR GetItemData(  
   int nItem   
) const;  
```  
  
#### Parameters  
 `nItem`  
 Index of the list item whose data is to be retrieved.  
  
## Return Value  
 A 32-bit application-specific value associated with the specified item.  
  
## Remarks  
 This value is the **lParam** member of the [LVITEM](http://msdn.microsoft.com/library/windows/desktop/bb774760) structure, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]  
  
## Example  
 [!code[NVC_MFC_CListCtrl#21](../vs140/codesnippet/CPP/clistctrl--getitemdata_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::SetItemData](../vs140/clistctrl--setitemdata.md)