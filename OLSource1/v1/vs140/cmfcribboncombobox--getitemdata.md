---
title: "CMFCRibbonComboBox::GetItemData"
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
  - "CMFCRibbonComboBox::GetItemData"
  - "GetItemData"
  - "CMFCRibbonComboBox.GetItemData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemData method"
ms.assetid: e6848eeb-c069-466f-aa9d-846c98526ecb
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonComboBox::GetItemData
Returns the data associated with an item at a specified index in the list box.  
  
## Syntax  
  
```  
DWORD_PTR GetItemData(  
   int iIndex   
) const;  
```  
  
#### Parameters  
 [in] `iIndex`  
 The zero-based index of an item in the list box.  
  
## Return Value  
 The data associated with the item; or 0 if the item does not exist, or if the index parameter is -1 and there is no selected item in the list box.  
  
## Requirements  
 **Header:** afxribboncombobox.h  
  
## See Also  
 [CMFCRibbonComboBox Class](../vs140/cmfcribboncombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)