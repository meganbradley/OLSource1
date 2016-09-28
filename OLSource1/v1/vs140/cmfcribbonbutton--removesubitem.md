---
title: "CMFCRibbonButton::RemoveSubItem"
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
  - "CMFCRibbonButton.RemoveSubItem"
  - "RemoveSubItem"
  - "CMFCRibbonButton::RemoveSubItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveSubItem method"
ms.assetid: f4bc97b7-663b-4db6-8eff-3d0510a352e1
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonButton::RemoveSubItem
Removes a menu item from the pop-up menu.  
  
## Syntax  
  
```  
BOOL RemoveSubItem(  
   int nIndex   
);  
```  
  
#### Parameters  
 [in] `nIndex`  
 Specifies the zero-based index of the menu item that you want to remove.  
  
## Return Value  
 `TRUE` if the specified item has been removed successfully; otherwise `FALSE` if `nIndex` is negative or exceeds the number of menu items in the pop-up menu.  
  
## Requirements  
 **Header:** afxribbonbutton.h  
  
## See Also  
 [CMFCRibbonButton Class](../vs140/cmfcribbonbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)