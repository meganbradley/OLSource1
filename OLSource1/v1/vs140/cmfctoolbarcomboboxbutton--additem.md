---
title: "CMFCToolBarComboBoxButton::AddItem"
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
  - "CMFCToolBarComboBoxButton::AddItem"
  - "CMFCToolBarComboBoxButton.AddItem"
  - "AddItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddItem method"
ms.assetid: 2cf40cc4-ea39-40cf-ac14-ca435cf60010
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarComboBoxButton::AddItem
Appends a unique item to the list box.  
  
## Syntax  
  
```  
virtual INT_PTR AddItem(  
   LPCTSTR lpszItem,  
   DWORD_PTR dwData=0   
);  
```  
  
#### Parameters  
 [in] `lpszItem`  
 The text of the item to add to the list box.  
  
 [in] `dwData`  
 The data associated with the item to add to the list box.  
  
## Return Value  
 The index of the last item in the list box.  
  
## Remarks  
 Do not use this method when the list box style is sorted.  
  
 If the item text is already in the list box, the new data is stored with the existing item. The search for the item is case sensitive.  
  
## Requirements  
 **Header:** afxtoolbarcomboboxbutton.h  
  
## See Also  
 [CMFCToolBarComboBoxButton Class](../vs140/cmfctoolbarcomboboxbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)