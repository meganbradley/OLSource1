---
title: "CDrawingManager::SmartMixColors"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - SmartMixColors
  - CDrawingManager::SmartMixColors
  - CDrawingManager.SmartMixColors
dev_langs: 
  - C++
helpviewer_keywords: 
  - SmartMixColors method
ms.assetid: 368f1059-3307-4714-97dc-dbd3ebec3dfe
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDrawingManager::SmartMixColors
Combines two colors based on a weighted ratio.  
  
## Syntax  
  
```  
static COLORREF __stdcall SmartMixColors(  
   COLORREF color1,  
   COLORREF color2,  
   double dblLumRatio = 1.,  
   int k1 = 1,  
   int k2 = 1  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] `color1`|The first color to mix.|  
|[in] `color2`|The second color to mix.|  
|[in] `dblLumRatio`|The ratio for the new color's luminosity. `SmartMixColors` multiplies the luminosity of the mixed color by this ratio before determining a final color.|  
|[in] `k1`|The weighted ratio for the first color.|  
|[in] `k2`|The weighted ratio for the second color.|  
  
## Return Value  
 A color that represents a weighted mixture of the supplied colors.  
  
## Remarks  
 This method fails with an error if either `k1` or `k2` is less than zero. If both of these parameters are set to 0, the method returns `RGB(0, 0, 0)`.  
  
 The weighted ratio is calculated with the following formula: (color1 * k1 + color2 \* k2)/(k1 + k2). After the weighted ratio is determined, the method calculates the luminosity for the mixed color. It then multiplies the luminosity by `dblLumRatio`. If the value is larger than 1.0, the method sets the luminosity for the mixed color to the new value. Otherwise, the luminosity is set to 1.0.  
  
## Requirements  
 **Header:** afxdrawmanager.h  
  
## See Also  
 [CDrawingManager Class](../vs140/cdrawingmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)