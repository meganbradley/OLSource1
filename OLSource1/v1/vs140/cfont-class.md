---
title: "CFont Class"
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
  - "CFont"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFont class"
  - "GDI, font classes"
  - "fonts, MFC classes"
ms.assetid: 3fad6bfe-d6ce-4ab9-967a-5ce0aa102800
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFont Class
Encapsulates a Windows graphics device interface (GDI) font and provides member functions for manipulating the font.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CFont::CFont](#cfont__cfont)|Constructs a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CFont::CreateFont](#cfont__createfont)|Initializes a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> with the specified characteristics.|  
|[CFont::CreateFontIndirect](#cfont__createfontindirect)|Initializes a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object with the characteristics given in a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> structure.|  
|[CFont::CreatePointFont](#cfont__createpointfont)|Initializes a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> with the specified height, measured in tenths of a point, and typeface.|  
|[CFont::CreatePointFontIndirect](#cfont__createpointfontindirect)|Same as <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> except that the font height is measured in tenths of a point rather than logical units.|  
|[CFont::FromHandle](#cfont__fromhandle)|Returns a pointer to a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object when given a Windows **HFONT**.|  
|[CFont::GetLogFont](#cfont__getlogfont)|Fills a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> with information about the logical font attached to the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CFont::operator HFONT](#cfont__operator_hfont)|Returns the Windows GDI font handle attached to the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 To use a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object, construct a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object and attach a Windows font to it with [CreateFont](#cfont__createfont), [CreateFontIndirect](#cfont__createfontindirect), [CreatePointFont](#cfont__createpointfont), or [CreatePointFontIndirect](#cfont__createpointfontindirect), and then use the object's member functions to manipulate the font.  
  
 The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> functions are often easier to use than <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> since they do the conversion for the height of the font from a point size to logical units automatically.  
  
 For more information on <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, see [Graphic Objects](../vs140/graphic-objects.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CGdiObject](../vs140/cgdiobject-class.md)  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxwin.h  
  
##  \<a name="cfont__cfont">\</a>  CFont::CFont  
 Constructs a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The resulting object must be initialized with <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> before it can be used.  
  
### Example  
 [!code[NVC_MFCDocView#70](../vs140/codesnippet/CPP/cfont-class_1.cpp)]  
  
##  \<a name="cfont__createfont">\</a>  CFont::CreateFont  
 Initializes a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object with the specified characteristics.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 Specifies the desired height (in logical units) of the font. See the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> member of the                                 [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037)structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a description. The absolute value of <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> must not exceed 16,384 device units after it is converted. For all height comparisons, the font mapper looks for the largest font that does not exceed the requested size or the smallest font if all the fonts exceed the requested size.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 Specifies the average width (in logical units) of characters in the font. If <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is 0, the aspect ratio of the device will be matched against the digitization aspect ratio of the available fonts to find the closest match, which is determined by the absolute value of the difference.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Specifies the angle (in 0.1-degree units) between the escapement vector and the x-axis of the display surface. The escapement vector is the line through the origins of the first and last characters on a line. The angle is measured counterclockwise from the x-axis. See the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> member in the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 Specifies the angle (in 0.1-degree units) between the baseline of a character and the x-axis. The angle is measured counterclockwise from the x-axis for coordinate systems in which the y-direction is down and clockwise from the x-axis for coordinate systems in which the y-direction is up.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Specifies the font weight (in inked pixels per 1000). See the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> member in the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information. The described values are approximate; the actual appearance depends on the typeface. Some fonts have only <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> weights. If <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> is specified, a default weight is used.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 Specifies whether the font is italic.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Specifies whether the font is underlined.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 Specifies whether characters in the font are struck out. Specifies a strikeout font if set to a nonzero value.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 Specifies the font's character setSee the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> member in the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of values.  
  
 The OEM character set is system-dependent.  
  
 Fonts with other character sets may exist in the system. An application that uses a font with an unknown character set must not attempt to translate or interpret strings that are to be rendered with that font. Instead, the strings should be passed directly to the output device driver.  
  
 The font mapper does not use the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> value. An application can use this value to allow the name and size of a font to fully describe the logical font. If a font with the specified name does not exist, a font from any character set can be substituted for the specified font. To avoid unexpected results, applications should use the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> value sparingly.  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 Specifies the desired output precision. The output precision defines how closely the output must match the requested font's height, width, character orientation, escapement, and pitch. See the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> member in the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of values and more information.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 Specifies the desired clipping precision. The clipping precision defines how to clip characters that are partially outside the clipping region. See the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> member in the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of values.  
  
 To use an embedded read-only font, an application must specify <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.  
  
 To achieve consistent rotation of device, TrueType, and vector fonts, an application can use the OR operator to combine the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> value with any of the other <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> values. If the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> bit is set, the rotation for all fonts depends on whether the orientation of the coordinate system is left-handed or right-handed. (For more information about the orientation of coordinate systems, see the description of the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> parameter.) If <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> is not set, device fonts always rotate counterclockwise, but the rotation of other fonts is dependent on the orientation of the coordinate system.  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 Specifies the font's output quality, which defines how carefully the GDI must attempt to match the logical-font attributes to those of an actual physical font. See the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> member in the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of values.  
  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 Specifies the pitch and family of the font. See the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> member in the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of values and more information.  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> or pointer to a null-terminated string that specifies the typeface name of the font. The length of this string must not exceed 30 characters. The Windows                                 [EnumFontFamilies](http://msdn.microsoft.com/library/windows/desktop/dd162619) function can be used to enumerate all currently available fonts. If <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>, the GDI uses a device-independent typeface.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The font can subsequently be selected as the font for any device context.  
  
 The <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> function does not create a new Windows GDI font. It merely selects the closest match from the physical fonts available to the GDI.  
  
 Applications can use the default settings for most parameters when creating a logical font. The parameters that should always be given specific values are <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> are not set by the application, the logical font that is created is device-dependent.  
  
 When you finish with the <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> object created by the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> function, use <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> to select a different font into the device context, then delete the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> object that is no longer needed.  
  
### Example  
 [!code[NVC_MFCDocView#71](../vs140/codesnippet/CPP/cfont-class_2.cpp)]  
  
##  \<a name="cfont__createfontindirect">\</a>  CFont::CreateFontIndirect  
 Initializes a <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> object with the characteristics given in a                 [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037)structure.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 Points to a <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> structure that defines the characteristics of the logical font.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The font can subsequently be selected as the current font for any device.  
  
 This font has the characteristics specified in the                         [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) structure. When the font is selected by using the [CDC::SelectObject](../vs140/cdc-class.md#cdc__selectobject) member function, the GDI font mapper attempts to match the logical font with an existing physical font. If the font mapper fails to find an exact match for the logical font, it provides an alternative font whose characteristics match as many of the requested characteristics as possible.  
  
 When you no longer need the <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> object created by the <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> function, use <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> to select a different font into the device context, then delete the <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> object that is no longer needed.  
  
### Example  
 [!code[NVC_MFCDocView#72](../vs140/codesnippet/CPP/cfont-class_3.cpp)]  
  
##  \<a name="cfont__createpointfont">\</a>  CFont::CreatePointFont  
 This function provides a simple way to create a font of a specified typeface and point size.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 Requested font height in tenths of a point. (For instance, pass 120 to request a 12-point font.)  
  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> or pointer to a null-terminated string that specifies the typeface name of the font. The length of this string must not exceed 30 characters. The Windows **EnumFontFamilies** function can be used to enumerate all currently available fonts. If <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> is **NULL**, the GDI uses a device-independent typeface.  
  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 Pointer to the [CDC](../vs140/cdc-class.md) object to be used to convert the height in <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> to logical units. If **NULL**, a screen device context is used for the conversion.  
  
### Return Value  
 Nonzero if successful, otherwise 0.  
  
### Remarks  
 It automatically converts the height in <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> to logical units using the <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> object pointed to by <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.  
  
 When you finish with the <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> object created by the <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> function, first select the font out of the device context, then delete the <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> object.  
  
### Example  
 [!code[NVC_MFCDocView#73](../vs140/codesnippet/CPP/cfont-class_4.cpp)]  
  
##  \<a name="cfont__createpointfontindirect">\</a>  CFont::CreatePointFontIndirect  
 This function is the same as [CreateFontIndirect](#cfont__createfontindirect) except that the **lfHeight** member of the <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> is interpreted in tenths of a point rather than device units.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 Points to a                                 [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) structure that defines the characteristics of the logical font. The **lfHeight** member of the <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> structure is measured in tenths of a point rather than logical units. (For instance, set **lfHeight** to 120 to request a 12-point font.)  
  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 Pointer to the [CDC](../vs140/cdc-class.md) object to be used to convert the height in **lfHeight** to logical units. If **NULL**, a screen device context is used for the conversion.  
  
### Return Value  
 Nonzero if successful, otherwise 0.  
  
### Remarks  
 This function automatically converts the height in **lfHeight** to logical units using the <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> object pointed to by <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> before passing the <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> structure on to Windows.  
  
 When you finish with the <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> object created by the <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> function, first select the font out of the device context, then delete the <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> object.  
  
### Example  
 [!code[NVC_MFCDocView#74](../vs140/codesnippet/CPP/cfont-class_5.cpp)]  
  
##  \<a name="cfont__fromhandle">\</a>  CFont::FromHandle  
 Returns a pointer to a <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> object when given an **HFONT** handle to a Windows GDI font object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 An **HFONT** handle to a Windows font.  
  
### Return Value  
 A pointer to a <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> object if successful; otherwise **NULL**.  
  
### Remarks  
 If a <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> object is not already attached to the handle, a temporary <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> object is created and attached. This temporary <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> object is valid only until the next time the application has idle time in its event loop, at which time all temporary graphic objects are deleted. Another way of saying this is that the temporary object is valid only during the processing of one window message.  
  
### Example  
 [!code[NVC_MFCDocView#75](../vs140/codesnippet/CPP/cfont-class_6.cpp)]  
  
##  \<a name="cfont__getlogfont">\</a>  CFont::GetLogFont  
 Call this function to retrieve a copy of the <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> structure for <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 *pLogFont*  
 Pointer to the                                 [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) structure to receive the font information.  
  
### Return Value  
 Nonzero if the function succeeds, otherwise 0.  
  
### Example  
 [!code[NVC_MFCDocView#76](../vs140/codesnippet/CPP/cfont-class_7.cpp)]  
  
##  \<a name="cfont__operator_hfont">\</a>  CFont::operator HFONT  
 Use this operator to get the Windows GDI handle of the font attached to the <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 The handle of the Windows GDI font object attached to <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> if successful; otherwise **NULL**.  
  
### Remarks  
 Since this operator is automatically used for conversions from <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> to                         [Fonts and Text](http://msdn.microsoft.com/library/windows/desktop/dd144819), you can pass <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> objects to functions that expect **HFONT**s.  
  
 For more information about using graphic objects, see                         [Graphic Objects](http://msdn.microsoft.com/library/windows/desktop/dd144962) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFCDocView#77](../vs140/codesnippet/CPP/cfont-class_8.cpp)]  
  
## See Also  
 [MFC Sample HIERSVR](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cgdiobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)