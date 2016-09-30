---
title: "CView::OnDragScroll"
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
  - "CView.OnDragScroll"
  - "CView::OnDragScroll"
  - "OnDragScroll"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "dragging"
  - "drop effect"
  - "DROPEFFECT_LINK"
  - "OnDragScroll method"
  - "DROPEFFECT_COPY"
  - "DROPEFFECT_NONE"
  - "scrolling regions"
  - "DROPEFFECT_SCROLL"
  - "drag and drop, type of drop"
  - "DROPEFFECT_MOVE"
  - "CView class, overridables"
ms.assetid: 526fc8cb-57c5-4a5d-93d9-93b1e8d46c69
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CView::OnDragScroll
Called by the framework before calling [OnDragEnter](../vs140/cview--ondragenter.md) or [OnDragOver](../vs140/cview--ondragover.md) to determine whether the point is in the scrolling region.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Contains the state of the modifier keys. This is a combination of any number of the following: **MK_CONTROL**, **MK_SHIFT**, **MK_ALT**, **MK_LBUTTON**, **MK_MBUTTON**, and **MK_RBUTTON**.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Contains the location of the cursor, in pixels, relative to the screen.  
  
## Return Value  
 A value from the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> enumerated type, which indicates the type of drop that would occur if the user dropped the object at this position. The type of drop usually depends on the current key state indicated by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. A standard mapping of keystates to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> values is:  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> The data object cannot be dropped in this window.  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> for **MK_CONTROL &#124; MK_SHIFT** Creates a linkage between the object and its server.  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> for **MK_CONTROL** Creates a copy of the dropped object.  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> for **MK_ALT** Creates a copy of the dropped object and delete the original object.  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> Indicates that a drag scroll operation is about to occur or is occurring in the target view.  
  
 For more information, see the MFC Advanced Concepts sample [OCLIENT](../vs140/visual-c---samples.md).  
  
## Remarks  
 Override this function when you want to provide special behavior for this event. The default implementation automatically scrolls windows when the cursor is dragged into the default scroll region inside the border of each window.For more information, see the article [Drag and Drop: Implementing a Drop Target](../vs140/drag-and-drop--implementing-a-drop-target.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CView Class](../vs140/cview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CView::OnDragEnter](../vs140/cview--ondragenter.md)   
 [CView::OnDragOver](../vs140/cview--ondragover.md)   
 [CView::OnDrop](../vs140/cview--ondrop.md)   
 [CView::OnDragLeave](../vs140/cview--ondragleave.md)   
 [COleDropTarget::OnDragScroll](../vs140/coledroptarget--ondragscroll.md)