---
title: "CTreeCtrl::GetItemData"
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
  - "CTreeCtrl::GetItemData"
  - "CTreeCtrl.GetItemData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemData method"
ms.assetid: 1ecc025f-5995-48b1-82ea-cd3aadb58467
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::GetItemData
Call this function to retrieve the 32-bit application-specific value associated with the specified item.  
  
## Syntax  
  
```  
  
      DWORD_PTR GetItemData(  
   HTREEITEM hItem   
) const;  
```  
  
#### Parameters  
 `hItem`  
 Handle of the item whose data is to be retrieved.  
  
## Return Value  
 A 32-bit application-specific value associated with the item specified by `hItem`.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#14](../vs140/codesnippet/CPP/ctreectrl--getitemdata_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::SetItemData](../vs140/ctreectrl--setitemdata.md)