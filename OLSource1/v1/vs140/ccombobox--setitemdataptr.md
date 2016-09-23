---
title: "CComboBox::SetItemDataPtr"
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
  - CComboBox.SetItemDataPtr
  - CComboBox::SetItemDataPtr
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetItemDataPtr method
ms.assetid: cd1924b1-29ce-4704-9c3b-e8a6d9360e42
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComboBox::SetItemDataPtr
Sets the 32-bit value associated with the specified item in a combo box to be the specified pointer (**void\***).  
  
## Syntax  
  
```  
  
      int SetItemDataPtr(   
   int nIndex,   
   void* pData   
);  
```  
  
#### Parameters  
 `nIndex`  
 Contains a zero-based index to the item.  
  
 `pData`  
 Contains the pointer to associate with the item.  
  
## Return Value  
 **CB_ERR** if an error occurs.  
  
## Remarks  
 This pointer remains valid for the life of the combo box, even though the item's relative position within the combo box might change as items are added or removed. Hence, the item's index within the box can change, but the pointer remains reliable.  
  
## Example  
 [!code[NVC_MFC_CComboBox#37](../vs140/codesnippet/CPP/ccombobox--setitemdataptr_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::DeleteItem](../vs140/ccombobox--deleteitem.md)   
 [CComboBox::GetItemData](../vs140/ccombobox--getitemdata.md)   
 [CComboBox::GetItemDataPtr](../vs140/ccombobox--getitemdataptr.md)   
 [CComboBox::SetItemData](../vs140/ccombobox--setitemdata.md)   
 [CB_SETITEMDATA](http://msdn.microsoft.com/library/windows/desktop/bb775909)   
 [CComboBox::AddString](../vs140/ccombobox--addstring.md)   
 [CComboBox::InsertString](../vs140/ccombobox--insertstring.md)