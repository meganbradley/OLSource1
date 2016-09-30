---
title: "CGdiObject Class"
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
  - "CGdiObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "brushes, base class for"
  - "fonts, base class for"
  - "regions, base class for"
  - "pens, base class for"
  - "palettes, base class for"
  - "CGdiObject class"
  - "GDI objects, base class for"
ms.assetid: 1cba3ba5-3d49-4e43-8293-209299f2f6f4
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CGdiObject Class
Provides a base class for various kinds of Windows graphics device interface (GDI) objects such as bitmaps, regions, brushes, pens, palettes, and fonts.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CGdiObject::CGdiObject](#cgdiobject__cgdiobject)|Constructs a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CGdiObject::Attach](#cgdiobject__attach)|Attaches a Windows GDI object to a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.|  
|[CGdiObject::CreateStockObject](#cgdiobject__createstockobject)|Retrieves a handle to one of the Windows predefined stock pens, brushes, or fonts.|  
|[CGdiObject::DeleteObject](#cgdiobject__deleteobject)|Deletes the Windows GDI object attached to the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object from memory by freeing all system storage associated with the object.|  
|[CGdiObject::DeleteTempMap](#cgdiobject__deletetempmap)|Deletes any temporary <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> objects created by <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.|  
|[CGdiObject::Detach](#cgdiobject__detach)|Detaches a Windows GDI object from a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object and returns a handle to the Windows GDI object.|  
|[CGdiObject::FromHandle](#cgdiobject__fromhandle)|Returns a pointer to a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object given a handle to a Windows GDI object.|  
|[CGdiObject::GetObject](#cgdiobject__getobject)|Fills a buffer with data that describes the Windows GDI object attached to the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.|  
|[CGdiObject::GetObjectType](#cgdiobject__getobjecttype)|Retrieves the type of the GDI object.|  
|[CGdiObject::GetSafeHandle](#cgdiobject__getsafehandle)|Returns <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> unless <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, in which case <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is returned.|  
|[CGdiObject::UnrealizeObject](#cgdiobject__unrealizeobject)|Resets the origin of a brush or resets a logical palette.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CGdiObject::operator !=](#cgdiobject__operator__neq)|Determines if two GDI objects are logically not equal.|  
|[CGdiObject::operator ==](#cgdiobject__operator__eq_eq)|Determines if two GDI objects are logically equal.|  
|[CGdiObject::operator HGDIOBJ](#cgdiobject__operator_hgdiobj)|Retrieves a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> to the attached Windows GDI object.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CGdiObject::m_hObject](#cgdiobject__m_hobject)|A <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> containing the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> attached to this object.|  
  
## Remarks  
 You never create a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> directly. Rather, you create an object from one of its derived classes, such as <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, see [Graphic Objects](../vs140/graphic-objects.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxwin.h  
  
##  \<a name="cgdiobject__attach">\</a>  CGdiObject::Attach  
 Attaches a Windows GDI object to a <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> to a Windows GDI object (for example, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>).  
  
### Return Value  
 Nonzero if attachment is successful; otherwise 0.  
  
##  \<a name="cgdiobject__cgdiobject">\</a>  CGdiObject::CGdiObject  
 Constructs a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 You never create a <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> directly. Rather, you create an object from one of its derived classes, such as <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> or **Cbrush**.  
  
##  \<a name="cgdiobject__createstockobject">\</a>  CGdiObject::CreateStockObject  
 Retrieves a handle to one of the predefined stock Windows GDI pens, brushes, or fonts, and attaches the GDI object to the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 A constant specifying the type of stock object desired. See the parameter                                 *fnObject* for                                 [GetStockObject](http://msdn.microsoft.com/library/windows/desktop/dd144925) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a description of appropriate values.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 Call this function with one of the derived classes that corresponds to the Windows GDI object type, such as <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> for a stock pen.  
  
##  \<a name="cgdiobject__deleteobject">\</a>  CGdiObject::DeleteObject  
 Deletes the attached Windows GDI object from memory by freeing all system storage associated with the Windows GDI object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the GDI object was successfully deleted; otherwise 0.  
  
### Remarks  
 The storage associated with the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object is not affected by this call. An application should not call <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> on a <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object that is currently selected into a device context.  
  
 When a pattern brush is deleted, the bitmap associated with the brush is not deleted. The bitmap must be deleted independently.  
  
##  \<a name="cgdiobject__deletetempmap">\</a>  CGdiObject::DeleteTempMap  
 Called automatically by the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> idle-time handler, <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> deletes any temporary <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> objects created by <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> detaches the Windows GDI object attached to a temporary <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> object before deleting the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> object.  
  
### Example  
 [!code[NVC_MFCDocView#175](../vs140/codesnippet/CPP/cgdiobject-class_1.cpp)]  
  
##  \<a name="cgdiobject__detach">\</a>  CGdiObject::Detach  
 Detaches a Windows GDI object from a <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> object and returns a handle to the Windows GDI object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> to the Windows GDI object detached; otherwise **NULL** if no GDI object is attached.  
  
##  \<a name="cgdiobject__fromhandle">\</a>  CGdiObject::FromHandle  
 Returns a pointer to a <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> object given a handle to a Windows GDI object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> to a Windows GDI object.  
  
### Return Value  
 A pointer to a <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> that may be temporary or permanent.  
  
### Remarks  
 If a <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> object is not already attached to the Windows GDI object, a temporary <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> object is created and attached.  
  
 This temporary <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object is only valid until the next time the application has idle time in its event loop, at which time all temporary graphic objects are deleted. Another way of saying this is that the temporary object is only valid during the processing of one window message.  
  
##  \<a name="cgdiobject__getobject">\</a>  CGdiObject::GetObject  
 Fills a buffer with data that defines a specified object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 Specifies the number of bytes to copy into the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> buffer.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 Points to a user-supplied buffer that is to receive the information.  
  
### Return Value  
 The number of bytes retrieved; otherwise 0 if an error occurs.  
  
### Remarks  
 The function retrieves a data structure whose type depends on the type of graphic object, as shown by the following list:  
  
|Object|Buffer type|  
|------------|-----------------|  
|<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>|[LOGPEN](../vs140/logpen-structure.md)|  
|<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>|[LOGBRUSH](../vs140/logbrush-structure.md)|  
|<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>|[LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037)|  
|<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>|[BITMAP](../vs140/bitmap-structure.md)|  
|<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>|**WORD**|  
|<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>|Not supported|  
  
 If the object is a <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> object, <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> returns only the width, height, and color format information of the bitmap. The actual bits can be retrieved by using [CBitmap::GetBitmapBits](../vs140/cbitmap-class.md#cbitmap__getbitmapbits).  
  
 If the object is a <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> object, <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> retrieves a **WORD** that specifies the number of entries in the palette. The function does not retrieve the                         [LOGPALETTE](http://msdn.microsoft.com/library/windows/desktop/dd145040) structure that defines the palette. An application can get information on palette entries by calling [CPalette::GetPaletteEntries](../vs140/cpalette-class.md#cpalette__getpaletteentries).  
  
##  \<a name="cgdiobject__getobjecttype">\</a>  CGdiObject::GetObjectType  
 Retrieves the type of the GDI object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 The type of the object, if successful; otherwise 0. The value can be one of the following:  
  
-   **OBJ_BITMAP** Bitmap  
  
-   **OBJ_BRUSH** Brush  
  
-   **OBJ_FONT** Font  
  
-   **OBJ_PAL** Palette  
  
-   **OBJ_PEN** Pen  
  
-   **OBJ_EXTPEN** Extended pen  
  
-   **OBJ_REGION** Region  
  
-   **OBJ_DC** Device context  
  
-   **OBJ_MEMDC** Memory device context  
  
-   **OBJ_METAFILE** Metafile  
  
-   **OBJ_METADC** Metafile device context  
  
-   **OBJ_ENHMETAFILE** Enhanced metafile  
  
-   **OBJ_ENHMETADC** Enhanced-metafile device context  
  
##  \<a name="cgdiobject__getsafehandle">\</a>  CGdiObject::GetSafeHandle  
 Returns <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> unless **this** is **NULL**, in which case **NULL** is returned.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> to the attached Windows GDI object; otherwise **NULL** if no object is attached.  
  
### Remarks  
 This is part of the general handle interface paradigm and is useful when **NULL** is a valid or special value for a handle.  
  
### Example  
  See the example for [CWnd::IsWindowEnabled](../vs140/cwnd-class.md#cwnd__iswindowenabled).  
  
##  \<a name="cgdiobject__m_hobject">\</a>  CGdiObject::m_hObject  
 A <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> containing the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>, **HRGN**, <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>, or **HFONT** attached to this object.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="cgdiobject__operator__neq">\</a>  CGdiObject::operator !=  
 Determines if two GDI objects are logically not equal.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
 A pointer to an existing <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>.  
  
### Remarks  
 Determines if a GDI object on the left side is not equal to a GDI object on the right side.  
  
##  \<a name="cgdiobject__operator__eq_eq">\</a>  CGdiObject::operator ==  
 Determines if two GDI objects are logically equal.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>  
 A reference to an existing <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>.  
  
### Remarks  
 Determines if a GDI object on the left side is equal to a GDI object on the right side.  
  
##  \<a name="cgdiobject__operator_hgdiobj">\</a>  CGdiObject::operator HGDIOBJ  
 Retrieves a <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> to the attached Windows GDI object; otherwise **NULL** if no object is attached.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
##  \<a name="cgdiobject__unrealizeobject">\</a>  CGdiObject::UnrealizeObject  
 Resets the origin of a brush or resets a logical palette.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 While <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> is a member function of the <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> class, it should be invoked only on <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> objects.  
  
 For <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> objects, <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> directs the system to reset the origin of the given brush the next time it is selected into a device context. If the object is a <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> object, <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> directs the system to realize the palette as though it had not previously been realized. The next time the application calls the [CDC::RealizePalette](../vs140/cdc-class.md#cdc__realizepalette) function for the specified palette, the system completely remaps the logical palette to the system palette.  
  
 The <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> function should not be used with stock objects. The <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> function must be called whenever a new brush origin is set (by means of the [CDC::SetBrushOrg](../vs140/cdc-class.md#cdc__setbrushorg) function). The <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> function must not be called for the currently selected brush or currently selected palette of any display context.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBitmap](../vs140/cbitmap-class.md)   
 [CBrush](../vs140/cbrush-class.md)   
 [CFont](../vs140/cfont-class.md)   
 [CPalette](../vs140/cpalette-class.md)   
 [CPen](../vs140/cpen-class.md)   
 [CRgn](../vs140/crgn-class.md)