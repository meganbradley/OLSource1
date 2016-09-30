---
title: "CDrawingManager Class"
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
  - "CDrawingManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDrawingManager class"
ms.assetid: 9e4775ca-101b-4aa9-a85a-4d047c701215
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDrawingManager Class
The <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> class implements complex drawing algorithms.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CDrawingManager::CDrawingManager](#cdrawingmanager__cdrawingmanager)|Constructs a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDrawingManager::CreateBitmap_32](#cdrawingmanager__createbitmap_32)|Creates a 32-bit device-independent bitmap (DIB) that applications can write to directly.|  
|[CDrawingManager::DrawAlpha](#cdrawingmanager__drawalpha)|Displays bitmaps that have transparent or semitransparent pixels.|  
|[CDrawingManager::DrawRotated](#cdrawingmanager__drawrotated)|Rotates a source DC content inside the given rectangle by +/- 90 degrees|  
|[CDrawingManager::DrawEllipse](#cdrawingmanager__drawellipse)|Draws an ellipse with the supplied fill and border colors.|  
|[CDrawingManager::DrawGradientRing](#cdrawingmanager__drawgradientring)|Draws a ring and fills it with a color gradient.|  
|[CDrawingManager::DrawLine, CDrawingManager::DrawLineA](#cdrawingmanager__drawline_cdrawingmanager__drawlinea)|Draws a line.|  
|[CDrawingManager::DrawRect](#cdrawingmanager__drawrect)|Draws a rectangle with the supplied fill and border colors.|  
|[CDrawingManager::DrawShadow](#cdrawingmanager__drawshadow)|Draws a shadow for a rectangular area.|  
|[CDrawingManager::Fill4ColorsGradient](#cdrawingmanager__fill4colorsgradient)|Fills a rectangular area with two color gradients.|  
|[CDrawingManager::FillGradient](#cdrawingmanager__fillgradient)|Fills a rectangular area with a specified color gradient.|  
|[CDrawingManager::FillGradient2](#cdrawingmanager__fillgradient2)|Fills a rectangular area with a specified color gradient. The direction of the gradient's color change is also specified.|  
|[CDrawingManager::GrayRect](#cdrawingmanager__grayrect)|Fills a rectangle with a specified gray color.|  
|[CDrawingManager::HighlightRect](#cdrawingmanager__highlightrect)|Highlights a rectangular area.|  
|[CDrawingManager::HLStoRGB_ONE](#cdrawingmanager__hlstorgb_one)|Converts a color from a HLS representation to a RGB representation.|  
|[CDrawingManager::HLStoRGB_TWO](#cdrawingmanager__hlstorgb_two)|Converts a color from a HLS representation to a RGB representation.|  
|[CDrawingManager::HSVtoRGB](#cdrawingmanager__hsvtorgb)|Converts a color from a HSV representation to a RGB representation.|  
|[CDrawingManager::HuetoRGB](#cdrawingmanager__huetorgb)|Helper method that converts a hue value to a red, green, or blue component.|  
|[CDrawingManager::MirrorRect](#cdrawingmanager__mirrorrect)|Flips a rectangular area.|  
|[CDrawingManager::PixelAlpha](#cdrawingmanager__pixelalpha)|Helper method that determines the final color for a semitransparent pixel.|  
|[CDrawingManager::PrepareShadowMask](#cdrawingmanager__prepareshadowmask)|Creates a bitmap that can be used as a shadow.|  
|[CDrawingManager::RGBtoHSL](#cdrawingmanager__rgbtohsl)|Converts a color from a RGB representation to a HSL representation.|  
|[CDrawingManager::RGBtoHSV](#cdrawingmanager__rgbtohsv)|Converts a color from a RGB representation to a HSV representation.|  
|[CDrawingManager::SetAlphaPixel](#cdrawingmanager__setalphapixel)|Helper method that colors a partially transparent pixel in a bitmap.|  
|[CDrawingManager::SetPixel](#cdrawingmanager__setpixel)|Helper method that changes a single pixel in a bitmap to the specified color.|  
|[CDrawingManager::SmartMixColors](#cdrawingmanager__smartmixcolors)|Combines two colors based on a weighted ratio.|  
  
## Remarks  
 The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> class provides functions for drawing shadows, color gradients, and highlighted rectangles. It also performs alpha-blending. You can use this class to directly change your application's UI.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 Â Â Â [CDrawingManager](../vs140/cdrawingmanager-class.md)  
  
## Requirements  
 **Header:** afxdrawmanager.h  
  
##  \<a name="cdrawingmanager__cdrawingmanager">\</a>  CDrawingManager::CDrawingManager  
 Constructs a [CDrawingManager](../vs140/cdrawingmanager-class.md) object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 A reference to a device context. The <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> uses this context for drawing.  
  
##  \<a name="cdrawingmanager__createbitmap_32">\</a>  CDrawingManager::CreateBitmap_32  
 Creates a 32-bit device-independent bitmap (DIB) that applications can write to directly.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|A [CSize](../vs140/csize-class.md) parameter that indicates the size of the bitmap.|  
|[out] <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|A pointer to a data pointer that receives the location of the DIB's bit values.|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|A handle to the original bitmap|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|An RGB value specifying transparent color of the original bitmap.|  
  
### Return Value  
 A handle to the newly created DIB bitmap if this method is successful; otherwise <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
### Remarks  
 For more information about how to create a DIB bitmap, see                         [CreateDIBSection](http://msdn.microsoft.com/library/windows/desktop/dd183491).  
  
##  \<a name="cdrawingmanager__drawalpha">\</a>  CDrawingManager::DrawAlpha  
 Displays bitmaps that have transparent or semitransparent pixels.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 A pointer to the device context for the destination.  
  
 [in] <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The destination rectangle.  
  
 [in] <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 A pointer to the device context for the source.  
  
 [in] <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The source rectangle.  
  
### Remarks  
 This method performs alpha-blending for two bitmaps. For more information about alpha-blending, see                         [AlphaBlend](http://msdn.microsoft.com/library/windows/desktop/dd183351) in the Windows SDK.  
  
##  \<a name="cdrawingmanager__drawellipse">\</a>  CDrawingManager::DrawEllipse  
 Draws an ellipse with the supplied fill and border colors.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The bounding rectangle for the ellipse.  
  
 [in] <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 The color this method uses to fill the ellipse.  
  
 [in] <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The color this method uses as the border of the ellipse.  
  
### Remarks  
 This method returns without drawing an ellipse if either color is set to -1. It also returns without drawing an ellipse if either dimension of the bounding rectangle is 0.  
  
##  \<a name="cdrawingmanager__drawgradientring">\</a>  CDrawingManager::DrawGradientRing  
 Draws a ring and fills it with a color gradient.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 A [CRect](../vs140/crect-class.md) parameter that specifies the boundary for the gradient ring.  
  
 [in] <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 The first color for the gradient.  
  
 [in] <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 The last color for the gradient.  
  
 [in] <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The color of the border.  
  
 [in] <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 A parameter that specifies the initial gradient drawing angle. This value should be between 0 and 360.  
  
 [in] <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The width of the border for the ring.  
  
 [in] <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 The color of the interior of the ring.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The rectangle defined by <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> must be at least 5 pixels wide and 5 pixels high.  
  
##  \<a name="cdrawingmanager__drawline_cdrawingmanager__drawlinea">\</a>  CDrawingManager::DrawLine, CDrawingManager::DrawLineA  
 Draws a line.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|The x coordinate where the line starts.|  
|[in] <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|The y coordinate where the line starts.|  
|[in] <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|The x coordinate where the line ends.|  
|[in] <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|The y coordinate where the line ends.|  
|[in] <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|The color of the line.|  
  
### Remarks  
 This method fails if <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> equals -1.  
  
##  \<a name="cdrawingmanager__drawrect">\</a>  CDrawingManager::DrawRect  
 Draws a rectangle with the supplied fill and border colors.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 The boundaries for the rectangle.  
  
 [in] <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 The color this method uses to fill the rectangle.  
  
 [in] <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 The color this method uses for the border of the rectangle.  
  
### Remarks  
 This method returns without drawing a rectangle if either color is set to -1. It also returns if either dimension of the rectangle is 0.  
  
##  \<a name="cdrawingmanager__drawshadow">\</a>  CDrawingManager::DrawShadow  
 Draws a shadow for a rectangular area.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 A rectangular area in your application. The drawing manager will draw a shadow underneath this area.  
  
 [in] <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 The width and height of the shadow.  
  
 [in] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 The minimum brightness of the shadow.  
  
 [in] <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 The maximum brightness of the shadow.  
  
 [in] <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 A pointer to a bitmap that contains the image for the bottom part of the shadow.  
  
 [in] <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 A pointer to a bitmap that contains the image for the shadow that is drawn on the right side of the rectangle.  
  
 [in] <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 The color of the shadow.  
  
 [in] <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates how the shadow is drawn. If <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> draws a shadow on the right side of the rectangle.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 You can provide two valid bitmaps for the bottom and right shadows by using the parameters <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>. If these [CBitmap](../vs140/cbitmap-class.md) objects have an attached GDI object, <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> will use those bitmaps as the shadows. If the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> parameters do not have an attached GDI object, <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> draws the shadow and attaches the bitmaps to the parameters. In future calls to <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>, you can provide these bitmaps to speed up the drawing process. For more information about the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> class and GDI objects, see [Graphic Objects](../vs140/graphic-objects.md).  
  
 If either of these parameters is <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> will automatically draw the shadow.  
  
 If you set <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>, the shadow will be drawn underneath and to the left of the rectangular area.  
  
### Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> class. This code snippet is part of the [Prop Sheet Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_PropSheetDemo#1](../vs140/codesnippet/CPP/cdrawingmanager-class_1.cpp)]  
  
##  \<a name="cdrawingmanager__fill4colorsgradient">\</a>  CDrawingManager::Fill4ColorsGradient  
 Fills a rectangular area with two color gradients.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 The rectangle to fill.  
  
 [in] <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 The initial color for the first color gradient.  
  
 [in] <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 The final color for the first color gradient.  
  
 [in] <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 The initial color for the second color gradient.  
  
 [in] <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 The final color for the second color gradient.  
  
 [in] <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> colors a horizontal or vertical gradient. <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> indicates a horizontal gradient.  
  
 [in] <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 An integer from 0-100. This value indicates the percentage of the rectangle to fill with the first color gradient.  
  
### Remarks  
 When a rectangle is filled with two color gradients, they are either located above each other or next to each other, depending on the value of <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>. Each color gradient is calculated independently with the method [CDrawingManager::FillGradient](#cdrawingmanager__fillgradient).  
  
 This method generates an assertion failure if <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> is less than 0 or more than 100.  
  
##  \<a name="cdrawingmanager__fillgradient">\</a>  CDrawingManager::FillGradient  
 Fills a rectangular area with the specified color gradient.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 The rectangular area to fill.  
  
 [in] <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
 The first color for the gradient.  
  
 [in] <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
 The final color for the gradient.  
  
 [in] <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> should draw a horizontal or vertical gradient.  
  
 [in] <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 The percentage of the rectangle that <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> fills with <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> before it starts the gradient.  
  
 [in] <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 The percentage of the rectangle that <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> fills with <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> after it finishes the gradient.  
  
### Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> class. This code snippet is part of the [MS Office 2007 Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_MSOffice2007Demo#12](../vs140/codesnippet/CPP/cdrawingmanager-class_2.cpp)]  
  
##  \<a name="cdrawingmanager__fillgradient2">\</a>  CDrawingManager::FillGradient2  
 Fills a rectangular area with a specified color gradient.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 The rectangular area to fill.  
  
 [in] <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 The first color of the gradient.  
  
 [in] <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 The last color of the gradient.  
  
 [in] <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 An integer between 0 and 360. This parameter specifies the direction of the color gradient.  
  
### Remarks  
 Use <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> to specify the direction of the color gradient. When you specify the direction of the color gradient, you also specify where the color gradient starts. A value of 0 for <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> indicates the gradient starts from the top of the rectangle. As <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> increases, the starting location for the gradient moves in a counter-clockwise direction based on the angle.  
  
### Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> class. This code snippet is part of the [New Controls sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_NewControls#37](../vs140/codesnippet/CPP/cdrawingmanager-class_3.cpp)]  
  
##  \<a name="cdrawingmanager__grayrect">\</a>  CDrawingManager::GrayRect  
 Fills a rectangle with a specified gray color.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 The rectangular area to fill.  
  
 [in] <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 The percentage of gray you want in the rectangle.  
  
 [in] <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 The transparent color.  
  
 [in] <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 The color that this method uses for de-saturation if <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> is set to -1.  
  
### Return Value  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> if the method was successful; otherwise <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>.  
  
### Remarks  
 For the parameter <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>, a lower value indicates a darker color.  
  
 The maximum value for <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> is 200. A value larger than 200 does not change the appearance of the rectangle. If the value is -1, this method uses <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> to limit the saturation of the rectangle.  
  
##  \<a name="cdrawingmanager__highlightrect">\</a>  CDrawingManager::HighlightRect  
 Highlights a rectangular area.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 A rectangular area to highlight.  
  
 [in] <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
 A percentage that indicates how transparent the highlight should be.  
  
 [in] <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 The transparent color.  
  
 [in] <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 An integer between 0 and 255 that indicates the color tolerance.  
  
 [in] <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 The base color for blending.  
  
### Return Value  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> if the method is successful; otherwise <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>.  
  
### Remarks  
 If <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> is between 0 and 99, <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> uses the alpha blending algorithm. For more information about alpha blending, see [Alpha Blending Lines and Fills](assetId:///5440f48c-3ac9-44c3-b170-c1c110bdbab8). If <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> is -1, this method uses the default highlight level. If <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> is 100, this method does nothing and returns <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>.  
  
 The method uses the parameter <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> to determine whether to highlight the rectangular area. To highlight the rectangle, the difference between the background color of your application and <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> must be less than <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> in each color component (red, green, and blue).  
  
##  \<a name="cdrawingmanager__hlstorgb_one">\</a>  CDrawingManager::HLStoRGB_ONE  
 Converts a color from a HLS representation to a RGB representation.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>  
 A number between 0 and 1 that represents the hue for the color.  
  
 [in] <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
 A number between 0 and 1 that indicates the luminosity for the color.  
  
 [in] <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
 A number between 0 and 1 that indicates the saturation for the color.  
  
### Return Value  
 The RGB representation of the HLS color provided.  
  
### Remarks  
 A color can be represented as HSV (hue, saturation, and value), HSL (hue, saturation, and luminosity), or RGB (red, green, and blue). For more information about the different representations of color, see                         [Color](http://go.microsoft.com/fwlink/?LinkID=119126).  
  
 This method and the <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> method perform the same operation, but require different values for the <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> parameter. In this method, <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> is a percentage of the circle. In the <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> method, <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> is a degree value between 0 and 360, which both represent red. For example, with <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>, a value of 0.25 for <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> is equivalent to a value of 90 with <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>.  
  
##  \<a name="cdrawingmanager__hlstorgb_two">\</a>  CDrawingManager::HLStoRGB_TWO  
 Converts a color from a HLS representation to a RGB representation.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
 A number between 0 and 360 that represents the hue for the color.  
  
 [in] <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
 A number between 0 and 1 that indicates the luminosity for the color.  
  
 [in] <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
 A number between 0 and 1 that indicates the saturation for the color.  
  
### Return Value  
 The RGB representation of the HLS color provided.  
  
### Remarks  
 A color can be represented as HSV (hue, saturation, and value), HSL (hue, saturation, and luminosity), or RGB (red, green, and blue). For more information about the different representations of color, see                         [Color](http://go.microsoft.com/fwlink/?LinkID=119126).  
  
 This method and the [CDrawingManager::HLStoRGB_ONE](#cdrawingmanager__hlstorgb_one) method perform the same operation, but require different values for the <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> parameter. In this method, <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> is a degree value between 0 and 360, which both represent red. In the [CDrawingManager::HLStoRGB_ONE](#cdrawingmanager__hlstorgb_one) method, <CodeContentPlaceHolder>160\</CodeContentPlaceHolder> is a percentage of the circle. For example, with <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>, a value of 0.25 for <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> is equivalent to a value of 90 with <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>.  
  
##  \<a name="cdrawingmanager__hsvtorgb">\</a>  CDrawingManager::HSVtoRGB  
 Converts a color from a HSV representation to a RGB representation.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>|A number between 0 and 360 that indicates the hue for the color.|  
|[in] <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>|A number between 0 and 1 that indicates the saturation for the color.|  
|[in] <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>|A number between 0 and 1 that indicates the value for the color.|  
  
### Return Value  
 The RGB representation of the HSV color provided.  
  
### Remarks  
 A color can be represented as HSV (hue, saturation, and value), HSL (hue, saturation, and luminosity), or RGB (red, green, and blue). For more information about the different representations of color, see                         [Color](http://go.microsoft.com/fwlink/?LinkID=119126).  
  
##  \<a name="cdrawingmanager__huetorgb">\</a>  CDrawingManager::HuetoRGB  
 Converts a hue value to a red, green, or blue component.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
 See Remarks.  
  
 [in] <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>  
 See Remarks.  
  
 [in] <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>  
 See Remarks.  
  
 [in] <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>  
 See Remarks.  
  
 [in] <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>  
 See Remarks.  
  
 [in] <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>  
 See Remarks.  
  
### Return Value  
 The individual red, green, or blue component for the provided hue.  
  
### Remarks  
 This method is a helper method that the [CDrawingManager Class](../vs140/cdrawingmanager-class.md) uses to compute the individual red, green, and blue components of a color in a HSV or HSL representation. This method is not designed to be called directly by the programmer. The input parameters are values that depend on the conversion algorithm.  
  
 To convert a HSV or HSL color to a RGB representation, call one of the following methods:  
  
-   [CDrawingManager::HSVtoRGB](#cdrawingmanager__hsvtorgb)  
  
-   [CDrawingManager::HLStoRGB_ONE](#cdrawingmanager__hlstorgb_one)  
  
-   [CDrawingManager::HLStoRGB_TWO](#cdrawingmanager__hlstorgb_two)  
  
##  \<a name="cdrawingmanager__mirrorrect">\</a>  CDrawingManager::MirrorRect  
 Flips a rectangular area.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
 The bounding rectangle of the area to flip.  
  
 [in] <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates whether the rectangle flips horizontally or vertically.  
  
### Remarks  
 This method can flip any area of the device context owned by the [CDrawingManager Class](../vs140/cdrawingmanager-class.md). If <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>, this method flips the area horizontally. Otherwise, it flips the area vertically.  
  
##  \<a name="cdrawingmanager__pixelalpha">\</a>  CDrawingManager::PixelAlpha  
 Calculates the final color for a semitransparent pixel.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
 The initial color for the pixel.  
  
 [in] <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>  
 A number between 0 and 100 that represents the percentage of transparency. A value of 100 indicates that the initial color is completely transparent.  
  
 [in] <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
 A number between 0 and 100 that represents the percentage of transparency for the red component.  
  
 [in] <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
 A number between 0 and 100 that represents the percentage of transparency for the green component.  
  
 [in] <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>  
 A number between 0 and 100 that represents the percentage of transparency for the blue component.  
  
 [in] <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
 The base color for the pixel.  
  
### Return Value  
 The final color for the semitransparent pixel.  
  
### Remarks  
 This is a helper class for coloring semitransparent bitmaps and is not designed to be called directly by the programmer.  
  
 When you use the version of the method that has <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>, the final color is a combination of <CodeContentPlaceHolder>184\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> color is the partially transparent color over the base color of <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>.  
  
##  \<a name="cdrawingmanager__prepareshadowmask">\</a>  CDrawingManager::PrepareShadowMask  
 Creates a bitmap that can be used as a shadow.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  
 The width and height of the shadow.  
  
 [in] <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  
 The color of the shadow.  
  
 [in] <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
 The minimum brightness of the shadow.  
  
 [in] <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
 The maximum brightness of the shadow.  
  
### Return Value  
 A handle to the created bitmap if this method is successful; otherwise <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>.  
  
### Remarks  
 If <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> is set to 0, this method exits and returns <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> is less than 3, the width and height of the shadow are set to 3 pixels.  
  
##  \<a name="cdrawingmanager__rgbtohsl">\</a>  CDrawingManager::RGBtoHSL  
 Converts a color from a red, green, and blue (RGB) representation to a hue, saturation, and lightness (HSL) representation.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>|The color in RGB values.|  
|[out] <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>|A pointer to a double where the method stores the hue for the color.|  
|[out] <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>|A pointer to a double where the method stores the saturation for the color.|  
|[out] <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>|A pointer to a double where the method stores the lightness for the color.|  
  
### Remarks  
 A color can be represented as HSV (hue, saturation, and value), HSL (hue, saturation, and luminosity), or RGB (red, green, and blue). For more information about the different representations of color, see                         [Color](http://go.microsoft.com/fwlink/?LinkID=119126).  
  
 The returned value for <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> is represented as a fraction between 0 and 1 where both 0 and 1 represent red. The returned values for <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>202\</CodeContentPlaceHolder> are numbers between 0 and 1.  
  
##  \<a name="cdrawingmanager__rgbtohsv">\</a>  CDrawingManager::RGBtoHSV  
 Converts a color from a RGB representation to a HSV representation.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>  
 The color to convert in a RGB representation.  
  
 [out] <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>  
 A pointer to a double where this method stores the resulting hue for the color.  
  
 [out] <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>  
 A pointer to a double where this method stores the resulting saturation for the color.  
  
 [out] <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>  
 A pointer to a double where this method stores the resulting value for the color.  
  
### Remarks  
 A color can be represented as HSV (hue, saturation, and value), HSL (hue, saturation, and luminosity), or RGB (red, green, and blue). For more information about the different representations of color, see                         [Color](http://go.microsoft.com/fwlink/?LinkID=119126).  
  
 The returned value for <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> is a number between 0 and 360 where both 0 and 360 indicate red. The return values for <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> are numbers between 0 and 1.  
  
##  \<a name="cdrawingmanager__setalphapixel">\</a>  CDrawingManager::SetAlphaPixel  
 Colors a transparent pixel in a bitmap.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>  
 A pointer to the bit values for the bitmap.  
  
 [in] <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>  
 A rectangular area in your application. The drawing manager draws a shadow underneath and to the right of this area.  
  
 [in] <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>  
 The horizontal coordinate of the pixel to color.  
  
 [in] <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>  
 The vertical coordinate of the pixel to color.  
  
 [in] <CodeContentPlaceHolder>214\</CodeContentPlaceHolder>  
 The percentage of transparency.  
  
 [in] <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>  
 The width and height of the shadow.  
  
 [in] <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>  
 The color of the shadow.  
  
 [in] <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>  
 A Boolean parameter that indicates which pixel to color. See the Remarks section for more information.  
  
### Remarks  
 This method is a helper method that is used by the [CDrawingManager::DrawShadow](#cdrawingmanager__drawshadow) method. We recommend that if you want to draw a shadow, call <CodeContentPlaceHolder>218\</CodeContentPlaceHolder> instead.  
  
 If <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>, the pixel to color is measured <CodeContentPlaceHolder>221\</CodeContentPlaceHolder> pixels from the right edge of <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>. If it is <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>, the pixel to color is measured <CodeContentPlaceHolder>224\</CodeContentPlaceHolder> pixels from the left edge of <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>.  
  
##  \<a name="cdrawingmanager__setpixel">\</a>  CDrawingManager::SetPixel  
 Changes a single pixel in a bitmap to the specified color.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>|A pointer to the bit values of the bitmap.|  
|[in] <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>|The total width of the bitmap.|  
|[in] <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>|The total height of the bitmap.|  
|[in] <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>|The x-coordinate of the pixel in the bitmap to change.|  
|[in] <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>|The y-coordinate of the pixel in the bitmap to change.|  
|[in] <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>|The new color for the pixel identified by the supplied coordinates.|  
  
##  \<a name="cdrawingmanager__smartmixcolors">\</a>  CDrawingManager::SmartMixColors  
 Combines two colors based on a weighted ratio.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>|The first color to mix.|  
|[in] <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>|The second color to mix.|  
|[in] <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>|The ratio for the new color's luminosity. <CodeContentPlaceHolder>235\</CodeContentPlaceHolder> multiplies the luminosity of the mixed color by this ratio before determining a final color.|  
|[in] <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>|The weighted ratio for the first color.|  
|[in] <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>|The weighted ratio for the second color.|  
  
### Return Value  
 A color that represents a weighted mixture of the supplied colors.  
  
### Remarks  
 This method fails with an error if either <CodeContentPlaceHolder>238\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>239\</CodeContentPlaceHolder> is less than zero. If both of these parameters are set to 0, the method returns <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>.  
  
 The weighted ratio is calculated with the following formula:                         (color1 * k1 + color2 \* k2)/(k1 + k2). After the weighted ratio is determined, the method calculates the luminosity for the mixed color. It then multiplies the luminosity by <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>. If the value is larger than 1.0, the method sets the luminosity for the mixed color to the new value. Otherwise, the luminosity is set to 1.0.  
  
##  \<a name="cdrawingmanager__drawrotated">\</a>  CDrawingManager::DrawRotated  
 Rotates a source DC content inside the given rectangle by 90 degrees.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>  
 Destination rectangle.  
  
 <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>  
 The source device context.  
  
 <CodeContentPlaceHolder>244\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>245\</CodeContentPlaceHolder> indicates rotate +90 degrees; <CodeContentPlaceHolder>246\</CodeContentPlaceHolder> indicates rotate -90 degrees.  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)