---
title: "CMFCToolBarImages Class"
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
  - "CMFCToolBarImages"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCToolBarImages class"
ms.assetid: d4e50518-9ffc-406f-9996-f79e5cd38155
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarImages Class
The images on a toolbar. The <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> class manages toolbar images loaded from application resources or from files.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCToolBarImages::CMFCToolBarImages](#cmfctoolbarimages__cmfctoolbarimages)|Constructs a <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCToolBarImages::AdaptColors](#cmfctoolbarimages__adaptcolors)||  
|[CMFCToolBarImages::AddIcon](#cmfctoolbarimages__addicon)|Adds an icon to the toolbar images.|  
|[CMFCToolBarImages::AddImage](#cmfctoolbarimages__addimage)|Adds a bitmap to the toolbar images.|  
|[CMFCToolBarImages::CleanUp](#cmfctoolbarimages__cleanup)||  
|[CMFCToolBarImages::Clear](#cmfctoolbarimages__clear)|Frees the system resources that were allocated to this object.|  
|[CMFCToolBarImages::ConvertTo32Bits](#cmfctoolbarimages__convertto32bits)|Converts underlined bitmaps to 32 bpp images.|  
|[CMFCToolBarImages::CopyImageToClipboard](#cmfctoolbarimages__copyimagetoclipboard)||  
|[CMFCToolBarImages::CopyTo](#cmfctoolbarimages__copyto)||  
|[CMFCToolBarImages::CreateFromImageList](#cmfctoolbarimages__createfromimagelist)|Initializes the toolbar images from an image list ( [CImageList](../vs140/cimagelist-class.md)).|  
|[CMFCToolBarImages::CreateRegionFromImage](#cmfctoolbarimages__createregionfromimage)||  
|[CMFCToolBarImages::DeleteImage](#cmfctoolbarimages__deleteimage)|Deletes the image that has a specified index from the toolbar images if this set of toolbar images contains user-defined images.|  
|[CMFCToolBarImages::Draw](#cmfctoolbarimages__draw)|Draws a single toolbar image (button).|  
|[CMFCToolBarImages::DrawEx](#cmfctoolbarimages__drawex)||  
|[CMFCToolBarImages::EnableRTL](#cmfctoolbarimages__enablertl)||  
|[CMFCToolBarImages::EndDrawImage](#cmfctoolbarimages__enddrawimage)|Frees system resources after a toolbar image is drawn.|  
|[CMFCToolBarImages::ExtractIcon](#cmfctoolbarimages__extracticon)|Returns the icon that has a specified image index from the toolbar images.|  
|[CMFCToolBarImages::FillDitheredRect](#cmfctoolbarimages__fillditheredrect)|Fills a rectangle by using a brush that has the toolbar background colors.|  
|[CMFCToolBarImages::GetAlwaysLight](#cmfctoolbarimages__getalwayslight)||  
|[CMFCToolBarImages::GetBitsPerPixel](#cmfctoolbarimages__getbitsperpixel)|Returns current resolution of underlined images.|  
|[CMFCToolBarImages::GetCount](#cmfctoolbarimages__getcount)|Returns the number of images on the toolbar.|  
|[CMFCToolBarImages::GetDisabledImageAlpha](#cmfctoolbarimages__getdisabledimagealpha)|Returns the alpha channel value that is used for disabled images.|  
|[CMFCToolBarImages::GetFadedImageAlpha](#cmfctoolbarimages__getfadedimagealpha)||  
|[CMFCToolBarImages::GetImageSize](#cmfctoolbarimages__getimagesize)|Retrieves either the size of the toolbar images that are stored in memory (source size), or the size of the toolbar images that are drawn on the screen (destination size).|  
|[CMFCToolBarImages::GetImageWell](#cmfctoolbarimages__getimagewell)|Returns the handle to the bitmap that contains all the toolbar images.|  
|[CMFCToolBarImages::GetImageWellLight](#cmfctoolbarimages__getimagewelllight)||  
|[CMFCToolBarImages::GetLastImageRect](#cmfctoolbarimages__getlastimagerect)||  
|[CMFCToolBarImages::GetLightPercentage](#cmfctoolbarimages__getlightpercentage)||  
|[CMFCToolBarImages::GetMapTo3DColors](#cmfctoolbarimages__getmapto3dcolors)||  
|[CMFCToolBarImages::GetMask](#cmfctoolbarimages__getmask)||  
|[CMFCToolBarImages::GetResourceOffset](#cmfctoolbarimages__getresourceoffset)|Returns the image index for a specified resource ID.|  
|[CMFCToolBarImages::GetScale](#cmfctoolbarimages__getscale)|Returns current scale ratio of underlined images.|  
|[CMFCToolBarImages::GetTransparentColor](#cmfctoolbarimages__gettransparentcolor)||  
|[CMFCToolBarImages::GrayImages](#cmfctoolbarimages__grayimages)|Grays the toolbar images to make them look disabled.|  
|[CMFCToolBarImages::Is32BitTransparencySupported](#cmfctoolbarimages__is32bittransparencysupported)|Determines whether the operating system supports 32-bit alpha blending.|  
|[CMFCToolBarImages::IsPreMultiplyAutoCheck](#cmfctoolbarimages__ispremultiplyautocheck)||  
|[CMFCToolBarImages::IsRTL](#cmfctoolbarimages__isrtl)|Determines whether right-to-left (RTL) support is enabled.|  
|[CMFCToolBarImages::IsReadOnly](#cmfctoolbarimages__isreadonly)|Determines whether the toolbar images are read-only.|  
|[CMFCToolBarImages::IsScaled](#cmfctoolbarimages__isscaled)|Tells whether the underlined images are scaled or not.|  
|[CMFCToolBarImages::IsUserImagesList](#cmfctoolbarimages__isuserimageslist)|Determines whether this set of toolbar images contains user-defined images.|  
|[CMFCToolBarImages::IsValid](#cmfctoolbarimages__isvalid)|Determines whether this set of toolbar images contains a valid toolbar image.|  
|[CMFCToolBarImages::Load](#cmfctoolbarimages__load)|Loads toolbar images from system resources or from a file.|  
|[CMFCToolBarImages::LoadStr](#cmfctoolbarimages__loadstr)||  
|[CMFCToolBarImages::MapFromSysColor](#cmfctoolbarimages__mapfromsyscolor)||  
|[CMFCToolBarImages::MapTo3dColors](#cmfctoolbarimages__mapto3dcolors)||  
|[CMFCToolBarImages::MapToSysColor](#cmfctoolbarimages__maptosyscolor)||  
|[CMFCToolBarImages::MapToSysColorAlpha](#cmfctoolbarimages__maptosyscoloralpha)||  
|[CMFCToolBarImages::Mirror](#cmfctoolbarimages__mirror)|Horizontally mirrors all of the toolbar images.|  
|[CMFCToolBarImages::MirrorBitmap](#cmfctoolbarimages__mirrorbitmap)|Horizontally mirrors a bitmap.|  
|[CMFCToolBarImages::MirrorBitmapVert](#cmfctoolbarimages__mirrorbitmapvert)||  
|[CMFCToolBarImages::MirrorVert](#cmfctoolbarimages__mirrorvert)||  
|[CMFCToolBarImages::OnSysColorChange](#cmfctoolbarimages__onsyscolorchange)||  
|[CMFCToolBarImages::PrepareDrawImage](#cmfctoolbarimages__preparedrawimage)|Allocates the resources that are required to draw a toolbar image at a specified size.|  
|[CMFCToolBarImages::Save](#cmfctoolbarimages__save)|Stores the toolbar images in a file if this set of toolbar images contains user-defined images.|  
|[CMFCToolBarImages::SetAlwaysLight](#cmfctoolbarimages__setalwayslight)||  
|[CMFCToolBarImages::SetDisabledImageAlpha](#cmfctoolbarimages__setdisabledimagealpha)|Sets the alpha channel value that is used for disabled images.|  
|[CMFCToolBarImages::SetFadedImageAlpha](#cmfctoolbarimages__setfadedimagealpha)||  
|[CMFCToolBarImages::SetImageSize](#cmfctoolbarimages__setimagesize)|Sets the size of a toolbar image (source size).|  
|[CMFCToolBarImages::SetLightPercentage](#cmfctoolbarimages__setlightpercentage)||  
|[CMFCToolBarImages::SetMapTo3DColors](#cmfctoolbarimages__setmapto3dcolors)||  
|[CMFCToolBarImages::SetPreMultiplyAutoCheck](#cmfctoolbarimages__setpremultiplyautocheck)||  
|[CMFCToolBarImages::SetSingleImage](#cmfctoolbarimages__setsingleimage)||  
|[CMFCToolBarImages::SetTransparentColor](#cmfctoolbarimages__settransparentcolor)|Sets the transparent color of the toolbar images.|  
|[CMFCToolBarImages::SmoothResize](#cmfctoolbarimages__smoothresize)|Smoothly resizes underlined images.|  
|[CMFCToolBarImages::UpdateImage](#cmfctoolbarimages__updateimage)|Updates a user-defined toolbar image from a bitmap.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCToolBarImages::PreMultiplyAlpha](#cmfctoolbarimages__premultiplyalpha)||  
  
### Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCToolBarImages::m_bDisableTrueColorAlpha](#cmfctoolbarimages__m_bdisabletruecoloralpha)|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder> if truecolor alpha blending (32-bit color) is disabled.|  
  
## Remarks  
 The full bitmap of toolbar images managed by <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> consists of one or more small toolbar images (buttons) of a fixed size.  
  
## Example  
 The following example demonstrates how to configure a <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> object by using various methods in the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> class. The example shows how to set the size of the toolbar image, load an image, and set the transparent color of the image. This code snippet is part of the [Visual Studio Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#32](../vs140/codesnippet/CPP/cmfctoolbarimages-class_1.h)]  
[!code[NVC_MFC_VisualStudioDemo#33](../vs140/codesnippet/CPP/cmfctoolbarimages-class_2.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CMFCToolBarImages](../vs140/cmfctoolbarimages-class.md)  
  
## Requirements  
 **Header:** afxtoolbarimages.h  
  
##  \<a name="cmfctoolbarimages__adaptcolors">\</a>  CMFCToolBarImages::AdaptColors  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__addicon">\</a>  CMFCToolBarImages::AddIcon  
 Adds an icon to the list of toolbar images.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 A handle to the icon to be added.  
  
 [in] <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> if this icon is used with alpha blending; otherwise <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>.  
  
### Return Value  
 The zero-based index of the toolbar image that was added if the method is successful; otherwise -1.  
  
##  \<a name="cmfctoolbarimages__addimage">\</a>  CMFCToolBarImages::AddImage  
 Adds a bitmap to the toolbar images.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 The handle to the bitmap to add.  
  
 [in] <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> if the [CMFCToolBarImages](../vs140/cmfctoolbarimages-class.md) object uses the color depth (bits per pixel) of the new image; <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> object keeps the current color depth.  
  
 [in] <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> object that contains the image to add.  
  
 [in] <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 The index in the source <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> object of the image to add.  
  
### Return Value  
 The number of toolbar images that the [CMFCToolBarImages](../vs140/cmfctoolbarimages-class.md) object maintains after the new bitmap was added successfully; -1 if the operation failed.  
  
##  \<a name="cmfctoolbarimages__cleanup">\</a>  CMFCToolBarImages::CleanUp  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfctoolbarimages__clear">\</a>  CMFCToolBarImages::Clear  
 Frees the system resources that the [CMFCToolbarImages](../vs140/cmfctoolbarimages-class.md) object allocated.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="cmfctoolbarimages__cmfctoolbarimages">\</a>  CMFCToolBarImages::CMFCToolBarImages  
 Constructs a <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 Constructs a <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> object, initializes its rendering engine and sets the image size to its default value 16x15 pixels. Use [SetImageSize](#cmfctoolbarimages__setimagesize) to change the image size before you add images.  
  
##  \<a name="cmfctoolbarimages__copyimagetoclipboard">\</a>  CMFCToolBarImages::CopyImageToClipboard  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__copyto">\</a>  CMFCToolBarImages::CopyTo  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__createfromimagelist">\</a>  CMFCToolBarImages::CreateFromImageList  
 Initializes the toolbar images from a [CImageList](../vs140/cimagelist-class.md) object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 The image list to be used as a source for toolbar images.  
  
### Return Value  
 Always returns <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>.  
  
### Remarks  
 Use this function to quickly initialize the toolbar images list from an external image list.  
  
##  \<a name="cmfctoolbarimages__createregionfromimage">\</a>  CMFCToolBarImages::CreateRegionFromImage  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__deleteimage">\</a>  CMFCToolBarImages::DeleteImage  
 Deletes the user-defined image that has a specified index from the toolbar images.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the image to delete.  
  
### Return Value  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> if the image was deleted successfully; <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> if the image index is invalid, the <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> object is temporary, the <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> object does not contain user-defined images, or if some other error occurred.  
  
##  \<a name="cmfctoolbarimages__draw">\</a>  CMFCToolBarImages::Draw  
 Draws a single toolbar image.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
 The X coordinate of the left side of the rectangle where the image is to be drawn.  
  
 [in] <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 The Y coordinate of the top of the rectangle where the image is to be drawn.  
  
 [in] <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 The zero-based index of the image to be displayed.  
  
 [in] <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> if the image is to be highlighted; otherwise <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> if the image is to be drawn in the disabled style; otherwise <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> if the image is to be drawn in the indeterminate state style; otherwise <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> if the image is to be drawn with a drop shadow; otherwise <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> if the image is to be drawn in the inactive state style; otherwise <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 The alpha channel (opacity) value. A value of 255 means the image is drawn opaque. A value of 0 means the image is drawn transparent. This value is used only for 32 bit color images and for images that displayed a Windows Vista glass style.  
  
### Return Value  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> if the specified image was displayed successfully; <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> if the image index was invalid or some other error occurred.  
  
##  \<a name="cmfctoolbarimages__drawex">\</a>  CMFCToolBarImages::DrawEx  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__enablertl">\</a>  CMFCToolBarImages::EnableRTL  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__enddrawimage">\</a>  CMFCToolBarImages::EndDrawImage  
 Frees system resources that [CMFCToolBarImages::PrepareDrawImage](#cmfctoolbarimages__preparedrawimage) allocated after you draw a toolbar image by calling [CMFCToolBarImages::Draw](#cmfctoolbarimages__draw).  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 A reference to the <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> object that was passed to the <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> method.  
  
##  \<a name="cmfctoolbarimages__extracticon">\</a>  CMFCToolBarImages::ExtractIcon  
 Returns the icon that has a specified image index from the toolbar images.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 The zero-based index in the image list at which the image to be extracted as an icon is located.  
  
### Return Value  
 A handle to the extracted icon, or <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> is out of range.  
  
##  \<a name="cmfctoolbarimages__fillditheredrect">\</a>  CMFCToolBarImages::FillDitheredRect  
 Fills a rectangle with the toolbar background colors.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 The coordinates of a rectangle to fill.  
  
### Remarks  
 Use this method to fill a rectangle with a color that is the average of the system colors COLOR_BTNFACE and COLOR_BTNHIGHLIGHT. If the system is using 256 or fewer colors, the rectangle will be filled with a dithered pattern of those two colors instead.  
  
##  \<a name="cmfctoolbarimages__getalwayslight">\</a>  CMFCToolBarImages::GetAlwaysLight  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__getcount">\</a>  CMFCToolBarImages::GetCount  
 Returns the number of images in the toolbar images list.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 The number of images in the [CMFCToolbarImages](../vs140/cmfctoolbarimages-class.md) object.  
  
##  \<a name="cmfctoolbarimages__getdisabledimagealpha">\</a>  CMFCToolBarImages::GetDisabledImageAlpha  
 Returns the alpha channel (opacity) value that is used for disabled images.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 The current alpha channel value.  
  
### Remarks  
 You can call [SetDisabledImageAlpha](#cmfctoolbarimages__setdisabledimagealpha) to change the alpha channel value.  
  
##  \<a name="cmfctoolbarimages__getfadedimagealpha">\</a>  CMFCToolBarImages::GetFadedImageAlpha  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__getimagesize">\</a>  CMFCToolBarImages::GetImageSize  
 Retrieves either the size of the toolbar images that are stored in memory (source size), or the size of the toolbar images that are drawn on the screen (destination size).  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> to retrieve the destination size; <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> to retrieve the source image size.  
  
### Return Value  
 A <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> structure, which specifies the size of an image in pixels.  
  
### Remarks  
 The size of the source image is the size of the images that are stored in the [CMFCToolbarImages](../vs140/cmfctoolbarimages-class.md) object. You can call [SetImageSize](#cmfctoolbarimages__setimagesize) to set the source size. The default value is 16x15 pixels.  
  
 By default, the destination image size is 0x0. You specify the destination size when you call [PrepareDrawImage](#cmfctoolbarimages__preparedrawimage). The [EndDrawImage](#cmfctoolbarimages__enddrawimage) method resets the destination size to the default value.  
  
##  \<a name="cmfctoolbarimages__getimagewell">\</a>  CMFCToolBarImages::GetImageWell  
 Returns the handle to the bitmap that contains all the toolbar images.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 A handle to a bitmap that contains toolbar images.  
  
### Remarks  
 The toolbar images are stored in a row in a single bitmap that is known as an *image well*. To find a toolbar image in the image well, multiply the index of the image by the width of the toolbar images (see [CMFCToolBarImages::GetImageSize](#cmfctoolbarimages__getimagesize)) to obtain the horizontal offset of the image inside the image well.  
  
##  \<a name="cmfctoolbarimages__getimagewelllight">\</a>  CMFCToolBarImages::GetImageWellLight  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__getlastimagerect">\</a>  CMFCToolBarImages::GetLastImageRect  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__getlightpercentage">\</a>  CMFCToolBarImages::GetLightPercentage  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__getmapto3dcolors">\</a>  CMFCToolBarImages::GetMapTo3DColors  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__getmask">\</a>  CMFCToolBarImages::GetMask  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__getresourceoffset">\</a>  CMFCToolBarImages::GetResourceOffset  
 Returns the image index for a specified resource ID.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
 An image resource ID.  
  
### Return Value  
 An image index if the method was successful; -1 if the image with the specified resource ID does not exist.  
  
##  \<a name="cmfctoolbarimages__gettransparentcolor">\</a>  CMFCToolBarImages::GetTransparentColor  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__grayimages">\</a>  CMFCToolBarImages::GrayImages  
 Grays the toolbar images to make them look disabled.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
 Luminance percentage.  
  
### Return Value  
 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> if images in the collection were grayed successfully; otherwise <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method modifies the toolbar images by averaging the red, green, and blue components of each pixel and multiplying the result by <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> divided by 100. If <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> is zero or negative, the default value of 130 is used instead.  
  
> [!NOTE]
>  If you want to undo the change, you must reload the images from the source. You can do this by calling [Load](#cmfctoolbarimages__load) or [UpdateImage](#cmfctoolbarimages__updateimage) (only for user-defined images), or by calling [Clear](#cmfctoolbarimages__clear) and adding the images again by calling [AddIcon](#cmfctoolbarimages__addicon) or [AddImage](#cmfctoolbarimages__addimage).  
  
##  \<a name="cmfctoolbarimages__is32bittransparencysupported">\</a>  CMFCToolBarImages::Is32BitTransparencySupported  
 Specifies whether the operating system supports 32-bit alpha blending.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> if 32-bit alpha blending is supported; otherwise <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>.  
  
### Remarks  
 Use this static method to determine at runtime whether the operating system supports 32-bit alpha blending. This feature is supported on [!INCLUDE[win2kfamily](../vs140/includes/win2kfamily_md.md)] and later versions.  
  
##  \<a name="cmfctoolbarimages__ispremultiplyautocheck">\</a>  CMFCToolBarImages::IsPreMultiplyAutoCheck  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__isreadonly">\</a>  CMFCToolBarImages::IsReadOnly  
 Specifies whether the toolbar images are read-only.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> if the toolbar images are read-only, otherwise <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>.  
  
### Remarks  
 The <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> object is read-only when the bitmap with toolbar images was loaded from a read-only file, or when the bitmap was copied in using the <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> method.  
  
##  \<a name="cmfctoolbarimages__isrtl">\</a>  CMFCToolBarImages::IsRTL  
 Specifies whether right-to-left (RTL) support is enabled.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> if RTL support is enabled; otherwise <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>.  
  
### Remarks  
 RTL support is used when the application is localized to a language that is read from right to left, such as Arabic, Hebrew, Persian, or Urdu.  
  
##  \<a name="cmfctoolbarimages__isuserimageslist">\</a>  CMFCToolBarImages::IsUserImagesList  
 Specifies whether this set of toolbar images contains user-defined images.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> if the [CMFCToolbarImages](../vs140/cmfctoolbarimages-class.md) object contains user-defined toolbar images; otherwise <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbarimages__isvalid">\</a>  CMFCToolBarImages::IsValid  
 Indicates whether this set of toolbar images contains a valid toolbar image.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> if a [CMFCToolbarImages](../vs140/cmfctoolbarimages-class.md) object is valid; otherwise <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>.  
  
### Remarks  
 The <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> object is not valid when its handle to a bitmap with toolbar images is <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbarimages__load">\</a>  CMFCToolBarImages::Load  
 Loads toolbar images from system resources or from a file.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
 The ID of a bitmap resource.  
  
 [in] <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>  
 An instance of the resource DLL.  
  
 [in] <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> to add the loaded bitmap to the existing bitmap, or <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> to replace the existing bitmap.  
  
 [in] <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>  
 A path to a disk file from which to load the bitmap.  
  
 [in] <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
 Maximum number of bytes in the bitmap file; or 0 to load the bitmap regardless of file size. If the size of the file exceeds this maximum size, the method returns <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> and does not load the bitmap.  
  
### Return Value  
 <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> if the bitmap was loaded successfully; otherwise <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>.  
  
### Remarks  
 If the file has the read-only attribute, the image list is marked as read-only.  
  
##  \<a name="cmfctoolbarimages__loadstr">\</a>  CMFCToolBarImages::LoadStr  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__mapfromsyscolor">\</a>  CMFCToolBarImages::MapFromSysColor  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__mapto3dcolors">\</a>  CMFCToolBarImages::MapTo3dColors  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__maptosyscolor">\</a>  CMFCToolBarImages::MapToSysColor  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__maptosyscoloralpha">\</a>  CMFCToolBarImages::MapToSysColorAlpha  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__mirror">\</a>  CMFCToolBarImages::Mirror  
 Replaces the toolbar images with their horizontal mirror image.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> if the images were successfully mirrored; otherwise <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method is used to support right-to-left writing systems.  
  
##  \<a name="cmfctoolbarimages__mirrorbitmap">\</a>  CMFCToolBarImages::MirrorBitmap  
 Replaces a bitmap with its horizontal mirror image.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 [in, out] <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
 A handle to bitmap to mirror.  
  
 [in] <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
 Width of the image in pixels.  
  
### Return Value  
 <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> if the image was successfully mirrored; otherwise <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>.  
  
### Remarks  
 This function is used to support right-to-left writing systems.  
  
##  \<a name="cmfctoolbarimages__mirrorbitmapvert">\</a>  CMFCToolBarImages::MirrorBitmapVert  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__mirrorvert">\</a>  CMFCToolBarImages::MirrorVert  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__onsyscolorchange">\</a>  CMFCToolBarImages::OnSysColorChange  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfctoolbarimages__premultiplyalpha">\</a>  CMFCToolBarImages::PreMultiplyAlpha  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__m_bdisabletruecoloralpha">\</a>  CMFCToolBarImages::m_bDisableTrueColorAlpha  
 <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> if truecolor alpha blending (32-bit color) is disabled.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Remarks  
 Set this member variable to <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> to enable truecolor alpha-blending for toolbar images.  
  
 The default value is <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> for backward compatibility.  
  
##  \<a name="cmfctoolbarimages__preparedrawimage">\</a>  CMFCToolBarImages::PrepareDrawImage  
 Allocates the resources that are required to draw a toolbar image at a specified size.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>  
 A reference to <CodeContentPlaceHolder>202\</CodeContentPlaceHolder> structure, which stores the allocated resources between image rendering stages.  
  
 [in] <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>  
 Specifies the size of a destination image.  
  
 [in] <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> if you want inactive images to be drawn faded.  
  
### Return Value  
 <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> if the resources required to draw the toolbar image were allocated successfully, otherwise <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>.  
  
### Remarks  
 After you call this method, you can call [CMFCToolBarImages::Draw](#cmfctoolbarimages__draw) any number of times. After you finished drawing, you must call [CMFCToolBarImages::EndDrawImage](#cmfctoolbarimages__enddrawimage) to release the resources allocated by <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbarimages__save">\</a>  CMFCToolBarImages::Save  
 Stores the toolbar images in a file if this set of toolbar images contains user-defined images.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>  
 A path to a disk file.  
  
### Return Value  
 <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> if the toolbar images were saved successfully; otherwise <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>.  
  
### Remarks  
 Call this method to store the user-defined images into a disk file. If <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>, the method stores the bitmap into the file from which the bitmap was loaded by the [Load](#cmfctoolbarimages__load) method.  
  
##  \<a name="cmfctoolbarimages__setalwayslight">\</a>  CMFCToolBarImages::SetAlwaysLight  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>214\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__setdisabledimagealpha">\</a>  CMFCToolBarImages::SetDisabledImageAlpha  
 Sets the alpha channel (opacity) value that is used for disabled images.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>  
 The new value of the alpha channel.  
  
### Remarks  
 Use this method to set a custom alpha value for disabled images. The default value is 127, which causes disabled button images to be semitransparent. If you set a value of 0, disabled images will be completely transparent. If you set a value of 255, disabled images will be completely opaque.  
  
##  \<a name="cmfctoolbarimages__setfadedimagealpha">\</a>  CMFCToolBarImages::SetFadedImageAlpha  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__setimagesize">\</a>  CMFCToolBarImages::SetImageSize  
 Sets the size of each toolbar image (source size).  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>  
 The new size of toolbar images.  
  
### Remarks  
 By default the size of the toolbar image is 16x15 pixels. Call this method if you want to use toolbar images of a different size.  
  
##  \<a name="cmfctoolbarimages__setlightpercentage">\</a>  CMFCToolBarImages::SetLightPercentage  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__setmapto3dcolors">\</a>  CMFCToolBarImages::SetMapTo3DColors  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__setpremultiplyautocheck">\</a>  CMFCToolBarImages::SetPreMultiplyAutoCheck  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__setsingleimage">\</a>  CMFCToolBarImages::SetSingleImage  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfctoolbarimages__settransparentcolor">\</a>  CMFCToolBarImages::SetTransparentColor  
 Sets the transparent color of the toolbar images.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>  
 An RGB value.  
  
### Return Value  
 The previous transparent color.  
  
### Remarks  
 When you or the framework call [CMFCToolBarImages::Draw](#cmfctoolbarimages__draw), the method does not draw any pixel that matches the color specified by <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfctoolbarimages__updateimage">\</a>  CMFCToolBarImages::UpdateImage  
 Updates a user-defined toolbar image from a bitmap.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>  
 The zero-based index of the image to update.  
  
 [in] <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>  
 A handle to the bitmap from which to update the image.  
  
### Return Value  
 <CodeContentPlaceHolder>225\</CodeContentPlaceHolder> if the image was updated successfully; <CodeContentPlaceHolder>226\</CodeContentPlaceHolder> if the image list is not user-defined or temporary.  
  
##  \<a name="cmfctoolbarimages__convertto32bits">\</a>  CMFCToolBarImages::ConvertTo32Bits  
 Converts underlined bitmaps to 32 bpp images.  
  
<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>  
 Specifies transparent color of underlined bitmaps.  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__getbitsperpixel">\</a>  CMFCToolBarImages::GetBitsPerPixel  
 Returns current resolution of underlined images.  
  
<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
### Return Value  
 An integer value representing the current resolution of underlined images, in bits per pixel (bpp).  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__getscale">\</a>  CMFCToolBarImages::GetScale  
 Returns the current scale ratio of underlined images.  
  
<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
### Return Value  
 A value representing the current scale ratio.  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__isscaled">\</a>  CMFCToolBarImages::IsScaled  
 Tells whether the underlined images are scaled or not.  
  
<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>228\</CodeContentPlaceHolder> if underlined images are scaled; otherwise <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfctoolbarimages__smoothresize">\</a>  CMFCToolBarImages::SmoothResize  
 Smoothly resizes underlined images.  
  
<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>  
 Scale ratio.  
  
### Return Value  
 <CodeContentPlaceHolder>231\</CodeContentPlaceHolder> if resize succeeds; otherwise <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>.  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CObject](../vs140/cobject-class.md)   
 [CMFCToolBar](../vs140/cmfctoolbar-class.md)   
 [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md)