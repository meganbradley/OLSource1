---
title: "AFX_GLOBAL_DATA::SetMenuFont"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - SetMenuFont
  - AFX_GLOBAL_DATA::SetMenuFont
  - AFX_GLOBAL_DATA.SetMenuFont
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetMenuFont method
  - AFX_GLOBAL_DATA::SetMenuFont
ms.assetid: e121e599-715f-4ed3-8ca9-d4fc603447b5
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AFX_GLOBAL_DATA::SetMenuFont
Creates the specified logical font.  
  
## Syntax  
  
```  
BOOL SetMenuFont(  
   LPLOGFONT lpLogFont,  
   BOOL bHorz  
);  
```  
  
#### Parameters  
 [in] `lpLogFont`  
 Pointer to a structure that contains the attributes of a font.  
  
 [in] `bHorz`  
 `TRUE` to specify that the text runs horizontally; `FALSE` to specify that the text runs vertically.  
  
## Return Value  
 `TRUE` if this method succeeds; otherwise, `FALSE`. In debug mode, this method asserts if this method is unsuccessful.  
  
## Remarks  
 This method creates a horizontal regular font, an underlined font, and a bold font that is used in default menu items. This method optionally creates a regular vertical font. For more information about logical fonts, see [CFont::CreateFontIndirect](../vs140/cfont--createfontindirect.md).  
  
## Requirements  
 **Header:** afxglobals.h  
  
## See Also  
 [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/bb773327)   
 [CFont::CreateFontIndirect](../vs140/cfont--createfontindirect.md)