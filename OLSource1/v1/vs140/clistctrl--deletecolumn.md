---
title: "CListCtrl::DeleteColumn"
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
  - "CListCtrl::DeleteColumn"
  - "CListCtrl.DeleteColumn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DeleteColumn method"
ms.assetid: c9ea2506-36f1-494b-8f74-f5b2e8ecc0f4
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::DeleteColumn
Deletes a column from the list view control.  
  
## Syntax  
  
```  
  
      BOOL DeleteColumn(  
   int nCol   
);  
```  
  
#### Parameters  
 `nCol`  
 Index of the column to be deleted.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Example  
 [!code[NVC_MFC_CListCtrl#5](../vs140/codesnippet/CPP/clistctrl--deletecolumn_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::InsertColumn](../vs140/clistctrl--insertcolumn.md)   
 [CListCtrl::DeleteAllItems](../vs140/clistctrl--deleteallitems.md)