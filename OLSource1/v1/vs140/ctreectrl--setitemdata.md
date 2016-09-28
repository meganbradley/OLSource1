---
title: "CTreeCtrl::SetItemData"
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
  - "CTreeCtrl.SetItemData"
  - "CTreeCtrl::SetItemData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetItemData method"
ms.assetid: 3f1217fb-6613-4e33-b9af-3e9dac211791
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::SetItemData
Call this function to set the 32-bit application-specific value associated with the specified item.  
  
## Syntax  
  
```  
  
      BOOL SetItemData(  
   HTREEITEM hItem,  
   DWORD_PTR dwData   
);  
```  
  
#### Parameters  
 `hItem`  
 Handle of the item whose data is to be retrieved.  
  
 `dwData`  
 A 32-bit application-specific value associated with the item specified by `hItem`.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#33](../vs140/codesnippet/CPP/ctreectrl--setitemdata_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::GetItemData](../vs140/ctreectrl--getitemdata.md)