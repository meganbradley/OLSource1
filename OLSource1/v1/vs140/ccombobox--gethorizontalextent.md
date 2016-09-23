---
title: "CComboBox::GetHorizontalExtent"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CComboBox.GetHorizontalExtent
  - GetHorizontalExtent
  - CComboBox::GetHorizontalExtent
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetHorizontalExtent method
ms.assetid: 50ab291d-3f24-46c8-93e4-04e2326e0077
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComboBox::GetHorizontalExtent
Retrieves from the combo box the width in pixels by which the list-box portion of the combo box can be scrolled horizontally.  
  
## Syntax  
  
```  
  
UINT GetHorizontalExtent( ) const;  
  
```  
  
## Return Value  
 The scrollable width of the list-box portion of the combo box, in pixels.  
  
## Remarks  
 This is applicable only if the list-box portion of the combo box has a horizontal scroll bar.  
  
## Example  
 [!code[NVC_MFC_CComboBox#20](../vs140/codesnippet/CPP/ccombobox--gethorizontalextent_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::SetHorizontalExtent](../vs140/clistbox--sethorizontalextent.md)   
 [CB_GETHORIZONTALEXTENT](http://msdn.microsoft.com/library/windows/desktop/bb775857)