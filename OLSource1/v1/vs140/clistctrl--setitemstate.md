---
title: "CListCtrl::SetItemState"
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
  - "CListCtrl::SetItemState"
  - "CListCtrl.SetItemState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetItemState method"
ms.assetid: d1bdd0e3-afdb-4e25-ac77-3f9d85e313f2
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::SetItemState
Changes the state of an item in a list view control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Index of the item whose state is to be set.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Address of an [LVITEM](http://msdn.microsoft.com/library/windows/desktop/bb774760) structure, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. The structure's **stateMask** member specifies which state bits to change, and the structure's **state** member contains the new values for those bits. The other members are ignored.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 New values for the state bits. For a list of possible values, see [CListCtrl::GetNextItem](../vs140/clistctrl--getnextitem.md) and the [LVITEM](http://msdn.microsoft.com/library/windows/desktop/bb774760) state member.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Mask specifying which state bits to change. This value corresponds to the stateMask member of  the [LVITEM](http://msdn.microsoft.com/library/windows/desktop/bb774760) structure.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 An item's "state" is a value that specifies the item's availability, indicates user actions, or otherwise reflects the item's status. A list view control changes some state bits, such as when the user selects an item. An application might change other state bits to disable or hide the item, or to specify an overlay image or state image.  
  
## Example  
 See the example for [CListCtrl::GetTopIndex](../vs140/clistctrl--gettopindex.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::GetItemState](../vs140/clistctrl--getitemstate.md)