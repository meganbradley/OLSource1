---
title: "CMFCToolBar::CalcMaxButtonHeight"
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
  - "CMFCToolBar::CalcMaxButtonHeight"
  - "CMFCToolBar.CalcMaxButtonHeight"
  - "CalcMaxButtonHeight"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CalcMaxButtonHeight method"
ms.assetid: 9f29b1e6-b218-49d4-9d0d-9b2980e4b81a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::CalcMaxButtonHeight
Calculates the maximum height of buttons in the toolbar.  
  
## Syntax  
  
```  
virtual int CalcMaxButtonHeight();  
```  
  
## Return Value  
 The maximum height of buttons.  
  
## Remarks  
 This method calculates the maximum height among all toolbar buttons on the toolbar. The height may vary depending on factors such as the current toolbar docking state.  
  
 Override this method in a class derived from [CMFCToolBar](../vs140/cmfctoolbar-class.md) to provide your own height calculation.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)