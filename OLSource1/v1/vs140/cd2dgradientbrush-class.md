---
title: "CD2DGradientBrush Class"
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
  - "CD2DGradientBrush"
  - "afxrendertarget/CD2DGradientBrush"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DGradientBrush class"
ms.assetid: 5bf133e6-16b7-4e3a-845d-0ce63fafe5ec
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DGradientBrush Class
The base class of the CD2DLinearGradientBrush and the CD2DRadialGradientBrush classes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DGradientBrush::CD2DGradientBrush](#cd2dgradientbrush__cd2dgradientbrush)|Constructs a CD2DGradientBrush object.|  
|[CD2DGradientBrush::~CD2DGradientBrush](#cd2dgradientbrush__~cd2dgradientbrush)|The destructor. Called when a D2D gradient brush object is being destroyed.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DGradientBrush::Destroy](#cd2dgradientbrush__destroy)|Destroys a CD2DGradientBrush object. (Overrides [CD2DBrush::Destroy](../vs140/cd2dbrush-class.md#cd2dbrush__destroy).)|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DGradientBrush::m_arGradientStops](#cd2dgradientbrush__m_argradientstops)|Array of the D2D1_GRADIENT_STOP structures.|  
|[CD2DGradientBrush::m_colorInterpolationGamma](#cd2dgradientbrush__m_colorinterpolationgamma)|The space in which color interpolation between the gradient stops is performed.|  
|[CD2DGradientBrush::m_extendMode](#cd2dgradientbrush__m_extendmode)|The behavior of the gradient outside the [0,1] normalized range.|  
|[CD2DGradientBrush::m_pGradientStops](#cd2dgradientbrush__m_pgradientstops)|A pointer to an array of D2D1_GRADIENT_STOP structures.|  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CD2DResource](../vs140/cd2dresource-class.md)  
  
 [CD2DBrush](../vs140/cd2dbrush-class.md)  
  
 [CD2DGradientBrush](../vs140/cd2dgradientbrush-class.md)  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
##  \<a name="cd2dgradientbrush___dtorcd2dgradientbrush">\</a>  CD2DGradientBrush::~CD2DGradientBrush  
 The destructor. Called when a D2D gradient brush object is being destroyed.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cd2dgradientbrush__cd2dgradientbrush">\</a>  CD2DGradientBrush::CD2DGradientBrush  
 Constructs a CD2DGradientBrush object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 A pointer to the render target.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A pointer to an array of D2D1_GRADIENT_STOP structures.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 A value greater than or equal to 1 that specifies the number of gradient stops in the gradientStops array.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The space in which color interpolation between the gradient stops is performed.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The behavior of the gradient outside the [0,1] normalized range.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 A pointer to the opacity and transformation of a brush.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Indicates that the object will be destroyed by owner (pParentTarget).  
  
##  \<a name="cd2dgradientbrush__destroy">\</a>  CD2DGradientBrush::Destroy  
 Destroys a CD2DGradientBrush object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="cd2dgradientbrush__m_argradientstops">\</a>  CD2DGradientBrush::m_arGradientStops  
 Array of the D2D1_GRADIENT_STOP structures.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="cd2dgradientbrush__m_colorinterpolationgamma">\</a>  CD2DGradientBrush::m_colorInterpolationGamma  
 The space in which color interpolation between the gradient stops is performed.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="cd2dgradientbrush__m_extendmode">\</a>  CD2DGradientBrush::m_extendMode  
 The behavior of the gradient outside the [0,1] normalized range.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="cd2dgradientbrush__m_pgradientstops">\</a>  CD2DGradientBrush::m_pGradientStops  
 A pointer to an array of D2D1_GRADIENT_STOP structures.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)