---
title: "CMFCRibbonFontComboBox::GetFontType"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - afxribboncombobox/CMFCRibbonFontComboBox::GetFontType
  - GetFontType
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetFontType
ms.assetid: 6a11bc0e-4ff6-4025-81dc-29bbac9d802e
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonFontComboBox::GetFontType
Returns which font types to display in the combo box. Valid options are DEVICE_FONTTYPE, RASTER_FONTTYPE, and TRUETYPE_FONTTYPE, or any bitwise combination thereof.  
  
## Syntax  
  
```  
int GetFontType() const;  
```  
  
## Return Value  
 Font types (see EnumFontFamProc in the Windows SDK documentation).  
  
## Remarks  
  
## Requirements  
 **Header:** afxribboncombobox.h  
  
## See Also  
 [CMFCRibbonFontComboBox Class](../vs140/cmfcribbonfontcombobox-class.md)