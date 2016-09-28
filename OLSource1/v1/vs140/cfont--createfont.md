---
title: "CFont::CreateFont"
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
  - "CreateFont"
  - "CFont.CreateFont"
  - "CFont::CreateFont"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateFont method"
  - "CFont class, initialization"
ms.assetid: d0e25d21-e328-4510-b9e7-e89aa3992616
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFont::CreateFont
Initializes a `CFont` object with the specified characteristics.  
  
## Syntax  
  
```  
  
      BOOL CreateFont(  
   int nHeight,  
   int nWidth,  
   int nEscapement,  
   int nOrientation,  
   int nWeight,  
   BYTE bItalic,  
   BYTE bUnderline,  
   BYTE cStrikeOut,  
   BYTE nCharSet,  
   BYTE nOutPrecision,  
   BYTE nClipPrecision,  
   BYTE nQuality,  
   BYTE nPitchAndFamily,  
   LPCTSTR lpszFacename   
);  
```  
  
#### Parameters  
 `nHeight`  
 Specifies the desired height (in logical units) of the font. See the `lfHeight` member of the [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037)structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a description. The absolute value of `nHeight` must not exceed 16,384 device units after it is converted. For all height comparisons, the font mapper looks for the largest font that does not exceed the requested size or the smallest font if all the fonts exceed the requested size.  
  
 `nWidth`  
 Specifies the average width (in logical units) of characters in the font. If `nWidth` is 0, the aspect ratio of the device will be matched against the digitization aspect ratio of the available fonts to find the closest match, which is determined by the absolute value of the difference.  
  
 `nEscapement`  
 Specifies the angle (in 0.1-degree units) between the escapement vector and the x-axis of the display surface. The escapement vector is the line through the origins of the first and last characters on a line. The angle is measured counterclockwise from the x-axis. See the `lfEscapement` member in the `LOGFONT` structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
 `nOrientation`  
 Specifies the angle (in 0.1-degree units) between the baseline of a character and the x-axis. The angle is measured counterclockwise from the x-axis for coordinate systems in which the y-direction is down and clockwise from the x-axis for coordinate systems in which the y-direction is up.  
  
 `nWeight`  
 Specifies the font weight (in inked pixels per 1000). See the `lfWeight` member in the `LOGFONT` structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information. The described values are approximate; the actual appearance depends on the typeface. Some fonts have only `FW_NORMAL`, `FW_REGULAR`, and `FW_BOLD` weights. If `FW_DONTCARE` is specified, a default weight is used.  
  
 `bItalic`  
 Specifies whether the font is italic.  
  
 `bUnderline`  
 Specifies whether the font is underlined.  
  
 `cStrikeOut`  
 Specifies whether characters in the font are struck out. Specifies a strikeout font if set to a nonzero value.  
  
 `nCharSet`  
 Specifies the font's character setSee the `lfCharSet` member in the `LOGFONT` structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of values.  
  
 The OEM character set is system-dependent.  
  
 Fonts with other character sets may exist in the system. An application that uses a font with an unknown character set must not attempt to translate or interpret strings that are to be rendered with that font. Instead, the strings should be passed directly to the output device driver.  
  
 The font mapper does not use the `DEFAULT_CHARSET` value. An application can use this value to allow the name and size of a font to fully describe the logical font. If a font with the specified name does not exist, a font from any character set can be substituted for the specified font. To avoid unexpected results, applications should use the `DEFAULT_CHARSET` value sparingly.  
  
 `nOutPrecision`  
 Specifies the desired output precision. The output precision defines how closely the output must match the requested font's height, width, character orientation, escapement, and pitch. See the `lfOutPrecision` member in the `LOGFONT` structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of values and more information.  
  
 `nClipPrecision`  
 Specifies the desired clipping precision. The clipping precision defines how to clip characters that are partially outside the clipping region. See the `lfClipPrecision` member in the `LOGFONT` structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of values.  
  
 To use an embedded read-only font, an application must specify `CLIP_ENCAPSULATE`.  
  
 To achieve consistent rotation of device, TrueType, and vector fonts, an application can use the OR operator to combine the `CLIP_LH_ANGLES` value with any of the other `nClipPrecision` values. If the `CLIP_LH_ANGLES` bit is set, the rotation for all fonts depends on whether the orientation of the coordinate system is left-handed or right-handed. (For more information about the orientation of coordinate systems, see the description of the `nOrientation` parameter.) If `CLIP_LH_ANGLES` is not set, device fonts always rotate counterclockwise, but the rotation of other fonts is dependent on the orientation of the coordinate system.  
  
 `nQuality`  
 Specifies the font's output quality, which defines how carefully the GDI must attempt to match the logical-font attributes to those of an actual physical font. See the `lfQuality` member in the `LOGFONT` structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of values.  
  
 `nPitchAndFamily`  
 Specifies the pitch and family of the font. See the `lfPitchAndFamily` member in the `LOGFONT` structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of values and more information.  
  
 `lpszFacename`  
 A `CString` or pointer to a null-terminated string that specifies the typeface name of the font. The length of this string must not exceed 30 characters. The Windows [EnumFontFamilies](http://msdn.microsoft.com/library/windows/desktop/dd162619) function can be used to enumerate all currently available fonts. If `lpszFacename` is `NULL`, the GDI uses a device-independent typeface.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The font can subsequently be selected as the font for any device context.  
  
 The `CreateFont` function does not create a new Windows GDI font. It merely selects the closest match from the physical fonts available to the GDI.  
  
 Applications can use the default settings for most parameters when creating a logical font. The parameters that should always be given specific values are `nHeight` and `lpszFacename`. If `nHeight` and `lpszFacename` are not set by the application, the logical font that is created is device-dependent.  
  
 When you finish with the `CFont` object created by the `CreateFont` function, use `CDC::SelectObject` to select a different font into the device context, then delete the `CFont` object that is no longer needed.  
  
## Example  
 [!code[NVC_MFCDocView#71](../vs140/codesnippet/CPP/cfont--createfont_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFont Class](../vs140/cfont-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFont::CreateFontIndirect](../vs140/cfont--createfontindirect.md)   
 [CFont::CreatePointFont](../vs140/cfont--createpointfont.md)   
 [CreateFont](http://msdn.microsoft.com/library/windows/desktop/dd183499)   
 [EnumFontFamilies](http://msdn.microsoft.com/library/windows/desktop/dd162619)   
 [EnumFonts](http://msdn.microsoft.com/library/windows/desktop/dd162622)   
 [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037)