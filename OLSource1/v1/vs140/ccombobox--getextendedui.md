---
title: "CComboBox::GetExtendedUI"
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
  - "CComboBox::GetExtendedUI"
  - "GetExtendedUI"
  - "CComboBox.GetExtendedUI"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetExtendedUI method"
ms.assetid: fad4b45d-587e-445b-9e16-c536c1e22708
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::GetExtendedUI
Call the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function to determine whether a combo box has the default user interface or the extended user interface.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the combo box has the extended user interface; otherwise 0.  
  
## Remarks  
 The extended user interface can be identified in the following ways:  
  
-   Clicking the static control displays the list box only for combo boxes with the [CBS_DROPDOWNLIST](../vs140/combo-box-styles.md) style.  
  
-   Pressing the DOWN ARROW key displays the list box (F4 is disabled).  
  
 Scrolling in the static control is disabled when the item list is not visible (arrow keys are disabled).  
  
## Example  
 [!code[NVC_MFC_CComboBox#19](../vs140/codesnippet/CPP/ccombobox--getextendedui_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::SetExtendedUI](../vs140/ccombobox--setextendedui.md)   
 [CB_GETEXTENDEDUI](http://msdn.microsoft.com/library/windows/desktop/bb775855)