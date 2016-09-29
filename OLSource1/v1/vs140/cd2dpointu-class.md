---
title: "CD2DPointU Class"
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
  - "CD2DPointU"
  - "afxrendertarget/CD2DPointU"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DPointU class"
ms.assetid: 04733f96-b6de-4a89-82e3-caad1e8087a9
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DPointU Class
A wrapper for `D2D1_POINT_2U`.  
  
## Syntax  
  
```  
class CD2DPointU : public D2D1_POINT_2U;  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DPointU::CD2DPointU](#cd2dpointu__cd2dpointu)|Overloaded. Constructs a `CD2DPointU` from object `D2D1_POINT_2U` object.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DPointU::operator CPoint](#cd2dpointu__operator_cpoint)|Converts `CD2DPointU` to `CPoint` object.|  
  
## Inheritance Hierarchy  
 `D2D1_POINT_2U`  
  
 [CD2DPointU](../vs140/cd2dpointu-class.md)  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
##  <a name="cd2dpointu__cd2dpointu"></a>  CD2DPointU::CD2DPointU  
 Constructs a CD2DPointU object from CPoint object.  
  
```  
CD2DPointU(  
   const CPoint& pt  
);  
CD2DPointU(  
   const D2D1_POINT_2U& pt  
);  
CD2DPointU(  
   const D2D1_POINT_2U* pt  
);  
CD2DPointU(  
   UINT32 uX = 0,  
   UINT32 uY = 0  
);  
```  
  
### Parameters  
 `pt`  
 source point  
  
 `uX`  
 source X  
  
 `uY`  
 source Y  
  
##  <a name="cd2dpointu__operator_cpoint"></a>  CD2DPointU::operator CPoint  
 Converts CD2DPointU to CPoint object.  
  
```  
operator CPoint();  
```  
  
### Return Value  
 Current value of D2D point.  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)