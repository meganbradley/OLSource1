---
title: "CTreeCtrl::SetItem"
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
  - "CTreeCtrl::SetItem"
  - "CTreeCtrl.SetItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetItem method"
ms.assetid: 3c14d402-a4c8-4f0e-ba1b-1666a6abce6e
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTreeCtrl::SetItem
Call this function to set the attributes of the specified tree view item.  
  
## Syntax  
  
```  
  
      BOOL SetItem(  
   TVITEM* pItem   
);  
BOOL SetItem(  
   HTREEITEM hItem,  
   UINT nMask,  
   LPCTSTR lpszItem,  
   int nImage,  
   int nSelectedImage,  
   UINT nState,  
   UINT nStateMask,  
   LPARAM lParam   
);  
```  
  
#### Parameters  
 `pItem`  
 A pointer to a [TVITEM](http://msdn.microsoft.com/library/windows/desktop/bb773456) structure that contains the new item attributes, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `hItem`  
 Handle of the item whose attributes are to be set. See the **hItem** member of the `TVITEM` structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `nMask`  
 Integer specifying which attributes to set. See the **mask** member of the `TVITEM` structure.  
  
 `lpszItem`  
 Address of a string containing the item's text.  
  
 `nImage`  
 Index of the item's image in the tree view control's image list. See the `iImage` member of the `TVITEM` structure.  
  
 `nSelectedImage`  
 Index of the item's selected image in the tree view control's image list. See the **iSelectedImage** member of the `TVITEM` structure.  
  
 `nState`  
 Specifies values for the item's states. See the **State** member of the `TVITEM` structure.  
  
 `nStateMask`  
 Specifies which states are to be set. See the **stateMask** member of the `TVITEM` structure.  
  
 `lParam`  
 A 32-bit application-specific value associated with the item.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 In the `TVITEM` structure, the **hItem** member identifies the item, and the **mask** member specifies which attributes to set.  
  
 If the **mask** member or the `nMask` parameter specifies the `TVIF_TEXT` value, the **pszText** member or the `lpszItem` is the address of a null-terminated string and the **cchTextMax** member is ignored. If **mask** (or `nMask`) specifies the `TVIF_STATE` value, the **stateMask** member or the `nStateMask` parameter specifies which item states to change and the **state** member or `nState` parameter contains the values for those states.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#32](../vs140/codesnippet/CPP/ctreectrl--setitem_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::GetItem](../vs140/ctreectrl--getitem.md)