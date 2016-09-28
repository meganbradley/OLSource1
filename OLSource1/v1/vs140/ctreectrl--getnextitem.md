---
title: "CTreeCtrl::GetNextItem"
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
  - "CTreeCtrl.GetNextItem"
  - "TVGN_CARET"
  - "TVGN_PREVIOUSVISIBLE"
  - "TVGN_NEXTVISIBLE"
  - "TVGN_ROOT"
  - "TVGN_FIRSTVISIBLE"
  - "TVGN_PARENT"
  - "CTreeCtrl::GetNextItem"
  - "TVGN_DROPHILITE"
  - "TVGN_PREVIOUS"
  - "TVGN_CHILD"
  - "TVGN_NEXT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TVGN_PREVIOUSVISIBLE"
  - "GetNextItem method"
  - "TVGN_PARENT"
  - "TVGN_ROOT"
  - "TVGN_CARET"
  - "TVGN_PREVIOUS"
  - "TVGN_FIRSTVISIBLE"
  - "TVGN_CHILD"
  - "TVGN_NEXT"
  - "TVGN_NEXTVISIBLE"
  - "TVGN_DROPHILITE"
ms.assetid: 0f19ec21-a569-4f9e-b372-eefa821307d5
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::GetNextItem
Call this function to retrieve the tree view item that has the specified relationship, indicated by the `nCode` parameter, to `hItem`.  
  
## Syntax  
  
```  
  
      HTREEITEM GetNextItem(  
   HTREEITEM hItem,  
   UINT nCode   
) const;  
```  
  
#### Parameters  
 `hItem`  
 Handle of a tree item.  
  
 `nCode`  
 A flag indicating the type of relation to `hItem`. This flag can be one of the following values:  
  
-   `TVGN_CARET` Retrieves the currently selected item.  
  
-   `TVGN_CHILD` Retrieves the first child item of the item specified by the `hItem` parameter.  
  
-   `TVGN_DROPHILITE` Retrieves the item that is the target of a drag-and-drop operation.  
  
-   `TVGN_FIRSTVISIBLE` Retrieves the first visible item.  
  
-   `TVGN_LASTVISIBLE` Retrieves the last expanded item in the tree. This does not retrieve the last item visible in the tree-view window.  
  
-   `TVGN_NEXT` Retrieves the next sibling item.  
  
-   `TVGN_NEXTVISIBLE` Retrieves the next visible item that follows the specified item.  
  
-   `TVGN_PARENT` Retrieves the parent of the specified item.  
  
-   `TVGN_PREVIOUS` Retrieves the previous sibling item.  
  
-   `TVGN_PREVIOUSVISIBLE` Retrieves the first visible item that precedes the specified item.  
  
-   `TVGN_ROOT` Retrieves the first child item of the root item of which the specified item is a part.  
  
## Return Value  
 The handle of the next item if successful; otherwise **NULL**.  
  
## Remarks  
 This function will return **NULL** if the item being retrieved is the root node of the tree. For example, if you use this message with the `TVGN_PARENT` flag on a first-level child of the tree view's root node, the message will return **NULL**.  
  
## Example  
 For an example of using `GetNextItem` in a loop, see [CTreeCtrl::DeleteItem](../vs140/ctreectrl--deleteitem.md).  
  
 [!code[NVC_MFC_CTreeCtrl#20](../vs140/codesnippet/CPP/ctreectrl--getnextitem_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::SetItem](../vs140/ctreectrl--setitem.md)   
 [CTreeCtrl::GetChildItem](../vs140/ctreectrl--getchilditem.md)   
 [CTreeCtrl::GetItem](../vs140/ctreectrl--getitem.md)   
 [CTreeCtrl::SelectItem](../vs140/ctreectrl--selectitem.md)   
 [CTreeCtrl::GetPrevSiblingItem](../vs140/ctreectrl--getprevsiblingitem.md)