---
title: "CDC::GetAspectRatioFilter"
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
  - GetAspectRatioFilter
  - CDC::GetAspectRatioFilter
  - CDC.GetAspectRatioFilter
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetAspectRatioFilter method
  - CDC class, font functions
ms.assetid: 97fdf519-0e98-4be1-847a-2387718046f2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::GetAspectRatioFilter
Retrieves the setting for the current aspect-ratio filter.  
  
## Syntax  
  
```  
  
CSize GetAspectRatioFilter( ) const;  
```  
  
## Return Value  
 A `CSize` object representing the aspect ratio used by the current aspect ratio filter.  
  
## Remarks  
 The aspect ratio is the ratio formed by a device's pixel width and height. Information about a device's aspect ratio is used in the creation, selection, and display of fonts. Windows provides a special filter, the aspect-ratio filter, to select fonts designed for a particular aspect ratio from all of the available fonts. The filter uses the aspect ratio specified by the `SetMapperFlags` member function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SetMapperFlags](../vs140/cdc--setmapperflags.md)   
 [CSize Class](../vs140/csize-class.md)