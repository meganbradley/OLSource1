---
title: "CComboBox::SetHorizontalExtent"
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
  - "CComboBox::SetHorizontalExtent"
  - "CComboBox.SetHorizontalExtent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetHorizontalExtent method"
ms.assetid: 5248ea78-1472-4f98-9a10-81bef0a12c12
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::SetHorizontalExtent
Sets the width, in pixels, by which the list-box portion of the combo box can be scrolled horizontally.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *nExtent*  
 Specifies the number of pixels by which the list-box portion of the combo box can be scrolled horizontally.  
  
## Remarks  
 If the width of the list box is smaller than this value, the horizontal scroll bar will horizontally scroll items in the list box. If the width of the list box is equal to or greater than this value, the horizontal scroll bar is hidden or, if the combo box has the [CBS_DISABLENOSCROLL](../vs140/combo-box-styles.md) style, disabled.  
  
## Example  
 [!code[NVC_MFC_CComboBox#35](../vs140/codesnippet/CPP/ccombobox--sethorizontalextent_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::GetHorizontalExtent](../vs140/ccombobox--gethorizontalextent.md)   
 [CB_SETHORIZONTALEXTENT](http://msdn.microsoft.com/library/windows/desktop/bb775907)