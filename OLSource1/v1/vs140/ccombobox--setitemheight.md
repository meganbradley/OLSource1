---
title: "CComboBox::SetItemHeight"
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
  - "CComboBox.SetItemHeight"
  - "CComboBox::SetItemHeight"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetItemHeight method"
ms.assetid: 97f33f2f-e876-47b9-be12-77835bb1a1e5
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::SetItemHeight
Call the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function to set the height of list items in a combo box or the height of the edit-control (or static-text) portion of a combo box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies whether the height of list items or the height of the edit-control (or static-text) portion of the combo box is set.  
  
 If the combo box has the [CBS_OWNERDRAWVARIABLE](../vs140/combo-box-styles.md) style, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> specifies the zero-based index of the list item whose height is to be set; otherwise, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> must be 0 and the height of all list items will be set.  
  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is –1, the height of the edit-control or static-text portion of the combo box is to be set.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the height, in pixels, of the combo-box component identified by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Return Value  
 **CB_ERR** if the index or height is invalid; otherwise 0.  
  
## Remarks  
 The height of the edit-control (or static-text) portion of the combo box is set independently of the height of the list items. An application must ensure that the height of the edit-control (or static-text) portion is not smaller than the height of a particular list-box item.  
  
## Example  
 [!code[NVC_MFC_CComboBox#38](../vs140/codesnippet/CPP/ccombobox--setitemheight_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::GetItemHeight](../vs140/ccombobox--getitemheight.md)   
 [WM_MEASUREITEM](http://msdn.microsoft.com/library/windows/desktop/bb775925)   
 [CB_SETITEMHEIGHT](http://msdn.microsoft.com/library/windows/desktop/bb775911)