---
title: "CMFCRibbonFontComboBox Class"
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
  - "CMFCRibbonFontComboBox"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonFontComboBox class"
ms.assetid: 33b4db50-df4f-45fa-8f05-2e6e73c31435
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonFontComboBox Class
Implements a combo box that contains a list of fonts. You place the combo box on a ribbon panel.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Destructor.|  
  
### Protected Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonFontComboBox::CMFCRibbonFontComboBox](#cmfcribbonfontcombobox__cmfcribbonfontcombobox)|Constructs and initializes a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCRibbonFontComboBox::BuildFonts](#cmfcribbonfontcombobox__buildfonts)|Populates the ribbon font combo box with fonts of the specified font type, character set, and pitch and family.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Used by the framework to create a dynamic instance of this class type.|  
|[CMFCRibbonFontComboBox::GetCharSet](#cmfcribbonfontcombobox__getcharset)|Returns the specified character set.|  
|[CMFCRibbonFontComboBox::GetFontDesc](#cmfcribbonfontcombobox__getfontdesc)||  
|[CMFCRibbonFontComboBox::GetFontType](#cmfcribbonfontcombobox__getfonttype)|Returns which font types to display in the combo box. Valid options are DEVICE_FONTTYPE, RASTER_FONTTYPE, and TRUETYPE_FONTTYPE, or any bitwise combination thereof.|  
|[CMFCRibbonFontComboBox::GetPitchAndFamily](#cmfcribbonfontcombobox__getpitchandfamily)|Returns the pitch and the family of the fonts that are displayed in the combo box.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Used by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
|[CMFCRibbonFontComboBox::RebuildFonts](#cmfcribbonfontcombobox__rebuildfonts)|Populates the ribbon font combo box with fonts of the previously specified font type, character set, and pitch and family.|  
|[CMFCRibbonFontComboBox::SetFont](#cmfcribbonfontcombobox__setfont)|Selects the specified font in the combo box.|  
  
## Remarks  
 After you create a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object, add it to a ribbon panel by calling [CMFCRibbonPanel::Add](../vs140/cmfcribbonpanel-class.md#cmfcribbonpanel__add).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCRibbonBaseElement](../vs140/cmfcribbonbaseelement-class.md)  
  
 [CMFCRibbonButton](../vs140/cmfcribbonbutton-class.md)  
  
 [CMFCRibbonEdit](../vs140/cmfcribbonedit-class.md)  
  
 [CMFCRibbonComboBox](../vs140/cmfcribboncombobox-class.md)  
  
 [CMFCRibbonFontComboBox](../vs140/cmfcribbonfontcombobox-class.md)  
  
## Requirements  
 **Header:** afxRibbonComboBox.h  
  
##  \<a name="cmfcribbonfontcombobox__buildfonts">\</a>  CMFCRibbonFontComboBox::BuildFonts  
 Populates the combo box on the ribbon with fonts.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Specifies the font type of the fonts to add.  
  
 [in] <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Specifies the character set of the fonts to add.  
  
 [in] <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Specifies the pitch and family of the fonts to add.  
  
##  \<a name="cmfcribbonfontcombobox__cmfcribbonfontcombobox">\</a>  CMFCRibbonFontComboBox::CMFCRibbonFontComboBox  
 Constructs and initializes a [CMFCRibbonFontComboBox](../vs140/cmfcribbonfontcombobox-class.md) object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The command ID of the command that executes when the user selects an item from the combo box.  
  
 [in] <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Specifies which font types to display in the combo box. Valid options are                                 **DEVICE_FONTTYPE**,                                 **RASTER_FONTTYPE**, and                                 **TRUETYPE_FONTTYPE**, or any bitwise combination thereof.  
  
 [in] <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Filters the fonts in the combo box to those that belong to the specified character set..  
  
 [in] <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 Specifies the pitch and the family of the fonts that are displayed in the combo box.  
  
 [in] <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Specifies the width, in pixels, of the combo box.  
  
### Remarks  
 For more information about possible <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> parameter values, see                         [EnumFontFamProc](http://msdn.microsoft.com/library/windows/desktop/dd162621) in the Windows SDK documentation.  
  
 For more information about valid character sets that can be assigned to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and valid values that can be assigned to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, see                         [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) in the Windows SDK documentation.  
  
##  \<a name="cmfcribbonfontcombobox__getfontdesc">\</a>  CMFCRibbonFontComboBox::GetFontDesc  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonfontcombobox__rebuildfonts">\</a>  CMFCRibbonFontComboBox::RebuildFonts  
 Populates the combo box on the ribbon with fonts of a previously specified font type, character set, and pitch and family.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 You can specify the font type, character set, and pitch and family of the fonts to include in the ribbon font combo box in the [constructor](#cmfcribbonfontcombobox__cmfcribbonfontcombobox) for this class, or by calling [CMFCRibbonFontComboBox::BuildFonts](#cmfcribbonfontcombobox__buildfonts).  
  
##  \<a name="cmfcribbonfontcombobox__setfont">\</a>  CMFCRibbonFontComboBox::SetFont  
 Selects the specified font in the combo box.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Specifies the name of the font to select.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Specifies the character set for the selected font.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> to specify that the character set must match when selecting a font; <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> to specify that the character set can be ignored when selecting a font.  
  
### Return Value  
 Nonzero if the specified font was found and selected; otherwise, zero.  
  
### Remarks  
  
##  \<a name="cmfcribbonfontcombobox__getcharset">\</a>  CMFCRibbonFontComboBox::GetCharSet  
 Returns the specified character set.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Character set (see LOGFONT in the Windows SDK documentation).  
  
### Remarks  
  
##  \<a name="cmfcribbonfontcombobox__getfonttype">\</a>  CMFCRibbonFontComboBox::GetFontType  
 Returns which font types to display in the combo box. Valid options are DEVICE_FONTTYPE, RASTER_FONTTYPE, and TRUETYPE_FONTTYPE, or any bitwise combination thereof.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Font types (see EnumFontFamProc in the Windows SDK documentation).  
  
### Remarks  
  
##  \<a name="cmfcribbonfontcombobox__getpitchandfamily">\</a>  CMFCRibbonFontComboBox::GetPitchAndFamily  
 Returns the pitch and the family of the fonts that are displayed in the combo box.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 Pitch and the family (see LOGFONT in the Windows SDK documentation).  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCRibbonComboBox](../vs140/cmfcribboncombobox-class.md)