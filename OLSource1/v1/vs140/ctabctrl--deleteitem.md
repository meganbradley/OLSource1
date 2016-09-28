---
title: "CTabCtrl::DeleteItem"
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
  - "CTabCtrl.DeleteItem"
  - "CTabCtrl::DeleteItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DeleteItem method"
ms.assetid: 5c8319f6-836a-4af6-a339-742dd84740a0
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabCtrl::DeleteItem
Removes the specified item from a tab control.  
  
## Syntax  
  
```  
  
      BOOL DeleteItem(  
  int nItem   
);  
```  
  
#### Parameters  
 `nItem`  
 Zero-based value of the item to delete.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Example  
 [!code[NVC_MFC_CTabCtrl#3](../vs140/codesnippet/CPP/ctabctrl--deleteitem_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTabCtrl Class](../vs140/ctabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTabCtrl::DeleteAllItems](../vs140/ctabctrl--deleteallitems.md)