---
title: "CDC::GetPolyFillMode"
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
  - GetPolyFillMode
  - CDC::GetPolyFillMode
  - CDC.GetPolyFillMode
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetPolyFillMode method
  - CDC class, drawing-attribute functions
ms.assetid: 432f6a3a-61b6-4ee6-a72c-62ef327feac4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::GetPolyFillMode
Retrieves the current polygon-filling mode.  
  
## Syntax  
  
```  
  
int GetPolyFillMode( ) const;  
```  
  
## Return Value  
 The current polygon-filled mode, **ALTERNATE** or **WINDING**, if the function is successful.  
  
## Remarks  
 See the `SetPolyFillMode` member function for a description of the polygon-filling modes.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SetPolyFillMode](../vs140/cdc--setpolyfillmode.md)   
 [GetPolyFillMode](http://msdn.microsoft.com/library/windows/desktop/dd144910)