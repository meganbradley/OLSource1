---
title: "CScrollView::GetTotalSize"
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
  - "CScrollView.GetTotalSize"
  - "GetTotalSize"
  - "CScrollView::GetTotalSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CScrollView class, operations"
  - "GetTotalSize method"
ms.assetid: 9f13165b-e1d0-477e-8168-89eb09e6d0a1
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CScrollView::GetTotalSize
Call `GetTotalSize` to retrieve the current horizontal and vertical sizes of the scroll view.  
  
## Syntax  
  
```  
  
CSize GetTotalSize( ) const;  
  
```  
  
## Return Value  
 The total size of the scroll view in logical units. The horizontal size is in the **cx** member of the `CSize` return value. The vertical size is in the **cy** member.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CScrollView Class](../vs140/cscrollview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CScrollView::GetDeviceScrollSizes](../vs140/cscrollview--getdevicescrollsizes.md)   
 [CScrollView::SetScrollSizes](../vs140/cscrollview--setscrollsizes.md)