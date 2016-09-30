---
title: "CComboBox::DeleteItem"
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
  - "CComboBox.DeleteItem"
  - "CComboBox::DeleteItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComboBox class, overridables"
  - "DeleteItem method"
ms.assetid: 3539fc14-1327-4ec7-b9c1-e0188bd8f81e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBox::DeleteItem
Called by the framework when the user deletes an item from an owner-draw `CComboBox` object or destroys the combo box.  
  
## Syntax  
  
```  
  
      virtual void DeleteItem(  
   LPDELETEITEMSTRUCT lpDeleteItemStruct   
);  
```  
  
#### Parameters  
 `lpDeleteItemStruct`  
 A long pointer to a Windows [DELETEITEMSTRUCT](../vs140/deleteitemstruct-structure.md) structure that contains information about the deleted item. See [CWnd::OnDeleteItem](../vs140/cwnd--ondeleteitem.md) for a description of this structure.  
  
## Remarks  
 The default implementation of this function does nothing. Override this function to redraw the combo box as needed.  
  
## Example  
 [!code[NVC_MFC_CComboBox#8](../vs140/codesnippet/CPP/ccombobox--deleteitem_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CComboBox Class](../vs140/ccombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBox::CompareItem](../vs140/ccombobox--compareitem.md)   
 [CComboBox::DrawItem](../vs140/ccombobox--drawitem.md)   
 [CComboBox::MeasureItem](../vs140/ccombobox--measureitem.md)   
 [WM_DELETEITEM](http://msdn.microsoft.com/library/windows/desktop/bb761362)