---
title: "CTreeCtrl::GetChildItem"
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
  - "GetChildItem"
  - "CTreeCtrl.GetChildItem"
  - "CTreeCtrl::GetChildItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetChildItem method"
ms.assetid: fde6e18f-e954-4892-b472-474015e4fff9
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::GetChildItem
Call this function to retrieve the tree view item that is the child of the item specified by `hItem`.  
  
## Syntax  
  
```  
  
      HTREEITEM GetChildItem(  
   HTREEITEM hItem   
) const;  
```  
  
#### Parameters  
 `hItem`  
 Handle of a tree item.  
  
## Return Value  
 The handle of the child item if successful; otherwise **NULL**.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#7](../vs140/codesnippet/CPP/ctreectrl--getchilditem_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::GetItem](../vs140/ctreectrl--getitem.md)   
 [CTreeCtrl::GetParentItem](../vs140/ctreectrl--getparentitem.md)   
 [CTreeCtrl::SortChildren](../vs140/ctreectrl--sortchildren.md)