---
title: "CMFCFontComboBox::GetSelFont"
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
  - "CMFCFontComboBox::GetSelFont"
  - "GetSelFont"
  - "CMFCFontComboBox.GetSelFont"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSelFont method"
ms.assetid: d8dc66f3-398f-4c9b-bcfa-89995c581973
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCFontComboBox::GetSelFont
Retrieves information about the currently selected font.  
  
## Syntax  
  
```  
CMFCFontInfo* GetSelFont() const;  
```  
  
## Return Value  
 A pointer to [CMFCFontInfo Class](../vs140/cmfcfontinfo-class.md) object that describes a font. It can be `NULL` if no font is selected in the combo box.  
  
## Remarks  
  
## Requirements  
 **Header:** afxfontcombobox.h  
  
## See Also  
 [CMFCFontComboBox Class](../vs140/cmfcfontcombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)