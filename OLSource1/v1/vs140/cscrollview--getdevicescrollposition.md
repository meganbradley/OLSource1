---
title: "CScrollView::GetDeviceScrollPosition"
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
  - "CScrollView::GetDeviceScrollPosition"
  - "GetDeviceScrollPosition"
  - "CScrollView.GetDeviceScrollPosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CScrollView class, operations"
  - "GetDeviceScrollPosition method"
ms.assetid: e490e6c6-d4db-42a4-9d30-e203f1dc4465
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CScrollView::GetDeviceScrollPosition
Call `GetDeviceScrollPosition` when you need the current horizontal and vertical positions of the scroll boxes in the scroll bars.  
  
## Syntax  
  
```  
  
CPoint GetDeviceScrollPosition( ) const;  
```  
  
## Return Value  
 The horizontal and vertical positions (in device units) of the scroll boxes as a `CPoint` object.  
  
## Remarks  
 This coordinate pair corresponds to the location in the document to which the upper-left corner of the view has been scrolled. This is useful for offsetting mouse-device positions to scroll-view device positions.  
  
 `GetDeviceScrollPosition` returns values in device units. If you want logical units, use `GetScrollPosition` instead.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CScrollView Class](../vs140/cscrollview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CScrollView::GetScrollPosition](../vs140/cscrollview--getscrollposition.md)