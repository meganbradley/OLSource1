---
title: "CComboBox::SetTopIndex"
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
  - "CComboBox.SetTopIndex"
  - "CComboBox::SetTopIndex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTopIndex method"
ms.assetid: 38f789a1-466d-4d08-839c-0d44a2f77935
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::SetTopIndex
Ensures that a particular item is visible in the list-box portion of the combo box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the list-box item.  
  
## Return Value  
 Zero if successful, or **CB_ERR** if an error occurs.  
  
## Remarks  
 The system scrolls the list box until either the item specified by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> appears at the top of the list box or the maximum scroll range has been reached.  
  
## Example  
 [!code[NVC_MFC_CComboBox#40](../vs140/codesnippet/CPP/ccombobox--settopindex_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::GetTopIndex](../vs140/ccombobox--gettopindex.md)   
 [CB_SETTOPINDEX](http://msdn.microsoft.com/library/windows/desktop/bb775917)