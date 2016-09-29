---
title: "CMFCToolBarMenuButton::IsMenuPaletteMode"
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
  - "CMFCToolBarMenuButton::IsMenuPaletteMode"
  - "CMFCToolBarMenuButton.IsMenuPaletteMode"
  - "IsMenuPaletteMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsMenuPaletteMode method"
ms.assetid: d6d30237-da14-487c-8267-6140c9367206
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarMenuButton::IsMenuPaletteMode
Determines whether the drop-down menu is in palette mode.  
  
## Syntax  
  
```  
BOOL IsMenuPaletteMode() const;  
```  
  
## Return Value  
 `TRUE` if the palette mode is enabled, otherwise `FALSE`.  
  
## Remarks  
 When the menu button is set to palette mode, menu items appear in multiple columns with only a limited number of rows. Call this method to obtain the number of rows. You can enable or disable the palette mode by calling [CMFCToolBarMenuButton::SetMenuPaletteMode](../vs140/cmfctoolbarmenubutton--setmenupalettemode.md).  
  
## Requirements  
 **Header:** afxtoolbarmenubutton.h  
  
## See Also  
 [CMFCToolBarMenuButton Class](../vs140/cmfctoolbarmenubutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)