---
title: "CMFCFontInfo Class"
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
  - "CMFCFontInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCFontInfo class"
  - "CMFCFontInfo::CMFCFontInfo constructor"
ms.assetid: f88329b2-d74e-4921-9441-a3bb6536a049
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCFontInfo Class
The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class describes the name and other attributes of a font.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Constructs a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[GetFullName](#cmfcfontinfo__getfullname)|Retrieves the concatenated names of a font and its character set (script).|  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[m_nCharSet](#cmfcfontinfo__m_ncharset)|A value that specifies the character set (script) associated with the font.|  
|[m_nPitchAndFamily](#cmfcfontinfo__m_npitchandfamily)|A value that specifies the pitch and family of the font.|  
|[m_nType](#cmfcfontinfo__m_ntype)|A value that specifies the type of the font.|  
|[m_strName](#cmfcfontinfo__m_strname)|The name of the font; for example, **Arial**.|  
|[m_strScript](#cmfcfontinfo__m_strscript)|The name of a character set (script) associated with the font.|  
  
## Remarks  
 You can attach a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object to an item of the [CMFCToolbarFontCombo](../vs140/cmfctoolbarfontcombobox-class.md) class. Call the [CMFCToolBarFontComboBox::GetFontDesc](../vs140/cmfctoolbarfontcombobox-class.md#cmfctoolbarfontcombobox__getfontdesc) method to retrieve a pointer to a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.  
  
## Example  
 The following example demonstrates how to use various members of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class. The example demonstrates how to get a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object from a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and how to access its local variables. This example is part of the [MSOffice 2007 Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_MSOffice2007Demo#6](../vs140/codesnippet/CPP/cmfcfontinfo-class_1.cpp)]  
  
## Requirements  
 **Header:** afxtoolbarfontcombobox.h  
  
##  \<a name="cmfcfontinfo__cmfcfontinfo">\</a>  CMFCFontInfo::CMFCFontInfo  
 Constructs a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The name of the font. For more information, see the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> member of the                                 [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) structure.  
  
 [in] <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The name of the script (character set) of the font.  
  
 [in] <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 A value that specifies the character set (script) of the font. For more information, see the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> member of the                                 [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) structure.  
  
 [in] <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 A value that specifies the pitch and family of the font. For more information, see the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> member of the                                 [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) structure.  
  
 [in] <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 A value that specifies the font type. This parameter can be a bitwise combination (OR) of DEVICE_FONTTYPE, RASTER_FONTTYPE, and TRUETYPE_FONTTYPE.  
  
 [in] <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 An existing <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object whose members are used to construct this <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object.  
  
### Return Value  
  
### Remarks  
 This documentation uses the terms *character set* and *script* interchangeably. A *script*, which is also known as a writing system, is a collection of characters and rules for writing those characters in one or more languages. The collection of characters includes the alphabet and punctuation used in that script. For example, Latin script is used for English as it is spoken in the United States, and its alphabet includes the characters from A through Z. The <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> member of the                         [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) structure specifies a character set. For example, the value  <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> specifies the [!INCLUDE[vcpransi](../vs140/includes/vcpransi_md.md)] character set, which includes the alphabet of the Latin script.  
  
##  \<a name="cmfcfontinfo__getfullname">\</a>  CMFCFontInfo::GetFullName  
 Retrieves the concatenated names of a font and its character set (script).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A string that contains the font name and script.  
  
### Remarks  
 Use this method to obtain the full name of the font. For example, if the font name is is <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and the font script is <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, this method returns "Arial (Cyrillic)".  
  
##  \<a name="cmfcfontinfo__m_ncharset">\</a>  CMFCFontInfo::m_nCharSet  
 A value that specifies the character set (script) associated with the font.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 For more information, see the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> parameter of the [CMFCFontInfo::CMFCFontInfo](#cmfcfontinfo__cmfcfontinfo) constructor.  
  
##  \<a name="cmfcfontinfo__m_npitchandfamily">\</a>  CMFCFontInfo::m_nPitchAndFamily  
 A value that specifies the pitch (point size) and family (for example, serif, sans-serif, and monospace) of the font.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 For more information, see the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> parameter of the [CMFCFontInfo::CMFCFontInfo](#cmfcfontinfo__cmfcfontinfo) constructor.  
  
##  \<a name="cmfcfontinfo__m_ntype">\</a>  CMFCFontInfo::m_nType  
 A value that specifies the type of the font.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 For more information, see the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> parameter of the [CMFCFontInfo::CMFCFontInfo](#cmfcfontinfo__cmfcfontinfo) constructor.  
  
##  \<a name="cmfcfontinfo__m_strname">\</a>  CMFCFontInfo::m_strName  
 The name of the font: for example, **Arial**.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 For more information, see the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> parameter of the [CMFCFontInfo::CMFCFontInfo](#cmfcfontinfo__cmfcfontinfo) constructor.  
  
##  \<a name="cmfcfontinfo__m_strscript">\</a>  CMFCFontInfo::m_strScript  
 The name of a character set (script) associated with the font.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 For more information, see the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> parameter of the [CMFCFontInfo::CMFCFontInfo](#cmfcfontinfo__cmfcfontinfo) constructor.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCToolbarFontCombo](../vs140/cmfctoolbarfontcombobox-class.md)   
 [CMFCToolbarFontSizeCombo](../vs140/cmfctoolbarfontsizecombobox-class.md)