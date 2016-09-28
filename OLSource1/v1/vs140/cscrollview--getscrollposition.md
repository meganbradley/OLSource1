---
title: "CScrollView::GetScrollPosition"
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
  - "CScrollView::GetScrollPosition"
  - "CScrollView.GetScrollPosition"
  - "GetScrollPosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CScrollView class, operations"
  - "GetScrollPosition method"
ms.assetid: ef300d4f-c328-406d-a3dc-ffea48849b0b
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CScrollView::GetScrollPosition
Call `GetScrollPosition` when you need the current horizontal and vertical positions of the scroll boxes in the scroll bars.  
  
## Syntax  
  
```  
  
CPoint GetScrollPosition( ) const;   
```  
  
## Return Value  
 The horizontal and vertical positions (in logical units) of the scroll boxes as a `CPoint` object.  
  
## Remarks  
 This coordinate pair corresponds to the location in the document to which the upper-left corner of the view has been scrolled.  
  
 `GetScrollPosition` returns values in logical units. If you want device units, use `GetDeviceScrollPosition` instead.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CScrollView Class](../vs140/cscrollview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CScrollView::GetDeviceScrollPosition](../vs140/cscrollview--getdevicescrollposition.md)