---
title: "CComboBox::GetTopIndex"
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
  - "CComboBox.GetTopIndex"
  - "CComboBox::GetTopIndex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTopIndex method"
ms.assetid: 6776c539-b8a0-48ba-a956-2a423c3fbe5f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::GetTopIndex
Retrieves the zero-based index of the first visible item in the list-box portion of the combo box.  
  
## Syntax  
  
```  
  
int GetTopIndex( ) const;  
  
```  
  
## Return Value  
 The zero-based index of the first visible item in the list-box portion of the combo box if successful, **CB_ERR** otherwise.  
  
## Remarks  
 Initially, item 0 is at the top of the list box, but if the list box is scrolled, another item may be at the top.  
  
## Example  
 [!code[NVC_MFC_CComboBox#25](../vs140/codesnippet/CPP/ccombobox--gettopindex_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::SetTopIndex](../vs140/ccombobox--settopindex.md)   
 [CB_GETTOPINDEX](http://msdn.microsoft.com/library/windows/desktop/bb775871)