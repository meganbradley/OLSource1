---
title: "CD2DLinearGradientBrush Class"
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
  - "afxrendertarget/CD2DLinearGradientBrush"
  - "CD2DLinearGradientBrush"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DLinearGradientBrush class"
ms.assetid: d4be9ff9-0ea8-45e6-9b8d-f3bc5673cbac
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DLinearGradientBrush Class
A wrapper for ID2D1LinearGradientBrush.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DLinearGradientBrush::CD2DLinearGradientBrush](#cd2dlineargradientbrush__cd2dlineargradientbrush)|Constructs a CD2DLinearGradientBrush object.|  
|[CD2DLinearGradientBrush::~CD2DLinearGradientBrush](#cd2dlineargradientbrush___dtorcd2dlineargradientbrush)|The destructor. Called when a D2D linear gradient brush object is being destroyed.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DLinearGradientBrush::Attach](#cd2dlineargradientbrush__attach)|Attaches existing resource interface to the object|  
|[CD2DLinearGradientBrush::Create](#cd2dlineargradientbrush__create)|Creates a CD2DLinearGradientBrush. (Overrides [CD2DResource::Create](../vs140/cd2dresource-class.md#cd2dresource__create).)|  
|[CD2DLinearGradientBrush::Destroy](#cd2dlineargradientbrush__destroy)|Destroys a CD2DLinearGradientBrush object. (Overrides [CD2DGradientBrush::Destroy](../vs140/cd2dgradientbrush-class.md#cd2dgradientbrush__destroy).)|  
|[CD2DLinearGradientBrush::Detach](#cd2dlineargradientbrush__detach)|Detaches resource interface from the object|  
|[CD2DLinearGradientBrush::Get](#cd2dlineargradientbrush__get)|Returns ID2D1LinearGradientBrush interface|  
|[CD2DLinearGradientBrush::GetEndPoint](#cd2dlineargradientbrush__getendpoint)|Retrieves the ending coordinates of the linear gradient|  
|[CD2DLinearGradientBrush::GetStartPoint](#cd2dlineargradientbrush__getstartpoint)|Retrieves the starting coordinates of the linear gradient|  
|[CD2DLinearGradientBrush::SetEndPoint](#cd2dlineargradientbrush__setendpoint)|Sets the ending coordinates of the linear gradient in the brush's coordinate space|  
|[CD2DLinearGradientBrush::SetStartPoint](#cd2dlineargradientbrush__setstartpoint)|Sets the starting coordinates of the linear gradient in the brush's coordinate space|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DLinearGradientBrush::operator ID2D1LinearGradientBrush*](#cd2dlineargradientbrush__operator_id2d1lineargradientbrush_star)|Returns ID2D1LinearGradientBrush interface|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DLinearGradientBrush::m_LinearGradientBrushProperties](#cd2dlineargradientbrush__m_lineargradientbrushproperties)|The start and end points of the gradient.|  
|[CD2DLinearGradientBrush::m_pLinearGradientBrush](#cd2dlineargradientbrush__m_plineargradientbrush)|A pointer to an ID2D1LinearGradientBrush.|  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CD2DResource](../vs140/cd2dresource-class.md)  
  
 [CD2DBrush](../vs140/cd2dbrush-class.md)  
  
 [CD2DGradientBrush](../vs140/cd2dgradientbrush-class.md)  
  
 [CD2DLinearGradientBrush](../vs140/cd2dlineargradientbrush-class.md)  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
##  \<a name="cd2dlineargradientbrush___dtorcd2dlineargradientbrush">\</a>  CD2DLinearGradientBrush::~CD2DLinearGradientBrush  
 The destructor. Called when a D2D linear gradient brush object is being destroyed.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cd2dlineargradientbrush__attach">\</a>  CD2DLinearGradientBrush::Attach  
 Attaches existing resource interface to the object  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Existing resource interface. Cannot be NULL  
  
##  \<a name="cd2dlineargradientbrush__cd2dlineargradientbrush">\</a>  CD2DLinearGradientBrush::CD2DLinearGradientBrush  
 Constructs a CD2DLinearGradientBrush object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 A pointer to the render target.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 A pointer to an array of D2D1_GRADIENT_STOP structures.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 A value greater than or equal to 1 that specifies the number of gradient stops in the gradientStops array.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The start and end points of the gradient.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The space in which color interpolation between the gradient stops is performed.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The behavior of the gradient outside the [0,1] normalized range.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 A pointer to the opacity and transformation of a brush.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Indicates that the object will be destroyed by owner (pParentTarget).  
  
##  \<a name="cd2dlineargradientbrush__create">\</a>  CD2DLinearGradientBrush::Create  
 Creates a CD2DLinearGradientBrush.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 A pointer to the render target.  
  
### Return Value  
 If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.  
  
##  \<a name="cd2dlineargradientbrush__destroy">\</a>  CD2DLinearGradientBrush::Destroy  
 Destroys a CD2DLinearGradientBrush object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="cd2dlineargradientbrush__detach">\</a>  CD2DLinearGradientBrush::Detach  
 Detaches resource interface from the object  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to detached resource interface.  
  
##  \<a name="cd2dlineargradientbrush__get">\</a>  CD2DLinearGradientBrush::Get  
 Returns ID2D1LinearGradientBrush interface  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to an ID2D1LinearGradientBrush interface or NULL if object is not initialized yet.  
  
##  \<a name="cd2dlineargradientbrush__getendpoint">\</a>  CD2DLinearGradientBrush::GetEndPoint  
 Retrieves the ending coordinates of the linear gradient  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 The ending two-dimensional coordinates of the linear gradient, in the brush's coordinate space  
  
##  \<a name="cd2dlineargradientbrush__getstartpoint">\</a>  CD2DLinearGradientBrush::GetStartPoint  
 Retrieves the starting coordinates of the linear gradient  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 The starting two-dimensional coordinates of the linear gradient, in the brush's coordinate space  
  
##  \<a name="cd2dlineargradientbrush__m_lineargradientbrushproperties">\</a>  CD2DLinearGradientBrush::m_LinearGradientBrushProperties  
 The start and end points of the gradient.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="cd2dlineargradientbrush__m_plineargradientbrush">\</a>  CD2DLinearGradientBrush::m_pLinearGradientBrush  
 A pointer to an ID2D1LinearGradientBrush.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="cd2dlineargradientbrush__operator_id2d1lineargradientbrush_star">\</a>  CD2DLinearGradientBrush::operator ID2D1LinearGradientBrush*  
 Returns ID2D1LinearGradientBrush interface  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to an ID2D1LinearGradientBrush interface or NULL if object is not initialized yet.  
  
##  \<a name="cd2dlineargradientbrush__setendpoint">\</a>  CD2DLinearGradientBrush::SetEndPoint  
 Sets the ending coordinates of the linear gradient in the brush's coordinate space  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 The ending two-dimensional coordinates of the linear gradient, in the brush's coordinate space  
  
##  \<a name="cd2dlineargradientbrush__setstartpoint">\</a>  CD2DLinearGradientBrush::SetStartPoint  
 Sets the starting coordinates of the linear gradient in the brush's coordinate space  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The starting two-dimensional coordinates of the linear gradient, in the brush's coordinate space  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)