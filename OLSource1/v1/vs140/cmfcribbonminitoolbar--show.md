---
title: "CMFCRibbonMiniToolBar::Show"
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
  - "Show"
  - "CMFCRibbonMiniToolBar.Show"
  - "CMFCRibbonMiniToolBar::Show"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Show method"
ms.assetid: fc8f9859-1e48-4651-bb78-e8d31a0f482c
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonMiniToolBar::Show
Displays the mini toolbar at the specified screen coordinates.  
  
## Syntax  
  
```  
BOOL Show(  
    int x,  
    int y   
);  
```  
  
#### Parameters  
 [in] `x`  
 Specifies the horizontal position of the mini toolbar in screen coordinates.  
  
 [in] `y`  
 Specifies the vertical position of the mini toolbar in screen coordinates.  
  
## Return Value  
 `TRUE` if the mini toolbar was displayed successfully; otherwise, `FALSE`.  
  
## Requirements  
 **Header:** afxRibbonMiniToolBar.h  
  
## See Also  
 [CMFCRibbonMiniToolBar Class](../vs140/cmfcribbonminitoolbar-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)