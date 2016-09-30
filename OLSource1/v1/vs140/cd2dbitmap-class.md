---
title: "CD2DBitmap Class"
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
  - "afxrendertarget/CD2DBitmap"
  - "CD2DBitmap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DBitmap class"
ms.assetid: 2b3686f1-812c-462b-b449-9f0cb6949bf6
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DBitmap Class
A wrapper for ID2D1Bitmap.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DBitmap::CD2DBitmap](#cd2dbitmap__cd2dbitmap)|Overloaded. Constructs a CD2DBitmap object from HBITMAP.|  
|[CD2DBitmap::~CD2DBitmap](#cd2dbitmap___dtorcd2dbitmap)|The destructor. Called when a D2D bitmap object is being destroyed.|  
  
### Protected Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DBitmap::CD2DBitmap](#cd2dbitmap__cd2dbitmap)|Overloaded. Constructs a CD2DBitmap object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DBitmap::Attach](#cd2dbitmap__attach)|Attaches existing resource interface to the object|  
|[CD2DBitmap::CopyFromBitmap](#cd2dbitmap__copyfrombitmap)|Copies the specified region from the specified bitmap into the current bitmap|  
|[CD2DBitmap::CopyFromMemory](#cd2dbitmap__copyfrommemory)|Copies the specified region from memory into the current bitmap|  
|[CD2DBitmap::CopyFromRenderTarget](#cd2dbitmap__copyfromrendertarget)|Copies the specified region from the specified render target into the current bitmap|  
|[CD2DBitmap::Create](#cd2dbitmap__create)|Creates a CD2DBitmap. (Overrides [CD2DResource::Create](../vs140/cd2dresource-class.md#cd2dresource__create).)|  
|[CD2DBitmap::Destroy](#cd2dbitmap__destroy)|Destroys a CD2DBitmap object. (Overrides [CD2DResource::Destroy](../vs140/cd2dresource-class.md#cd2dresource__destroy).)|  
|[CD2DBitmap::Detach](#cd2dbitmap__detach)|Detaches resource interface from the object|  
|[CD2DBitmap::Get](#cd2dbitmap__get)|Returns ID2D1Bitmap interface|  
|[CD2DBitmap::GetDPI](#cd2dbitmap__getdpi)|Return the dots per inch (DPI) of the bitmap|  
|[CD2DBitmap::GetPixelFormat](#cd2dbitmap__getpixelformat)|Retrieves the pixel format and alpha mode of the bitmap|  
|[CD2DBitmap::GetPixelSize](#cd2dbitmap__getpixelsize)|Returns the size, in device-dependent units (pixels), of the bitmap|  
|[CD2DBitmap::GetSize](#cd2dbitmap__getsize)|Returns the size, in device-independent pixels (DIPs), of the bitmap|  
|[CD2DBitmap::IsValid](#cd2dbitmap__isvalid)|Checks resource validity (Overrides [CD2DResource::IsValid](../vs140/cd2dresource-class.md#cd2dresource__isvalid).)|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DBitmap::CommonInit](#cd2dbitmap__commoninit)|Initializes the object|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DBitmap::operator ID2D1Bitmap*](#cd2dbitmap__operator_id2d1bitmap_star)|Returns ID2D1Bitmap interface|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DBitmap::m_bAutoDestroyHBMP](#cd2dbitmap__m_bautodestroyhbmp)|TRUE if m_hBmpSrc should be destroyed; otherwise FALSE.|  
|[CD2DBitmap::m_hBmpSrc](#cd2dbitmap__m_hbmpsrc)|Source bitmap handle.|  
|[CD2DBitmap::m_lpszType](#cd2dbitmap__m_lpsztype)|Resource type.|  
|[CD2DBitmap::m_pBitmap](#cd2dbitmap__m_pbitmap)|Stores a pointer to an ID2D1Bitmap object.|  
|[CD2DBitmap::m_sizeDest](#cd2dbitmap__m_sizedest)|Bitmap destination size.|  
|[CD2DBitmap::m_strPath](#cd2dbitmap__m_strpath)|Botmap file path.|  
|[CD2DBitmap::m_uiResID](#cd2dbitmap__m_uiresid)|Bitmap resource ID.|  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CD2DResource](../vs140/cd2dresource-class.md)  
  
 [CD2DBitmap](../vs140/cd2dbitmap-class.md)  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
##  \<a name="cd2dbitmap___dtorcd2dbitmap">\</a>  CD2DBitmap::~CD2DBitmap  
 The destructor. Called when a D2D bitmap object is being destroyed.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cd2dbitmap__attach">\</a>  CD2DBitmap::Attach  
 Attaches existing resource interface to the object  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Existing resource interface. Cannot be NULL  
  
##  \<a name="cd2dbitmap__cd2dbitmap">\</a>  CD2DBitmap::CD2DBitmap  
 Constructs a CD2DBitmap object from resource.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 A pointer to the render target.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 The resource ID number of the resource.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string that contains the resource type.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Destination size of the bitmap.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Indicates that the object will be destroyed by owner (pParentTarget).  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string that contains the name of file.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Handle to the bitmap.  
  
##  \<a name="cd2dbitmap__commoninit">\</a>  CD2DBitmap::CommonInit  
 Initializes the object  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="cd2dbitmap__copyfrombitmap">\</a>  CD2DBitmap::CopyFromBitmap  
 Copies the specified region from the specified bitmap into the current bitmap  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The bitmap to copy from  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 In the current bitmap, the upper-left corner of the area to which the region specified by srcRect is copied  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The area of bitmap to copy  
  
### Return Value  
 If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.  
  
##  \<a name="cd2dbitmap__copyfrommemory">\</a>  CD2DBitmap::CopyFromMemory  
 Copies the specified region from memory into the current bitmap  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The data to copy  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The stride, or pitch, of the source bitmap stored in srcData. The stride is the byte count of a scanline (one row of pixels in memory). The stride can be computed from the following formula: pixel width * bytes per pixel + memory padding  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 In the current bitmap, the upper-left corner of the area to which the region specified by srcRect is copied  
  
### Return Value  
 If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.  
  
##  \<a name="cd2dbitmap__copyfromrendertarget">\</a>  CD2DBitmap::CopyFromRenderTarget  
 Copies the specified region from the specified render target into the current bitmap  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The render target that contains the region to copy  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 In the current bitmap, the upper-left corner of the area to which the region specified by srcRect is copied  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The area of renderTarget to copy  
  
### Return Value  
 If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.  
  
##  \<a name="cd2dbitmap__create">\</a>  CD2DBitmap::Create  
 Creates a CD2DBitmap.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 A pointer to the render target.  
  
### Return Value  
 If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.  
  
##  \<a name="cd2dbitmap__destroy">\</a>  CD2DBitmap::Destroy  
 Destroys a CD2DBitmap object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="cd2dbitmap__detach">\</a>  CD2DBitmap::Detach  
 Detaches resource interface from the object  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to detached resource interface.  
  
##  \<a name="cd2dbitmap__get">\</a>  CD2DBitmap::Get  
 Returns ID2D1Bitmap interface  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to an ID2D1Bitmap interface or NULL if object is not initialized yet.  
  
##  \<a name="cd2dbitmap__getdpi">\</a>  CD2DBitmap::GetDPI  
 Return the dots per inch (DPI) of the bitmap  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 The horizontal and vertical DPI of the bitmap.  
  
##  \<a name="cd2dbitmap__getpixelformat">\</a>  CD2DBitmap::GetPixelFormat  
 Retrieves the pixel format and alpha mode of the bitmap  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 The pixel format and alpha mode of the bitmap.  
  
##  \<a name="cd2dbitmap__getpixelsize">\</a>  CD2DBitmap::GetPixelSize  
 Returns the size, in device-dependent units (pixels), of the bitmap  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 The size, in pixels, of the bitmap..  
  
##  \<a name="cd2dbitmap__getsize">\</a>  CD2DBitmap::GetSize  
 Returns the size, in device-independent pixels (DIPs), of the bitmap  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 The size, in DIPs, of the bitmap.  
  
##  \<a name="cd2dbitmap__isvalid">\</a>  CD2DBitmap::IsValid  
 Checks resource validity  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 TRUE if resource is valid; otherwise FALSE.  
  
##  \<a name="cd2dbitmap__m_bautodestroyhbmp">\</a>  CD2DBitmap::m_bAutoDestroyHBMP  
 TRUE if m_hBmpSrc should be destroyed; otherwise FALSE.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
##  \<a name="cd2dbitmap__m_hbmpsrc">\</a>  CD2DBitmap::m_hBmpSrc  
 Source bitmap handle.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
##  \<a name="cd2dbitmap__m_lpsztype">\</a>  CD2DBitmap::m_lpszType  
 Resource type.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
##  \<a name="cd2dbitmap__m_pbitmap">\</a>  CD2DBitmap::m_pBitmap  
 Stores a pointer to an ID2D1Bitmap object.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
##  \<a name="cd2dbitmap__m_sizedest">\</a>  CD2DBitmap::m_sizeDest  
 Bitmap destination size.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
##  \<a name="cd2dbitmap__m_strpath">\</a>  CD2DBitmap::m_strPath  
 Botmap file path.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
##  \<a name="cd2dbitmap__m_uiresid">\</a>  CD2DBitmap::m_uiResID  
 Bitmap resource ID.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
##  \<a name="cd2dbitmap__operator_id2d1bitmap_star">\</a>  CD2DBitmap::operator ID2D1Bitmap*  
 Returns ID2D1Bitmap interface  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to an ID2D1Bitmap interface or NULL if object is not initialized yet.  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)