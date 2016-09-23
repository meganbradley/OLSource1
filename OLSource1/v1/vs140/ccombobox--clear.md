---
title: "CComboBox::Clear"
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
  - CComboBox.Clear
  - CComboBox::Clear
dev_langs: 
  - C++
helpviewer_keywords: 
  - Clear method
ms.assetid: dcd6f6ec-3303-4a29-a470-3dc00f961777
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComboBox::Clear
Deletes (clears) the current selection, if any, in the edit control of the combo box.  
  
## Syntax  
  
```  
  
void Clear( );  
```  
  
## Remarks  
 To delete the current selection and place the deleted contents onto the Clipboard, use the [Cut](../vs140/ccombobox--cut.md) member function.  
  
## Example  
 [!code[NVC_MFC_CComboBox#4](../vs140/codesnippet/CPP/ccombobox--clear_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::Copy](../vs140/ccombobox--copy.md)   
 [CComboBox::Cut](../vs140/ccombobox--cut.md)   
 [CComboBox::Paste](../vs140/ccombobox--paste.md)   
 [WM_CLEAR](http://msdn.microsoft.com/library/windows/desktop/ms649020)