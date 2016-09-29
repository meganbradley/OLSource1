---
title: "CListCtrl::SetItem"
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
  - "CListCtrl.SetItem"
  - "CListCtrl::SetItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LVIF_TEXT"
  - "LVIF_STATE"
  - "SetItem method"
ms.assetid: d9d956b3-c14d-42b8-a5f0-108d7a3ccfd6
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::SetItem
Sets some or all of a list view item's attributes.  
  
## Syntax  
  
```  
  
      BOOL SetItem(  
   const LVITEM* pItem   
);  
BOOL SetItem(  
   int nItem,  
   int nSubItem,  
   UINT nMask,  
   LPCTSTR lpszItem,  
   int nImage,  
   UINT nState,  
   UINT nStateMask,  
   LPARAM lParam   
);  
BOOL SetItem(  
   int nItem,  
   int nSubItem,  
   UINT nMask,  
   LPCTSTR lpszItem,  
   int nImage,  
   UINT nState,  
   UINT nStateMask,  
   LPARAM lParam,  
   int nIndent   
);  
```  
  
#### Parameters  
 `pItem`  
 Address of an [LVITEM](http://msdn.microsoft.com/library/windows/desktop/bb774760) structure that contains the new item attributes, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. The structure's **iItem** and **iSubItem** members identify the item or subitem, and the structure's **mask** member specifies which attributes to set. For more information on the **mask** member, see the **Remarks**.  
  
 `nItem`  
 Index of the item whose attributes are to be set.  
  
 `nSubItem`  
 Index of the subitem whose attributes are to be set.  
  
 `nMask`  
 Specifies which attributes are to be set (see the Remarks).  
  
 `lpszItem`  
 Address of a null-terminated string specifying the item's label.  
  
 `nImage`  
 Index of the item's image within the image list.  
  
 `nState`  
 Specifies values for states to be changed (see the Remarks).  
  
 `nStateMask`  
 Specifies which states are to be changed (see the Remarks).  
  
 `lParam`  
 A 32-bit application-specific value to be associated with the item.  
  
 `nIndent`  
 Width, in pixels, of the indentation. If `nIndent` is less than the system-defined minimum width, the new width is set to the system-defined minimum  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 The **iItem** and **iSubItem** members of the **LVITEM** structure and the `nItem` and `nSubItem` parameters identify the item and subitem whose attributes are to be set.  
  
 The **mask** member of the **LVITEM** structure and the `nMask` parameter specify which item attributes are to be set:  
  
-   `LVIF_TEXT` The **pszText** member or the `lpszItem` parameter is the address of a null-terminated string; the **cchTextMax** member is ignored.  
  
-   `LVIF_STATE` The **stateMask** member or `nStateMask` parameter specifies which item states to change and the **state** member or `nState` parameter contains the values for those states.  
  
## Example  
 See the example for [CListCtrl::HitTest](../vs140/clistctrl--hittest.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::GetItem](../vs140/clistctrl--getitem.md)