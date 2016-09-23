---
title: "CPalette::GetNearestPaletteIndex"
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
  - CPalette.GetNearestPaletteIndex
  - CPalette::GetNearestPaletteIndex
  - GetNearestPaletteIndex
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetNearestPaletteIndex method
  - color indexes
  - CPalette class, operations
  - indexes, colors
ms.assetid: aa405025-0c0d-4836-a602-d30423ba04e3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPalette::GetNearestPaletteIndex
Returns the index of the entry in the logical palette that most closely matches the specified color value.  
  
## Syntax  
  
```  
  
      UINT GetNearestPaletteIndex(  
   COLORREF crColor   
) const;  
```  
  
#### Parameters  
 `crColor`  
 Specifies the color to be matched.  
  
## Return Value  
 The index of an entry in a logical palette. The entry contains the color that most nearly matches the specified color.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CPalette Class](../vs140/cpalette-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [GetNearestPaletteIndex](http://msdn.microsoft.com/library/windows/desktop/dd144903)