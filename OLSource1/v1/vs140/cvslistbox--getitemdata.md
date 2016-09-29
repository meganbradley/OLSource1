---
title: "CVSListBox::GetItemData"
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
  - "CVSListBox::GetItemData"
  - "GetItemData"
  - "CVSListBox.GetItemData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemData method"
ms.assetid: 645bc84e-4e5e-4273-b4f4-ea138e8a9343
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CVSListBox::GetItemData
Retrieves an application-specific 32-bit value that is associated with an editable list control item.  
  
## Syntax  
  
```  
virtual DWORD_PTR GetItemData(  
   int iIndex   
) const;  
```  
  
#### Parameters  
 [in] `iIndex`  
 The zero-based index of an editable list control item.  
  
## Return Value  
 The 32-bit value that is associated with the specified item.  
  
## Remarks  
 Use the [CVSListBox::SetItemData](../vs140/cvslistbox--setitemdata.md) or [CVSListBox::AddItem](../vs140/cvslistbox--additem.md) method to associate the 32-bit value with the list control item. This value can be an application-specific integer or a pointer to other data.  
  
## Requirements  
 **Header:** afxvslistbox.h  
  
## See Also  
 [CVSListBox Class](../vs140/cvslistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)