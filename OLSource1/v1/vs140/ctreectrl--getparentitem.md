---
title: "CTreeCtrl::GetParentItem"
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
  - "GetParentItem"
  - "CTreeCtrl.GetParentItem"
  - "CTreeCtrl::GetParentItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetParentItem method"
ms.assetid: a8a42c8a-2da8-4f19-9e73-5f46e0e9f1e9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::GetParentItem
Call this function to retrieve the parent of `hItem`.  
  
## Syntax  
  
```  
  
      HTREEITEM GetParentItem(  
   HTREEITEM hItem   
) const;  
```  
  
#### Parameters  
 `hItem`  
 Handle of a tree item.  
  
## Return Value  
 The handle of the parent item; otherwise **NULL**.  
  
## Remarks  
 This function will return **NULL** if the parent of the specified item is the root node of the tree.  
  
## Example  
 See the example for [CTreeCtrl::EnsureVisible](../vs140/ctreectrl--ensurevisible.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::GetChildItem](../vs140/ctreectrl--getchilditem.md)   
 [CTreeCtrl::GetRootItem](../vs140/ctreectrl--getrootitem.md)   
 [CTreeCtrl::GetItem](../vs140/ctreectrl--getitem.md)   
 [CTreeCtrl::GetPrevSiblingItem](../vs140/ctreectrl--getprevsiblingitem.md)