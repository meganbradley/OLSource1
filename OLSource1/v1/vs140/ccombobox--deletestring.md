---
title: "CComboBox::DeleteString"
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
  - "CComboBox.DeleteString"
  - "CComboBox::DeleteString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DeleteString method"
ms.assetid: b49c4ef5-7d1a-4968-a841-47a3ac42db08
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::DeleteString
Deletes the item in position `nIndex` from the combo box.  
  
## Syntax  
  
```  
  
      int DeleteString(  
   UINT nIndex   
);  
```  
  
#### Parameters  
 `nIndex`  
 Specifies the index to the string that is to be deleted.  
  
## Return Value  
 If the return value is greater than or equal to 0, then it is a count of the strings remaining in the list. The return value is **CB_ERR** if `nIndex` specifies an index greater than the number of items in the list.  
  
## Remarks  
 All items following `nIndex` now move down one position. For example, if a combo box contains two items, deleting the first item will cause the remaining item to now be in the first position. `nIndex`=0 for the item in the first position.  
  
## Example  
 [!code[NVC_MFC_CComboBox#9](../vs140/codesnippet/CPP/ccombobox--deletestring_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::InsertString](../vs140/ccombobox--insertstring.md)   
 [CComboBox::AddString](../vs140/ccombobox--addstring.md)   
 [CB_DELETESTRING](http://msdn.microsoft.com/library/windows/desktop/bb775830)