---
title: "CListCtrl::SetItemData"
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
  - CListCtrl.SetItemData
  - CListCtrl::SetItemData
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetItemData method
ms.assetid: 95466ab7-71ad-459f-8faa-92b70c270c2a
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CListCtrl::SetItemData
Sets the 32-bit application-specific value associated with the item specified by `nItem`.  
  
## Syntax  
  
```  
  
      BOOL SetItemData(  
   int nItem,  
   DWORD_PTR dwData   
);  
```  
  
#### Parameters  
 `nItem`  
 Index of the list item whose data is to be set.  
  
 `dwData`  
 A 32-bit value to be associated with the item.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This value is the **lParam** member of the [LVITEM](http://msdn.microsoft.com/library/windows/desktop/bb774760) structure, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CListCtrl#37](../vs140/codesnippet/CPP/clistctrl--setitemdata_1.cpp)]
  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::GetItemData](../vs140/clistctrl--getitemdata.md)