---
title: "CD2DGeometrySink Class"
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
  - "afxrendertarget/CD2DGeometrySink"
  - "CD2DGeometrySink"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DGeometrySink class"
ms.assetid: e5e07f41-0343-4ab1-9d6b-8c62ed33c04a
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DGeometrySink Class
A wrapper for ID2D1GeometrySink.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DGeometrySink::CD2DGeometrySink](#cd2dgeometrysink__cd2dgeometrysink)|Constructs a CD2DGeometrySink object from CD2DPathGeometry object.|  
|[CD2DGeometrySink::~CD2DGeometrySink](#cd2dgeometrysink___dtorcd2dgeometrysink)|The destructor. Called when a D2D geometry sink object is being destroyed.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DGeometrySink::AddArc](#cd2dgeometrysink__addarc)|Adds a single arc to the path geometry|  
|[CD2DGeometrySink::AddBezier](#cd2dgeometrysink__addbezier)|Creates a cubic Bezier curve between the current point and the specified end point.|  
|[CD2DGeometrySink::AddBeziers](#cd2dgeometrysink__addbeziers)|Creates a sequence of cubic Bezier curves and adds them to the geometry sink.|  
|[CD2DGeometrySink::AddLine](#cd2dgeometrysink__addline)|Creates a line segment between the current point and the specified end point and adds it to the geometry sink.|  
|[CD2DGeometrySink::AddLines](#cd2dgeometrysink__addlines)|Creates a sequence of lines using the specified points and adds them to the geometry sink.|  
|[CD2DGeometrySink::AddQuadraticBezier](#cd2dgeometrysink__addquadraticbezier)|Creates a quadratic Bezier curve between the current point and the specified end point.|  
|[CD2DGeometrySink::AddQuadraticBeziers](#cd2dgeometrysink__addquadraticbeziers)|Adds a sequence of quadratic Bezier segments as an array in a single call.|  
|[CD2DGeometrySink::BeginFigure](#cd2dgeometrysink__beginfigure)|Starts a new figure at the specified point.|  
|[CD2DGeometrySink::Close](#cd2dgeometrysink__close)|Closes the geometry sink|  
|[CD2DGeometrySink::EndFigure](#cd2dgeometrysink__endfigure)|Ends the current figure; optionally, closes it.|  
|[CD2DGeometrySink::Get](#cd2dgeometrysink__get)|Returns ID2D1GeometrySink interface|  
|[CD2DGeometrySink::IsValid](#cd2dgeometrysink__isvalid)|Checks geometry sink validity|  
|[CD2DGeometrySink::SetFillMode](#cd2dgeometrysink__setfillmode)|Specifies the method used to determine which points are inside the geometry described by this geometry sink and which points are outside.|  
|[CD2DGeometrySink::SetSegmentFlags](#cd2dgeometrysink__setsegmentflags)|Specifies stroke and join options to be applied to new segments added to the geometry sink.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DGeometrySink::operator ID2D1GeometrySink*](#cd2dgeometrysink__operator_id2d1geometrysink_star)|Returns ID2D1GeometrySink interface|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DGeometrySink::m_pSink](#cd2dgeometrysink__m_psink)|A pointer to an ID2D1GeometrySink.|  
  
## Inheritance Hierarchy  
 [CD2DGeometrySink](../vs140/cd2dgeometrysink-class.md)  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
##  \<a name="cd2dgeometrysink___dtorcd2dgeometrysink">\</a>  CD2DGeometrySink::~CD2DGeometrySink  
 The destructor. Called when a D2D geometry sink object is being destroyed.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cd2dgeometrysink__addarc">\</a>  CD2DGeometrySink::AddArc  
 Adds a single arc to the path geometry  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The arc segment to add to the figure  
  
##  \<a name="cd2dgeometrysink__addbezier">\</a>  CD2DGeometrySink::AddBezier  
 Creates a cubic Bezier curve between the current point and the specified end point.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 A structure that describes the control points and end point of the Bezier curve to add.  
  
##  \<a name="cd2dgeometrysink__addbeziers">\</a>  CD2DGeometrySink::AddBeziers  
 Creates a sequence of cubic Bezier curves and adds them to the geometry sink.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 An array of Bezier segments that describes the Bezier curves to create. A curve is drawn from the geometry sink's current point (the end point of the last segment drawn or the location specified by BeginFigure) to the end point of the first Bezier segment in the array. if the array contains additional Bezier segments, each subsequent Bezier segment uses the end point of the preceding Bezier segment as its start point.  
  
##  \<a name="cd2dgeometrysink__addline">\</a>  CD2DGeometrySink::AddLine  
 Creates a line segment between the current point and the specified end point and adds it to the geometry sink.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The end point of the line to draw.  
  
##  \<a name="cd2dgeometrysink__addlines">\</a>  CD2DGeometrySink::AddLines  
 Creates a sequence of lines using the specified points and adds them to the geometry sink.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 An array of one or more points that describe the lines to draw. A line is drawn from the geometry sink's current point (the end point of the last segment drawn or the location specified by BeginFigure) to the first point in the array. if the array contains additional points, a line is drawn from the first point to the second point in the array, from the second point to the third point, and so on. An array of a sequence of the end points of the lines to draw.  
  
##  \<a name="cd2dgeometrysink__addquadraticbezier">\</a>  CD2DGeometrySink::AddQuadraticBezier  
 Creates a quadratic Bezier curve between the current point and the specified end point.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 A structure that describes the control point and the end point of the quadratic Bezier curve to add.  
  
##  \<a name="cd2dgeometrysink__addquadraticbeziers">\</a>  CD2DGeometrySink::AddQuadraticBeziers  
 Adds a sequence of quadratic Bezier segments as an array in a single call.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 An array of a sequence of quadratic Bezier segments.  
  
##  \<a name="cd2dgeometrysink__beginfigure">\</a>  CD2DGeometrySink::BeginFigure  
 Starts a new figure at the specified point.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The point at which to begin the new figure.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Whether the new figure should be hollow or filled.  
  
##  \<a name="cd2dgeometrysink__cd2dgeometrysink">\</a>  CD2DGeometrySink::CD2DGeometrySink  
 Constructs a CD2DGeometrySink object from CD2DPathGeometry object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 An existing CD2DPathGeometry object.  
  
##  \<a name="cd2dgeometrysink__close">\</a>  CD2DGeometrySink::Close  
 Closes the geometry sink  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if successful; otherwise FALSE.  
  
##  \<a name="cd2dgeometrysink__endfigure">\</a>  CD2DGeometrySink::EndFigure  
 Ends the current figure; optionally, closes it.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 A value that indicates whether the current figure is closed. If the figure is closed, a line is drawn between the current point and the start point specified by BeginFigure.  
  
##  \<a name="cd2dgeometrysink__get">\</a>  CD2DGeometrySink::Get  
 Returns ID2D1GeometrySink interface  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to an ID2D1GeometrySink interface or NULL if object is not initialized yet.  
  
##  \<a name="cd2dgeometrysink__isvalid">\</a>  CD2DGeometrySink::IsValid  
 Checks geometry sink validity  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 TRUE if geometry sink is valid; otherwise FALSE.  
  
##  \<a name="cd2dgeometrysink__m_psink">\</a>  CD2DGeometrySink::m_pSink  
 A pointer to an ID2D1GeometrySink.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
##  \<a name="cd2dgeometrysink__operator_id2d1geometrysink_star">\</a>  CD2DGeometrySink::operator ID2D1GeometrySink*  
 Returns ID2D1GeometrySink interface  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to an ID2D1GeometrySink interface or NULL if object is not initialized yet.  
  
##  \<a name="cd2dgeometrysink__setfillmode">\</a>  CD2DGeometrySink::SetFillMode  
 Specifies the method used to determine which points are inside the geometry described by this geometry sink and which points are outside.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The method used to determine whether a given point is part of the geometry.  
  
##  \<a name="cd2dgeometrysink__setsegmentflags">\</a>  CD2DGeometrySink::SetSegmentFlags  
 Specifies stroke and join options to be applied to new segments added to the geometry sink.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Stroke and join options to be applied to new segments added to the geometry sink.  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)