---
title: "CListCtrl::SetColumn"
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
  - "CListCtrl::SetColumn"
  - "SetColumn"
  - "CListCtrl.SetColumn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetColumn method"
ms.assetid: 72e568e4-6161-4cf2-a763-f2798ad51d17
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListCtrl::SetColumn
Sets the attributes of a list view column.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Index of the column whose attributes are to be set.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Address of an [LVCOLUMN](http://msdn.microsoft.com/library/windows/desktop/bb774743) structure that contains the new column attributes, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. The structure's **mask** member specifies which column attributes to set. If the **mask** member specifies the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> value, the structure's **pszText** member is the address of a null-terminated string and the structure's **cchTextMax** member is ignored.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Example  
 See the example for [CListCtrl::GetColumn](../vs140/clistctrl--getcolumn.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CListCtrl Class](../vs140/clistctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListCtrl::GetColumn](../vs140/clistctrl--getcolumn.md)