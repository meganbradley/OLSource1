---
title: "CMFCFontComboBox::Setup"
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
  - Setup
  - CMFCFontComboBox.Setup
  - CMFCFontComboBox::Setup
dev_langs: 
  - C++
helpviewer_keywords: 
  - Setup method
ms.assetid: 8e5cf7db-f3e9-4843-9eb2-470a47deeaa3
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCFontComboBox::Setup
Initializes the list of items in the font combo box.  
  
## Syntax  
  
```  
BOOL Setup(  
   int nFontType=DEVICE_FONTTYPE|RASTER_FONTTYPE|TRUETYPE_FONTTYPE,  
   BYTE nCharSet=DEFAULT_CHARSET,  
   BYTE nPitchAndFamily=DEFAULT_PITCH   
);  
```  
  
#### Parameters  
 [in] `nFontType`  
 Specifies the font type. The default value is the bitwise combination (OR) of DEVICE_FONTTYPE, RASTER_FONTTYPE, and TRUETYPE_FONTTYPE.  
  
 [in] `nCharSet`  
 Specifies the font character set. The default value is DEFAULT_CHARSET.  
  
 [in] `nPitchAndFamily`  
 Specifies the font pitch and family. The default value is DEFAULT_PITCH.  
  
## Return Value  
 `TRUE` if the font combo box was initialized successfully; otherwise, `FALSE`.  
  
## Remarks  
 This method initializes the font combo box by enumerating the currently installed fonts that match the specified parameters and inserting those font names in the font combo box.  
  
## Example  
 The following example demonstrates how to use the `Setup` method in the `CMFCFontComboBox` class. This example is part of the [New Controls sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_NewControls#34](../vs140/codesnippet/CPP/cmfcfontcombobox--setup_1.h)]
  
[!code[NVC_MFC_NewControls#36](../vs140/codesnippet/CPP/cmfcfontcombobox--setup_2.cpp)]
  
  
## Requirements  
 **Header:** afxfontcombobox.h  
  
## See Also  
 [CMFCFontComboBox Class](../vs140/cmfcfontcombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037)