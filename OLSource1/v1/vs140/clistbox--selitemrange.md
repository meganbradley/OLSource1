---
title: "CListBox::SelItemRange"
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
  - "CListBox.SelItemRange"
  - "CListBox::SelItemRange"
  - "SelItemRange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CListBox class, multiple-selection operations"
  - "SelItemRange method"
ms.assetid: 50656902-20e3-45b9-87c8-e3631d732fbd
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::SelItemRange
Selects multiple consecutive items in a multiple-selection list box.  
  
## Syntax  
  
```  
  
      int SelItemRange(  
   BOOL bSelect,  
   int nFirstItem,  
   int nLastItem   
);  
```  
  
#### Parameters  
 `bSelect`  
 Specifies how to set the selection. If `bSelect` is **TRUE**, the string is selected and highlighted; if **FALSE**, the highlight is removed and the string is no longer selected.  
  
 `nFirstItem`  
 Specifies the zero-based index of the first item to set.  
  
 `nLastItem`  
 Specifies the zero-based index of the last item to set.  
  
## Return Value  
 **LB_ERR** if an error occurs.  
  
## Remarks  
 Use this member function only with multiple-selection list boxes. If you need to select only one item in a multiple-selection list box — that is, if `nFirstItem` is equal to `nLastItem` — call the [SetSel](../vs140/clistbox--setsel.md) member function instead.  
  
## Example  
 [!code[NVC_MFC_CListBox#28](../vs140/codesnippet/CPP/clistbox--selitemrange_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LB_SELITEMRANGE](http://msdn.microsoft.com/library/windows/desktop/bb761329)   
 [CListBox::GetSelItems](../vs140/clistbox--getselitems.md)