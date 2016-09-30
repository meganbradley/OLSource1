---
title: "CD2DRoundedRect Class"
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
  - "afxrendertarget/CD2DRoundedRect"
  - "CD2DRoundedRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DRoundedRect class"
ms.assetid: 06207fb5-e92b-41c0-bceb-b45d8f466531
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DRoundedRect Class
A wrapper for `D2D1_ROUNDED_RECT`.  
  
## Syntax  
  
```  
class CD2DRoundedRect : public D2D1_ROUNDED_RECT;  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CD2DRoundedRect::CD2DRoundedRect](#cd2droundedrect__cd2droundedrect)|Overloaded. Constructs a `CD2DRoundedRect` object from `D2D1_ROUNDED_RECT` object.|  
  
## Inheritance Hierarchy  
 `D2D1_ROUNDED_RECT`  
  
 [CD2DRoundedRect](../vs140/cd2droundedrect-class.md)  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
##  \<a name="cd2droundedrect__cd2droundedrect"></a>  CD2DRoundedRect::CD2DRoundedRect  
 Constructs a CD2DRoundedRect object from CD2DRectF object.  
  
```  
CD2DRoundedRect(  
   const CD2DRectF& rectIn,  
   const CD2DSizeF& sizeRadius  
);  
CD2DRoundedRect(  
   const D2D1_ROUNDED_RECT& rectIn  
);  
CD2DRoundedRect(  
   const D2D1_ROUNDED_RECT* rectIn  
);  
```  
  
### Parameters  
 `rectIn`  
 source rectangle  
  
 `sizeRadius`  
 radius size  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)