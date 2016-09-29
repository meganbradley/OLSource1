---
title: "CComboBox::GetItemHeight"
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
  - "GetItemHeight"
  - "CComboBox.GetItemHeight"
  - "CComboBox::GetItemHeight"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemHeight method"
ms.assetid: 669a9cfd-05cd-460f-b7d3-e80fa921fafa
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::GetItemHeight
Call the `GetItemHeight` member function to retrieve the height of list items in a combo box.  
  
## Syntax  
  
```  
  
      int GetItemHeight(  
   int nIndex   
) const;  
```  
  
#### Parameters  
 `nIndex`  
 Specifies the component of the combo box whose height is to be retrieved. If the `nIndex` parameter is –1, the height of the edit-control (or static-text) portion of the combo box is retrieved. If the combo box has the [CBS_OWNERDRAWVARIABLE](../vs140/combo-box-styles.md) style, `nIndex` specifies the zero-based index of the list item whose height is to be retrieved. Otherwise, `nIndex` should be set to 0.  
  
## Return Value  
 The height, in pixels, of the specified item in a combo box. The return value is **CB_ERR** if an error occurs.  
  
## Example  
 [!code[NVC_MFC_CComboBox#23](../vs140/codesnippet/CPP/ccombobox--getitemheight_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::SetItemHeight](../vs140/ccombobox--setitemheight.md)   
 [WM_MEASUREITEM](http://msdn.microsoft.com/library/windows/desktop/bb775925)   
 [CB_GETITEMHEIGHT](http://msdn.microsoft.com/library/windows/desktop/bb775860)