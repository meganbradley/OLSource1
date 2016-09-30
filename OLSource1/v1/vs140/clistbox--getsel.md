---
title: "CListBox::GetSel"
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
  - "CListBox.GetSel"
  - "CListBox::GetSel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CListBox class, general operations"
  - "GetSel method"
ms.assetid: 26551d2a-ed03-4541-8ba2-bf3d28b4e8de
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::GetSel
Retrieves the selection state of an item.  
  
## Syntax  
  
```  
  
      int GetSel(  
   int nIndex   
) const;  
```  
  
#### Parameters  
 `nIndex`  
 Specifies the zero-based index of the item.  
  
## Return Value  
 A positive number if the specified item is selected; otherwise, it is 0. The return value is `LB_ERR` if an error occurs.  
  
## Remarks  
 This member function works with both single- and multiple-selection list boxes.  
  
 To retrieve the index of the currently-selected list box item, use [CListBox::GetCurSel](../vs140/clistbox--getcursel.md).  
  
## Example  
 [!code[NVC_MFC_CListBox#19](../vs140/codesnippet/CPP/clistbox--getsel_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LB_GETSEL](http://msdn.microsoft.com/library/windows/desktop/bb775212)   
 [CListBox::SetSel](../vs140/clistbox--setsel.md)   
 [CListBox::GetCurSel](../vs140/clistbox--getcursel.md)