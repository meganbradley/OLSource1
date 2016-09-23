---
title: "CMFCFontComboBox::SelectFont"
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
  - CMFCFontComboBox::SelectFont
  - CMFCFontComboBox.SelectFont
  - SelectFont
dev_langs: 
  - C++
helpviewer_keywords: 
  - SelectFont method
ms.assetid: 21d17eb7-63a6-454e-9c8c-a26a545a37ce
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCFontComboBox::SelectFont
Selects the font that matches the specified criteria from the font combo box.  
  
## Syntax  
  
```  
BOOL SelectFont(  
   CMFCFontInfo* pDesc   
);  
BOOL SelectFont(  
   LPCTSTR lpszName,  
   BYTE nCharSet=DEFAULT_CHARSET   
);  
```  
  
#### Parameters  
 [in] `pDesc`  
 Points to a font description object.  
  
 [in] `lpszName`  
 Specifies a font name.  
  
 [in] `nCharSet`  
 Specifies a character set. The default value is DEFAULT_CHARSET. For more information, see the `lfCharSet` member of the [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) structure.  
  
## Return Value  
 `TRUE` if an item in the font combo box matches the specified font description object or font name and charset; otherwise, `FALSE`.  
  
## Remarks  
 Use this method to select and scroll to the item in the font combo box that corresponds to the specified font.  
  
## Example  
 The following example demonstrates how to use the `SelectFont` method in the `CMFCFontComboBox` class. This example is part of the [New Controls sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_NewControls#34](../vs140/codesnippet/CPP/cmfcfontcombobox--selectfont_1.h)]
  
[!code[NVC_MFC_NewControls#35](../vs140/codesnippet/CPP/cmfcfontcombobox--selectfont_2.cpp)]
  
  
## Requirements  
 **Header:** afxfontcombobox.h  
  
## See Also  
 [CMFCFontComboBox Class](../vs140/cmfcfontcombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCFontInfo Class](../vs140/cmfcfontinfo-class.md)   
 [CComboBox::SetCurSel](../vs140/ccombobox--setcursel.md)   
 [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037)