---
title: "CComboBox::GetEditSel"
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
  - GetEditSel
  - CComboBox::GetEditSel
  - CComboBox.GetEditSel
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetEditSel method
ms.assetid: b28d9022-129a-4025-916d-3238ac5f0216
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComboBox::GetEditSel
Gets the starting and ending character positions of the current selection in the edit control of a combo box.  
  
## Syntax  
  
```  
  
DWORD GetEditSel( ) const;  
```  
  
## Return Value  
 A 32-bit value that contains the starting position in the low-order word and the position of the first nonselected character after the end of the selection in the high-order word. If this function is used on a combo box without an edit control, **CB_ERR** is returned.  
  
## Example  
 [!code[NVC_MFC_CComboBox#18](../vs140/codesnippet/CPP/ccombobox--geteditsel_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::SetEditSel](../vs140/ccombobox--seteditsel.md)   
 [CB_GETEDITSEL](http://msdn.microsoft.com/library/windows/desktop/bb775853)