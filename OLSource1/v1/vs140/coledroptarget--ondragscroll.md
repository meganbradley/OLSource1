---
title: "COleDropTarget::OnDragScroll"
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
  - "COleDropTarget::OnDragScroll"
  - "COleDropTarget.OnDragScroll"
  - "OnDragScroll"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DROPEFFECT_LINK"
  - "OnDragScroll method"
  - "DROPEFFECT_COPY"
  - "DROPEFFECT_NONE"
  - "DROPEFFECT_SCROLL"
  - "DROPEFFECT_MOVE"
ms.assetid: 017e120b-19f2-4cc4-9fe1-35bb5141def2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDropTarget::OnDragScroll
Called by the framework before calling [OnDragEnter](../vs140/coledroptarget--ondragenter.md) or [OnDragOver](../vs140/coledroptarget--ondragover.md) to determine whether `point` is in the scrolling region.  
  
## Syntax  
  
```  
  
      virtual DROPEFFECT OnDragScroll(  
   CWnd* pWnd,  
   DWORD dwKeyState,  
   CPoint point   
);  
```  
  
#### Parameters  
 `pWnd`  
 Points to the window the cursor is currently over.  
  
 `dwKeyState`  
 Contains the state of the modifier keys. This is a combination of any number of the following: **MK_CONTROL**, **MK_SHIFT**, **MK_ALT**, **MK_LBUTTON**, **MK_MBUTTON**, and **MK_RBUTTON**.  
  
 `point`  
 Contains the location of the cursor, in pixels, relative to the screen.  
  
## Return Value  
 The effect that would result if a drop were attempted at the location specified by `point`. It can be one or more of the following:  
  
-   `DROPEFFECT_NONE` A drop would not be allowed.  
  
-   `DROPEFFECT_COPY` A copy operation would be performed.  
  
-   `DROPEFFECT_MOVE` A move operation would be performed.  
  
-   `DROPEFFECT_LINK` A link from the dropped data to the original data would be established.  
  
-   `DROPEFFECT_SCROLL` Indicates that a drag scroll operation is about to occur or is occurring in the target.  
  
## Remarks  
 Override this function when you want to provide special behavior for this event. The default implementation of this function calls [CView::OnDragScroll](../vs140/cview--ondragscroll.md), which returns `DROPEFFECT_NONE` and scrolls the window when the cursor is dragged into the default scroll region inside the border of the window.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleDropTarget Class](../vs140/coledroptarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)