---
title: "CComboBox::GetItemDataPtr"
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
  - CComboBox::GetItemDataPtr
  - CComboBox.GetItemDataPtr
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetItemDataPtr method
ms.assetid: 9ea5b5f5-435b-475f-8fbe-e7cb971ceb8a
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComboBox::GetItemDataPtr
Retrieves the application-supplied 32-bit value associated with the specified combo-box item as a pointer (**void\***).  
  
## Syntax  
  
```  
  
      void* GetItemDataPtr(  
   int nIndex   
) const;  
```  
  
#### Parameters  
 `nIndex`  
 Contains the zero-based index of an item in the combo box's list box.  
  
## Return Value  
 Retrieves a pointer, or –1 if an error occurs.  
  
## Example  
 [!code[NVC_MFC_CComboBox#22](../vs140/codesnippet/CPP/ccombobox--getitemdataptr_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::SetItemDataPtr](../vs140/ccombobox--setitemdataptr.md)   
 [CComboBox::GetItemData](../vs140/ccombobox--getitemdata.md)   
 [CComboBox::SetItemData](../vs140/ccombobox--setitemdata.md)   
 [CB_GETITEMDATA](http://msdn.microsoft.com/library/windows/desktop/bb775859)