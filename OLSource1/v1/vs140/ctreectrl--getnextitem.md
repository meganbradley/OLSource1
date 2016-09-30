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
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::GetNextItem
Call this function to retrieve the tree view item that has the specified relationship, indicated by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> parameter, to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Handle of a tree item.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A flag indicating the type of relation to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. This flag can be one of the following values:  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> Retrieves the currently selected item.  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> Retrieves the first child item of the item specified by the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter.  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> Retrieves the item that is the target of a drag-and-drop operation.  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> Retrieves the first visible item.  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> Retrieves the last expanded item in the tree. This does not retrieve the last item visible in the tree-view window.  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> Retrieves the next sibling item.  
  
-   <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> Retrieves the next visible item that follows the specified item.  
  
-   <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> Retrieves the parent of the specified item.  
  
-   <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> Retrieves the previous sibling item.  
  
-   <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> Retrieves the first visible item that precedes the specified item.  
  
-   <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> Retrieves the first child item of the root item of which the specified item is a part.  
  
## Return Value  
 The handle of the next item if successful; otherwise **NULL**.  
  
## Remarks  
 This function will return **NULL** if the item being retrieved is the root node of the tree. For example, if you use this message with the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> flag on a first-level child of the tree view's root node, the message will return **NULL**.  
  
## Example  
 For an example of using <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> in a loop, see [CTreeCtrl::DeleteItem](../vs140/ctreectrl--deleteitem.md).  
  
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