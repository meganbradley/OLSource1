---
title: "CTreeCtrl::DeleteItem"
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
  - "CTreeCtrl.DeleteItem"
  - "CTreeCtrl::DeleteItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DeleteItem method"
ms.assetid: 3835f7bc-1f09-4214-b77e-827506f02599
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::DeleteItem
Call this function to delete an item from the tree view control.  
  
## Syntax  
  
```  
  
      BOOL DeleteItem(  
   HTREEITEM hItem   
);  
```  
  
#### Parameters  
 `hItem`  
 Handle of the tree item to be deleted. If *hitem* has the **TVI_ROOT** value, all items are deleted from the tree view control.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#4](../vs140/codesnippet/CPP/ctreectrl--deleteitem_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::DeleteAllItems](../vs140/ctreectrl--deleteallitems.md)   
 [CTreeCtrl::InsertItem](../vs140/ctreectrl--insertitem.md)