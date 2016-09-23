---
title: "CMFCToolBarFontComboBox::SetFont"
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
  - CMFCToolBarFontComboBox.SetFont
  - CMFCToolBarFontComboBox::SetFont
  - SetFont
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetFont method
ms.assetid: aa5259ab-afee-4283-8694-d525b33ca18f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarFontComboBox::SetFont
Selects the font in the font combo box according to the font name and character set that are specified in the parameters.  
  
## Syntax  
  
```  
BOOL SetFont(  
   LPCTSTR lpszName,  
   BYTE nCharSet=DEFAULT_CHARSET,  
   BOOL bExact=FALSE   
);  
```  
  
#### Parameters  
 [in] `lpszName`  
 Specifies the font name or prefix.  
  
 [in] `nCharSet`  
 Specifies the character set.  
  
 [in] `bExact`  
 Specifies whether `lpszName` contains the font name or the font prefix.  
  
## Return Value  
 Nonzero if the font was selected successfully; otherwise 0.  
  
## Remarks  
 If `bExact` is `TRUE`, this method selects a font that exactly matches the name that you specified as `lpszName`. If `bExact` is `FALSE`, this method selects a font that starts with the text specified as `lpszName` and that uses the character set that you specified as `nCharSet`. If `nCharSet` is set to DEFAULT_CHARSET, the character set will be ignored and only `lpszName` will be used to select a font.  
  
## Requirements  
 **Header:** afxtoolbarfontcombobox.h  
  
## See Also  
 [CMFCToolBarFontComboBox Class](../vs140/cmfctoolbarfontcombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)