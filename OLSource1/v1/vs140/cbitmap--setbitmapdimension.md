---
title: "CBitmap::SetBitmapDimension"
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
  - CBitmap::SetBitmapDimension
  - CBitmap.SetBitmapDimension
  - SetBitmapDimension
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetBitmapDimension method
ms.assetid: 0ba464f7-d3e0-43a0-95d0-1776dca55338
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CBitmap::SetBitmapDimension
Assigns a width and height to a bitmap in 0.1-millimeter units.  
  
## Syntax  
  
```  
  
      CSize SetBitmapDimension(  
   int nWidth,  
   int nHeight   
);  
```  
  
#### Parameters  
 `nWidth`  
 Specifies the width of the bitmap (in 0.1-millimeter units).  
  
 `nHeight`  
 Specifies the height of the bitmap (in 0.1-millimeter units).  
  
## Return Value  
 The previous bitmap dimensions. Height is in the **cy** member variable of the `CSize` object, and width is in the **cx** member variable.  
  
## Remarks  
 The GDI does not use these values except to return them when an application calls the [GetBitmapDimension](../vs140/cbitmap--getbitmapdimension.md) member function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CBitmap Class](../vs140/cbitmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBitmap::GetBitmapDimension](../vs140/cbitmap--getbitmapdimension.md)