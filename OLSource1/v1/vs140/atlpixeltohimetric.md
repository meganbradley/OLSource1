---
title: "AtlPixelToHiMetric"
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
  - "ATL.AtlPixelToHiMetric"
  - "ATL::AtlPixelToHiMetric"
  - "AtlPixelToHiMetric"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlPixelToHiMetric function"
ms.assetid: a0bd0c50-7ce9-4c62-9642-bcbd7c79a071
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlPixelToHiMetric
Converts an object's size in pixels on the screen device to a size in HIMETRIC units (each unit is 0.01 millimeter).  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
      extern void AtlPixelToHiMetric(  
const SIZEL* lpSizeInPix,  
LPSIZEL lpSizeInHiMetric   
);  
```  
  
#### Parameters  
 `lpSizeInPix`  
 [in] Pointer to the object's size in pixels.  
  
 `lpSizeInHiMetric`  
 [out] Pointer to where the object's size in HIMETRIC units is to be returned.  
  
## Example  
 [!code[NVC_ATL_COM#51](../vs140/codesnippet/CPP/atlpixeltohimetric_1.cpp)]  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [Pixel/HIMETRIC Conversion Global Functions](../vs140/pixel-himetric-conversion-global-functions.md)   
 [AtlHiMetricToPixel](../vs140/atlhimetrictopixel.md)