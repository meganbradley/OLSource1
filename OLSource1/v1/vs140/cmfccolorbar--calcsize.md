---
title: "CMFCColorBar::CalcSize"
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
  - "CMFCColorBar.CalcSize"
  - "CMFCColorBar::CalcSize"
  - "CalcSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CalcSize method"
ms.assetid: 043b3424-a7b7-4505-99b4-27fd86ffc9eb
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorBar::CalcSize
Called by the framework as part of the layout calculation process.  
  
## Syntax  
  
```  
virtual CSize CalcSize(  
   BOOL bVertDock   
);  
```  
  
#### Parameters  
 [in] `bVertDock`  
 `TRUE` to specify that the color bar control is docked vertically; `FALSE` to specify that the color bar control is docked horizontally.  
  
## Return Value  
 The size of the array of color buttons in a color bar control.  
  
## Requirements  
 **Header:** afxcolorbar.h  
  
## See Also  
 [CMFCColorBar Class](../vs140/cmfccolorbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)