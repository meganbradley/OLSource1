---
title: "CImage Class"
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
  - "CImage"
  - "ATL.CImage"
  - "ATL::CImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "jpeg files"
  - "bitmaps [C++], ATL and MFC support for"
  - "images [C++], ATL and MFC support for"
  - "gif files, ATL and MFC support"
  - ".gif files, ATL and MFC support"
  - "PNG files, ATL and MFC support"
  - "CImage class"
  - "transparent color"
ms.assetid: 52861e3d-bf7e-481f-a240-90e88f76c490
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CImage Class
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder> provides enhanced bitmap support, including the ability to load and save images in JPEG, GIF, BMP, and Portable Network Graphics (PNG) formats.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CImage::CImage](#cimage__cimage)|The constructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CImage::AlphaBlend](#cimage__alphablend)|Displays bitmaps that have transparent or semitransparent pixels.|  
|[CImage::Attach](#cimage__attach)|Attaches an                                         <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> to a                                         <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object. Can be used with either non-DIB section bitmaps or DIB section bitmaps.|  
|[CImage::BitBlt](#cimage__bitblt)|Copies a bitmap from the source device context to this current device context.|  
|[CImage::Create](#cimage__create)|Creates a DIB section bitmap and attaches it to the previously constructed                                         <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object.|  
|[CImage::CreateEx](#cimage__createex)|Creates a DIB section bitmap (with additional parameters) and attaches it to the previously constructed                                         <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object.|  
|[CImage::Destroy](#cimage__destroy)|Detaches the bitmap from the                                         <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object and destroys the bitmap.|  
|[CImage::Detach](#cimage__detach)|Detaches the bitmap from a                                         <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> object.|  
|[CImage::Draw](#cimage__draw)|Copies a bitmap from a source rectangle into a destination rectangle.                                         **Draw** stretches or compresses the bitmap to fit the dimensions of the destination rectangle, if necessary, and handles alpha blending and transparent colors.|  
|[CImage::GetBits](#cimage__getbits)|Retrieves a pointer to the actual pixel values of the bitmap.|  
|[CImage::GetBPP](#cimage__getbpp)|Retrieves the bits per pixel.|  
|[CImage::GetColorTable](#cimage__getcolortable)|Retrieves red, green, blue (RGB) color values from a range of entries in the color table.|  
|[CImage::GetDC](#cimage__getdc)|Retrieves the device context into which the current bitmap is selected.|  
|[CImage::GetExporterFilterString](#cimage__getexporterfilterstring)|Finds the available image formats and their descriptions.|  
|[CImage::GetHeight](#cimage__getheight)|Retrieves the height of the current image in pixels.|  
|[CImage::GetImporterFilterString](#cimage__getimporterfilterstring)|Finds the available image formats and their descriptions.|  
|[CImage::GetMaxColorTableEntries](#cimage__getmaxcolortableentries)|Retrieves the maximum number of entries in the color table.|  
|[CImage::GetPitch](#cimage__getpitch)|Retrieves the pitch of the current image, in bytes.|  
|[CImage::GetPixel](#cimage__getpixel)|Retrieves the color of the pixel specified by                                         *x* and                                         *y*.|  
|[CImage::GetPixelAddress](#cimage__getpixeladdress)|Retrieves the address of a given pixel.|  
|[CImage::GetTransparentColor](#cimage__gettransparentcolor)|Retrieves the position of the transparent color in the color table.|  
|[CImage::GetWidth](#cimage__getwidth)|Retrieves the width of the current image in pixels.|  
|[CImage::IsDIBSection](#cimage__isdibsection)|Determines if the attached bitmap is a DIB section.|  
|[CImage::IsIndexed](#cimage__isindexed)|Indicates that a bitmap's colors are mapped to an indexed palette.|  
|[CImage::IsNull](#cimage__isnull)|Indicates if a source bitmap is currently loaded.|  
|[CImage::IsTransparencySupported](#cimage__istransparencysupported)|Indicates whether the application supports transparent bitmaps and was compiled for Windows 2000 or later.|  
|[CImage::Load](#cimage__load)|Loads an image from the specified file.|  
|[CImage::LoadFromResource](#cimage__loadfromresource)|Loads an image from the specified resource.|  
|[CImage::MaskBlt](#cimage__maskblt)|Combines the color data for the source and destination bitmaps using the specified mask and raster operation.|  
|[CImage::PlgBlt](#cimage__plgblt)|Performs a bit-block transfer from a rectangle in a source device context into a parallelogram in a destination device context.|  
|[CImage::ReleaseDC](#cimage__releasedc)|Releases the device context that was retrieved with                                         [CImage::GetDC](#cimage__getdc).|  
|[CImage::ReleaseGDIPlus](#cimage__releasegdiplus)|Releases resources used by GDI+. Must be called to free resources created by a global                                         <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object.|  
|[CImage::Save](#cimage__save)|Saves an image as the specified type.                                         **Save** cannot specify image options.|  
|[CImage::SetColorTable](#cimage__setcolortable)|Sets red, green, blue RGB) color values in a range of entries in the color table of the DIB section.|  
|[CImage::SetPixel](#cimage__setpixel)|Sets the pixel at the specified coordinates to the specified color.|  
|[CImage::SetPixelIndexed](#cimage__setpixelindexed)|Sets the pixel at the specified coordinates to the color at the specified index of the palette.|  
|[CImage::SetPixelRGB](#cimage__setpixelrgb)|Sets the pixel at the specified coordinates to the specified red, green, blue (RGB) value.|  
|[CImage::SetTransparentColor](#cimage__settransparentcolor)|Sets the index of the color to be treated as transparent. Only one color in a palette can be transparent.|  
|[CImage::StretchBlt](#cimage__stretchblt)|Copies a bitmap from a source rectangle into a destination rectangle, stretching or compressing the bitmap to fit the dimensions of the destination rectangle, if necessary.|  
|[CImage::TransparentBlt](#cimage__transparentblt)|Copies a bitmap with transparent color from the source device context to this current device context.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CImage::operator HBITMAP](#cimage__operator_hbitmap)|Returns the Windows handle attached to the                                         <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> takes bitmaps that are either device-independent bitmap (DIB) sections or not; however, you can use                 [Create](#cimage__create) or                 [CImage::Load](#cimage__load) with only DIB sections. You can attach a non-DIB section bitmap to a                 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object using                 [Attach](#cimage__attach), but then you cannot use the following                 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> methods, which support only DIB section bitmaps:  
  
-   [GetBits](#cimage__getbits)  
  
-   [GetColorTable](#cimage__getcolortable)  
  
-   [GetMaxColorTableEntries](#cimage__getmaxcolortableentries)  
  
-   [GetPitch](#cimage__getpitch)  
  
-   [GetPixelAddress](#cimage__getpixeladdress)  
  
-   [IsIndexed](#cimage__isindexed)  
  
-   [SetColorTable](#cimage__setcolortable)  
  
 To determine if an attached bitmap is a DIB section, call                 [IsDibSection](#cimage__isdibsection)**.**  
  
> [!NOTE]
>  **Note** In Visual Studio .NET 2003, this class keeps a count of the number of                     <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> objects created. Whenever the count goes to 0, the function                     [GdiplusShutdown](_gdiplus_func_gdiplusshutdown_) is automatically called to release resources used by GDI+. This ensures that any                     <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> objects created directly or indirectly by DLLs are always destroyed properly and that                     **GdiplusShutdown** is not called from                     <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  Using global                     <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> objects in a DLL is not recommended. If you need to use a global                     <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object in a DLL, call                     [CImage::ReleaseGDIPlus](#cimage__releasegdiplus) to explicitly release resources used by GDI+.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> cannot be selected into a new                 [CDC](../vs140/cdc-class.md).                 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> creates its own                 **HDC** for the image. Because an                 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> can only be selected into one                 **HDC** at a time, the                 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> associated with the                 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> cannot be selected into another                 **HDC**. If you need a                 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, retrieve the                 **HDC** from the                 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> and give it to                 [CDC::FromHandle](../vs140/cdc--fromhandle.md).  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#70](../vs140/codesnippet/CPP/cimage-class_1.cpp)]  
  
 When you use                     <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> in an MFC project, note which member functions in your project expect a pointer to a                     [CBitmap](../vs140/cbitmap-class.md) object. If you want to use                     <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> with such a function, like                     [CMenu::AppendMenu](../vs140/cmenu--appendmenu.md), use                     [CBitmap::FromHandle](../vs140/cbitmap--fromhandle.md), pass it your                     <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, and use the returned                     <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#71](../vs140/codesnippet/CPP/cimage-class_2.cpp)]  
  
 Through                     <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, you have access to the actual bits of a DIB section. You can use a                     <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> object anywhere you previously used a Win32 HBITMAP or DIB section.  
  
> [!NOTE]
>  The following                         <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> methods have limitations on their use:  
  
|Method|Limitation|  
|------------|----------------|  
|[PlgBlt](#cimage__plgblt)|Works with only Windows NT 4.0 or later. Will not work on applications running on Windows 95/98 or later.|  
|[MaskBlt](#cimage__maskblt)|Works with only Windows NT 4.0 or later. Will not work on applications running on Windows 95/98 or later.|  
|[AlphaBlend](#cimage__alphablend)|Works with only Windows 2000, Windows 98, and later systems.|  
|[TransparentBlt](#cimage__transparentblt)|Works with only Windows 2000, Windows 98, and later systems.|  
|[Draw](#cimage__draw)|Supports transparency with only Windows 2000, Windows 98, and later systems.|  
  
 See                     [CImage Limitations with Earlier Operating Systems](../vs140/cimage-limitations-with-earlier-operating-systems.md) for more detailed information about the limitations on these methods.  
  
 You can use                     <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> from either MFC or ATL.  
  
> [!NOTE]
>  When you create a project using                         <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>, you must define                         <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> before you include                         <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>. If your project uses ATL without MFC, include                         <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> before you include                         <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>. If your project uses MFC (or if it is an ATL project with MFC support), include                         <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> before you include                         <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.  
>   
>  Likewise, you must include                         <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> before you include                         <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>. To accomplish this easily, include                         <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> in your                         <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** atlimage.h  
  
##  \<a name="cimage__alphablend">\</a>  CImage::AlphaBlend  
 Displays bitmaps that have transparent or semitransparent pixels.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 Handle to the destination device context.  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 The x-coordinate, in logical units, of the upper left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 The y-coordinate, in logical units, of the upper left corner of the destination rectangle.  
  
 *bSrcAlpha*  
 An alpha transparency value to be used on the entire source bitmap. The default 0xff (255) assumes that your image is opaque, and that you want to use per-pixel alpha values only.  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
 The alpha-blending function for source and destination bitmaps, a global alpha value to be applied to the entire source bitmap, and format information for the source bitmap. The source and destination blend functions are currently limited to                                 **AC_SRC_OVER**.  
  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 A reference to a                                 [POINT](http://msdn.microsoft.com/library/windows/desktop/dd162805) structure that identifies the upper left corner of the destination rectangle, in logical units.  
  
 <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>  
 The width, in logical units, of the destination rectangle.  
  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 The height, in logical units, of the destination rectangle.  
  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 The logical x-coordinate of the upper left corner of the source rectangle.  
  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 The logical y-coordinate of the upper left corner of the source rectangle.  
  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 The width, in logical units, of the source rectangle.  
  
 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>  
 The height, in logical units, of the source rectangle.  
  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 A reference to a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure, identifying the destination.  
  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 A reference to a                                 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> structure, identifying the source.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 Alpha-blend bitmaps support color blending on a per-pixel basis.  
  
 When                         <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> is set to the default of                         **AC_SRC_OVER**, the source bitmap is placed over the destination bitmap based on the alpha values of the source pixels.  
  
 This method is applicable to Microsoft Windows 2000, Windows 98, and later systems. See                         [AlphaBlend](http://msdn.microsoft.com/library/windows/desktop/dd183351) in the                         [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] and                         [CImage Limitations with Earlier Operating Systems](../vs140/cimage-limitations-with-earlier-operating-systems.md) for more detailed information.  
  
##  \<a name="cimage__attach">\</a>  CImage::Attach  
 Attaches                 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> to a                 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 A handle to an                                 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.  
  
 *eOrientation*  
 Specifies the orientation of the bitmap. Can be one of the following:  
  
-   **DIBOR_DEFAULT** The orientation of the bitmap is determined by the operating system. However, this may not always have the intended results on all operating systems. For more information on this, see the following Knowledge Base article (                                        **Q186586**): PRB: GetObject() Always Returns Positive Height For DIB Sections.  
  
-   **DIBOR_BOTTOMUP** The lines of the bitmap are in reverse order. This causes                                         [CImage::GetBits](#cimage__getbits) to return a pointer near the end of the bitmap buffer and                                         [CImage::GetPitch](#cimage__getpitch) to return a negative number.  
  
-   **DIBOR_TOPDOWN**  The lines of the bitmap are in top to bottom order. This causes                                         [CImage::GetBits](#cimage__getbits) to return a pointer to the first byte of the bitmap buffer and                                         [CImage::GetPitch](#cimage__getpitch) to return a positive number.  
  
### Remarks  
 The bitmap can be either a non-DIB section bitmap or a DIB section bitmap. See                         [IsDIBSection](#cimage__isdibsection) for a list of methods that you can use only with DIB section bitmaps.  
  
##  \<a name="cimage__bitblt">\</a>  CImage::BitBlt  
 Copies a bitmap from the source device context to this current device context.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 The destination                                 **HDC**.  
  
 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>  
 The logical x-coordinate of the upper left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 The logical y-coordinate of the upper left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>  
 The raster operation to be performed. Raster-operation codes define exactly how to combine the bits of the source, the destination, and the pattern (as defined by the currently selected brush) to form the destination. See                                 [BitBlt](http://msdn.microsoft.com/library/windows/desktop/dd183370) in the                                 [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of other raster-operation codes and their descriptions.  
  
 <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 A                                 [POINT](http://msdn.microsoft.com/library/windows/desktop/dd162805) structure indicating the upper left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
 The width, in logical units, of the destination rectangle.  
  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 The height, in logical units, of the destination rectangle.  
  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 The logical x-coordinate of the upper left corner of the source rectangle.  
  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 The logical y-coordinate of the upper left corner of the source rectangle.  
  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 A                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure indicating the destination rectangle.  
  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 A                                 **POINT** structure indicating the upper left corner of the source rectangle.  
  
### Return Value  
 Nonzero if successful; otherwise zero.  
  
### Remarks  
 For more information, see                         [BitBlt](http://msdn.microsoft.com/library/windows/desktop/dd183370) in the                         [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cimage__cimage">\</a>  CImage::CImage  
 Constructs a                 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 Once you have constructed the object, call                         [Create](#cimage__create),                         [Load](#cimage__load),                         [LoadFromResource](#cimage__loadfromresource), or                         [Attach](#cimage__attach) to attach a bitmap to the object.  
  
 **Note** In Visual Studio, this class keeps a count of the number of                         <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> objects created. Whenever the count goes to 0, the function                         [GdiplusShutdown](_gdiplus_func_gdiplusshutdown_) is automatically called to release resources used by GDI+. This ensures that any                         <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> objects created directly or indirectly by DLLs are always destroyed properly and that                         **GdiplusShutdown** is not called from DllMain.  
  
 Using global                         <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> objects in a DLL is not recommended. If you need to use a global                         <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> object in a DLL, call                         [CImage::ReleaseGDIPlus](#cimage__releasegdiplus) to explicitly release resources used by GDI+.  
  
##  \<a name="cimage__create">\</a>  CImage::Create  
 Creates a                 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> bitmap and attach it to the previously constructed                 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 The width of the                                 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> bitmap, in pixels.  
  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
 The height of the                                 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> bitmap, in pixels. If                                 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> is positive, the bitmap is a bottom-up DIB and its origin is the lower left corner. If                                 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> is negative, the bitmap is a top-down DIB and its origin is the upper left corner.  
  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 The numbers of bits per pixel in the bitmap. Usually 4, 8, 16, 24, or 32. Can be 1 for monochrome bitmaps or masks.  
  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 Specifies if the bitmap object has an alpha channel. Can be a combination of zero or more of the following values:  
  
-   **createAlphaChannel** Can only be used if                                         <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> is 32, and                                         <CodeContentPlaceHolder>131\</CodeContentPlaceHolder> is                                         **BI_RGB**. If specified, the created image has an alpha (transparency) value for each pixel, stored in the 4th byte of each pixel (unused in a non-alpha 32-bit image). This alpha channel is automatically used when calling                                         [CImage::AlphaBlend](#cimage__alphablend).  
  
> [!NOTE]
>  In calls to                                     [CImage::Draw](#cimage__draw), images with an alpha channel are automatically alpha blended to the destination.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
##  \<a name="cimage__createex">\</a>  CImage::CreateEx  
 Creates a                 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> bitmap and attach it to the previously constructed                 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 The width of the                                 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> bitmap, in pixels.  
  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
 The height of the                                 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> bitmap, in pixels. If                                 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> is positive, the bitmap is a bottom-up DIB and its origin is the lower left corner. If                                 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> is negative, the bitmap is a top-down DIB and its origin is the upper left corner.  
  
 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 The numbers of bits per pixel in the bitmap. Usually 4, 8, 16, 24, or 32. Can be 1 for monochrome bitmaps or masks.  
  
 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 Specifies the type of compression for a compressed bottom-up bitmap (top-down DIBs cannot be compressed). Can be one of the following values:  
  
-   **BI_RGB** The format is uncompressed. Specifying this value when calling                                         <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> is equivalent to calling                                         <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>.  
  
-   **BI_BITFIELDS** The format is uncompressed and the color table consists of three                                         <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> color masks that specify the red, green, and blue components, respectively, of each pixel. This is valid when used with 16- and 32-bpp bitmaps.  
  
 *pdwBitfields*  
 Only used if                                 <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> is set to                                 **BI_BITFIELDS**, otherwise it must be                                 **NULL**. A pointer to an array of three                                 <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> bitmasks, specifying which bits of each pixel are used for the red, green, and blue components of the color, respectively. For information on restrictions for the bitfields, see                                 [BITMAPINFOHEADER](http://msdn.microsoft.com/library/windows/desktop/dd183376) in the                                 [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>  
 Specifies if the bitmap object has an alpha channel. Can be a combination of zero or more of the following values:  
  
-   **createAlphaChannel** Can only be used if                                         <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> is 32, and                                         <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> is                                         **BI_RGB**. If specified, the created image has an alpha (transparency) value for each pixel, stored in the 4th byte of each pixel (unused in a non-alpha 32-bit image). This alpha channel is automatically used when calling                                         [CImage::AlphaBlend](#cimage__alphablend).  
  
    > [!NOTE]
    >  In calls to                                             [CImage::Draw](#cimage__draw), images with an alpha channel are automatically alpha blended to the destination.  
  
### Return Value  
 **TRUE** if successful. Otherwise                         **FALSE**.  
  
### Example  
 The following example creates a 100x100 pixel bitmap, using 16 bits to encode each pixel. In a given 16-bit pixel, bits 0-3 encode the red component, bits 4-7 encode green, and bits 8-11 encode blue. The remaining 4 bits are unused.  
  
 [!code[NVC_ATLMFC_Utilities#69](../vs140/codesnippet/CPP/cimage-class_3.cpp)]  
  
##  \<a name="cimage__destroy">\</a>  CImage::Destroy  
 Detaches the bitmap from the                 <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> object and destroys the bitmap.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="cimage__detach">\</a>  CImage::Detach  
 Detaches a bitmap from a                 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 A handle to the bitmap detached, or                         **NULL** if no bitmap is attached.  
  
##  \<a name="cimage__draw">\</a>  CImage::Draw  
 Copies a bitmap from the source device context to the current device context.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
 A handle to the destination device context.  
  
 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 The x-coordinate, in logical units, of the upper left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>  
 The y-coordinate, in logical units, of the upper left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>  
 The width, in logical units, of the destination rectangle.  
  
 <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
 The height, in logical units, of the destination rectangle.  
  
 <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
 The x-coordinate, in logical units, of the upper left corner of the source rectangle.  
  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 The y-coordinate, in logical units, of the upper left corner of the source rectangle.  
  
 <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>  
 The width, in logical units, of the source rectangle.  
  
 <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>  
 The height, in logical units, of the source rectangle.  
  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 A reference to a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure, identifying the destination.  
  
 <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>  
 A reference to a                                 <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> structure, identifying the source.  
  
 <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  
 A reference to a                                 [POINT](http://msdn.microsoft.com/library/windows/desktop/dd162805) structure that identifies the upper left corner of the destination rectangle, in logical units.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 **Draw** performs the same operation as                         [StretchBlt](#cimage__stretchblt), unless the image contains a transparent color or alpha channel. In that case,                         **Draw** performs the same operation as either                         [TransparentBlt](#cimage__transparentblt) or                         [AlphaBlend](#cimage__alphablend) as required.  
  
 For versions of                         **Draw** that do not specify a source rectangle, the entire source image is the default. For the version of                         **Draw** that does not specify a size for the destination rectangle, the size of the source image is the default and no stretching or shrinking occurs.  
  
##  \<a name="cimage__getbits">\</a>  CImage::GetBits  
 Retrieves a pointer to the actual bit values of a given pixel in a bitmap.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the bitmap buffer. If the bitmap is a bottom-up DIB, the pointer points near the end of the buffer. If the bitmap is a top-down DIB, the pointer points to the first byte of the buffer.  
  
### Remarks  
 Using this pointer, along with the value returned by                         [GetPitch](#cimage__getpitch), you can locate and change individual pixels in an image.  
  
> [!NOTE]
>  This method supports only DIB section bitmaps; consequently, you access the pixels of a                             <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> object the same way you would the pixels of a DIB section. The returned pointer points to the pixel at the location (0, 0).  
  
##  \<a name="cimage__getbpp">\</a>  CImage::GetBPP  
 Retrieves the bits-per-pixel value.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 The number of bits per pixel.  
  
### Remarks  
 This value determines the number of bits that define each pixel and the maximum number of colors in the bitmap.  
  
 The bits per pixel is usually 1, 4, 8, 16, 24, or 32. See the                         **biBitCount** member of                         [BITMAPINFOHEADER](http://msdn.microsoft.com/library/windows/desktop/dd183376) in the                         [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information about this value.  
  
##  \<a name="cimage__getcolortable">\</a>  CImage::GetColorTable  
 Retrieves red, green, blue (RGB) color values from a range of entries in the palette of the DIB section.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>  
 The color table index of the first entry to retrieve.  
  
 <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>  
 The number of color table entries to retrieve.  
  
 <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>  
 A pointer to the array of                                 [RGBQUAD](http://msdn.microsoft.com/library/windows/desktop/dd162938) structures to retrieve the color table entries.  
  
##  \<a name="cimage__getdc">\</a>  CImage::GetDC  
 Retrieves the device context that currently has the image selected into it.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 A handle to a device context.  
  
### Remarks  
 For each call to                         <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>, you must have a subsequent call to                         [ReleaseDC](#cimage__releasedc).  
  
##  \<a name="cimage__getexporterfilterstring">\</a>  CImage::GetExporterFilterString  
 Finds image formats available for saving images.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 *strExporters*  
 A reference to a                                 **CSimpleString** object. See                                 **Remarks** for more information.  
  
 <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>  
 An array of GUIDs, with each element corresponding to one of the file types in the string. In the example in                                 <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> below,                                 <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>[0] is                                 <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> and the remaining array values are the image file formats supported by the current operating system.  
  
> [!NOTE]
>  For a complete list of constants, see                                     [Image File Format Constants](_gdiplus_constant_image_file_format_constants) in the                                     [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
 If this parameter is not                                 **NULL**, the filter string will have one additional filter at the beginning of the list. This filter will have the current value of                                 <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> for its description, and accepts files of any extension supported by any other exporter in the list.  
  
 For example:  
  
 [!code[NVC_ATLMFC_Utilities#73](../vs140/codesnippet/CPP/cimage-class_4.cpp)]  
  
 <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
 Set of bit flags specifying which file types to exclude from the list. Allowable flags are:  
  
-   **excludeGIF** = 0x01   Excludes GIF files.  
  
-   **excludeBMP** = 0x02   Excludes BMP (Windows Bitmap) files.  
  
-   **excludeEMF** = 0x04   Excludes EMF (Enhanced Metafile) files.  
  
-   **excludeWMF** = 0x08   Excludes WMF (Windows Metafile) files.  
  
-   **excludeJPEG** = 0x10   Excludes JPEG files.  
  
-   **excludePNG** = 0x20   Excludes PNG files.  
  
-   **excludeTIFF** = 0x40   Excludes TIFF files.  
  
-   **excludeIcon** = 0x80   Excludes ICO (Windows Icon) files.  
  
-   **excludeOther** = 0x80000000   Excludes any other file type not listed above.  
  
-   **excludeDefaultLoad** = 0   For load, all file types are included by default  
  
-   **excludeDefaultSave** =                                         **excludeIcon &#124; excludeEMF &#124; excludeWMF** For saving, these files are excluded by default because they usually have special requirements.  
  
 <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
 The separator used between the image formats. See                                 **Remarks** for more information.  
  
### Return Value  
 A standard                         <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>.  
  
### Remarks  
 You can pass the resulting format string to your MFC                         [CFileDialog](../vs140/cfiledialog-class.md) object to expose the file extensions of the available image formats in the File Save As dialog box.  
  
 The parameter                         *strExporter* has the format:  
  
 file description0&#124;\*.ext0&#124;filedescription1&#124;\*.ext1&#124;...file description                        *n*&#124;\*.ext                        *n*&#124;&#124;  
  
 where '&#124;' is the separator character specified by                         <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>. For example:  
  
 <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
  
 Use the default separator '&#124;' if you pass this string to an MFC                         <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> object. Use the null separator '\0' if you pass this string to a common File Save dialog box.  
  
##  \<a name="cimage__getheight">\</a>  CImage::GetHeight  
 Retrieves the height, in pixels, of an image.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 The height, in pixels, of an image.  
  
##  \<a name="cimage__getimporterfilterstring">\</a>  CImage::GetImporterFilterString  
 Finds image formats available for loading images.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 *strImporters*  
 A reference to a                                 **CSimpleString** object. See                                 **Remarks** for more information.  
  
 <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
 An array of GUIDs, with each element corresponding to one of the file types in the string. In the example in                                 <CodeContentPlaceHolder>183\</CodeContentPlaceHolder> below,                                 <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>[0] is                                 <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> with the remaining array values are the image file formats supported by the current operating system.  
  
> [!NOTE]
>  For a complete list of constants, see                                     [Image File Format Constants](_gdiplus_constant_image_file_format_constants) in the                                     [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>  
 If this parameter is not                                 **NULL**, the filter string will have one additional filter at the beginning of the list. This filter will have the current value of                                 <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> for its description, and accepts files of any extension supported by any other exporter in the list.  
  
 For example:  
  
 [!code[NVC_ATLMFC_Utilities#74](../vs140/codesnippet/CPP/cimage-class_5.cpp)]  
  
 <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  
 Set of bit flags specifying which file types to exclude from the list. Allowable flags are:  
  
-   **excludeGIF** = 0x01   Excludes GIF files.  
  
-   **excludeBMP** = 0x02   Excludes BMP (Windows Bitmap) files.  
  
-   **excludeEMF** = 0x04   Excludes EMF (Enhanced Metafile) files.  
  
-   **excludeWMF** = 0x08   Excludes WMF (Windows Metafile) files.  
  
-   **excludeJPEG** = 0x10   Excludes JPEG files.  
  
-   **excludePNG** = 0x20   Excludes PNG files.  
  
-   **excludeTIFF** = 0x40   Excludes TIFF files.  
  
-   **excludeIcon** = 0x80   Excludes ICO (Windows Icon) files.  
  
-   **excludeOther** = 0x80000000   Excludes any other file type not listed above.  
  
-   **excludeDefaultLoad** = 0   For load, all file types are included by default  
  
-   **excludeDefaultSave** =                                         **excludeIcon &#124; excludeEMF &#124; excludeWMF** For saving, these files are excluded by default because they usually have special requirements.  
  
 <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  
 The separator used between the image formats. See                                 **Remarks** for more information.  
  
### Remarks  
 You can pass the resulting format string to your MFC                         [CFileDialog](../vs140/cfiledialog-class.md) object to expose the file extensions of the available image formats in the                         **File Open** dialog box.  
  
 The parameter                         *strImporter* has the format:  
  
 file description0&#124;\*.ext0&#124;filedescription1&#124;\*.ext1&#124;...file description                        *n*&#124;\*.ext                        *n*&#124;&#124;  
  
 where '&#124;' is the separator character specified by                         <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>. For example:  
  
 <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
  
 Use the default separator '&#124;' if you pass this string to an MFC                         <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> object. Use the null separator '\0' if you pass this string to a common                         **File Open** dialog box.  
  
##  \<a name="cimage__getmaxcolortableentries">\</a>  CImage::GetMaxColorTableEntries  
 Retrieves the maximum number of entries in the color table.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 The number of entries in the color table.  
  
### Remarks  
 This method supports only DIB section bitmaps.  
  
##  \<a name="cimage__getpitch">\</a>  CImage::GetPitch  
 Retrieves the pitch of an image.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 The pitch of the image. If the return value is negative, the bitmap is a bottom-up DIB and its origin is the lower left corner. If the return value is positive, the bitmap is a top-down DIB and its origin is the upper left corner.  
  
### Remarks  
 The pitch is the distance, in bytes, between two memory addresses that represent the beginning of one bitmap line and the beginning of the next bitmap line. Because pitch is measured in bytes, the pitch of an image helps you to determine the pixel format. The pitch can also include additional memory, reserved for the bitmap.  
  
 Use                         <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> with                         [GetBits](#cimage__getbits) to find individual pixels of an image.  
  
> [!NOTE]
>  This method supports only DIB section bitmaps.  
  
##  \<a name="cimage__getpixel">\</a>  CImage::GetPixel  
 Retrieves the color of the pixel at the location specified by                 *x* and                 *y*.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 The x-coordinate of the pixel.  
  
 *y*  
 The y-coordinate of the pixel.  
  
### Return Value  
 The red, green, blue (RGB) value of the pixel. If the pixel is outside of the current clipping region, the return value is                         **CLR_INVALID**.  
  
##  \<a name="cimage__getpixeladdress">\</a>  CImage::GetPixelAddress  
 Retrieves the exact address of a pixel.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 The x-coordinate of the pixel.  
  
 *y*  
 The y-coordinate of the pixel.  
  
### Remarks  
 The address is determined according to the coordinates of a pixel, the pitch of the bitmap, and the bits per pixel.  
  
 For formats that have less than 8 bits per pixel, this method returns the address of the byte containing the pixel. For example, if your image format has 4 bits per pixel,                         <CodeContentPlaceHolder>194\</CodeContentPlaceHolder> returns the address of the first pixel in the byte, and you must calculate for 2 pixels per byte.  
  
> [!NOTE]
>  This method supports only DIB section bitmaps.  
  
##  \<a name="cimage__gettransparentcolor">\</a>  CImage::GetTransparentColor  
 Retrieves the indexed location of the transparent color in the color palette.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 The index of the transparent color.  
  
##  \<a name="cimage__getwidth">\</a>  CImage::GetWidth  
 Retrieves the width, in pixels, of an image.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 The width of the bitmap, in pixels.  
  
##  \<a name="cimage__isdibsection">\</a>  CImage::IsDIBSection  
 Determines if the attached bitmap is a DIB section.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 **true** if the attached bitmap is a DIB section. Otherwise                         **false**.  
  
### Remarks  
 If the bitmap is not a DIB section, you cannot use the following                         <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> methods, which support only DIB section bitmaps:  
  
-   [GetBits](#cimage__getbits)  
  
-   [GetColorTable](#cimage__getcolortable)  
  
-   [GetMaxColorTableEntries](#cimage__getmaxcolortableentries)  
  
-   [GetPitch](#cimage__getpitch)  
  
-   [GetPixelAddress](#cimage__getpixeladdress)  
  
-   [IsIndexed](#cimage__isindexed)  
  
-   [SetColorTable](#cimage__setcolortable)  
  
##  \<a name="cimage__isindexed">\</a>  CImage::IsIndexed  
 Determines whether a bitmap's pixels are mapped to a color palette.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
 **true** if indexed; otherwise                         **false**.  
  
### Remarks  
 This method returns                         **true** only if the bitmap is 8-bit (256 colors) or less.  
  
> [!NOTE]
>  This method supports only DIB section bitmaps.  
  
##  \<a name="cimage__isnull">\</a>  CImage::IsNull  
 Determines if a bitmap is currently loaded.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Remarks  
 This method returns                         **True** if a bitmap is not currently loaded; otherwise                         **False**.  
  
##  \<a name="cimage__istransparencysupported">\</a>  CImage::IsTransparencySupported  
 Indicates whether the application supports transparent bitmaps and was compiled for Windows 2000 or later.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the current platform supports transparency. Otherwise 0.  
  
### Remarks  
 If the return value is nonzero, and transparency is supported, a call to                         [AlphaBlend](#cimage__alphablend),                         [TransparentBlt](#cimage__transparentblt), or                         [Draw](#cimage__draw) will handle transparent colors.  
  
 If the application is compiled for use with operating systems before Windows 2000 or Windows 98, this method will always return 0, even on newer operating systems.  
  
 See                         [CImage Limitations with Earlier Operating Systems](../vs140/cimage-limitations-with-earlier-operating-systems.md) for more detailed information.  
  
##  \<a name="cimage__load">\</a>  CImage::Load  
 Loads an image.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>  
 A pointer to a string containing the name of the image file to load.  
  
 <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
 A pointer to a stream containing the name of the image file to load.  
  
### Return Value  
 A standard                         <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>.  
  
### Remarks  
 Loads the image specified by                         *pszFileName* or                         <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>.  
  
 Valid image types are BMP, GIF, JPEG, PNG, and TIFF.  
  
##  \<a name="cimage__loadfromresource">\</a>  CImage::LoadFromResource  
 Loads an image from a                 <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> resource.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>  
 Handle to an instance of the module that contains the image to be loaded.  
  
 <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>  
 A pointer to the string containing the name of the resource containing the image to load.  
  
 <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>  
 The ID of the resource to load.  
  
### Remarks  
 The resource must be of type                         <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>.  
  
##  \<a name="cimage__maskblt">\</a>  CImage::MaskBlt  
 Combines the color data for the source and destination bitmaps using the specified mask and raster operation.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>  
 The handle to the module whose executable contains the resource.  
  
 <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>  
 The x-coordinate, in logical units, of the upper left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>207\</CodeContentPlaceHolder>  
 The y-coordinate, in logical units, of the upper left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>  
 The width, in logical units, of the destination rectangle and source bitmap.  
  
 <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>  
 The height, in logical units, of the destination rectangle and source bitmap.  
  
 <CodeContentPlaceHolder>210\</CodeContentPlaceHolder>  
 The logical x-coordinate of the upper left corner of the source bitmap.  
  
 <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>  
 The logical y-coordinate of the upper left corner of the source bitmap.  
  
 <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>  
 Handle to the monochrome mask bitmap combined with the color bitmap in the source device context.  
  
 <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>  
 The horizontal pixel offset for the mask bitmap specified by the                                 <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>  
 The vertical pixel offset for the mask bitmap specified by the                                 <CodeContentPlaceHolder>216\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>  
 Specifies both foreground and background ternary raster operation codes that the method uses to control the combination of source and destination data. The background raster operation code is stored in the high-order byte of the high-order word of this value; the foreground raster operation code is stored in the low-order byte of the high-order word of this value; the low-order word of this value is ignored, and should be zero. For a discussion of foreground and background in the context of this method, see                                 <CodeContentPlaceHolder>218\</CodeContentPlaceHolder> in the                                 [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For a list of common raster operation codes, see                                 <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> in the                                 [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>220\</CodeContentPlaceHolder>  
 A reference to a                                 <CodeContentPlaceHolder>221\</CodeContentPlaceHolder> structure, identifying the destination.  
  
 <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>  
 A                                 <CodeContentPlaceHolder>223\</CodeContentPlaceHolder> structure indicating the upper left corner of the source rectangle.  
  
 <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>  
 A                                 **POINT** structure indicating the upper left corner of the mask bitmap.  
  
 <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>  
 A reference to a                                 **POINT** structure that identifies the upper left corner of the destination rectangle, in logical units.  
  
### Return Value  
 Nonzero if successful, otherwise 0.  
  
### Remarks  
 This method applies to Windows NT, versions 4.0 and later only.  
  
 See                         <CodeContentPlaceHolder>226\</CodeContentPlaceHolder> in the                         [!INCLUDE[winsdkshort](../vs140/includes/winsdkshort_md.md)] and                         [CImage Limitations with Earlier Operating Systems](../vs140/cimage-limitations-with-earlier-operating-systems.md) for more detailed information.  
  
##  \<a name="cimage__operator_hbitmap">\</a>  CImage::operator HBITMAP  
 Use this operator to get the attached Windows GDI handle of the                 <CodeContentPlaceHolder>227\</CodeContentPlaceHolder> object. This operator is a casting operator, which supports direct use of an                 <CodeContentPlaceHolder>228\</CodeContentPlaceHolder> object.  
  
##  \<a name="cimage__plgblt">\</a>  CImage::PlgBlt  
 Performs a bit-block transfer from a rectangle in a source device context into a parallelogram in a destination device context.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>  
 A handle to the destination device context.  
  
 *pPoints*  
 A pointer to an array of three points in logical space that identify three corners of the destination parallelogram. The upper left corner of the source rectangle is mapped to the first point in this array, the upper-right corner to the second point in this array, and the lower left corner to the third point. The lower-right corner of the source rectangle is mapped to the implicit fourth point in the parallelogram.  
  
 <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>  
 A handle to an optional monochrome bitmap that is used to mask the colors of the source rectangle.  
  
 <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>  
 The x-coordinate, in logical units, of the upper left corner of the source rectangle.  
  
 <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>  
 The y-coordinate, in logical units, of the upper left corner of the source rectangle.  
  
 <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>  
 The width, in logical units, of the source rectangle.  
  
 <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>  
 The height, in logical units, of the source rectangle.  
  
 <CodeContentPlaceHolder>235\</CodeContentPlaceHolder>  
 The x-coordinate of the upper left corner of the monochrome bitmap.  
  
 <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>  
 The y-coordinate of the upper left corner of the monochrome bitmap.  
  
 <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>  
 A reference to a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure specifying the coordinates of the source rectangle.  
  
 <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>  
 A                                 [POINT](http://msdn.microsoft.com/library/windows/desktop/dd162805) structure indicating the upper left corner of the mask bitmap.  
  
### Return Value  
 Nonzero if successful, otherwise 0.  
  
### Remarks  
 If                         <CodeContentPlaceHolder>239\</CodeContentPlaceHolder> identifies a valid monochrome bitmap,                         **PlgBit** uses this bitmap to mask the bits of color data from the source rectangle.  
  
 This method applies to Windows NT, versions 4.0 and later only. See                         [PlgBlt](http://msdn.microsoft.com/library/windows/desktop/dd162804) in the                         [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] and                         [CImage Limitations with Earlier Operating Systems](../vs140/cimage-limitations-with-earlier-operating-systems.md) for more detailed information.  
  
##  \<a name="cimage__releasedc">\</a>  CImage::ReleaseDC  
 Releases the device context.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Remarks  
 Because only one bitmap can be selected into a device context at a time, you must call                         <CodeContentPlaceHolder>240\</CodeContentPlaceHolder> for each call to                         [GetDC](#cimage__getdc).  
  
##  \<a name="cimage__releasegdiplus">\</a>  CImage::ReleaseGDIPlus  
 Releases resources used by GDI+.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Remarks  
 This method must be called to free resources allocated by a global                         <CodeContentPlaceHolder>241\</CodeContentPlaceHolder> object. See                         [CImage::CImage](#cimage__cimage).  
  
##  \<a name="cimage__save">\</a>  CImage::Save  
 Saves an image to the specified stream or file on disk.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>242\</CodeContentPlaceHolder>  
 A pointer to a COM IStream object containing the file image data.  
  
 *pszFileName*  
 A pointer to the file name for the image.  
  
 <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>  
 The file type to save the image as. Can be one of the following:  
  
-   **ImageFormatBMP** An uncompressed bitmap image.  
  
-   **ImageFormatPNG** A Portable Network Graphic (PNG) compressed image.  
  
-   **ImageFormatJPEG** A JPEG compressed image.  
  
-   **ImageFormatGIF** A GIF compressed image.  
  
> [!NOTE]
>  For a complete list of constants, see                                     [Image File Format Constants](_gdiplus_constant_image_file_format_constants) in the                                     [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 A standard                         <CodeContentPlaceHolder>244\</CodeContentPlaceHolder>.  
  
### Remarks  
 Call this function to save the image using a specified name and type. If the                         <CodeContentPlaceHolder>245\</CodeContentPlaceHolder> parameter is not included, the file name's file extension will be used to determine the image format. If no extension is provided, the image will be saved in BMP format.  
  
##  \<a name="cimage__setcolortable">\</a>  CImage::SetColorTable  
 Sets the red, green, blue (RGB) color values for a range of entries in the palette of the DIB section.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>246\</CodeContentPlaceHolder>  
 The color table index of the first entry to set.  
  
 <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>  
 The number of color table entries to set.  
  
 <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>  
 A pointer to the array of                                 [RGBQUAD](http://msdn.microsoft.com/library/windows/desktop/dd162938) structures to set the color table entries.  
  
### Remarks  
 This method supports only DIB section bitmaps.  
  
##  \<a name="cimage__setpixel">\</a>  CImage::SetPixel  
 Sets the color of a pixel at a given location in the bitmap.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 The horizontal location of the pixel to set.  
  
 *y*  
 The vertical location of the pixel to set.  
  
 <CodeContentPlaceHolder>249\</CodeContentPlaceHolder>  
 The color to which you set the pixel.  
  
### Remarks  
 This method fails if the pixel coordinates lie outside of the selected clipping region.  
  
##  \<a name="cimage__setpixelindexed">\</a>  CImage::SetPixelIndexed  
 Sets the pixel color to the color located at                 <CodeContentPlaceHolder>250\</CodeContentPlaceHolder> in the color palette.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 The horizontal location of the pixel to set.  
  
 *y*  
 The vertical location of the pixel to set.  
  
 <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>  
 The index of a color in the color palette.  
  
##  \<a name="cimage__setpixelrgb">\</a>  CImage::SetPixelRGB  
 Sets the pixel at the locations specified by                 *x* and                 *y* to the colors indicated by                 *r*,                 *g*, and                 *b*, in a red, green, blue (RGB) image.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 The horizontal location of the pixel to set.  
  
 *y*  
 The vertical location of the pixel to set.  
  
 *r*  
 The intensity of the red color.  
  
 *g*  
 The intensity of the green color.  
  
 *b*  
 The intensity of the blue color.  
  
### Remarks  
 The red, green, and blue parameters are each represented by a number between 0 and 255. If you set all three parameters to zero, the combined resulting color is black. If you set all three parameters to 255, the combined resulting color is white.  
  
##  \<a name="cimage__settransparentcolor">\</a>  CImage::SetTransparentColor  
 Sets a color at a given indexed location as transparent.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 *iTransparentColor*  
 The index, in a color palette, of the color to set to transparent. If –1, no color is set to transparent.  
  
### Return Value  
 The index of the color previously set as transparent.  
  
##  \<a name="cimage__stretchblt">\</a>  CImage::StretchBlt  
 Copies a bitmap from the source device context to this current device context.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>252\</CodeContentPlaceHolder>  
 A handle to the destination device context.  
  
 <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>  
 The x-coordinate, in logical units, of the upper left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>254\</CodeContentPlaceHolder>  
 The y-coordinate, in logical units, of the upper left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>255\</CodeContentPlaceHolder>  
 The width, in logical units, of the destination rectangle.  
  
 <CodeContentPlaceHolder>256\</CodeContentPlaceHolder>  
 The height, in logical units, of the destination rectangle.  
  
 <CodeContentPlaceHolder>257\</CodeContentPlaceHolder>  
 The raster operation to be performed. Raster-operation codes define exactly how to combine the bits of the source, the destination, and the pattern (as defined by the currently selected brush) to form the destination. See                                 [BitBlt](http://msdn.microsoft.com/library/windows/desktop/dd183370) in the                                 [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of other raster-operation codes and their descriptions.  
  
 <CodeContentPlaceHolder>258\</CodeContentPlaceHolder>  
 A reference to a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure, identifying the destination.  
  
 <CodeContentPlaceHolder>259\</CodeContentPlaceHolder>  
 The x-coordinate, in logical units, of the upper left corner of the source rectangle.  
  
 <CodeContentPlaceHolder>260\</CodeContentPlaceHolder>  
 The y-coordinate, in logical units, of the upper left corner of the source rectangle.  
  
 <CodeContentPlaceHolder>261\</CodeContentPlaceHolder>  
 The width, in logical units, of the source rectangle.  
  
 <CodeContentPlaceHolder>262\</CodeContentPlaceHolder>  
 The height, in logical units, of the source rectangle.  
  
 <CodeContentPlaceHolder>263\</CodeContentPlaceHolder>  
 A reference to a                                 <CodeContentPlaceHolder>264\</CodeContentPlaceHolder> structure, identifying the source.  
  
### Return Value  
 Nonzero if successful, otherwise 0.  
  
### Remarks  
 For more information, see                         [StretchBlt](http://msdn.microsoft.com/library/windows/desktop/dd145120) in the                         [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cimage__transparentblt">\</a>  CImage::TransparentBlt  
 Copies a bitmap from the source device context to this current device context.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>265\</CodeContentPlaceHolder>  
 A handle to the destination device context.  
  
 <CodeContentPlaceHolder>266\</CodeContentPlaceHolder>  
 The x-coordinate, in logical units, of the upper left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>267\</CodeContentPlaceHolder>  
 The y-coordinate, in logical units, of the upper left corner of the destination rectangle.  
  
 <CodeContentPlaceHolder>268\</CodeContentPlaceHolder>  
 The width, in logical units, of the destination rectangle.  
  
 <CodeContentPlaceHolder>269\</CodeContentPlaceHolder>  
 The height, in logical units, of the destination rectangle.  
  
 *crTransparent*  
 The color in the source bitmap to treat as transparent. By default,                                 **CLR_INVALID**, indicating that the color currently set as the transparent color of the image should be used.  
  
 <CodeContentPlaceHolder>270\</CodeContentPlaceHolder>  
 A reference to a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure, identifying the destination.  
  
 <CodeContentPlaceHolder>271\</CodeContentPlaceHolder>  
 The x-coordinate, in logical units, of the upper left corner of the source rectangle.  
  
 <CodeContentPlaceHolder>272\</CodeContentPlaceHolder>  
 The y-coordinate, in logical units, of the upper left corner of the source rectangle.  
  
 <CodeContentPlaceHolder>273\</CodeContentPlaceHolder>  
 The width, in logical units, of the source rectangle.  
  
 <CodeContentPlaceHolder>274\</CodeContentPlaceHolder>  
 The height, in logical units, of the source rectangle.  
  
 <CodeContentPlaceHolder>275\</CodeContentPlaceHolder>  
 A reference to a                                 <CodeContentPlaceHolder>276\</CodeContentPlaceHolder> structure, identifying the source.  
  
### Return Value  
 **TRUE** if successful, otherwise                         **FALSE**.  
  
### Remarks  
 <CodeContentPlaceHolder>277\</CodeContentPlaceHolder> is supported for source bitmaps of 4 bits per pixel and 8 bits per pixel. Use                         [CImage::AlphaBlend](#cimage__alphablend) to specify 32 bits-per-pixel bitmaps with transparency.  
  
 This method is applicable to Microsoft Windows 2000, Windows 98, and later systems. See                         [TransparentBlt](http://msdn.microsoft.com/library/windows/desktop/dd145141) in the                         [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] and                         [CImage Limitations with Earlier Operating Systems](../vs140/cimage-limitations-with-earlier-operating-systems.md) for more detailed information.  
  
### Example  
 [!code[NVC_ATLMFC_Utilities#199](../vs140/codesnippet/CPP/cimage-class_6.cpp)]  
  
## See Also  
 [MMXSwarm Sample](../vs140/visual-c---samples.md)   
 [SimpleImage Sample](../vs140/visual-c---samples.md)   
 [Device-Independent Bitmaps](http://msdn.microsoft.com/library/windows/desktop/dd183562)   
 [CreateDIBSection](http://msdn.microsoft.com/library/windows/desktop/dd183494)   
 [ATL Reference](../vs140/atl-com-desktop-components.md)