---
title: "CTreeCtrl::ItemHasChildren"
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
  - CTreeCtrl::ItemHasChildren
  - CTreeCtrl.ItemHasChildren
  - ItemHasChildren
dev_langs: 
  - C++
helpviewer_keywords: 
  - ItemHasChildren method
ms.assetid: b432c2f4-ddef-479b-8337-606d289ecf37
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CTreeCtrl::ItemHasChildren
Use this function to determine whether the tree item specified by `hItem` has child items.  
  
## Syntax  
  
```  
  
      BOOL ItemHasChildren(  
   HTREEITEM hItem   
) const;  
```  
  
#### Parameters  
 `hItem`  
 Handle of a tree item.  
  
## Return Value  
 Nonzero if the tree item specified by `hItem` has child items; 0 if it does not.  
  
## Remarks  
 If so, you can then use [CTreeCtrl::GetChildItem](../vs140/ctreectrl--getchilditem.md) to retrieve those child items.  
  
## Example  
 See the example for [CTreeCtrl::GetSelectedItem](../vs140/ctreectrl--getselecteditem.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::GetChildItem](../vs140/ctreectrl--getchilditem.md)