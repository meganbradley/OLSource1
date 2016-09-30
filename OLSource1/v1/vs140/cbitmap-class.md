---
title: "CBitmap Class"
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
  - "CBitmap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "drawing, tools"
  - "CBitmap class"
  - "GDI bitmap"
ms.assetid: 3980616a-c59d-495a-86e6-62bd3889c84c
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBitmap Class
Encapsulates a Windows graphics device interface (GDI) bitmap and provides member functions to manipulate the bitmap.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CBitmap::CBitmap](#cbitmap__cbitmap)|Constructs a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CBitmap::CreateBitmap](#cbitmap__createbitmap)|Initializes the object with a device-dependent memory bitmap that has a specified width, height, and bit pattern.|  
|[CBitmap::CreateBitmapIndirect](#cbitmap__createbitmapindirect)|Initializes the object with a bitmap with the width, height, and bit pattern (if one is specified) given in a **BITMAP** structure.|  
|[CBitmap::CreateCompatibleBitmap](#cbitmap__createcompatiblebitmap)|Initializes the object with a bitmap so that it is compatible with a specified device.|  
|[CBitmap::CreateDiscardableBitmap](#cbitmap__creatediscardablebitmap)|Initializes the object with a discardable bitmap that is compatible with a specified device.|  
|[CBitmap::FromHandle](#cbitmap__fromhandle)|Returns a pointer to a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object when given a handle to a Windows <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> bitmap.|  
|[CBitmap::GetBitmap](#cbitmap__getbitmap)|Fills a **BITMAP** structure with information about the bitmap.|  
|[CBitmap::GetBitmapBits](#cbitmap__getbitmapbits)|Copies the bits of the specified bitmap into the specified buffer.|  
|[CBitmap::GetBitmapDimension](#cbitmap__getbitmapdimension)|Returns the width and height of the bitmap. The height and width are assumed to have been set previously by the [SetBitmapDimension](#cbitmap__setbitmapdimension) member function.|  
|[CBitmap::LoadBitmap](#cbitmap__loadbitmap)|Initializes the object by loading a named bitmap resource from the application's executable file and attaching the bitmap to the object.|  
|[CBitmap::LoadMappedBitmap](#cbitmap__loadmappedbitmap)|Loads a bitmap and maps colors to current system colors.|  
|[CBitmap::LoadOEMBitmap](#cbitmap__loadoembitmap)|Initializes the object by loading a predefined Windows bitmap and attaching the bitmap to the object.|  
|[CBitmap::SetBitmapBits](#cbitmap__setbitmapbits)|Sets the bits of a bitmap to the specified bit values.|  
|[CBitmap::SetBitmapDimension](#cbitmap__setbitmapdimension)|Assigns a width and height to a bitmap in 0.1-millimeter units.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CBitmap::operator HBITMAP](#cbitmap__operator_hbitmap)|Returns the Windows handle attached to the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 To use a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object, construct the object, attach a bitmap handle to it with one of the initialization member functions, and then call the object's member functions.  
  
 For more information on using graphic objects like <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, see [Graphic Objects](../vs140/graphic-objects.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CGdiObject](../vs140/cgdiobject-class.md)  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxwin.h  
  
##  \<a name="cbitmap__cbitmap">\</a>  CBitmap::CBitmap  
 Constructs a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The resulting object must be initialized with one of the initialization member functions.  
  
##  \<a name="cbitmap__createbitmap">\</a>  CBitmap::CreateBitmap  
 Initializes a device-dependent memory bitmap that has the specified width, height, and bit pattern.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Specifies the width (in pixels) of the bitmap.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Specifies the height (in pixels) of the bitmap.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Specifies the number of color planes in the bitmap.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Specifies the number of color bits per display pixel.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Points to an array of bytes that contains the initial bitmap bit values. If it is **NULL**, the new bitmap is left uninitialized.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 For a color bitmap, either the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> parameter should be set to 1. If both of these parameters are set to 1, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> creates a monochrome bitmap.  
  
 Although a bitmap cannot be directly selected for a display device, it can be selected as the current bitmap for a "memory device context" by using [CDC::SelectObject](../vs140/cdc-class.md#cdc__selectobject) and copied to any compatible device context by using the [CDC::BitBlt](../vs140/cdc-class.md#cdc__bitblt) function.  
  
 When you finish with the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object created by the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> function, first select the bitmap out of the device context, then delete the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object.  
  
 For more information, see the description of the **bmBits** field in the **BITMAP** structure. The [BITMAP](../vs140/bitmap-structure.md) structure is described under the [CBitmap::CreateBitmapIndirect](#cbitmap__createbitmapindirect) member function.  
  
##  \<a name="cbitmap__createbitmapindirect">\</a>  CBitmap::CreateBitmapIndirect  
 Initializes a bitmap that has the width, height, and bit pattern (if one is specified) given in the structure pointed to by <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 Points to a [BITMAP](../vs140/bitmap-structure.md) structure that contains information about the bitmap.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 Although a bitmap cannot be directly selected for a display device, it can be selected as the current bitmap for a memory device context by using [CDC::SelectObject](../vs140/cdc-class.md#cdc__selectobject) and copied to any compatible device context by using the [CDC::BitBlt](../vs140/cdc-class.md#cdc__bitblt) or [CDC::StretchBlt](../vs140/cdc-class.md#cdc__stretchblt) function. (The [CDC::PatBlt](../vs140/cdc-class.md#cdc__patblt) function can copy the bitmap for the current brush directly to the display device context.)  
  
 If the **BITMAP** structure pointed to by the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> parameter has been filled in by using the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> function, the bits of the bitmap are not specified and the bitmap is uninitialized. To initialize the bitmap, an application can use a function such as [CDC::BitBlt](../vs140/cdc-class.md#cdc__bitblt) or                         [SetDIBits](http://msdn.microsoft.com/library/windows/desktop/dd162973) to copy the bits from the bitmap identified by the first parameter of <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> to the bitmap created by <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
 When you finish with the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object created with <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> function, first select the bitmap out of the device context, then delete the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object.  
  
##  \<a name="cbitmap__createcompatiblebitmap">\</a>  CBitmap::CreateCompatibleBitmap  
 Initializes a bitmap that is compatible with the device specified by <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 Specifies the device context.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 Specifies the width (in pixels) of the bitmap.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Specifies the height (in pixels) of the bitmap.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The bitmap has the same number of color planes or the same bits-per-pixel format as the specified device context. It can be selected as the current bitmap for any memory device that is compatible with the one specified by <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is a memory device context, the bitmap returned has the same format as the currently selected bitmap in that device context. A "memory device context" is a block of memory that represents a display surface. It can be used to prepare images in memory before copying them to the actual display surface of the compatible device.  
  
 When a memory device context is created, GDI automatically selects a monochrome stock bitmap for it.  
  
 Since a color memory device context can have either color or monochrome bitmaps selected, the format of the bitmap returned by the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> function is not always the same; however, the format of a compatible bitmap for a nonmemory device context is always in the format of the device.  
  
 When you finish with the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object created with the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> function, first select the bitmap out of the device context, then delete the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> object.  
  
##  \<a name="cbitmap__creatediscardablebitmap">\</a>  CBitmap::CreateDiscardableBitmap  
 Initializes a discardable bitmap that is compatible with the device context identified by <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 Specifies a device context.  
  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 Specifies the width (in bits) of the bitmap.  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 Specifies the height (in bits) of the bitmap.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The bitmap has the same number of color planes or the same bits-per-pixel format as the specified device context. An application can select this bitmap as the current bitmap for a memory device that is compatible with the one specified by <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
 Windows can discard a bitmap created by this function only if an application has not selected it into a display context. If Windows discards the bitmap when it is not selected and the application later attempts to select it, the [CDC::SelectObject](../vs140/cdc-class.md#cdc__selectobject) function will return **NULL**.  
  
 When you finish with the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object created with the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> function, first select the bitmap out of the device context, then delete the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> object.  
  
##  \<a name="cbitmap__fromhandle">\</a>  CBitmap::FromHandle  
 Returns a pointer to a <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object when given a handle to a Windows GDI bitmap.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 Specifies a Windows GDI bitmap.  
  
### Return Value  
 A pointer to a <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object if successful; otherwise **NULL**.  
  
### Remarks  
 If a <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> object is not already attached to the handle, a temporary <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object is created and attached. This temporary <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> object is valid only until the next time the application has idle time in its event loop, at which time all temporary graphic objects are deleted. Another way of saying this is that the temporary object is only valid during the processing of one window message.  
  
##  \<a name="cbitmap__getbitmap">\</a>  CBitmap::GetBitmap  
 Retrieves image properties for the attached bitmap.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 Pointer to a [BITMAP](../vs140/bitmap-structure.md) structure that will receive the image properties. This parameter must not be <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.  
  
### Return Value  
 Nonzero if the method was successful; otherwise 0.  
  
### Remarks  
  
##  \<a name="cbitmap__getbitmapbits">\</a>  CBitmap::GetBitmapBits  
 Copies the bit pattern of the attached bitmap into the specified buffer.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 The number of bytes to copy to the buffer.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 Pointer to the buffer that will receive the bitmap.  
  
### Return Value  
 The number of bytes copied to the buffer if the method was successful; otherwise 0.  
  
### Remarks  
 Use [CBitmap::GetBitmap](#cbitmap__getbitmap) to determine the required buffer size.  
  
##  \<a name="cbitmap__getbitmapdimension">\</a>  CBitmap::GetBitmapDimension  
 Returns the width and height of the bitmap.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 The width and height of the bitmap, measured in 0.1-millimeter units. The height is in the **cy** member of the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> object, and the width is in the **cx** member. If the bitmap width and height have not been set by using <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>, the return value is 0.  
  
### Remarks  
 The height and width are assumed to have been set previously by using the [SetBitmapDimension](#cbitmap__setbitmapdimension) member function.  
  
##  \<a name="cbitmap__loadbitmap">\</a>  CBitmap::LoadBitmap  
 Loads the bitmap resource named by <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> or identified by the ID number in <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> from the application's executable file.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 Points to a null-terminated string that contains the name of the bitmap resource.  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
 Specifies the resource ID number of the bitmap resource.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The loaded bitmap is attached to the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> object.  
  
 If the bitmap identified by <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> does not exist or if there is insufficient memory to load the bitmap, the function returns 0.  
  
 You can use the [CGdiObject::DeleteObject](../vs140/cgdiobject-class.md#cgdiobject__deleteobject) function to delete bitmap loaded by the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> function, or the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> destructor will delete the object for you.  
  
> [!CAUTION]
>  Before you delete the object, make sure it is not selected into a device context.  
  
 The following bitmaps were added to Windows versions 3.1 and later:  
  
 **OBM_UPARRROWIOBM_DNARROWIOBM_RGARROWIOBM_LFARROWI**  
  
 These bitmaps are not found in device drivers for Windows versions 3.0 and earlier. For a complete list of bitmaps and a display of their appearance, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cbitmap__loadmappedbitmap">\</a>  CBitmap::LoadMappedBitmap  
 Call this member function to load a bitmap and map the colors to the current system colors.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 The ID of the bitmap resource.  
  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 A flag for a bitmap. Can be zero or **CMB_MASKED**.  
  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 A pointer to a **COLORMAP** structure that contains the color information needed to map the bitmaps. If this parameter is **NULL**, the function uses the default color map.  
  
 *nMapSize*  
 The number of color maps pointed to by <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 By default, <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> will map colors commonly used in button glyphs.  
  
 For information about creating a mapped bitmap, see the Windows function                         [CreateMappedBitmap](http://go.microsoft.com/fwlink/?LinkID=230562) and the                         [COLORMAP](http://msdn.microsoft.com/library/windows/desktop/bb760448) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cbitmap__loadoembitmap">\</a>  CBitmap::LoadOEMBitmap  
 Loads a predefined bitmap used by Windows.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
 ID number of the predefined Windows bitmap. The possible values are listed below from WINDOWS.H:  
  
|||  
|-|-|  
|**OBM_BTNCORNERS**|**OBM_OLD_RESTORE**|  
|**OBM_BTSIZE**|**OBM_OLD_RGARROW**|  
|**OBM_CHECK**|**OBM_OLD_UPARROW**|  
|**OBM_CHECKBOXES**|**OBM_OLD_ZOOM**|  
|**OBM_CLOSE**|**OBM_REDUCE**|  
|**OBM_COMBO**|**OBM_REDUCED**|  
|**OBM_DNARROW**|**OBM_RESTORE**|  
|**OBM_DNARROWD**|**OBM_RESTORED**|  
|**OBM_DNARROWI**|**OBM_RGARROW**|  
|**OBM_LFARROW**|**OBM_RGARROWD**|  
|**OBM_LFARROWD**|**OBM_RGARROWI**|  
|**OBM_LFARROWI**|**OBM_SIZE**|  
|**OBM_MNARROW**|**OBM_UPARROW**|  
|**OBM_OLD_CLOSE**|**OBM_UPARROWD**|  
|**OBM_OLD_DNARROW**|**OBM_UPARROW**|  
|**OBM_OLD_LFARROW**|**OBM_ZOOM**|  
|**OBM_OLD_REDUCE**|**OBM_ZOOMD**|  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 Bitmap names that begin with **OBM_OLD** represent bitmaps used by Windows versions prior to 3.0.  
  
 Note that the constant **OEMRESOURCE** must be defined before including WINDOWS.H in order to use any of the **OBM_** constants.  
  
##  \<a name="cbitmap__operator_hbitmap">\</a>  CBitmap::operator HBITMAP  
 Use this operator to get the attached Windows GDI handle of the <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 If successful, a handle to the Windows GDI object represented by the <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> object; otherwise **NULL**.  
  
### Remarks  
 This operator is a casting operator, which supports direct use of an <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> object.  
  
 For more information about using graphic objects, see                         [Graphic Objects](http://msdn.microsoft.com/library/windows/desktop/dd144962) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="cbitmap__setbitmapbits">\</a>  CBitmap::SetBitmapBits  
 Sets the bits of a bitmap to the bit values given by <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 Specifies the number of bytes pointed to by <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
 Points to the **BYTE** array that contains the pixel values to be copied to the <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> object. In order for the bitmap to be able to render its image correctly, the values should be formatted to conform to the height, width and color depth values that were specified when the CBitmap instance was created. For more information, see [CBitmap::CreateBitmap](#cbitmap__createbitmap).  
  
### Return Value  
 The number of bytes used in setting the bitmap bits; 0 if the function fails.  
  
##  \<a name="cbitmap__setbitmapdimension">\</a>  CBitmap::SetBitmapDimension  
 Assigns a width and height to a bitmap in 0.1-millimeter units.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 Specifies the width of the bitmap (in 0.1-millimeter units).  
  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 Specifies the height of the bitmap (in 0.1-millimeter units).  
  
### Return Value  
 The previous bitmap dimensions. Height is in the **cy** member variable of the <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> object, and width is in the **cx** member variable.  
  
### Remarks  
 The GDI does not use these values except to return them when an application calls the [GetBitmapDimension](#cbitmap__getbitmapdimension) member function.  
  
## See Also  
 [MFC Sample MDI](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cgdiobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)