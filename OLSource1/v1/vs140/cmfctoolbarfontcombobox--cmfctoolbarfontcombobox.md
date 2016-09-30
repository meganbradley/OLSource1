---
title: "CMFCToolBarFontComboBox::CMFCToolBarFontComboBox"
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
  - "CMFCToolBarFontComboBox"
  - "CMFCToolBarFontComboBox.CMFCToolBarFontComboBox"
  - "CMFCToolBarFontComboBox::CMFCToolBarFontComboBox"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCToolBarFontComboBox class, constructor"
ms.assetid: b51c8e4e-7569-4aa1-92f9-9379c478aae5
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarFontComboBox::CMFCToolBarFontComboBox
Constructs a [CMFCToolBarFontComboBox](../vs140/cmfctoolbarfontcombobox-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The command ID of the combo box.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The zero-based index of a toolbar image. The image is located in the [CMFCToolBarImages](../vs140/cmfctoolbarimages-class.md) object that [CMFCToolBar](../vs140/cmfctoolbar-class.md) class maintains.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The types of fonts that the combo box contains. This parameter can be a combination (boolean OR) of the following values:  
  
 DEVICE_FONTTYPE  
  
 RASTER_FONTTYPE  
  
 TRUETYPE_FONTTYPE  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 If set to DEFAULT_CHARSET, the combo box contains all uniquely-named fonts in all character sets. (If there are two fonts with the same name, the combo box contains one of them.) If set to a valid character set value, the combo box contains only fonts in the specified character set. See [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) for a listing of possible character sets.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The style of the combo box. (see [Combo-Box Styles](../vs140/combo-box-styles.md))  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The width in pixels of the edit control.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 If set to DEFAULT_PITCH, the combo box contains fonts regardless of pitch. If set to FIXED_PITCH or VARIABLE_PITCH, the combo box contains only fonts with that pitch type. Filtering based on font family is not currently supported.  
  
 [out] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Pointer to a [CObList](../vs140/coblist-class.md) object that stores the available fonts.  
  
## Remarks  
 Usually, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> objects store the list of available fonts in a single shared <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object. If you use the second overload of the constructor and provide a valid pointer to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, that <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object will instead fill the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> that <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> points to with available fonts.  
  
## Example  
 The following example demonstrates how to construct a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object. This code snippet is part of the [Word Pad sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_WordPad#7](../vs140/codesnippet/CPP/cmfctoolbarfontcombobox--cmfctoolbarfontcombobox_1.cpp)]  
  
## Requirements  
 **Header:** afxtoolbarfontcombobox.h  
  
## See Also  
 [CMFCToolBarFontComboBox Class](../vs140/cmfctoolbarfontcombobox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)