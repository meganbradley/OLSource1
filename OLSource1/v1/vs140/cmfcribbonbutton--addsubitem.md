---
title: "CMFCRibbonButton::AddSubItem"
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
  - "AddSubItem"
  - "CMFCRibbonButton::AddSubItem"
  - "CMFCRibbonButton.AddSubItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddSubItem method"
ms.assetid: 5e5d3129-a892-48ba-8a62-eda1f5769e39
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonButton::AddSubItem
Adds a menu item to the pop-up menu that is associated with the button.  
  
## Syntax  
  
```  
void AddSubItem(  
   CMFCRibbonBaseElement* pSubItem,  
   int nIndex=-1   
);  
```  
  
#### Parameters  
 [in] `pSubItem`  
 Specifies a pointer to the new element to add.  
  
 [in] `nIndex`  
 Specifies the index at which to add the element to the array of menu items of the button; -1 to add the element at the end of the array of menu items.  
  
## Requirements  
 **Header:** afxribbonbutton.h  
  
## See Also  
 [CMFCRibbonButton Class](../vs140/cmfcribbonbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)