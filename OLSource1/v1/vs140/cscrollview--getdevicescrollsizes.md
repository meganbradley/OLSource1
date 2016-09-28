---
title: "CScrollView::GetDeviceScrollSizes"
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
  - "CScrollView::GetDeviceScrollSizes"
  - "CScrollView.GetDeviceScrollSizes"
  - "GetDeviceScrollSizes"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CScrollView class, operations"
  - "GetDeviceScrollSizes method"
ms.assetid: 84c68b3b-ae0e-421b-a73d-7448e9a31e2f
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CScrollView::GetDeviceScrollSizes
`GetDeviceScrollSizes` gets the current mapping mode, the total size, and the line and page sizes of the scrollable view.  
  
## Syntax  
  
```  
  
      void GetDeviceScrollSizes(  
   int& nMapMode,  
   SIZE& sizeTotal,  
   SIZE& sizePage,  
   SIZE& sizeLine   
) const;  
```  
  
#### Parameters  
 `nMapMode`  
 Returns the current mapping mode for this view. For a list of possible values, see `SetScrollSizes`.  
  
 `sizeTotal`  
 Returns the current total size of the scroll view in device units.  
  
 `sizePage`  
 Returns the current horizontal and vertical amounts to scroll in each direction in response to a mouse click in a scroll-bar shaft. The **cx** member contains the horizontal amount. The **cy** member contains the vertical amount.  
  
 `sizeLine`  
 Returns the current horizontal and vertical amounts to scroll in each direction in response to a mouse click in a scroll arrow. The **cx** member contains the horizontal amount. The **cy** member contains the vertical amount.  
  
## Remarks  
 Sizes are in device units. This member function is rarely called.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CScrollView Class](../vs140/cscrollview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CScrollView::SetScrollSizes](../vs140/cscrollview--setscrollsizes.md)   
 [CScrollView::GetTotalSize](../vs140/cscrollview--gettotalsize.md)