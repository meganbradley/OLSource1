---
title: "CBitmap::GetBitmapDimension"
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
  - "CBitmap::GetBitmapDimension"
  - "CBitmap.GetBitmapDimension"
  - "GetBitmapDimension"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetBitmapDimension method"
ms.assetid: dc653659-6b7a-4abc-b0c5-7deecac03b1e
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBitmap::GetBitmapDimension
Returns the width and height of the bitmap.  
  
## Syntax  
  
```  
  
CSize GetBitmapDimension( ) const;  
```  
  
## Return Value  
 The width and height of the bitmap, measured in 0.1-millimeter units. The height is in the **cy** member of the `CSize` object, and the width is in the **cx** member. If the bitmap width and height have not been set by using `SetBitmapDimension`, the return value is 0.  
  
## Remarks  
 The height and width are assumed to have been set previously by using the [SetBitmapDimension](../vs140/cbitmap--setbitmapdimension.md) member function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CBitmap Class](../vs140/cbitmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBitmap::SetBitmapDimension](../vs140/cbitmap--setbitmapdimension.md)