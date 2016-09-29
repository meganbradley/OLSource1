---
title: "CMFCToolBar::GetHighlightedButton"
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
  - "GetHighlightedButton"
  - "CMFCToolBar.GetHighlightedButton"
  - "CMFCToolBar::GetHighlightedButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetHighlightedButton method"
ms.assetid: cc5add69-7458-4e8b-ba88-5db5872511b2
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::GetHighlightedButton
Returns a pointer to the toolbar button that is currently highlighted.  
  
## Syntax  
  
```  
CMFCToolBarButton* GetHighlightedButton() const;  
```  
  
## Return Value  
 A pointer to a toolbar button object; or `NULL` if no button is highlighted.  
  
## Remarks  
 A toolbar button is highlighted if it has keyboard focus. A toolbar button is also highlighted if the toolbar buttons are hot-tracked in this application (for more information, see [CMFCToolBar::GetHotBorder](../vs140/cmfctoolbar--gethotborder.md) and [CMFCToolBar::SetHotBorder](../vs140/cmfctoolbar--sethotborder.md)) and the mouse is pointing at it when no toolbar button or menu item has keyboard focus.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)