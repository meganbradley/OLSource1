---
title: "CListBox::GetCurSel"
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
  - "CListBox::GetCurSel"
  - "CListBox.GetCurSel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CListBox class, single-selection operations"
  - "GetCurSel method"
ms.assetid: e931f4a7-bdcb-4bbf-b23c-e51f69912634
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::GetCurSel
Retrieves the zero-based index of the currently selected item, if any, in a single-selection list box.  
  
## Syntax  
  
```  
int GetCurSel( ) const;  
```  
  
## Return Value  
 The zero-based index of the currently selected item if it is a single-selection list box. It is `LB_ERR` if no item is currently selected.  
  
 In a multiple-selection list box, the index of the item that has the focus.  
  
## Remarks  
 Do not call `GetCurSel` for a multiple-selection list box. Use [CListBox::GetSelItems](../vs140/clistbox--getselitems.md) instead.  
  
## Example  
 [!code[NVC_MFC_CListBox#13](../vs140/codesnippet/CPP/clistbox--getcursel_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LB_GETCURSEL](http://msdn.microsoft.com/library/windows/desktop/bb775197)   
 [CListBox::SetCurSel](../vs140/clistbox--setcursel.md)   
 [CListBox::GetSelItems](../vs140/clistbox--getselitems.md)