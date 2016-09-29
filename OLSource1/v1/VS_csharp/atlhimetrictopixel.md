---
title: "AtlHiMetricToPixel"
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
  - "ATL::AtlHiMetricToPixel"
  - "AtlHiMetricToPixel"
  - "ATL.AtlHiMetricToPixel"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlHiMetricToPixel function"
ms.assetid: 00c3af58-7298-4082-9a2e-5b68a8cec6fd
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlHiMetricToPixel
Converts an object's size in HIMETRIC units (each unit is 0.01 millimeter) to a size in pixels on the screen device.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
      extern void AtlHiMetricToPixel(  
const SIZEL* lpSizeInHiMetric,  
LPSIZEL lpSizeInPix   
);  
```  
  
#### Parameters  
 `lpSizeInHiMetric`  
 [in] Pointer to the size of the object in HIMETRIC units.  
  
 `lpSizeInPix`  
 [out] Pointer to where the object's size in pixels is to be returned.  
  
## Example  
 [!code[NVC_ATL_COM#49](../VS_csharp/codesnippet/CPP/atlhimetrictopixel_1.cpp)]  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [AtlPixelToHiMetric](../VS_csharp/atlpixeltohimetric.md)   
 [Pixel/HIMETRIC Conversion Global Functions](../VS_csharp/pixel-himetric-conversion-global-functions.md)