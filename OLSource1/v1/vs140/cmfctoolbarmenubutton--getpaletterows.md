---
title: "CMFCToolBarMenuButton::GetPaletteRows"
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
  - "CMFCToolBarMenuButton::GetPaletteRows"
  - "GetPaletteRows"
  - "CMFCToolBarMenuButton.GetPaletteRows"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPaletteRows method"
ms.assetid: f880423a-a4a7-4e1d-8f19-a8c7aa39a1fe
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarMenuButton::GetPaletteRows
Returns the number of rows in the drop-down menu when the menu is in palette mode.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The number of rows in the palette.  
  
## Remarks  
 When the menu button is set to palette mode, menu items will appear in multiple columns with only a limited number of rows. Call this method to obtain the number of rows. You can enable or disable palette mode and specify the number of rows using [CMFCToolBarMenuButton::SetMenuPaletteMode](../vs140/cmfctoolbarmenubutton--setmenupalettemode.md).  
  
## Requirements  
 **Header:** afxtoolbarmenubutton.h  
  
## See Also  
 [CMFCToolBarMenuButton Class](../vs140/cmfctoolbarmenubutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)