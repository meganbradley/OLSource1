---
title: "CComboBox::SetItemData"
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
  - "CComboBox::SetItemData"
  - "CComboBox.SetItemData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetItemData method"
ms.assetid: 61735c4e-b75f-46c9-a7a5-333460145d6a
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::SetItemData
Sets the 32-bit value associated with the specified item in a combo box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Contains a zero-based index to the item to set.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Contains the new value to associate with the item.  
  
## Return Value  
 **CB_ERR** if an error occurs.  
  
## Remarks  
 Use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member function if the 32-bit item is to be a pointer.  
  
## Example  
 [!code[NVC_MFC_CComboBox#36](../vs140/codesnippet/CPP/ccombobox--setitemdata_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::GetItemData](../vs140/ccombobox--getitemdata.md)   
 [CComboBox::GetItemDataPtr](../vs140/ccombobox--getitemdataptr.md)   
 [CComboBox::SetItemDataPtr](../vs140/ccombobox--setitemdataptr.md)   
 [CB_SETITEMDATA](http://msdn.microsoft.com/library/windows/desktop/bb775909)   
 [CComboBox::AddString](../vs140/ccombobox--addstring.md)   
 [CComboBox::InsertString](../vs140/ccombobox--insertstring.md)