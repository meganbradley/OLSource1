---
title: "COleControl::AmbientScaleUnits"
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
  - AmbientScaleUnits
  - COleControl.AmbientScaleUnits
  - COleControl::AmbientScaleUnits
dev_langs: 
  - C++
helpviewer_keywords: 
  - AmbientScaleUnits method
ms.assetid: e4871dd8-41f6-4727-ad69-6b60e8d24185
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleControl::AmbientScaleUnits
Returns the type of units used by the container.  
  
## Syntax  
  
```  
  
CString AmbientScaleUnits( );  
```  
  
## Return Value  
 A string containing the ambient ScaleUnits of the container. If this property is not supported, this function returns a zero-length string.  
  
## Remarks  
 The container's ambient ScaleUnits property can be used to display positions or dimensions, labeled with the chosen unit, such as twips or centimeters. Note that the container is not required to support this property.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::TransformCoords](../vs140/colecontrol--transformcoords.md)