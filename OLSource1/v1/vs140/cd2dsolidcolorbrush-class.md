---
title: "CD2DSolidColorBrush Class"
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
  - "CD2DSolidColorBrush"
  - "afxrendertarget/CD2DSolidColorBrush"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DSolidColorBrush class"
ms.assetid: d4506637-acce-4f74-8a9b-f0a45571a735
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DSolidColorBrush Class
A wrapper for ID2D1SolidColorBrush.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DSolidColorBrush::CD2DSolidColorBrush](#cd2dsolidcolorbrush__cd2dsolidcolorbrush)|Overloaded. Constructs a CD2DSolidColorBrush object.|  
|[CD2DSolidColorBrush::~CD2DSolidColorBrush](#cd2dsolidcolorbrush__~cd2dsolidcolorbrush)|The destructor. Called when a D2D solid brush object is being destroyed.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DSolidColorBrush::Attach](#cd2dsolidcolorbrush__attach)|Attaches existing resource interface to the object|  
|[CD2DSolidColorBrush::Create](#cd2dsolidcolorbrush__create)|Creates a CD2DSolidColorBrush. (Overrides [CD2DResource::Create](../vs140/cd2dresource-class.md#cd2dresource__create).)|  
|[CD2DSolidColorBrush::Destroy](#cd2dsolidcolorbrush__destroy)|Destroys a CD2DSolidColorBrush object. (Overrides [CD2DBrush::Destroy](../vs140/cd2dbrush-class.md#cd2dbrush__destroy).)|  
|[CD2DSolidColorBrush::Detach](#cd2dsolidcolorbrush__detach)|Detaches resource interface from the object|  
|[CD2DSolidColorBrush::Get](#cd2dsolidcolorbrush__get)|Returns ID2D1SolidColorBrush interface|  
|[CD2DSolidColorBrush::GetColor](#cd2dsolidcolorbrush__getcolor)|Retrieves the color of the solid color brush|  
|[CD2DSolidColorBrush::SetColor](#cd2dsolidcolorbrush__setcolor)|Specifies the color of this solid color brush|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DSolidColorBrush::operator ID2D1SolidColorBrush*](#cd2dsolidcolorbrush__operator_id2d1solidcolorbrush_star)|Returns ID2D1SolidColorBrush interface|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DSolidColorBrush::m_colorSolid](#cd2dsolidcolorbrush__m_colorsolid)|Brush solid color.|  
|[CD2DSolidColorBrush::m_pSolidColorBrush](#cd2dsolidcolorbrush__m_psolidcolorbrush)|Stores a pointer to an ID2D1SolidColorBrush object.|  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CD2DResource](../vs140/cd2dresource-class.md)  
  
 [CD2DBrush](../vs140/cd2dbrush-class.md)  
  
 [CD2DSolidColorBrush](../vs140/cd2dsolidcolorbrush-class.md)  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
##  \<a name="cd2dsolidcolorbrush___dtorcd2dsolidcolorbrush">\</a>  CD2DSolidColorBrush::~CD2DSolidColorBrush  
 The destructor. Called when a D2D solid brush object is being destroyed.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cd2dsolidcolorbrush__attach">\</a>  CD2DSolidColorBrush::Attach  
 Attaches existing resource interface to the object  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Existing resource interface. Cannot be NULL  
  
##  \<a name="cd2dsolidcolorbrush__cd2dsolidcolorbrush">\</a>  CD2DSolidColorBrush::CD2DSolidColorBrush  
 Constructs a CD2DSolidColorBrush object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 A pointer to the render target.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The red, green, blue, and alpha values of the brush's color.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 A pointer to the opacity and transformation of a brush.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Indicates that the object will be destroyed by owner (pParentTarget).  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The opacity of the brush's color.  
  
##  \<a name="cd2dsolidcolorbrush__create">\</a>  CD2DSolidColorBrush::Create  
 Creates a CD2DSolidColorBrush.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 A pointer to the render target.  
  
### Return Value  
 If the method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.  
  
##  \<a name="cd2dsolidcolorbrush__destroy">\</a>  CD2DSolidColorBrush::Destroy  
 Destroys a CD2DSolidColorBrush object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="cd2dsolidcolorbrush__detach">\</a>  CD2DSolidColorBrush::Detach  
 Detaches resource interface from the object  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to detached resource interface.  
  
##  \<a name="cd2dsolidcolorbrush__get">\</a>  CD2DSolidColorBrush::Get  
 Returns ID2D1SolidColorBrush interface  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to an ID2D1SolidColorBrush interface or NULL if object is not initialized yet.  
  
##  \<a name="cd2dsolidcolorbrush__getcolor">\</a>  CD2DSolidColorBrush::GetColor  
 Retrieves the color of the solid color brush  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 The color of this solid color brush  
  
##  \<a name="cd2dsolidcolorbrush__m_colorsolid">\</a>  CD2DSolidColorBrush::m_colorSolid  
 Brush solid color.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="cd2dsolidcolorbrush__m_psolidcolorbrush">\</a>  CD2DSolidColorBrush::m_pSolidColorBrush  
 Stores a pointer to an ID2D1SolidColorBrush object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="cd2dsolidcolorbrush__operator_id2d1solidcolorbrush_star">\</a>  CD2DSolidColorBrush::operator ID2D1SolidColorBrush*  
 Returns ID2D1SolidColorBrush interface  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to an ID2D1SolidColorBrush interface or NULL if object is not initialized yet.  
  
##  \<a name="cd2dsolidcolorbrush__setcolor">\</a>  CD2DSolidColorBrush::SetColor  
 Specifies the color of this solid color brush  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The color of this solid color brush  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)