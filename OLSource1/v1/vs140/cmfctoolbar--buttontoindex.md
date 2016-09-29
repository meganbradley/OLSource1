---
title: "CMFCToolBar::ButtonToIndex"
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
  - "ButtonToIndex"
  - "CMFCToolBar::ButtonToIndex"
  - "CMFCToolBar.ButtonToIndex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ButtonToIndex method"
ms.assetid: 15471f19-7a31-4144-9c6c-c8b54cf18bc2
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::ButtonToIndex
Returns the index of a specified [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md) object in this toolbar.  
  
## Syntax  
  
```  
int ButtonToIndex(  
   const CMFCToolBarButton* pButton   
) const;  
```  
  
#### Parameters  
 [in] `pButton`  
 A pointer to the toolbar button object.  
  
## Return Value  
 Index of `pButton` in the internal list of toolbar buttons; or -1 if the specified button is not on this toolbar.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)