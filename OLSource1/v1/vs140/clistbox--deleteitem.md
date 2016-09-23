---
title: "CListBox::DeleteItem"
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
  - CListBox.DeleteItem
  - CListBox::DeleteItem
dev_langs: 
  - C++
helpviewer_keywords: 
  - DeleteItem method
  - CListBox class, overridables
ms.assetid: a98483f6-b689-475b-9bc9-d87da9cc6fcd
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CListBox::DeleteItem
Called by the framework when the user deletes an item from an owner-draw `CListBox` object or destroys the list box.  
  
## Syntax  
  
```  
  
      virtual void DeleteItem(  
   LPDELETEITEMSTRUCT lpDeleteItemStruct   
);  
```  
  
#### Parameters  
 `lpDeleteItemStruct`  
 A long pointer to a Windows [DELETEITEMSTRUCT](../vs140/deleteitemstruct-structure.md) structure that contains information about the deleted item.  
  
## Remarks  
 The default implementation of this function does nothing. Override this function to redraw an owner-draw list box as needed.  
  
 See [CWnd::OnDeleteItem](../vs140/cwnd--ondeleteitem.md) for a description of the `DELETEITEMSTRUCT` structure.  
  
## Example  
 [!code[NVC_MFC_CListBox#6](../vs140/codesnippet/CPP/clistbox--deleteitem_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::CompareItem](../vs140/clistbox--compareitem.md)   
 [CWnd::OnDeleteItem](../vs140/cwnd--ondeleteitem.md)   
 [CListBox::DrawItem](../vs140/clistbox--drawitem.md)   
 [CListBox::MeasureItem](../vs140/clistbox--measureitem.md)