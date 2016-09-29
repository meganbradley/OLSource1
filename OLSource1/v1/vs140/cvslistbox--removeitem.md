---
title: "CVSListBox::RemoveItem"
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
  - "RemoveItem"
  - "CVSListBox::RemoveItem"
  - "CVSListBox.RemoveItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveItem method"
ms.assetid: 07240645-6c8d-4039-b1b4-2066a697d093
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CVSListBox::RemoveItem
Removes an item from an editable list control.  
  
## Syntax  
  
```  
virtual BOOL RemoveItem(  
   int iIndex   
);  
```  
  
#### Parameters  
 [in] `iIndex`  
 The zero-based index of an editable list control item.  
  
## Return Value  
 `TRUE` if the specified item is removed; otherwise, `FALSE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxvslistbox.h  
  
## See Also  
 [CVSListBox Class](../vs140/cvslistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)