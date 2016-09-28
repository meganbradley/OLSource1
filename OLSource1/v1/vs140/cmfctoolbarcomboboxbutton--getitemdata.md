---
title: "CMFCToolBarComboBoxButton::GetItemData"
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
  - "CMFCToolBarComboBoxButton.GetItemData"
  - "GetItemData"
  - "CMFCToolBarComboBoxButton::GetItemData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemData method"
ms.assetid: c1cb8b78-84d4-4a8f-8605-cf59056e4451
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarComboBoxButton::GetItemData
Returns the data associated with an item at a specific index in the list box.  
  
## Syntax  
  
```  
DWORD_PTR GetItemData(  
   int iIndex=-1   
) const;  
```  
  
#### Parameters  
 [in] `iIndex`  
 The zero-based index of an item in the list box.  
  
## Return Value  
 The data associated with the item; or 0 if the item does not exist.  
  
## Remarks  
 An index parameter of -1 returns the data associated with the currently selected item.  
  
## Requirements  
 **Header:** afxtoolbarcomboboxbutton.h  
  
## See Also  
 [CMFCToolBarComboBoxButton Class](../vs140/cmfctoolbarcomboboxbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)