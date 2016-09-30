---
title: "CRgn Class"
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
  - "CRgn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HRGN"
  - "CRgn class"
  - "regions, MFC"
ms.assetid: d904da84-76aa-481e-8780-b09485f49e64
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRgn Class
Encapsulates a Windows graphics device interface (GDI) region.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CRgn::CRgn](#crgn__crgn)|Constructs a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CRgn::CombineRgn](#crgn__combinergn)|Sets a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object so that it is equivalent to the union of two specified <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> objects.|  
|[CRgn::CopyRgn](#crgn__copyrgn)|Sets a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object so that it is a copy of a specified <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.|  
|[CRgn::CreateEllipticRgn](#crgn__createellipticrgn)|Initializes a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object with an elliptical region.|  
|[CRgn::CreateEllipticRgnIndirect](#crgn__createellipticrgnindirect)|Initializes a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object with an elliptical region defined by a [RECT](../vs140/rect-structure.md) structure.|  
|[CRgn::CreateFromData](#crgn__createfromdata)|Creates a region from the given region and transformation data.|  
|[CRgn::CreateFromPath](#crgn__createfrompath)|Creates a region from the path that is selected into the given device context.|  
|[CRgn::CreatePolygonRgn](#crgn__createpolygonrgn)|Initializes a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object with a polygonal region. The system closes the polygon automatically, if necessary, by drawing a line from the last vertex to the first.|  
|[CRgn::CreatePolyPolygonRgn](#crgn__createpolypolygonrgn)|Initializes a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object with a region consisting of a series of closed polygons. The polygons may be disjoint, or they may overlap.|  
|[CRgn::CreateRectRgn](#crgn__createrectrgn)|Initializes a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object with a rectangular region.|  
|[CRgn::CreateRectRgnIndirect](#crgn__createrectrgnindirect)|Initializes a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object with a rectangular region defined by a [RECT](../vs140/rect-structure.md) structure.|  
|[CRgn::CreateRoundRectRgn](#crgn__createroundrectrgn)|Initializes a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object with a rectangular region with rounded corners.|  
|[CRgn::EqualRgn](#crgn__equalrgn)|Checks two <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> objects to determine whether they are equivalent.|  
|[CRgn::FromHandle](#crgn__fromhandle)|Returns a pointer to a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object when given a handle to a Windows region.|  
|[CRgn::GetRegionData](#crgn__getregiondata)|Fills the specified buffer with data describing the given region.|  
|[CRgn::GetRgnBox](#crgn__getrgnbox)|Retrieves the coordinates of the bounding rectangle of a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object.|  
|[CRgn::OffsetRgn](#crgn__offsetrgn)|Moves a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object by the specified offsets.|  
|[CRgn::PtInRegion](#crgn__ptinregion)|Determines whether a specified point is in the region.|  
|[CRgn::RectInRegion](#crgn__rectinregion)|Determines whether any part of a specified rectangle is within the boundaries of the region.|  
|[CRgn::SetRectRgn](#crgn__setrectrgn)|Sets the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object to the specified rectangular region.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CRgn::operator HRGN](#crgn__operator_hrgn)|Returns the Windows handle contained in the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 A region is an elliptical or polygonal area within a window. To use regions, you use the member functions of class <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> with the clipping functions defined as members of class <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
 The member functions of <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> create, alter, and retrieve information about the region object for which they are called.  
  
 For more information on using <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, see [Graphic Objects](../vs140/graphic-objects.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CGdiObject](../vs140/cgdiobject-class.md)  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxwin.h  
  
##  \<a name="crgn__combinergn">\</a>  CRgn::CombineRgn  
 Creates a new GDI region by combining two existing regions.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 Identifies an existing region.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 Identifies an existing region.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Specifies the operation to be performed when combining the two source regions. It can be any one of the following values:  
  
-   **RGN_AND** Uses overlapping areas of both regions (intersection).  
  
-   **RGN_COPY** Creates a copy of region 1 (identified by <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>).  
  
-   **RGN_DIFF** Creates a region consisting of the areas of region 1 (identified by <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>) that are not part of region 2 (identified by <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>).  
  
-   **RGN_OR** Combines both regions in their entirety (union).  
  
-   **RGN_XOR** Combines both regions but removes overlapping areas.  
  
### Return Value  
 Specifies the type of the resulting region. It can be one of the following values:  
  
-   **COMPLEXREGION** New region has overlapping borders.  
  
-   **ERROR** No new region created.  
  
-   **NULLREGION** New region is empty.  
  
-   **SIMPLEREGION** New region has no overlapping borders.  
  
### Remarks  
 The regions are combined as specified by <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
 The two specified regions are combined, and the resulting region handle is stored in the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object. Thus, whatever region is stored in the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> object is replaced by the combined region.  
  
 The size of a region is limited to 32,767 by 32,767 logical units or 64K of memory, whichever is smaller.  
  
 Use [CopyRgn](#crgn__copyrgn) to simply copy one region into another region.  
  
### Example  
 [!code[NVC_MFCDocView#144](../vs140/codesnippet/CPP/crgn-class_1.cpp)]  
  
##  \<a name="crgn__copyrgn">\</a>  CRgn::CopyRgn  
 Copies the region defined by <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> into the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 Identifies an existing region.  
  
### Return Value  
 Specifies the type of the resulting region. It can be one of the following values:  
  
-   **COMPLEXREGION** New region has overlapping borders.  
  
-   **ERROR** No new region created.  
  
-   **NULLREGION** New region is empty.  
  
-   **SIMPLEREGION** New region has no overlapping borders.  
  
### Remarks  
 The new region replaces the region formerly stored in the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> object. This function is a special case of the [CombineRgn](#crgn__combinergn) member function.  
  
### Example  
  See the example for [CRgn::CreateEllipticRgn](#crgn__createellipticrgn).  
  
##  \<a name="crgn__createellipticrgn">\</a>  CRgn::CreateEllipticRgn  
 Creates an elliptical region.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Specifies the logical x-coordinate of the upper-left corner of the bounding rectangle of the ellipse.  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 Specifies the logical y-coordinate of the upper-left corner of the bounding rectangle of the ellipse.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 Specifies the logical x-coordinate of the lower-right corner of the bounding rectangle of the ellipse.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 Specifies the logical y-coordinate of the lower-right corner of the bounding rectangle of the ellipse.  
  
### Return Value  
 Nonzero if the operation succeeded; otherwise 0.  
  
### Remarks  
 The region is defined by the bounding rectangle specified by <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>. The region is stored in the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object.  
  
 The size of a region is limited to 32,767 by 32,767 logical units or 64K of memory, whichever is smaller.  
  
 When it has finished using a region created with the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> function, an application should select the region out of the device context and use the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> function to remove it.  
  
### Example  
 [!code[NVC_MFCDocView#145](../vs140/codesnippet/CPP/crgn-class_2.cpp)]  
  
##  \<a name="crgn__createellipticrgnindirect">\</a>  CRgn::CreateEllipticRgnIndirect  
 Creates an elliptical region.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 Points to a <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> structure or a <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> object that contains the logical coordinates of the upper-left and lower-right corners of the bounding rectangle of the ellipse.  
  
### Return Value  
 Nonzero if the operation succeeded; otherwise 0.  
  
### Remarks  
 The region is defined by the structure or object pointed to by <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> and is stored in the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> object.  
  
 The size of a region is limited to 32,767 by 32,767 logical units or 64K of memory, whichever is smaller.  
  
 When it has finished using a region created with the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> function, an application should select the region out of the device context and use the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> function to remove it.  
  
### Example  
  See the example for [CRgn::CreateRectRgnIndirect](#crgn__createrectrgnindirect).  
  
##  \<a name="crgn__createfromdata">\</a>  CRgn::CreateFromData  
 Creates a region from the given region and transformation data.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 *lpXForm*  
 Points to an [XFORM](../vs140/xform-structure.md) data structure that defines the transformation to be performed on the region. If this pointer is **NULL**, the identity transformation is used.  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 Specifies the number of bytes pointed to by <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 Points to a [RGNDATA](../vs140/rgndata-structure.md) data structure that contains the region data.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 An application can retrieve data for a region by calling the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> function.  
  
##  \<a name="crgn__createfrompath">\</a>  CRgn::CreateFromPath  
 Creates a region from the path that is selected into the given device context.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 Identifies a device context that contains a closed path.  
  
### Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
### Remarks  
 The device context identified by the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> parameter must contain a closed path. After <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> converts a path into a region, Windows discards the closed path from the device context.  
  
##  \<a name="crgn__createpolygonrgn">\</a>  CRgn::CreatePolygonRgn  
 Creates a polygonal region.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 Points to an array of **POINT** structures or an array of <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> objects. Each structure specifies the x-coordinate and y-coordinate of one vertex of the polygon. The **POINT** structure has the following form:  
  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 Specifies the number of **POINT** structures or <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> objects in the array pointed to by <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>  
 Specifies the filling mode for the region. This parameter may be either **ALTERNATE** or **WINDING**.  
  
### Return Value  
 Nonzero if the operation succeeded; otherwise 0.  
  
### Remarks  
 The system closes the polygon automatically, if necessary, by drawing a line from the last vertex to the first. The resulting region is stored in the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> object.  
  
 The size of a region is limited to 32,767 by 32,767 logical units or 64K of memory, whichever is smaller.  
  
 When the polygon-filling mode is **ALTERNATE**, the system fills the area between odd-numbered and even-numbered polygon sides on each scan line. That is, the system fills the area between the first and second side, between the third and fourth side, and so on.  
  
 When the polygon-filling mode is **WINDING**, the system uses the direction in which a figure was drawn to determine whether to fill an area. Each line segment in a polygon is drawn in either a clockwise or a counterclockwise direction. Whenever an imaginary line drawn from an enclosed area to the outside of a figure passes through a clockwise line segment, a count is incremented. When the line passes through a counterclockwise line segment, the count is decremented. The area is filled if the count is nonzero when the line reaches the outside of the figure.  
  
 When an application has finished using a region created with the <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> function, it should select the region out of the device context and use the <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> function to remove it.  
  
### Example  
 [!code[NVC_MFCDocView#146](../vs140/codesnippet/CPP/crgn-class_3.cpp)]  
  
##  \<a name="crgn__createpolypolygonrgn">\</a>  CRgn::CreatePolyPolygonRgn  
 Creates a region consisting of a series of closed polygons.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 Points to an array of **POINT** structures or an array of <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> objects that defines the vertices of the polygons. Each polygon must be explicitly closed because the system does not close them automatically. The polygons are specified consecutively. The **POINT** structure has the following form:  
  
 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>  
 Points to an array of integers. The first integer specifies the number of vertices in the first polygon in the <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> array, the second integer specifies the number of vertices in the second polygon, and so on.  
  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 Specifies the total number of integers in the <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> array.  
  
 <CodeContentPlaceHolder>106\</CodeContentPlaceHolder>  
 Specifies the polygon-filling mode. This value may be either **ALTERNATE** or **WINDING**.  
  
### Return Value  
 Nonzero if the operation succeeded; otherwise 0.  
  
### Remarks  
 The resulting region is stored in the <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> object.  
  
 The polygons may be disjoint, or they may overlap.  
  
 The size of a region is limited to 32,767 by 32,767 logical units or 64K of memory, whichever is smaller.  
  
 When the polygon-filling mode is **ALTERNATE**, the system fills the area between odd-numbered and even-numbered polygon sides on each scan line. That is, the system fills the area between the first and second side, between the third and fourth side, and so on.  
  
 When the polygon-filling mode is **WINDING**, the system uses the direction in which a figure was drawn to determine whether to fill an area. Each line segment in a polygon is drawn in either a clockwise or a counterclockwise direction. Whenever an imaginary line drawn from an enclosed area to the outside of a figure passes through a clockwise line segment, a count is incremented. When the line passes through a counterclockwise line segment, the count is decremented. The area is filled if the count is nonzero when the line reaches the outside of the figure.  
  
 When an application has finished using a region created with the <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> function, it should select the region out of the device context and use the [CGDIObject::DeleteObject](../vs140/cgdiobject-class.md#cgdiobject__deleteobject) member function to remove it.  
  
##  \<a name="crgn__createrectrgn">\</a>  CRgn::CreateRectRgn  
 Creates a rectangular region that is stored in the <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>  
 Specifies the logical x-coordinate of the upper-left corner of the region.  
  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 Specifies the logical y-coordinate of the upper-left corner of the region.  
  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>  
 Specifies the logical x-coordinate of the lower-right corner of the region.  
  
 <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>  
 Specifies the logical y-coordinate of the lower-right corner of the region.  
  
### Return Value  
 Nonzero if the operation succeeded; otherwise 0.  
  
### Remarks  
 The size of a region is limited to 32,767 by 32,767 logical units or 64K of memory, whichever is smaller.  
  
 When it has finished using a region created by <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>, an application should use the [CGDIObject::DeleteObject](../vs140/cgdiobject-class.md#cgdiobject__deleteobject) member function to remove the region.  
  
### Example  
 [!code[NVC_MFCDocView#147](../vs140/codesnippet/CPP/crgn-class_4.cpp)]  
  
 For an additional example, see [CRgn::CombineRgn](#crgn__combinergn).  
  
##  \<a name="crgn__createrectrgnindirect">\</a>  CRgn::CreateRectRgnIndirect  
 Creates a rectangular region that is stored in the <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>  
 Points to a <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> structure or <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> object that contains the logical coordinates of the upper-left and lower-right corners of the region. The <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> structure has the following form:  
  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
  
### Return Value  
 Nonzero if the operation succeeded; otherwise 0.  
  
### Remarks  
 The size of a region is limited to 32,767 by 32,767 logical units or 64K of memory, whichever is smaller.  
  
 When it has finished using a region created by <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>, an application should use the [CGDIObject::DeleteObject](../vs140/cgdiobject-class.md#cgdiobject__deleteobject) member function to remove the region.  
  
### Example  
 [!code[NVC_MFCDocView#148](../vs140/codesnippet/CPP/crgn-class_5.cpp)]  
  
##  \<a name="crgn__createroundrectrgn">\</a>  CRgn::CreateRoundRectRgn  
 Creates a rectangular region with rounded corners that is stored in the <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 Specifies the logical x-coordinate of the upper-left corner of the region.  
  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 Specifies the logical y-coordinate of the upper-left corner of the region.  
  
 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
 Specifies the logical x-coordinate of the lower-right corner of the region.  
  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 Specifies the logical y-coordinate of the lower-right corner of the region.  
  
 *x3*  
 Specifies the width of the ellipse used to create the rounded corners.  
  
 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 Specifies the height of the ellipse used to create the rounded corners.  
  
### Return Value  
 Nonzero if the operation succeeded; otherwise 0.  
  
### Remarks  
 The size of a region is limited to 32,767 by 32,767 logical units or 64K of memory, whichever is smaller.  
  
 When an application has finished using a region created with the <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> function, it should select the region out of the device context and use the [CGDIObject::DeleteObject](../vs140/cgdiobject-class.md#cgdiobject__deleteobject) member function to remove it.  
  
### Example  
 [!code[NVC_MFCDocView#149](../vs140/codesnippet/CPP/crgn-class_6.cpp)]  
  
##  \<a name="crgn__crgn">\</a>  CRgn::CRgn  
 Constructs a <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Remarks  
 The <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> data member does not contain a valid Windows GDI region until the object is initialized with one or more of the other <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> member functions.  
  
### Example  
  See the example for [CRgn::CreateRoundRectRgn](#crgn__createroundrectrgn).  
  
##  \<a name="crgn__equalrgn">\</a>  CRgn::EqualRgn  
 Determines whether the given region is equivalent to the region stored in the <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 Identifies a region.  
  
### Return Value  
 Nonzero if the two regions are equivalent; otherwise 0.  
  
### Example  
 [!code[NVC_MFCDocView#150](../vs140/codesnippet/CPP/crgn-class_7.cpp)]  
  
##  \<a name="crgn__fromhandle">\</a>  CRgn::FromHandle  
 Returns a pointer to a <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> object when given a handle to a Windows region.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 Specifies a handle to a Windows region.  
  
### Return Value  
 A pointer to a <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> object. If the function was not successful, the return value is **NULL**.  
  
### Remarks  
 If a <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> object is not already attached to the handle, a temporary <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> object is created and attached. This temporary <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> object is valid only until the next time the application has idle time in its event loop, at which time all temporary graphic objects are deleted. Another way of saying this is that the temporary object is only valid during the processing of one window message.  
  
##  \<a name="crgn__getregiondata">\</a>  CRgn::GetRegionData  
 Fills the specified buffer with data describing the region.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
 Points to a [RGNDATA](../vs140/rgndata-structure.md) data structure that receives the information. If this parameter is **NULL**, the return value contains the number of bytes needed for the region data.  
  
 <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>  
 Specifies the size, in bytes, of the <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> buffer.  
  
### Return Value  
 If the function succeeds and <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> specifies an adequate number of bytes, the return value is always <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>. If the function fails, or if <CodeContentPlaceHolder>150\</CodeContentPlaceHolder> specifies less than adequate number of bytes, the return value is 0 (error).  
  
### Remarks  
 This data includes the dimensions of the rectangles that make up the region. This function is used in conjunction with the <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> function.  
  
##  \<a name="crgn__getrgnbox">\</a>  CRgn::GetRgnBox  
 Retrieves the coordinates of the bounding rectangle of the <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 Points to a <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> structure or <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> object to receive the coordinates of the bounding rectangle. The <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> structure has the following form:  
  
 <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>  
  
### Return Value  
 Specifies the region's type. It can be any of the following values:  
  
-   **COMPLEXREGION** Region has overlapping borders.  
  
-   **NULLREGION** Region is empty.  
  
-   **ERROR** <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> object does not specify a valid region.  
  
-   **SIMPLEREGION** Region has no overlapping borders.  
  
### Example  
  See the example for [CRgn::CreatePolygonRgn](#crgn__createpolygonrgn).  
  
##  \<a name="crgn__offsetrgn">\</a>  CRgn::OffsetRgn  
 Moves the region stored in the <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> object by the specified offsets.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 Specifies the number of units to move left or right.  
  
 *y*  
 Specifies the number of units to move up or down.  
  
 <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>  
 The x-coordinate of <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> specifies the number of units to move left or right. The y-coordinate of <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> specifies the number of units to move up or down. The <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> parameter may be either a **POINT** structure or a <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> object.  
  
### Return Value  
 The new region's type. It can be any one of the following values:  
  
-   **COMPLEXREGION** Region has overlapping borders.  
  
-   **ERROR** Region handle is not valid.  
  
-   **NULLREGION** Region is empty.  
  
-   **SIMPLEREGION** Region has no overlapping borders.  
  
### Remarks  
 The function moves the region                         *x* units along the x-axis and                         *y* units along the y-axis.  
  
 The coordinate values of a region must be less than or equal to 32,767 and greater than or equal to –32,768. The                         *x* and                         *y* parameters must be carefully chosen to prevent invalid region coordinates.  
  
### Example  
  See the example for [CRgn::CreateEllipticRgn](#crgn__createellipticrgn).  
  
##  \<a name="crgn__operator_hrgn">\</a>  CRgn::operator HRGN  
 Use this operator to get the attached Windows GDI handle of the <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 If successful, a handle to the Windows GDI object represented by the <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> object; otherwise **NULL**.  
  
### Remarks  
 This operator is a casting operator, which supports direct use of an **HRGN** object.  
  
 For more information about using graphic objects, see the article                         [Graphic Objects](http://msdn.microsoft.com/library/windows/desktop/dd144962) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="crgn__ptinregion">\</a>  CRgn::PtInRegion  
 Checks whether the point given by                 *x* and                 *y* is in the region stored in the <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 *x*  
 Specifies the logical x-coordinate of the point to test.  
  
 *y*  
 Specifies the logical y-coordinate of the point to test.  
  
 <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
 The x- and y-coordinates of <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> specify the x- and y-coordinates of the point to test the value of. The <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> parameter can either be a **POINT** structure or a <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> object.  
  
### Return Value  
 Nonzero if the point is in the region; otherwise 0.  
  
##  \<a name="crgn__rectinregion">\</a>  CRgn::RectInRegion  
 Determines whether any part of the rectangle specified by <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> is within the boundaries of the region stored in the <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
 Points to a <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> structure or <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> object. The <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> structure has the following form:  
  
 <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  
  
### Return Value  
 Nonzero if any part of the specified rectangle lies within the boundaries of the region; otherwise 0.  
  
##  \<a name="crgn__setrectrgn">\</a>  CRgn::SetRectRgn  
 Creates a rectangular region.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the upper-left corner of the rectangular region.  
  
 <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the upper-left corner of the rectangular region.  
  
 <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
 Specifies the x-coordinate of the lower-right corner of the rectangular region.  
  
 <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
 Specifies the y-coordinate of the lower-right corner of the rectangular region.  
  
 <CodeContentPlaceHolder>193\</CodeContentPlaceHolder>  
 Specifies the rectangular region. Can be either a pointer to a <CodeContentPlaceHolder>194\</CodeContentPlaceHolder> structure or a <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> object.  
  
### Remarks  
 Unlike [CreateRectRgn](#crgn__createrectrgn), however, it does not allocate any additional memory from the local Windows application heap. Instead, it uses the space allocated for the region stored in the <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> object. This means that the <CodeContentPlaceHolder>197\</CodeContentPlaceHolder> object must already have been initialized with a valid Windows region before calling <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>. The points given by <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>202\</CodeContentPlaceHolder> specify the minimum size of the allocated space.  
  
 Use this function instead of the <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> member function to avoid calls to the local memory manager.  
  
## See Also  
 [Base Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)