---
title: "CScrollView::ScrollToPosition"
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
  - "CScrollView::ScrollToPosition"
  - "CScrollView.ScrollToPosition"
  - "ScrollToPosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CScrollView class, operations"
  - "ScrollToPosition method"
ms.assetid: dfd050bd-b96d-4fc9-8e30-7a137f0ba12d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CScrollView::ScrollToPosition
Call <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to scroll to a given point in the view.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The point to scroll to, in logical units. The **x** member must be a positive value (greater than or equal to 0, up to the total size of the view). The same is true for the **y** member when the mapping mode is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. The **y** member is negative in mapping modes other than <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 The view will be scrolled so that this point is at the upper-left corner of the window. This member function must not be called if the view is scaled to fit.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CScrollView Class](../vs140/cscrollview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CScrollView::GetDeviceScrollPosition](../vs140/cscrollview--getdevicescrollposition.md)   
 [CScrollView::SetScaleToFitSize](../vs140/cscrollview--setscaletofitsize.md)   
 [CScrollView::SetScrollSizes](../vs140/cscrollview--setscrollsizes.md)