---
title: "CScrollView::SetScaleToFitSize"
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
  - "SetScaleToFitSize"
  - "CScrollView::SetScaleToFitSize"
  - "CScrollView.SetScaleToFitSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CScrollView class, operations"
  - "SetScaleToFitSize method"
ms.assetid: ca8d38c8-e9d8-4462-a394-03b859975850
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CScrollView::SetScaleToFitSize
Call `SetScaleToFitSize` when you want to scale the viewport size to the current window size automatically.  
  
## Syntax  
  
```  
  
      void SetScaleToFitSize(  
   SIZE sizeTotal   
);  
```  
  
#### Parameters  
 `sizeTotal`  
 The horizontal and vertical sizes to which the view is to be scaled. The scroll view's size is measured in logical units. The horizontal size is contained in the **cx** member. The vertical size is contained in the **cy** member. Both **cx** and **cy** must be greater than or equal to 0.  
  
## Remarks  
 With scroll bars, only a portion of the logical view may be visible at any time. But with the scale-to-fit capability, the view has no scroll bars and the logical view is stretched or shrunk to exactly fit the window's client area. When the window is resized, the view draws its data at a new scale based on the size of the window.  
  
 You'll typically place the call to `SetScaleToFitSize` in your override of the view's `OnInitialUpdate` member function. If you do not want automatic scaling, call the `SetScrollSizes` member function instead.  
  
 `SetScaleToFitSize` can be used to implement a "Zoom to Fit" operation. Use `SetScrollSizes` to reinitialize scrolling.  
  
 `SetScaleToFitSize` assumes that the size of the view window has been set. If the view window size has not been set when `SetScaleToFitSize` is called, you will get an assertion. To ensure that this does not happen, make the following call before calling `SetScaleToFitSize`:  
  
 [!code[NVC_MFCDocView#165](../vs140/codesnippet/CPP/cscrollview--setscaletofitsize_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CScrollView Class](../vs140/cscrollview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CScrollView::SetScrollSizes](../vs140/cscrollview--setscrollsizes.md)   
 [CView::OnInitialUpdate](../vs140/cview--oninitialupdate.md)