---
title: "CMFCFontInfo::CMFCFontInfo"
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
  - "CMFCFontInfo.CMFCFontInfo"
  - "CMFCFontInfo::CMFCFontInfo"
  - "CMFCFontInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCFontInfo class, constructor"
ms.assetid: f7e6584e-257f-4fc1-837c-043d9a7cc1da
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCFontInfo::CMFCFontInfo
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The name of the font. For more information, see the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member of the [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) structure.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The name of the script (character set) of the font.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A value that specifies the character set (script) of the font. For more information, see the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> member of the [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) structure.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A value that specifies the pitch and family of the font. For more information, see the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> member of the [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) structure.  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A value that specifies the font type. This parameter can be a bitwise combination (OR) of DEVICE_FONTTYPE, RASTER_FONTTYPE, and TRUETYPE_FONTTYPE.  
  
 [in] <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 An existing <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object whose members are used to construct this <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.  
  
## Return Value  
  
## Remarks  
 This documentation uses the terms *character set* and *script*interchangeably. A *script*, which is also known as a writing system, is a collection of characters and rules for writing those characters in one or more languages. The collection of characters includes the alphabet and punctuation used in that script. For example, Latin script is used for English as it is spoken in the United States, and its alphabet includes the characters from A through Z. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> member of the [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) structure specifies a character set. For example, the value <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> specifies the [!INCLUDE[vcpransi](../vs140/includes/vcpransi_md.md)] character set, which includes the alphabet of the Latin script.  
  
## Requirements  
 **Header:** afxtoolbarfontcombobox.h  
  
## See Also  
 [CMFCFontInfo Class](../vs140/cmfcfontinfo-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037)