---
title: "CMFCRibbonFontComboBox::CMFCRibbonFontComboBox"
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
  - CMFCRibbonFontComboBox
  - CMFCRibbonFontComboBox.CMFCRibbonFontComboBox
  - CMFCRibbonFontComboBox::CMFCRibbonFontComboBox
dev_langs: 
  - C++
helpviewer_keywords: 
  - CMFCRibbonFontComboBox class, constructor
ms.assetid: 63d7767b-0979-4aa7-8557-e623623a119b
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCRibbonFontComboBox::CMFCRibbonFontComboBox
Constructs and initializes a [CMFCRibbonFontComboBox](../vs140/cmfcribbonfontcombobox-class.md) object.  
  
## Syntax  
  
```  
CMFCRibbonFontComboBox(  
    UINT nID,  
    int nFontType = DEVICE_FONTTYPE | RASTER_FONTTYPE | TRUETYPE_FONTTYPE,  
    BYTE nCharSet = DEFAULT_CHARSET,  
    BYTE nPitchAndFamily = DEFAULT_PITCH,  
    int nWidth = -1  
);  
```  
  
#### Parameters  
 [in] `nID`  
 The command ID of the command that executes when the user selects an item from the combo box.  
  
 [in] `nFontType`  
 Specifies which font types to display in the combo box. Valid options are **DEVICE_FONTTYPE**, **RASTER_FONTTYPE**, and **TRUETYPE_FONTTYPE**, or any bitwise combination thereof.  
  
 [in] `nCharSet`  
 Filters the fonts in the combo box to those that belong to the specified character set..  
  
 [in] `nPitchAndFamily`  
 Specifies the pitch and the family of the fonts that are displayed in the combo box.  
  
 [in] `nWidth`  
 Specifies the width, in pixels, of the combo box.  
  
## Remarks  
 For more information about possible `nFontType` parameter values, see [EnumFontFamProc](http://msdn.microsoft.com/library/windows/desktop/dd162621) in the Windows SDK documentation.  
  
 For more information about valid character sets that can be assigned to `nCharSet,` and valid values that can be assigned to `nPitchAndFamily`, see [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) in the Windows SDK documentation.  
  
## Requirements  
 **Header:** afxRibbonComboBox.h  
  
## See Also  
 [CMFCRibbonFontComboBox Class](../vs140/cmfcribbonfontcombobox-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)