---
title: "CView::OnDragLeave"
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
  - "CView.OnDragLeave"
  - "CView::OnDragLeave"
  - "OnDragLeave"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "dragging"
  - "CView class, OLE overridables"
  - "mouse, position"
  - "OnDragLeave method"
ms.assetid: 969e4208-c4f1-457d-b9c7-da93b25f76da
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CView::OnDragLeave
Called by the framework during a drag operation when the mouse is moved out of the valid drop area for that window.  
  
## Syntax  
  
```  
  
virtual void OnDragLeave( );  
```  
  
## Remarks  
 Override this function if the current view needs to clean up any actions taken during [OnDragEnter](../vs140/cview--ondragenter.md) or [OnDragOver](../vs140/cview--ondragover.md) calls, such as removing any visual user feedback while the object was dragged and dropped.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CView Class](../vs140/cview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CView::OnDragEnter](../vs140/cview--ondragenter.md)   
 [CView::OnDragOver](../vs140/cview--ondragover.md)   
 [CView::OnScroll](../vs140/cview--onscroll.md)   
 [COleDropTarget::OnDragLeave](../vs140/coledroptarget--ondragleave.md)