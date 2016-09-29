---
title: "CD2DRectU Class"
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
  - "CD2DRectU"
  - "afxrendertarget/CD2DRectU"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DRectU class"
ms.assetid: a62f17d1-011d-4867-8f51-fd7e7c00561d
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DRectU Class
A wrapper for `D2D1_RECT_U`.  
  
## Syntax  
  
```  
class CD2DRectU : public D2D1_RECT_U;  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DRectU::CD2DRectU](#cd2drectu__cd2drectu)|Overloaded. Constructs a `CD2DRectU` object from `D2D1_RECT_U` object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DRectU::IsNull](#cd2drectu__isnull)|Returns a `boolean` value that indicates whether an expression contains no valid data ( `null`).|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DRectU::operator CRect](#cd2drectu__operator_crect)|Converts `CD2DRectU` to `CRect` object.|  
  
## Inheritance Hierarchy  
 `D2D1_RECT_U`  
  
 [CD2DRectU](../VS_csharp/cd2drectu-class.md)  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
##  <a name="cd2drectu__cd2drectu"></a>  CD2DRectU::CD2DRectU  
 Constructs a CD2DRectU object from CRect object.  
  
```  
CD2DRectU(  
   const CRect& rect  
);  
CD2DRectU(  
   const D2D1_RECT_U& rect  
);  
CD2DRectU(  
   const D2D1_RECT_U* rect  
);  
CD2DRectU(  
   UINT32 uLeft = 0,  
   UINT32 uTop = 0,  
   UINT32 uRight = 0,  
   UINT32 uBottom = 0  
);  
```  
  
### Parameters  
 `rect`  
 source rectangle  
  
 `uLeft`  
 source left coordinate  
  
 `uTop`  
 source top coordinate  
  
 `uRight`  
 source right coordinate  
  
 `uBottom`  
 source bottom coordinate  
  
##  <a name="cd2drectu__isnull"></a>  CD2DRectU::IsNull  
 Returns a Boolean value that indicates whether an expression contains no valid data (Null).  
  
```  
BOOL IsNull() const;  
```  
  
### Return Value  
 TRUE if rectangle's top, left, bottom, and right values are all equal to 0; otherwise FALSE.  
  
##  <a name="cd2drectu__operator_crect"></a>  CD2DRectU::operator CRect  
 Converts CD2DRectU to CRect object.  
  
```  
operator CRect();  
```  
  
### Return Value  
 Current value of D2D rectangle.  
  
## See Also  
 [MFC Classes](../VS_csharp/mfc-classes.md)