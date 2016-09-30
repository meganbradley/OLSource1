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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Address of an [LVITEM](http://msdn.microsoft.com/library/windows/desktop/bb774760) structure that contains the new item attributes, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. The structure's **iItem** and **iSubItem** members identify the item or subitem, and the structure's **mask** member specifies which attributes to set. For more information on the **mask** member, see the **Remarks**.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Index of the item whose attributes are to be set.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Index of the subitem whose attributes are to be set.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies which attributes are to be set (see the Remarks).  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Address of a null-terminated string specifying the item's label.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Index of the item's image within the image list.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies values for states to be changed (see the Remarks).  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Specifies which states are to be changed (see the Remarks).  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A 32-bit application-specific value to be associated with the item.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Width, in pixels, of the indentation. If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is less than the system-defined minimum width, the new width is set to the system-defined minimum  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 The **iItem** and **iSubItem** members of the **LVITEM** structure and the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameters identify the item and subitem whose attributes are to be set.  
  
 The **mask** member of the **LVITEM** structure and the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameter specify which item attributes are to be set:  
  
-   <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> The **pszText** member or the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> parameter is the address of a null-terminated string; the **cchTextMax** member is ignored.  
  
-   <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> The **stateMask** member or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> parameter specifies which item states to change and the **state** member or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> parameter contains the values for those states.  
  
## Example  
 See the example for [CListCtrl::HitTest](../vs140/clistctrl--hittest.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::GetItem](../vs140/clistctrl--getitem.md)