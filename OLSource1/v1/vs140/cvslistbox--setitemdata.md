---
title: "CVSListBox::SetItemData"
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
  - CVSListBox::SetItemData
  - SetItemData
  - CVSListBox.SetItemData
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetItemData method
ms.assetid: cb5713c9-1c08-4745-bc61-774e09ee4c5a
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CVSListBox::SetItemData
Associates an application-specific 32-bit value with an editable list control item.  
  
## Syntax  
  
```  
virtual void SetItemData(  
   int iIndex,  
   DWORD_PTR dwData   
);  
```  
  
#### Parameters  
 [in] `iIndex`  
 The zero-based index of an editable list control item.  
  
 [in] `dwData`  
 A 32-bit value. This value can be an application-specific integer or a pointer to other data.  
  
## Remarks  
  
## Requirements  
 **Header:** afxvslistbox.h  
  
## See Also  
 [CVSListBox Class](../vs140/cvslistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CVSListBox::GetItemData](../vs140/cvslistbox--getitemdata.md)