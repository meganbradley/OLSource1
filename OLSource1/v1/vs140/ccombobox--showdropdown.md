---
title: "CComboBox::ShowDropDown"
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
  - "ShowDropDown"
  - "CComboBox.ShowDropDown"
  - "CComboBox::ShowDropDown"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ShowDropDown method"
ms.assetid: a8dec9b8-d827-4ad7-a4f3-889420fd1a8f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::ShowDropDown
Shows or hides the list box of a combo box that has the [CBS_DROPDOWN](../vs140/combo-box-styles.md) or [CBS_DROPDOWNLIST](../vs140/combo-box-styles.md) style.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *bShowIt*  
 Specifies whether the drop-down list box is to be shown or hidden. A value of **TRUE** shows the list box. A value of **FALSE** hides the list box.  
  
## Remarks  
 By default, a combo box of this style will show the list box.  
  
 This member function has no effect on a combo box created with the [CBS_SIMPLE](../vs140/combo-box-styles.md) style.  
  
## Example  
 See the example for [CComboBox::GetDroppedState](../vs140/ccombobox--getdroppedstate.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CB_SHOWDROPDOWN](http://msdn.microsoft.com/library/windows/desktop/bb775919)