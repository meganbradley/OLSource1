---
title: "CComboBox::CompareItem"
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
  - "CComboBox::CompareItem"
  - "CComboBox.CompareItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComboBox class, overridables"
  - "CompareItem method"
ms.assetid: ca323a36-1cf8-433e-ba76-8c54ec0050e6
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::CompareItem
Called by the framework to determine the relative position of a new item in the list-box portion of a sorted owner-draw combo box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A long pointer to a [COMPAREITEMSTRUCT](../vs140/compareitemstruct-structure.md) structure.  
  
## Return Value  
 Indicates the relative position of the two items described in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> structure. It can be any of the following values:  
  
|Value|Meaning|  
|-----------|-------------|  
|– 1|Item 1 sorts before item 2.|  
|0|Item 1 and item 2 sort the same.|  
|1|Item 1 sorts after item 2.|  
  
 See [CWnd::OnCompareItem](../vs140/cwnd--oncompareitem.md) for a description of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 By default, this member function does nothing. If you create an owner-draw combo box with the **LBS_SORT** style, you must override this member function to assist the framework in sorting new items added to the list box.  
  
## Example  
 [!code[NVC_MFC_CComboBox#5](../vs140/codesnippet/CPP/ccombobox--compareitem_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_COMPAREITEM](http://msdn.microsoft.com/library/windows/desktop/bb775921)   
 [CComboBox::DrawItem](../vs140/ccombobox--drawitem.md)   
 [CComboBox::MeasureItem](../vs140/ccombobox--measureitem.md)   
 [CComboBox::DeleteItem](../vs140/ccombobox--deleteitem.md)