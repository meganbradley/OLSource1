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
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFont::CreateFont
Initializes a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object with the specified characteristics.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the desired height (in logical units) of the font. See the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member of the [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037)structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a description. The absolute value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> must not exceed 16,384 device units after it is converted. For all height comparisons, the font mapper looks for the largest font that does not exceed the requested size or the smallest font if all the fonts exceed the requested size.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the average width (in logical units) of characters in the font. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is 0, the aspect ratio of the device will be matched against the digitization aspect ratio of the available fonts to find the closest match, which is determined by the absolute value of the difference.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies the angle (in 0.1-degree units) between the escapement vector and the x-axis of the display surface. The escapement vector is the line through the origins of the first and last characters on a line. The angle is measured counterclockwise from the x-axis. See the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> member in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Specifies the angle (in 0.1-degree units) between the baseline of a character and the x-axis. The angle is measured counterclockwise from the x-axis for coordinate systems in which the y-direction is down and clockwise from the x-axis for coordinate systems in which the y-direction is up.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Specifies the font weight (in inked pixels per 1000). See the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> member in the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information. The described values are approximate; the actual appearance depends on the typeface. Some fonts have only <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> weights. If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is specified, a default weight is used.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Specifies whether the font is italic.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Specifies whether the font is underlined.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 Specifies whether characters in the font are struck out. Specifies a strikeout font if set to a nonzero value.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Specifies the font's character setSee the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> member in the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of values.  
  
 The OEM character set is system-dependent.  
  
 Fonts with other character sets may exist in the system. An application that uses a font with an unknown character set must not attempt to translate or interpret strings that are to be rendered with that font. Instead, the strings should be passed directly to the output device driver.  
  
 The font mapper does not use the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> value. An application can use this value to allow the name and size of a font to fully describe the logical font. If a font with the specified name does not exist, a font from any character set can be substituted for the specified font. To avoid unexpected results, applications should use the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> value sparingly.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Specifies the desired output precision. The output precision defines how closely the output must match the requested font's height, width, character orientation, escapement, and pitch. See the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> member in the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of values and more information.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Specifies the desired clipping precision. The clipping precision defines how to clip characters that are partially outside the clipping region. See the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> member in the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of values.  
  
 To use an embedded read-only font, an application must specify <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
 To achieve consistent rotation of device, TrueType, and vector fonts, an application can use the OR operator to combine the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> value with any of the other <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> values. If the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> bit is set, the rotation for all fonts depends on whether the orientation of the coordinate system is left-handed or right-handed. (For more information about the orientation of coordinate systems, see the description of the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> parameter.) If <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is not set, device fonts always rotate counterclockwise, but the rotation of other fonts is dependent on the orientation of the coordinate system.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Specifies the font's output quality, which defines how carefully the GDI must attempt to match the logical-font attributes to those of an actual physical font. See the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> member in the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of values.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 Specifies the pitch and family of the font. See the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> member in the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of values and more information.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> or pointer to a null-terminated string that specifies the typeface name of the font. The length of this string must not exceed 30 characters. The Windows [EnumFontFamilies](http://msdn.microsoft.com/library/windows/desktop/dd162619) function can be used to enumerate all currently available fonts. If <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, the GDI uses a device-independent typeface.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The font can subsequently be selected as the font for any device context.  
  
 The <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> function does not create a new Windows GDI font. It merely selects the closest match from the physical fonts available to the GDI.  
  
 Applications can use the default settings for most parameters when creating a logical font. The parameters that should always be given specific values are <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> are not set by the application, the logical font that is created is device-dependent.  
  
 When you finish with the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> object created by the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> function, use <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> to select a different font into the device context, then delete the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object that is no longer needed.  
  
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