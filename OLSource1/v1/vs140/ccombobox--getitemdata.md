---
title: "CComboBox::GetItemData"
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
  - "CComboBox::GetItemData"
  - "CComboBox.GetItemData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemData method"
ms.assetid: 3c9ca5de-1905-4949-84d1-6b5616a3d4b6
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::GetItemData
Retrieves the application-supplied 32-bit value associated with the specified combo-box item.  
  
## Syntax  
  
```  
  
      DWORD_PTR GetItemData(  
   int nIndex   
) const;  
```  
  
#### Parameters  
 `nIndex`  
 Contains the zero-based index of an item in the combo box's list box.  
  
## Return Value  
 The 32-bit value associated with the item, or **CB_ERR** if an error occurs.  
  
## Remarks  
 The 32-bit value can be set with the `dwItemData` parameter of a [SetItemData](../vs140/ccombobox--setitemdata.md) member function call. Use the `GetItemDataPtr` member function if the 32-bit value to be retrieved is a pointer (**void\***).  
  
## Example  
 [!code[NVC_MFC_CComboBox#21](../vs140/codesnippet/CPP/ccombobox--getitemdata_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::SetItemData](../vs140/ccombobox--setitemdata.md)   
 [CComboBox::GetItemDataPtr](../vs140/ccombobox--getitemdataptr.md)   
 [CComboBox::SetItemDataPtr](../vs140/ccombobox--setitemdataptr.md)   
 [CB_GETITEMDATA](http://msdn.microsoft.com/library/windows/desktop/bb775859)