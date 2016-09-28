---
title: "CComboBox::MeasureItem"
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
  - "CComboBox::MeasureItem"
  - "CComboBox.MeasureItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MeasureItem method"
  - "CComboBox class, overridables"
ms.assetid: 389f0d45-b443-4de2-ab13-a58aaad90d87
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::MeasureItem
Called by the framework when a combo box with an owner-draw style is created.  
  
## Syntax  
  
```  
  
      virtual void MeasureItem(  
   LPMEASUREITEMSTRUCT lpMeasureItemStruct   
);  
```  
  
#### Parameters  
 `lpMeasureItemStruct`  
 A long pointer to a [MEASUREITEMSTRUCT](../vs140/measureitemstruct-structure.md) structure.  
  
## Remarks  
 By default, this member function does nothing. Override this member function and fill in the `MEASUREITEMSTRUCT` structure to inform Windows of the dimensions of the list box in the combo box. If the combo box is created with the [CBS_OWNERDRAWVARIABLE](../vs140/combo-box-styles.md) style, the framework calls this member function for each item in the list box. Otherwise, this member is called only once.  
  
 Using the **CBS_OWNERDRAWFIXED** style in an owner-draw combo box created with the [SubclassDlgItem](../vs140/cwnd--subclassdlgitem.md) member function of `CWnd` involves further programming considerations. See the discussion in [Technical Note 14](../vs140/tn014--custom-controls.md).  
  
 See [CWnd::OnMeasureItem](../vs140/cwnd--onmeasureitem.md) for a description of the `MEASUREITEMSTRUCT` structure.  
  
## Example  
 [!code[NVC_MFC_CComboBox#29](../vs140/codesnippet/CPP/ccombobox--measureitem_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::CompareItem](../vs140/ccombobox--compareitem.md)   
 [CComboBox::DrawItem](../vs140/ccombobox--drawitem.md)   
 [WM_MEASUREITEM](http://msdn.microsoft.com/library/windows/desktop/bb775925)   
 [CComboBox::DeleteItem](../vs140/ccombobox--deleteitem.md)