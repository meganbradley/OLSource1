---
title: "CMFCToolBar::GetDroppedDownMenu"
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
  - "CMFCToolBar::GetDroppedDownMenu"
  - "GetDroppedDownMenu"
  - "CMFCToolBar.GetDroppedDownMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDroppedDownMenu method"
ms.assetid: 40d4d94f-9e14-4df3-b093-7dfeac33e497
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::GetDroppedDownMenu
Retrieves a pointer to the menu button object that is currently displaying its sub-menu.  
  
## Syntax  
  
```  
CMFCToolBarMenuButton* GetDroppedDownMenu(  
   int* pIndex = NULL  
) const;  
```  
  
#### Parameters  
 [out] `pIndex`  
 Receives the index of the button in the collection of toolbar buttons.  
  
## Return Value  
 A pointer to the menu button object that is displaying its sub-menu or `NULL` if no menu is displaying its sub-menu.  
  
## Remarks  
 If this method returns a non-`NULL` value and `pIndex` is not `NULL`, the value pointed to by `pIndex` is set to the index of the menu button in the collection of toolbar buttons.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)