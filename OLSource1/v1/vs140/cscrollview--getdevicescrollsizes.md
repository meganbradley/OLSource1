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
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CScrollView::GetDeviceScrollSizes
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder> gets the current mapping mode, the total size, and the line and page sizes of the scrollable view.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Returns the current mapping mode for this view. For a list of possible values, see <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Returns the current total size of the scroll view in device units.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Returns the current horizontal and vertical amounts to scroll in each direction in response to a mouse click in a scroll-bar shaft. The **cx** member contains the horizontal amount. The **cy** member contains the vertical amount.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
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