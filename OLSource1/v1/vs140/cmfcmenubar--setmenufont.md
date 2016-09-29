---
title: "CMFCMenuBar::SetMenuFont"
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
  - "SetMenuFont"
  - "CMFCMenuBar.SetMenuFont"
  - "CMFCMenuBar::SetMenuFont"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetMenuFont method"
ms.assetid: 10926e3b-292b-45a7-a93b-bf5bb793e121
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCMenuBar::SetMenuFont
Sets the font for all menu bars in your application.  
  
## Syntax  
  
```  
static BOOL SetMenuFont(  
   LPLOGFONT lpLogFont,  
   BOOL bHorz = TRUE  
);  
```  
  
#### Parameters  
 [in] `lpLogFont`  
 A pointer to a [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/bb773327) structure that defines the font to set.  
  
 [in] `bHorz`  
 TRUE if you want the `lpLogFont` parameter to be used for the vertical font, FALSE if you want it to be used for horizontal font.  
  
## Return Value  
 `TRUE` if the method was successful; otherwise `FALSE`.  
  
## Remarks  
 Two fonts are used for all [CMFCMenuBar](../vs140/cmfcmenubar-class.md) objects. These separate fonts are used for horizontal and vertical menu bars.  
  
 The font settings are global variables and affect all `CMFCMenuBar` objects.  
  
## Requirements  
 **Header:** afxmenubar.h  
  
## See Also  
 [CMFCMenuBar Class](../vs140/cmfcmenubar-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCMenuBar::GetMenuFont](../vs140/cmfcmenubar--getmenufont.md)