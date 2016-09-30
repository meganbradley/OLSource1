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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a [TVITEM](http://msdn.microsoft.com/library/windows/desktop/bb773456) structure that contains the new item attributes, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Handle of the item whose attributes are to be set. See the **hItem** member of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Integer specifying which attributes to set. See the **mask** member of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> structure.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Address of a string containing the item's text.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Index of the item's image in the tree view control's image list. See the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> member of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> structure.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Index of the item's selected image in the tree view control's image list. See the **iSelectedImage** member of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> structure.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Specifies values for the item's states. See the **State** member of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> structure.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Specifies which states are to be set. See the **stateMask** member of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> structure.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 A 32-bit application-specific value associated with the item.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 In the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> structure, the **hItem** member identifies the item, and the **mask** member specifies which attributes to set.  
  
 If the **mask** member or the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> parameter specifies the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> value, the **pszText** member or the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is the address of a null-terminated string and the **cchTextMax** member is ignored. If **mask** (or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>) specifies the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> value, the **stateMask** member or the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> parameter specifies which item states to change and the **state** member or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> parameter contains the values for those states.  
  
## Example  
 [!code[NVC_MFC_CTreeCtrl#32](../vs140/codesnippet/CPP/ctreectrl--setitem_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTreeCtrl::GetItem](../vs140/ctreectrl--getitem.md)