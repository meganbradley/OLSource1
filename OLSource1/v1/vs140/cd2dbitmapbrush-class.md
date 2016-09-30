---
title: "CD2DBitmapBrush Class"
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
  - "CD2DBitmapBrush"
  - "afxrendertarget/CD2DBitmapBrush"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DBitmapBrush class"
ms.assetid: 46ebbe34-66e0-44c8-af1d-d129e851de5e
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DBitmapBrush Class
A wrapper for ID2D1BitmapBrush.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DBitmapBrush::CD2DBitmapBrush](#cd2dbitmapbrush__cd2dbitmapbrush)|Overloaded. Constructs a CD2DBitmapBrush object from file.|  
|[CD2DBitmapBrush::~CD2DBitmapBrush](#cd2dbitmapbrush__dtorcd2dbitmapbrush)|The destructor. Called when a D2D bitmap brush object is being destroyed.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DBitmapBrush::Attach](#cd2dbitmapbrush__attach)|Attaches existing resource interface to the object|  
|[CD2DBitmapBrush::Create](#cd2dbitmapbrush__create)|Creates a CD2DBitmapBrush. (Overrides [CD2DResource::Create](../vs140/cd2dresource-class.md#cd2dresource__create).)|  
|[CD2DBitmapBrush::Destroy](#cd2dbitmapbrush__destroy)|Destroys a CD2DBitmapBrush object. (Overrides [CD2DBrush::Destroy](../vs140/cd2dbrush-class.md#cd2dbrush__destroy).)|  
|[CD2DBitmapBrush::Detach](#cd2dbitmapbrush__detach)|Detaches resource interface from the object|  
|[CD2DBitmapBrush::Get](#cd2dbitmapbrush__get)|Returns ID2D1BitmapBrush interface|  
|[CD2DBitmapBrush::GetBitmap](#cd2dbitmapbrush__getbitmap)|Gets the bitmap source that this brush uses to paint|  
|[CD2DBitmapBrush::GetExtendModeX](#cd2dbitmapbrush__getextendmodex)|Gets the method by which the brush horizontally tiles those areas that extend past its bitmap|  
|[CD2DBitmapBrush::GetExtendModeY](#cd2dbitmapbrush__getextendmodey)|Gets the method by which the brush vertically tiles those areas that extend past its bitmap|  
|[CD2DBitmapBrush::GetInterpolationMode](#cd2dbitmapbrush__getinterpolationmode)|Gets the interpolation method used when the brush bitmap is scaled or rotated|  
|[CD2DBitmapBrush::SetBitmap](#cd2dbitmapbrush__setbitmap)|Specifies the bitmap source that this brush uses to paint|  
|[CD2DBitmapBrush::SetExtendModeX](#cd2dbitmapbrush__setextendmodex)|Specifies how the brush horizontally tiles those areas that extend past its bitmap|  
|[CD2DBitmapBrush::SetExtendModeY](#cd2dbitmapbrush__setextendmodey)|Specifies how the brush vertically tiles those areas that extend past its bitmap|  
|[CD2DBitmapBrush::SetInterpolationMode](#cd2dbitmapbrush__setinterpolationmode)|Specifies the interpolation mode used when the brush bitmap is scaled or rotated|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DBitmapBrush::CommonInit](#cd2dbitmapbrush__commoninit)|Initializes the object|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DBitmapBrush::operator ID2D1BitmapBrush*](#cd2dbitmapbrush__operator_id2d1bitmapbrush_star)|Returns ID2D1BitmapBrush interface|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DBitmapBrush::m_pBitmap](#cd2dbitmapbrush__m_pbitmap)|Stores a pointer to a CD2DBitmap object.|  
|[CD2DBitmapBrush::m_pBitmapBrush](#cd2dbitmapbrush__m_pbitmapbrush)|Stores a pointer to an ID2D1BitmapBrush object.|  
|[CD2DBitmapBrush::m_pBitmapBrushProperties](#cd2dbitmapbrush__m_pbitmapbrushproperties)|Bitmap brush properties.|  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CD2DResource](../vs140/cd2dresource-class.md)  
  
 [CD2DBrush](../vs140/cd2dbrush-class.md)  
  
 [CD2DBitmapBrush](../vs140/cd2dbitmapbrush-class.md)  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
##  \<a name="cd2dbitmapbrush___dtorcd2dbitmapbrush">\</a>  CD2DBitmapBrush::~CD2DBitmapBrush  
 The destructor. Called when a D2D bitmap brush object is being destroyed.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cd2dbitmapbrush__attach">\</a>  CD2DBitmapBrush::Attach  
 Attaches existing resource interface to the object  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Existing resource interface. Cannot be NULL  
  
##  \<a name="cd2dbitmapbrush__cd2dbitmapbrush">\</a>  CD2DBitmapBrush::CD2DBitmapBrush  
 Constructs a CD2DBitmapBrush object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 A pointer to the render target.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 A pointer to the extend modes and the interpolation mode of a bitmap brush.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 A pointer to the opacity and transformation of a brush.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Indicates that the object will be destroyed by owner (pParentTarget).  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The resource ID number of the resource.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string that contains the resource type.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Destination size of the bitmap.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Pointer to a null-terminated string that contains the name of file.  
  
##  \<a name="cd2dbitmapbrush__commoninit">\</a>  CD2DBitmapBrush::CommonInit  
 Initializes the object  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 A pointer to the bitmap brush properties.  
  
##  \<a name="cd2dbitmapbrush__create">\</a>  CD2DBitmapBrush::Create  
 Creates a CD2DBitmapBrush.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 A pointer to the render target.  
  
### Return Value  
 If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.  
  
##  \<a name="cd2dbitmapbrush__destroy">\</a>  CD2DBitmapBrush::Destroy  
 Destroys a CD2DBitmapBrush object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="cd2dbitmapbrush__detach">\</a>  CD2DBitmapBrush::Detach  
 Detaches resource interface from the object  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to detached resource interface.  
  
##  \<a name="cd2dbitmapbrush__get">\</a>  CD2DBitmapBrush::Get  
 Returns ID2D1BitmapBrush interface  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to an ID2D1BitmapBrush interface or NULL if object is not initialized yet.  
  
##  \<a name="cd2dbitmapbrush__getbitmap">\</a>  CD2DBitmapBrush::GetBitmap  
 Gets the bitmap source that this brush uses to paint  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to an CD2DBitmap object or NULL if object is not initialized yet.  
  
##  \<a name="cd2dbitmapbrush__getextendmodex">\</a>  CD2DBitmapBrush::GetExtendModeX  
 Gets the method by which the brush horizontally tiles those areas that extend past its bitmap  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 A value that specifies how the brush horizontally tiles those areas that extend past its bitmap  
  
##  \<a name="cd2dbitmapbrush__getextendmodey">\</a>  CD2DBitmapBrush::GetExtendModeY  
 Gets the method by which the brush vertically tiles those areas that extend past its bitmap  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 A value that specifies how the brush vertically tiles those areas that extend past its bitmap  
  
##  \<a name="cd2dbitmapbrush__getinterpolationmode">\</a>  CD2DBitmapBrush::GetInterpolationMode  
 Gets the interpolation method used when the brush bitmap is scaled or rotated  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 The interpolation method used when the brush bitmap is scaled or rotated  
  
##  \<a name="cd2dbitmapbrush__m_pbitmap">\</a>  CD2DBitmapBrush::m_pBitmap  
 Stores a pointer to a CD2DBitmap object.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
##  \<a name="cd2dbitmapbrush__m_pbitmapbrush">\</a>  CD2DBitmapBrush::m_pBitmapBrush  
 Stores a pointer to an ID2D1BitmapBrush object.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
##  \<a name="cd2dbitmapbrush__m_pbitmapbrushproperties">\</a>  CD2DBitmapBrush::m_pBitmapBrushProperties  
 Bitmap brush properties.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
##  \<a name="cd2dbitmapbrush__operator_id2d1bitmapbrush_star">\</a>  CD2DBitmapBrush::operator ID2D1BitmapBrush*  
 Returns ID2D1BitmapBrush interface  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to an ID2D1BitmapBrush interface or NULL if object is not initialized yet.  
  
##  \<a name="cd2dbitmapbrush__setbitmap">\</a>  CD2DBitmapBrush::SetBitmap  
 Specifies the bitmap source that this brush uses to paint  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The bitmap source used by the brush  
  
##  \<a name="cd2dbitmapbrush__setextendmodex">\</a>  CD2DBitmapBrush::SetExtendModeX  
 Specifies how the brush horizontally tiles those areas that extend past its bitmap  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 A value that specifies how the brush horizontally tiles those areas that extend past its bitmap  
  
##  \<a name="cd2dbitmapbrush__setextendmodey">\</a>  CD2DBitmapBrush::SetExtendModeY  
 Specifies how the brush vertically tiles those areas that extend past its bitmap  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 A value that specifies how the brush vertically tiles those areas that extend past its bitmap  
  
##  \<a name="cd2dbitmapbrush__setinterpolationmode">\</a>  CD2DBitmapBrush::SetInterpolationMode  
 Specifies the interpolation mode used when the brush bitmap is scaled or rotated  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The interpolation mode used when the brush bitmap is scaled or rotated  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)