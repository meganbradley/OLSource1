---
title: "CComboBoxEx::InsertItem"
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
  - "CComboBoxEx.InsertItem"
  - "CComboBoxEx::InsertItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsertItem method"
ms.assetid: d0fe0057-b2d0-4ba5-aa64-822ab51afaf0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComboBoxEx::InsertItem
Inserts a new item in a **ComboBoxEx** control.  
  
## Syntax  
  
```  
  
      int InsertItem(  
   const COMBOBOXEXITEM* pCBItem   
);  
```  
  
#### Parameters  
 `pCBItem`  
 A pointer to a [COMBOBOXEXITEM](http://msdn.microsoft.com/library/windows/desktop/bb775746) structure that will receive the item information. This structure contains callback flag values for the item.  
  
## Return Value  
 The index at which the new item was inserted if successful; otherwise -1.  
  
## Remarks  
 When you call `InsertItem`, a [WM_NOTIFY](http://msdn.microsoft.com/library/windows/desktop/bb775583) message with [CBEN_INSERTITEM](http://msdn.microsoft.com/library/windows/desktop/bb775764) notification will be sent to the parent window.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CComboBoxEx Class](../vs140/ccomboboxex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CComboBoxEx::GetItem](../vs140/ccomboboxex--getitem.md)   
 [CComboBoxEx::SetItem](../vs140/ccomboboxex--setitem.md)