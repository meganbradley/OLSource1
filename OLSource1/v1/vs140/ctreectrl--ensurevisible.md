---
title: "CTreeCtrl::EnsureVisible"
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
  - "CTreeCtrl::EnsureVisible"
  - "CTreeCtrl.EnsureVisible"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnsureVisible method"
ms.assetid: 67e05a30-b716-4e83-9c43-8f89d35aefdd
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::EnsureVisible
Call this function to ensure that a tree view item is visible.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Handle of the tree item being made visible.  
  
## Return Value  
 Returns **TRUE** if the system scrolled the items in the tree-view control to ensure that the specified item is visible. Otherwise, the return value is **FALSE**.  
  
## Remarks  
 If necessary, the function expands the parent item or scrolls the tree view control so that the item is visible.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#6](../vs140/codesnippet/CPP/ctreectrl--ensurevisible_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::GetFirstVisibleItem](../vs140/ctreectrl--getfirstvisibleitem.md)   
 [CTreeCtrl::GetVisibleCount](../vs140/ctreectrl--getvisiblecount.md)