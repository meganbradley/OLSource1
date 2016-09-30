---
title: "CMFCRibbonComboBox::OnSelectItem"
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
  - "CMFCRibbonComboBox.OnSelectItem"
  - "OnSelectItem"
  - "CMFCRibbonComboBox::OnSelectItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSelectItem method"
ms.assetid: 860767ed-6e78-45ae-9fe3-9b27f4f0345b
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonComboBox::OnSelectItem
Called by the framework when a user selects an item in the list box.  
  
## Syntax  
  
```  
virtual void OnSelectItem(  
   int nItem   
);  
```  
  
#### Parameters  
 [in] `nItem`  
 The index of the selected item.  
  
## Remarks  
 Override this method if you want to process a user input selection.  
  
## Requirements  
 **Header:** afxribboncombobox.h  
  
## See Also  
 [CMFCRibbonComboBox Class](../vs140/cmfcribboncombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)