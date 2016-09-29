---
title: "CD2DBrushProperties::CD2DBrushProperties"
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
  - "CD2DBrushProperties"
  - "afxrendertarget/CD2DBrushProperties::CD2DBrushProperties"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CD2DBrushProperties class, constructor"
ms.assetid: 8e68f5c0-b435-4269-9070-ad21f0334ff1
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DBrushProperties::CD2DBrushProperties
Creates a CD2D_BRUSH_PROPERTIES structure  
  
## Syntax  
  
```  
CD2DBrushProperties();  
CD2DBrushProperties(  
   FLOAT _opacity  
);  
CD2DBrushProperties(  
   D2D1_MATRIX_3X2_F _transform,  
   FLOAT _opacity = 1.  
);  
```  
  
#### Parameters  
 `_opacity`  
 The base opacity of the brush. The default value is 1.0.  
  
 `_transform`  
 The transformation to apply to the brush  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DBrushProperties Class](../vs140/cd2dbrushproperties-class.md)