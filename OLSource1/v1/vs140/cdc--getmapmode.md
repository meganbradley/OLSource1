---
title: "CDC::GetMapMode"
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
  - CDC::GetMapMode
  - GetMapMode
  - CDC.GetMapMode
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDC class, mapping functions
  - GetMapMode method
ms.assetid: c84f7e08-e965-44e0-acb3-3d74e463db2a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::GetMapMode
Retrieves the current mapping mode.  
  
## Syntax  
  
```  
  
int GetMapMode( ) const;  
```  
  
## Return Value  
 The mapping mode.  
  
## Remarks  
 For a description of the mapping modes, see the `SetMapMode` member function.  
  
> [!NOTE]
>  If you call [SetLayout](../vs140/cdc--setlayout.md) to change the DC to right-to-left layout, **SetLayout** automatically changes the mapping mode to `MM_ISOTROPIC`. Consequently, any subsequent call to `GetMapMode` will return `MM_ISOTROPIC`.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SetMapMode](../vs140/cdc--setmapmode.md)   
 [CDC::GetLayout](../vs140/cdc--getlayout.md)   
 [GetMapMode](http://msdn.microsoft.com/library/windows/desktop/dd144897)