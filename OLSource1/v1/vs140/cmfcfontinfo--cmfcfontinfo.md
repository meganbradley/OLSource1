---
title: "CMFCFontInfo::CMFCFontInfo"
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
  - CMFCFontInfo.CMFCFontInfo
  - CMFCFontInfo::CMFCFontInfo
  - CMFCFontInfo
dev_langs: 
  - C++
helpviewer_keywords: 
  - CMFCFontInfo class, constructor
ms.assetid: f7e6584e-257f-4fc1-837c-043d9a7cc1da
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCFontInfo::CMFCFontInfo
Constructs a `CMFCFontInfo` object.  
  
## Syntax  
  
```  
CMFCFontInfo(  
   LPCTSTR lpszName,  
   LPCTSTR lpszScript,  
   BYTE nCharSet,  
   BYTE nPitchAndFamily,  
   int nType   
);  
CMFCFontInfo(  
   const CMFCFontInfo& src   
);  
```  
  
#### Parameters  
 [in] `lpszName`  
 The name of the font. For more information, see the `lfFaceName` member of the [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) structure.  
  
 [in] `lpszScript`  
 The name of the script (character set) of the font.  
  
 [in] `nCharSet`  
 A value that specifies the character set (script) of the font. For more information, see the `lfCharSet` member of the [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) structure.  
  
 [in] `nPitchAndFamily`  
 A value that specifies the pitch and family of the font. For more information, see the `lfPitchAndFamily` member of the [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) structure.  
  
 [in] `nType`  
 A value that specifies the font type. This parameter can be a bitwise combination (OR) of DEVICE_FONTTYPE, RASTER_FONTTYPE, and TRUETYPE_FONTTYPE.  
  
 [in] `src`  
 An existing `CMFCFontInfo` object whose members are used to construct this `CMFCFontInfo` object.  
  
## Return Value  
  
## Remarks  
 This documentation uses the terms *character set* and *script*interchangeably. A *script*, which is also known as a writing system, is a collection of characters and rules for writing those characters in one or more languages. The collection of characters includes the alphabet and punctuation used in that script. For example, Latin script is used for English as it is spoken in the United States, and its alphabet includes the characters from A through Z. The `lfCharSet` member of the [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) structure specifies a character set. For example, the value `ANSI_CHARSET` specifies the [!INCLUDE[vcpransi](../vs140/includes/vcpransi_md.md)] character set, which includes the alphabet of the Latin script.  
  
## Requirements  
 **Header:** afxtoolbarfontcombobox.h  
  
## See Also  
 [CMFCFontInfo Class](../vs140/cmfcfontinfo-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037)