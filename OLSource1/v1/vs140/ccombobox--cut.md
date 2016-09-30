---
title: "CComboBox::Cut"
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
  - "Cut"
  - "CComboBox::Cut"
  - "CComboBox.Cut"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Cut method"
ms.assetid: 92895914-bf87-4731-9f6e-08b7c83e4109
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::Cut
Deletes (cuts) the current selection, if any, in the combo-box edit control and copies the deleted text onto the Clipboard in **CF_TEXT** format.  
  
## Syntax  
  
```  
  
void Cut( );  
```  
  
## Remarks  
 To delete the current selection without placing the deleted text onto the Clipboard, call the [Clear](../vs140/ccombobox--clear.md) member function.  
  
## Example  
 [!code[NVC_MFC_CComboBox#7](../vs140/codesnippet/CPP/ccombobox--cut_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::Clear](../vs140/ccombobox--clear.md)   
 [CComboBox::Copy](../vs140/ccombobox--copy.md)   
 [CComboBox::Paste](../vs140/ccombobox--paste.md)   
 [WM_CUT](http://msdn.microsoft.com/library/windows/desktop/ms649023)