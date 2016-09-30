---
title: "CComboBox::Paste"
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
  - "CComboBox.Paste"
  - "CComboBox::Paste"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Paste method"
ms.assetid: cfe35b59-d8e2-47bb-8cc7-9b0e21d951c2
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::Paste
Inserts the data from the Clipboard into the edit control of the combo box at the current cursor position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Data is inserted only if the Clipboard contains data in **CF_TEXT** format.  
  
## Example  
 [!code[NVC_MFC_CComboBox#30](../vs140/codesnippet/CPP/ccombobox--paste_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::Clear](../vs140/ccombobox--clear.md)   
 [CComboBox::Copy](../vs140/ccombobox--copy.md)   
 [CComboBox::Cut](../vs140/ccombobox--cut.md)   
 [WM_PASTE](http://msdn.microsoft.com/library/windows/desktop/ms649028)