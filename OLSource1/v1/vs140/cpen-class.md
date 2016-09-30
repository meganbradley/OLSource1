---
title: "CPen Class"
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
  - "HPEN"
  - "CPen"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HPEN"
  - "CPen class"
  - "pens, MFC"
ms.assetid: 93175a3a-d46c-4768-be8d-863254f97a5f
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPen Class
Encapsulates a Windows graphics device interface (GDI) pen.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CPen::CPen](#cpen__cpen)|Constructs a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CPen::CreatePen](#cpen__createpen)|Creates a logical cosmetic or geometric pen with the specified style, width, and brush attributes, and attaches it to the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.|  
|[CPen::CreatePenIndirect](#cpen__createpenindirect)|Creates a pen with the style, width, and color given in a                                         [LOGPEN](http://msdn.microsoft.com/library/windows/desktop/dd145041) structure, and attaches it to the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.|  
|[CPen::FromHandle](#cpen__fromhandle)|Returns a pointer to a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object when given a Windows <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.|  
|[CPen::GetExtLogPen](#cpen__getextlogpen)|Gets an                                         [EXTLOGPEN](http://msdn.microsoft.com/library/windows/desktop/dd162711) underlying structure.|  
|[CPen::GetLogPen](#cpen__getlogpen)|Gets a                                         [LOGPEN](http://msdn.microsoft.com/library/windows/desktop/dd145041) underlying structure.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CPen::operator HPEN](#cpen__operator_hpen)|Returns the Windows handle attached to the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 For more information on using <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, see [Graphic Objects](../vs140/graphic-objects.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CGdiObject](../vs140/cgdiobject-class.md)  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxwin.h  
  
##  \<a name="cpen__cpen">\</a>  CPen::CPen  
 Constructs a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Specifies the pen style. This parameter in the first version of the constructor can be one of the following values:  
  
-   **PS_SOLID** Creates a solid pen.  
  
-   **PS_DASH** Creates a dashed pen. Valid only when the pen width is 1 or less, in device units.  
  
-   **PS_DOT** Creates a dotted pen. Valid only when the pen width is 1 or less, in device units.  
  
-   **PS_DASHDOT** Creates a pen with alternating dashes and dots. Valid only when the pen width is 1 or less, in device units.  
  
-   **PS_DASHDOTDOT** Creates a pen with alternating dashes and double dots. Valid only when the pen width is 1 or less, in device units.  
  
-   **PS_NULL** Creates a null pen.  
  
-   **PS_INSIDEFRAME** Creates a pen that draws a line inside the frame of closed shapes produced by the Windows GDI output functions that specify a bounding rectangle (for example, the **Ellipse**, **Rectangle**, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> member functions). When this style is used with Windows GDI output functions that do not specify a bounding rectangle (for example, the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> member function), the drawing area of the pen is not limited by a frame.  
  
 The second version of the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> constructor specifies a combination of type, style, end cap, and join attributes. The values from each category should be combined by using the bitwise OR operator (&#124;). The pen type can be one of the following values:  
  
-   **PS_GEOMETRIC** Creates a geometric pen.  
  
-   **PS_COSMETIC** Creates a cosmetic pen.  
  
     The second version of the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> constructor adds the following pen styles for <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>:  
  
-   **PS_ALTERNATE** Creates a pen that sets every other pixel. (This style is applicable only for cosmetic pens.)  
  
-   **PS_USERSTYLE** Creates a pen that uses a styling array supplied by the user.  
  
     The end cap can be one of the following values:  
  
-   **PS_ENDCAP_ROUND** End caps are round.  
  
-   **PS_ENDCAP_SQUARE** End caps are square.  
  
-   **PS_ENDCAP_FLAT** End caps are flat.  
  
     The join can be one of the following values:  
  
-   **PS_JOIN_BEVEL** Joins are beveled.  
  
-   **PS_JOIN_MITER** Joins are mitered when they are within the current limit set by the                                         [SetMiterLimit](http://msdn.microsoft.com/library/windows/desktop/dd145076) function. If the join exceeds this limit, it is beveled.  
  
-   **PS_JOIN_ROUND** Joins are round.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Specifies the width of the pen.  
  
-   For the first version of the constructor, if this value is 0, the width in device units is always 1 pixel, regardless of the mapping mode.  
  
-   For the second version of the constructor, if <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is **PS_GEOMETRIC**, the width is given in logical units. If <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is **PS_COSMETIC**, the width must be set to 1.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Contains an RGB color for the pen.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Points to a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> structure. If <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is **PS_COSMETIC**, the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> member of the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> structure specifies the color of the pen and the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> member of the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> structure must be set to **BS_SOLID**. If <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is **PS_GEOMETRIC**, all members must be used to specify the brush attributes of the pen.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 Specifies the length, in doubleword units, of the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> array. This value must be zero if <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is not **PS_USERSTYLE**.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 Points to an array of doubleword values. The first value specifies the length of the first dash in a user-defined style, the second value specifies the length of the first space, and so on. This pointer must be **NULL** if <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is not **PS_USERSTYLE**.  
  
### Remarks  
 If you use the constructor with no arguments, you must initialize the resulting <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object with the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> member functions.  
  
 If you use the constructor that takes arguments, then no further initialization is necessary. The constructor with arguments can throw an exception if errors are encountered, while the constructor with no arguments will always succeed.  
  
### Example  
 [!code[NVC_MFCDocView#99](../vs140/codesnippet/CPP/cpen-class_1.cpp)]  
  
##  \<a name="cpen__createpen">\</a>  CPen::CreatePen  
 Creates a logical cosmetic or geometric pen with the specified style, width, and brush attributes, and attaches it to the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Specifies the style for the pen. For a list of possible values, see the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> parameter in the [CPen](#cpen__cpen) constructor.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 Specifies the width of the pen.  
  
-   For the first version of <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, if this value is 0, the width in device units is always 1 pixel, regardless of the mapping mode.  
  
-   For the second version of <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, if <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> is **PS_GEOMETRIC**, the width is given in logical units. If <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> is **PS_COSMETIC**, the width must be set to 1.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Contains an RGB color for the pen.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 Points to a                                 [LOGBRUSH](http://msdn.microsoft.com/library/windows/desktop/dd145035) structure. If <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> is **PS_COSMETIC**, the **lbColor** member of the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> structure specifies the color of the pen and the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> member of the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> structure must be set to **BS_SOLID**. If **nPenStyle** is **PS_GEOMETRIC**, all members must be used to specify the brush attributes of the pen.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 Specifies the length, in doubleword units, of the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> array. This value must be zero if <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> is not **PS_USERSTYLE**.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 Points to an array of doubleword values. The first value specifies the length of the first dash in a user-defined style, the second value specifies the length of the first space, and so on. This pointer must be **NULL** if <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> is not **PS_USERSTYLE**.  
  
### Return Value  
 Nonzero if successful, or zero if the method fails.  
  
### Remarks  
 The first version of <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> initializes a pen with the specified style, width, and color. The pen can be subsequently selected as the current pen for any device context.  
  
 Pens that have a width greater than 1 pixel should always have either the **PS_NULL**, **PS_SOLID**, or **PS_INSIDEFRAME** style.  
  
 If a pen has the **PS_INSIDEFRAME** style and a color that does not match a color in the logical color table, the pen is drawn with a dithered color. The **PS_SOLID** pen style cannot be used to create a pen with a dithered color. The style **PS_INSIDEFRAME** is identical to **PS_SOLID** if the pen width is less than or equal to 1.  
  
 The second version of <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> initializes a logical cosmetic or geometric pen that has the specified style, width, and brush attributes. The width of a cosmetic pen is always 1; the width of a geometric pen is always specified in world units. After an application creates a logical pen, it can select that pen into a device context by calling the [CDC::SelectObject](../vs140/cdc-class.md#cdc__selectobject) function. After a pen is selected into a device context, it can be used to draw lines and curves.  
  
-   If <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> is **PS_COSMETIC** and **PS_USERSTYLE**, the entries in the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> array specify lengths of dashes and spaces in style units. A style unit is defined by the device in which the pen is used to draw a line.  
  
-   If <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> is **PS_GEOMETRIC** and **PS_USERSTYLE**, the entries in the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> array specify lengths of dashes and spaces in logical units.  
  
-   If <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> is **PS_ALTERNATE**, the style unit is ignored and every other pixel is set.  
  
 When an application no longer requires a given pen, it should call the [CGdiObject::DeleteObject](../vs140/cgdiobject-class.md#cgdiobject__deleteobject) member function or destroy the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> object so the resource is no longer in use. An application should not delete a pen when the pen is selected in a device context.  
  
### Example  
 [!code[NVC_MFCDocView#100](../vs140/codesnippet/CPP/cpen-class_2.cpp)]  
  
##  \<a name="cpen__createpenindirect">\</a>  CPen::CreatePenIndirect  
 Initializes a pen that has the style, width, and color given in the structure pointed to by <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 Points to the Windows [LOGPEN](../vs140/logpen-structure.md) structure that contains information about the pen.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 Pens that have a width greater than 1 pixel should always have either the **PS_NULL**, **PS_SOLID**, or **PS_INSIDEFRAME** style.  
  
 If a pen has the **PS_INSIDEFRAME** style and a color that does not match a color in the logical color table, the pen is drawn with a dithered color. The **PS_INSIDEFRAME** style is identical to **PS_SOLID** if the pen width is less than or equal to 1.  
  
### Example  
 [!code[NVC_MFCDocView#101](../vs140/codesnippet/CPP/cpen-class_3.cpp)]  
  
##  \<a name="cpen__fromhandle">\</a>  CPen::FromHandle  
 Returns a pointer to a <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> object given a handle to a Windows GDI pen object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 *hPen*  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> handle to Windows GDI pen.  
  
### Return Value  
 A pointer to a <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> object if successful; otherwise **NULL**.  
  
### Remarks  
 If a <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> object is not attached to the handle, a temporary <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> object is created and attached. This temporary <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> object is valid only until the next time the application has idle time in its event loop, at which time all temporary graphic objects are deleted. In other words, the temporary object is only valid during the processing of one window message.  
  
### Example  
 [!code[NVC_MFCDocView#105](../vs140/codesnippet/CPP/cpen-class_4.cpp)]  
  
##  \<a name="cpen__getextlogpen">\</a>  CPen::GetExtLogPen  
 Gets an **EXTLOGPEN** underlying structure.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
 Points to an                                 [EXTLOGPEN](http://msdn.microsoft.com/library/windows/desktop/dd162711) structure that contains information about the pen.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The **EXTLOGPEN** structure defines the style, width, and brush attributes of a pen. For example, call <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> to match the particular style of a pen.  
  
 See the following topics in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for information about pen attributes:  
  
-   [GetObject](http://msdn.microsoft.com/library/windows/desktop/dd144904)  
  
-   [EXTLOGPEN](http://msdn.microsoft.com/library/windows/desktop/dd162711)  
  
-   [LOGPEN](http://msdn.microsoft.com/library/windows/desktop/dd145041)  
  
-   [ExtCreatePen](http://msdn.microsoft.com/library/windows/desktop/dd162705)  
  
### Example  
 The following code example demonstrates calling <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> to retrieve a pen's attributes, and then create a new, cosmetic pen with the same color.  
  
 [!code[NVC_MFCDocView#102](../vs140/codesnippet/CPP/cpen-class_5.cpp)]  
  
##  \<a name="cpen__getlogpen">\</a>  CPen::GetLogPen  
 Gets a <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> underlying structure.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 Points to a                                 [LOGPEN](http://msdn.microsoft.com/library/windows/desktop/dd145041) structure to contain information about the pen.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> structure defines the style, color, and pattern of a pen.  
  
 For example, call <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> to match the particular style of pen.  
  
 See the following topics in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for information about pen attributes:  
  
-   [GetObject](http://msdn.microsoft.com/library/windows/desktop/dd144904)  
  
-   [LOGPEN](http://msdn.microsoft.com/library/windows/desktop/dd145041)  
  
### Example  
 The following code example demonstrates calling <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> to retrieve a pen character, and then create a new, solid pen with the same color.  
  
 [!code[NVC_MFCDocView#103](../vs140/codesnippet/CPP/cpen-class_6.cpp)]  
  
##  \<a name="cpen__operator_hpen">\</a>  CPen::operator HPEN  
 Gets the attached Windows GDI handle of the <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 If successful, a handle to the Windows GDI object represented by the <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> object; otherwise **NULL**.  
  
### Remarks  
 This operator is a casting operator, which supports direct use of an <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> object.  
  
 For more information about using graphic objects, see the article                         [Graphic Objects](http://msdn.microsoft.com/library/windows/desktop/dd144962) in [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFCDocView#104](../vs140/codesnippet/CPP/cpen-class_7.cpp)]  
  
## See Also  
 [Base Class](../vs140/cgdiobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBrush](../vs140/cbrush-class.md)