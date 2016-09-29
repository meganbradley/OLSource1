---
title: "CListBox::SetItemDataPtr"
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
  - "CListBox.SetItemDataPtr"
  - "CListBox::SetItemDataPtr"
  - "SetItemDataPtr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetItemDataPtr method"
  - "CListBox class, general operations"
ms.assetid: 88ede889-cf18-4058-9ba8-0011a8a7a6f0
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::SetItemDataPtr
Sets the 32-bit value associated with the specified item in a list box to be the specified pointer (**void\***).  
  
## Syntax  
  
```  
  
      int SetItemDataPtr(  
   int nIndex,  
   void* pData   
);  
```  
  
#### Parameters  
 `nIndex`  
 Specifies the zero-based index of the item.  
  
 `pData`  
 Specifies the pointer to be associated with the item.  
  
## Return Value  
 **LB_ERR** if an error occurs.  
  
## Remarks  
 This pointer remains valid for the life of the list box, even though the item's relative position within the list box might change as items are added or removed. Hence, the item's index within the box can change, but the pointer remains reliable.  
  
## Example  
 [!code[NVC_MFC_CListBox#35](../vs140/codesnippet/CPP/clistbox--setitemdataptr_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::SetItemData](../vs140/clistbox--setitemdata.md)   
 [CListBox::GetItemData](../vs140/clistbox--getitemdata.md)   
 [CListBox::GetItemDataPtr](../vs140/clistbox--getitemdataptr.md)   
 [LB_SETITEMDATA](http://msdn.microsoft.com/library/windows/desktop/bb761346)