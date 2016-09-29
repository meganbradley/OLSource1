---
title: "CTreeCtrl::Select"
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
  - "CTreeCtrl.Select"
  - "CTreeCtrl::Select"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Select method"
  - "TVGN_CARET"
  - "TVGN_FIRSTVISIBLE"
  - "TVGN_DROPHILITE"
ms.assetid: 7ed5e67b-ed47-45db-9273-58cc29b5fc88
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::Select
Call this function to select the given tree view item, scroll the item into view, or redraw the item in the style used to indicate the target of a drag-and-drop operation.  
  
## Syntax  
  
```  
  
      BOOL Select(  
   HTREEITEM hItem,  
   UINT nCode   
);  
```  
  
#### Parameters  
 `hItem`  
 Handle of a tree item.  
  
 `nCode`  
 The type of action to take. This parameter can be one of the following values:  
  
-   `TVGN_CARET` Sets the selection to the given item.  
  
-   `TVGN_DROPHILITE` Redraws the given item in the style used to indicate the target of a drag-and-drop operation.  
  
-   `TVGN_FIRSTVISIBLE` Scrolls the tree view vertically so that the given item is the first visible item.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 If `nCode` contains the value `TVGN_CARET`, the parent window receives the **TVN_SELCHANGING** and **TVN_SELCHANGED** notification messages. In addition, if the specified item is the child of a collapsed parent item, the parent's list of child items is expanded to reveal the specified item. In this case, the parent window receives the **TVN_ITEMEXPANDING** and **TVN_ITEMEXPANDED** notification messages.  
  
## Example  
 See the example for [CTreeCtrl::HitTest](../vs140/ctreectrl--hittest.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::SelectItem](../vs140/ctreectrl--selectitem.md)   
 [CTreeCtrl::GetSelectedItem](../vs140/ctreectrl--getselecteditem.md)   
 [CTreeCtrl::SelectDropTarget](../vs140/ctreectrl--selectdroptarget.md)