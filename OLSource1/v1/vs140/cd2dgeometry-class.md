---
title: "CD2DGeometry Class"
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
  - "CD2DGeometry"
  - "afxrendertarget/CD2DGeometry"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DGeometry class"
ms.assetid: 3f95054b-fdb8-4e87-87f2-9fc3df7279ec
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DGeometry Class
A wrapper for ID2D1Geometry.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DGeometry::CD2DGeometry](#cd2dgeometry__cd2dgeometry)|Constructs a CD2DGeometry object.|  
|[CD2DGeometry::~CD2DGeometry](#cd2dgeometry___dtorcd2dgeometry)|The destructor. Called when a D2D geometry object is being destroyed.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DGeometry::Attach](#cd2dgeometry__attach)|Attaches existing resource interface to the object|  
|[CD2DGeometry::CombineWithGeometry](#cd2dgeometry__combinewithgeometry)|Combines this geometry with the specified geometry and stores the result in an ID2D1SimplifiedGeometrySink.|  
|[CD2DGeometry::CompareWithGeometry](#cd2dgeometry__comparewithgeometry)|Describes the intersection between this geometry and the specified geometry. The comparison is performed using the specified flattening tolerance.|  
|[CD2DGeometry::ComputeArea](#cd2dgeometry__computearea)|Computes the area of the geometry after it has been transformed by the specified matrix and flattened using the specified tolerance.|  
|[CD2DGeometry::ComputeLength](#cd2dgeometry__computelength)|Calculates the length of the geometry as though each segment were unrolled into a line.|  
|[CD2DGeometry::ComputePointAtLength](#cd2dgeometry__computepointatlength)|Calculates the point and tangent vector at the specified distance along the geometry after it has been transformed by the specified matrix and flattened using the specified tolerance.|  
|[CD2DGeometry::Destroy](#cd2dgeometry__destroy)|Destroys a CD2DGeometry object. (Overrides [CD2DResource::Destroy](../vs140/cd2dresource-class.md#cd2dresource__destroy).)|  
|[CD2DGeometry::Detach](#cd2dgeometry__detach)|Detaches resource interface from the object|  
|[CD2DGeometry::FillContainsPoint](#cd2dgeometry__fillcontainspoint)|Indicates whether the area filled by the geometry would contain the specified point given the specified flattening tolerance.|  
|[CD2DGeometry::Get](#cd2dgeometry__get)|Returns ID2D1Geometry interface|  
|[CD2DGeometry::GetBounds](#cd2dgeometry__getbounds)||  
|[CD2DGeometry::GetWidenedBounds](#cd2dgeometry__getwidenedbounds)|Gets the bounds of the geometry after it has been widened by the specified stroke width and style and transformed by the specified matrix.|  
|[CD2DGeometry::IsValid](#cd2dgeometry__isvalid)|Checks resource validity (Overrides [CD2DResource::IsValid](../vs140/cd2dresource-class.md#cd2dresource__isvalid).)|  
|[CD2DGeometry::Outline](#cd2dgeometry__outline)|Computes the outline of the geometry and writes the result to an ID2D1SimplifiedGeometrySink.|  
|[CD2DGeometry::Simplify](#cd2dgeometry__simplify)|Creates a simplified version of the geometry that contains only lines and (optionally) cubic Bezier curves and writes the result to an ID2D1SimplifiedGeometrySink.|  
|[CD2DGeometry::StrokeContainsPoint](#cd2dgeometry__strokecontainspoint)|Determines whether the geometry's stroke contains the specified point given the specified stroke thickness, style, and transform.|  
|[CD2DGeometry::Tessellate](#cd2dgeometry__tessellate)|Creates a set of clockwise-wound triangles that cover the geometry after it has been transformed using the specified matrix and flattened using the specified tolerance.|  
|[CD2DGeometry::Widen](#cd2dgeometry__widen)|Widens the geometry by the specified stroke and writes the result to an ID2D1SimplifiedGeometrySink after it has been transformed by the specified matrix and flattened using the specified tolerance.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DGeometry::operator ID2D1Geometry*](#cd2dgeometry__operator_id2d1geometry_star)|Returns ID2D1Geometry interface|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DGeometry::m_pGeometry](#cd2dgeometry__m_pgeometry)|A pointer to an ID2D1Geometry.|  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CD2DResource](../vs140/cd2dresource-class.md)  
  
 [CD2DGeometry](../vs140/cd2dgeometry-class.md)  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
##  \<a name="cd2dgeometry___dtorcd2dgeometry">\</a>  CD2DGeometry::~CD2DGeometry  
 The destructor. Called when a D2D geometry object is being destroyed.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cd2dgeometry__attach">\</a>  CD2DGeometry::Attach  
 Attaches existing resource interface to the object  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Existing resource interface. Cannot be NULL  
  
##  \<a name="cd2dgeometry__cd2dgeometry">\</a>  CD2DGeometry::CD2DGeometry  
 Constructs a CD2DGeometry object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 A pointer to the render target.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Indicates that the object will be destroyed by owner (pParentTarget).  
  
##  \<a name="cd2dgeometry__combinewithgeometry">\</a>  CD2DGeometry::CombineWithGeometry  
 Combines this geometry with the specified geometry and stores the result in an ID2D1SimplifiedGeometrySink.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The geometry to combine with this instance.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 The type of combine operation to perform.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 The transform to apply to inputGeometry before combining.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The result of the combine operation.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The maximum bounds on the distance between points in the polygonal approximation of the geometries. Smaller values produce more accurate results but cause slower execution.  
  
### Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
##  \<a name="cd2dgeometry__comparewithgeometry">\</a>  CD2DGeometry::CompareWithGeometry  
 Describes the intersection between this geometry and the specified geometry. The comparison is performed using the specified flattening tolerance.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The geometry to test.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The transform to apply to inputGeometry.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The maximum bounds on the distance between points in the polygonal approximation of the geometries. Smaller values produce more accurate results but cause slower execution.  
  
### Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
##  \<a name="cd2dgeometry__computearea">\</a>  CD2DGeometry::ComputeArea  
 Computes the area of the geometry after it has been transformed by the specified matrix and flattened using the specified tolerance.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 The transform to apply to this geometry before computing its area.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 When this method returns, contains a pointer to the area of the transformed, flattened version of this geometry. You must allocate storage for this parameter.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The maximum bounds on the distance between points in the polygonal approximation of the geometry. Smaller values produce more accurate results but cause slower execution.  
  
### Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
##  \<a name="cd2dgeometry__computelength">\</a>  CD2DGeometry::ComputeLength  
 Calculates the length of the geometry as though each segment were unrolled into a line.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The transform to apply to the geometry before calculating its length.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 When this method returns, contains a pointer to the length of the geometry. For closed geometries, the length includes an implicit closing segment. You must allocate storage for this parameter.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The maximum bounds on the distance between points in the polygonal approximation of the geometry. Smaller values produce more accurate results but cause slower execution.  
  
### Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
##  \<a name="cd2dgeometry__computepointatlength">\</a>  CD2DGeometry::ComputePointAtLength  
 Calculates the point and tangent vector at the specified distance along the geometry after it has been transformed by the specified matrix and flattened using the specified tolerance.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 The distance along the geometry of the point and tangent to find. If this distance is less then 0, this method calculates the first point in the geometry. If this distance is greater than the length of the geometry, this method calculates the last point in the geometry.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The transform to apply to the geometry before calculating the specified point and tangent.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 The location at the specified distance along the geometry. If the geometry is empty, this point contains NaN as its x and y values.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 When this method returns, contains a pointer to the tangent vector at the specified distance along the geometry. If the geometry is empty, this vector contains NaN as its x and y values. You must allocate storage for this parameter.  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 The maximum bounds on the distance between points in the polygonal approximation of the geometry. Smaller values produce more accurate results but cause slower execution.  
  
### Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
##  \<a name="cd2dgeometry__destroy">\</a>  CD2DGeometry::Destroy  
 Destroys a CD2DGeometry object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="cd2dgeometry__detach">\</a>  CD2DGeometry::Detach  
 Detaches resource interface from the object  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to detached resource interface.  
  
##  \<a name="cd2dgeometry__fillcontainspoint">\</a>  CD2DGeometry::FillContainsPoint  
 Indicates whether the area filled by the geometry would contain the specified point given the specified flattening tolerance.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 The point to test.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 The transform to apply to the geometry prior to testing for containment.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 When this method returns, contains a bool value that is TRUE if the area filled by the geometry contains point; otherwise, FALSE. You must allocate storage for this parameter.  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 The numeric accuracy with which the precise geometric path and path intersection is calculated. Points missing the fill by less than the tolerance are still considered inside. Smaller values produce more accurate results but cause slower execution.  
  
### Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
##  \<a name="cd2dgeometry__get">\</a>  CD2DGeometry::Get  
 Returns ID2D1Geometry interface  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to an ID2D1Geometry interface or NULL if object is not initialized yet.  
  
##  \<a name="cd2dgeometry__getbounds">\</a>  CD2DGeometry::GetBounds  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
  
### Return Value  
  
##  \<a name="cd2dgeometry__getwidenedbounds">\</a>  CD2DGeometry::GetWidenedBounds  
 Gets the bounds of the geometry after it has been widened by the specified stroke width and style and transformed by the specified matrix.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 The amount by which to widen the geometry by stroking its outline.  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 The style of the stroke that widens the geometry.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 A transform to apply to the geometry after the geometry is transformed and after the geometry has been stroked.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 When this method returns, contains the bounds of the widened geometry. You must allocate storage for this parameter.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 The maximum bounds on the distance between points in the polygonal approximation of the geometries. Smaller values produce more accurate results but cause slower execution.  
  
### Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
##  \<a name="cd2dgeometry__isvalid">\</a>  CD2DGeometry::IsValid  
 Checks resource validity  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 TRUE if resource is valid; otherwise FALSE.  
  
##  \<a name="cd2dgeometry__m_pgeometry">\</a>  CD2DGeometry::m_pGeometry  
 A pointer to an ID2D1Geometry.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
##  \<a name="cd2dgeometry__operator_id2d1geometry_star">\</a>  CD2DGeometry::operator ID2D1Geometry*  
 Returns ID2D1Geometry interface  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to an ID2D1Geometry interface or NULL if object is not initialized yet.  
  
##  \<a name="cd2dgeometry__outline">\</a>  CD2DGeometry::Outline  
 Computes the outline of the geometry and writes the result to an ID2D1SimplifiedGeometrySink.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 The transform to apply to the geometry outline.  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 The ID2D1SimplifiedGeometrySink to which the geometry transformed outline is appended.  
  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 The maximum bounds on the distance between points in the polygonal approximation of the geometry. Smaller values produce more accurate results but cause slower execution.  
  
### Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
##  \<a name="cd2dgeometry__simplify">\</a>  CD2DGeometry::Simplify  
 Creates a simplified version of the geometry that contains only lines and (optionally) cubic Bezier curves and writes the result to an ID2D1SimplifiedGeometrySink.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 A value that specifies whether the simplified geometry should contain curves.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 The transform to apply to the simplified geometry.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 The ID2D1SimplifiedGeometrySink to which the simplified geometry is appended.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 The maximum bounds on the distance between points in the polygonal approximation of the geometry. Smaller values produce more accurate results but cause slower execution.  
  
### Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
##  \<a name="cd2dgeometry__strokecontainspoint">\</a>  CD2DGeometry::StrokeContainsPoint  
 Determines whether the geometry's stroke contains the specified point given the specified stroke thickness, style, and transform.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 The point to test for containment.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 The thickness of the stroke to apply.  
  
 <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>  
 The style of the stroke to apply.  
  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 The transform to apply to the stroked geometry.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 When this method returns, contains a boolean value set to TRUE if the geometry's stroke contains the specified point; otherwise, FALSE. You must allocate storage for this parameter.  
  
 <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
 The numeric accuracy with which the precise geometric path and path intersection is calculated. Points missing the stroke by less than the tolerance are still considered inside. Smaller values produce more accurate results but cause slower execution.  
  
### Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
##  \<a name="cd2dgeometry__tessellate">\</a>  CD2DGeometry::Tessellate  
 Creates a set of clockwise-wound triangles that cover the geometry after it has been transformed using the specified matrix and flattened using the specified tolerance.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 The transform to apply to this geometry, or NULL.  
  
 <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
 The ID2D1TessellationSink to which the tessellated is appended.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 The maximum bounds on the distance between points in the polygonal approximation of the geometry. Smaller values produce more accurate results but cause slower execution.  
  
### Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
##  \<a name="cd2dgeometry__widen">\</a>  CD2DGeometry::Widen  
 Widens the geometry by the specified stroke and writes the result to an ID2D1SimplifiedGeometrySink after it has been transformed by the specified matrix and flattened using the specified tolerance.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 The amount by which to widen the geometry.  
  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>  
 The style of stroke to apply to the geometry, or NULL.  
  
 <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>  
 The transform to apply to the geometry after widening it.  
  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 The ID2D1SimplifiedGeometrySink to which the widened geometry is appended.  
  
 <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>  
 The maximum bounds on the distance between points in the polygonal approximation of the geometry. Smaller values produce more accurate results but cause slower execution.  
  
### Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)